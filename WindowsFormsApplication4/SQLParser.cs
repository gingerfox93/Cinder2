using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using System.Reflection;
using System.Collections;

namespace Cinder
{
    public class SQLParser
    {

        public static List<string> Parse(string SQLText)
        {
            List<string> LoggingErrors = new List<string>();
            StringReader ReadText = new StringReader(SQLText);
            TSql120Parser Parser = new TSql120Parser(initialQuotedIdentifiers: false);
            IList<ParseError> parseerrors;
            TSqlFragment sqlFragment = Parser.Parse(ReadText, out parseerrors);

            if (parseerrors.Count > 0)
            {
                foreach (ParseError error in parseerrors)
                {
                    LoggingErrors.Add("Error -" + error.Message + " on line " + error.Line);
                }
            }

            return LoggingErrors;
        }

        public static Dictionary<string, object> ExtractStatementInfo(string SQLText)
        {
            StringReader ReadText = new StringReader(SQLText);
            TSql120Parser Parser = new TSql120Parser(initialQuotedIdentifiers: false);
            IList<ParseError> parseerrors;

            TSqlFragment sqlFragment = Parser.Parse(ReadText, out parseerrors);
            SQLVisitor visitor = new SQLVisitor();
            sqlFragment.Accept(visitor);

            //Get statement statistics
            Dictionary<string, int> StatementStatistics = new Dictionary<string, int>();
            StatementStatistics = visitor.GetStatementStatistics();
            
            //Put all table references in a dictionary
            Dictionary<string, object> TableReferences = new Dictionary<string, object>();
            //Dictionary<string, object> ProcedureReferences = new Dictionary<string, object>();
            Dictionary<string, object> ExecutableProcedureReferences = new Dictionary<string, object>();

            //foreach (object tableReference in visitor.TableReferences)
            //{
                //if (!TableReferences.ContainsKey(tableReference.SchemaObject.BaseIdentifier.Value))
                //{
                //    TableReferences.Add(tableReference.SchemaObject.BaseIdentifier.Value, tableReference.SchemaObject);
                //}
            //}

            foreach (NamedTableReference tableReference in visitor.NamedTableReferences)
            {
                if (!TableReferences.ContainsKey(tableReference.SchemaObject.BaseIdentifier.Value))
                {
                    TableReferences.Add(tableReference.SchemaObject.BaseIdentifier.Value, tableReference.SchemaObject);
                }
            }

            //foreach (ProcedureReferenceName procReference in visitor.ProcedureReferences)
            //{
            //    SchemaObjectName tmpprocReference = (SchemaObjectName)procReference.ProcedureReference.Name;

            //    if (!ProcedureReferences.ContainsKey(procReference.ProcedureReference.Name.BaseIdentifier.Value))
            //    {
            //        ProcedureReferences.Add(procReference.ProcedureReference.Name.BaseIdentifier.Value, procReference);
            //    }
            //}

            foreach (ExecutableProcedureReference procReference in visitor.ExecutableProcedureReferences)
            {
                ProcedureReferenceName tmpprocReference = (ProcedureReferenceName)procReference.ProcedureReference;
                VariableReference tmpVariableReference = (VariableReference)procReference.ProcedureReference.ProcedureVariable;

                if (!ExecutableProcedureReferences.ContainsKey(procReference.ProcedureReference.ProcedureReference.Name.BaseIdentifier.Value))
                {
                    ExecutableProcedureReferences.Add(procReference.ProcedureReference.ProcedureReference.Name.BaseIdentifier.Value, procReference);
                }
            }

            //foreach (SetClause SetClause in visitor.SetClauses)
            //{
            //    TableReferences.Add(SetClause.ToString());
            //}

            //foreach (SchemaObjectName SchemaObjectName in visitor.SchemaObjectNames)
            //{
            //    if (!TableReferences.ContainsKey(SchemaObjectName.BaseIdentifier.Value))
            //    {
            //        //TableReferences.Add(SchemaObjectName.BaseIdentifier.Value, SchemaObjectName);
            //    }
            //}

            //Build return object
            Dictionary<string, object> StatementInfo = new Dictionary<string, object>();

            StatementInfo.Add("StatementStatistics", StatementStatistics);
            StatementInfo.Add("TableReferences", TableReferences);
            //StatementInfo.Add("ProcedureReferences", ProcedureReferences);
            StatementInfo.Add("ExecutableProcedureReferences", ExecutableProcedureReferences);

            return StatementInfo;
        }


    }

    public class Variables
    {
        public static Dictionary<string, int> statementsToParse = new Dictionary<string, int>{
            { "SELECT", 1 },
            { "INSERT", 1 },
            { "UPDATE", 1 },
            { "DELETE", 1 },
            { "MERGE", 1 },
            { "EXECPROC", 1 }
        };

        public static string selectedServer = "";
        public static string selectedDatabase = "";
    }

    public class SQLVisitor : TSqlFragmentVisitor
    {
        private int SELECTcount = 0;
        private int INSERTcount = 0;
        private int UPDATEcount = 0;
        private int DELETEcount = 0;
        private int MERGEcount = 0;
        private int EXECPROCCount = 0;
        
        public List<SelectStatement> SelectStatements = new List<SelectStatement>();
        public List<TableReference> TableReferences = new List<TableReference>();
        public List<NamedTableReference> NamedTableReferences = new List<NamedTableReference>();
        public List<SetClause> SetClauses = new List<SetClause>();
        public List<SchemaObjectName> SchemaObjectNames = new List<SchemaObjectName>();
        //public List<ProcedureReferenceName> ProcedureReferences = new List<ProcedureReferenceName>();
        public List<ExecutableProcedureReference> ExecutableProcedureReferences = new List<ExecutableProcedureReference>();

        // SELECTS 
        public override void ExplicitVisit(SelectStatement node)
        {
            if(Variables.statementsToParse["SELECT"] == 1)
            {
                SELECTcount++;
                base.ExplicitVisit(node);
            }
            
        }

        // INSERTs 
        public override void ExplicitVisit(InsertStatement node)
        {
            if (Variables.statementsToParse["INSERT"] == 1)
            {
                INSERTcount++;
                base.ExplicitVisit(node);
            }
        }

        // UPDATEs 
        public override void ExplicitVisit(UpdateStatement node)
        {
            if (Variables.statementsToParse["UPDATE"] == 1)
            {
                UPDATEcount++;
                base.ExplicitVisit(node);
            }
        }
        // DELETEs 
        public override void ExplicitVisit(DeleteStatement node)
        {
            if (Variables.statementsToParse["DELETE"] == 1)
            {
                DELETEcount++;
                base.ExplicitVisit(node);
            }
        }
        // MERGE 
        public override void ExplicitVisit(MergeStatement node)
        {
            if (Variables.statementsToParse["MERGE"] == 1)
            {
                MERGEcount++;
                base.ExplicitVisit(node);
            }
        }

        public override void ExplicitVisit(NamedTableReference node)
        {
            NamedTableReferences.Add(node);
            base.ExplicitVisit(node);
        }

        public override void ExplicitVisit(TableReference node)
        {
            TableReferences.Add(node);
            base.ExplicitVisit(node);
        }

        //All Proc References
        //public override void ExplicitVisit(ProcedureReferenceName node)
        //{
        //    PROCEDURECount++;
        //    ProcedureReferences.Add(node);
        //    base.ExplicitVisit(node);
        //}

        public override void ExplicitVisit(ExecutableProcedureReference node)
        {
            if (Variables.statementsToParse["EXECPROC"] == 1)
            {
                EXECPROCCount++;
                ExecutableProcedureReferences.Add(node);
                base.ExplicitVisit(node);
            }
        }

        //public override void ExplicitVisit(SetClause node)
        //{
        //    SetClauses.Add(node);
        //    base.ExplicitVisit(node);
        //}
        public Dictionary<string, int> GetStatementStatistics()
        {
            Dictionary<string, int> StatementStatistics = new Dictionary<string, int>();
            if(this.SELECTcount > 0)
                StatementStatistics.Add("SELECT statement(s)", this.SELECTcount);
            if (this.INSERTcount > 0)
                StatementStatistics.Add("INSERT statement(s)", this.INSERTcount);
            if (this.UPDATEcount > 0)
                StatementStatistics.Add("UPDATE statement(s)", this.UPDATEcount);
            if (this.DELETEcount > 0)
                StatementStatistics.Add("DELETE statement(s)", this.DELETEcount);
            if (this.MERGEcount > 0)
                StatementStatistics.Add("MERGE statement(s)", this.MERGEcount);
            if (this.EXECPROCCount > 0)
                StatementStatistics.Add("EXECPROC statement(s)", this.EXECPROCCount);

            return StatementStatistics;
        }

        private string GetNodeTokenText(TSqlFragment fragment)
        {
            StringBuilder tokenText = new StringBuilder();
            for (int counter = fragment.FirstTokenIndex; counter <= fragment.LastTokenIndex; counter++)
            {
                tokenText.Append(fragment.ScriptTokenStream[counter].Text);
            }
            return tokenText.ToString();
        }

    }
}
