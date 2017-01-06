using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.TransactSql.ScriptDom;

namespace Cinder
{
    public partial class ProcInformation : Form
    {
        public ProcInformation()
        {
            InitializeComponent();

            //grid_TableInformation.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            //grid_TableInformation.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            Dictionary<string, object> StatementInformation = Form1.StatementInformation;

            //Dictionary<string, object> ProcReferences = (Dictionary<string, Object>)StatementInformation["ProcedureReferences"];
            Dictionary<string, object> ExecutableProcedureReferences = (Dictionary<string, Object>)StatementInformation["ExecutableProcedureReferences"];

            

            foreach (KeyValuePair<string, object> proc in ExecutableProcedureReferences)
            {
                ExecutableProcedureReference procParams = (ExecutableProcedureReference)proc.Value;

                //appendToApplicationLog("Proc Name: " + procParams.ProcedureReference.ProcedureReference.Name.BaseIdentifier.Value.ToString());

                List<string> tmpParameters = new List<string>();
                //Loop through parameters
                foreach (ExecuteParameter parameter in procParams.Parameters)
                {

                    if(parameter.ParameterValue.GetType().ToString() == "Microsoft.SqlServer.TransactSql.ScriptDom.StringLiteral")
                    { 
                        StringLiteral tmpParamValue = (StringLiteral)parameter.ParameterValue;
                        VariableReference tmpParamVar = (VariableReference)parameter.Variable;

                        if (tmpParamVar != null)
                        {
                            tmpParameters.Add(tmpParamVar.Name.ToString() + " = \"" + tmpParamValue.Value.ToString() + "\"");
                        } else
                        {
                            tmpParameters.Add("\"" + tmpParamValue.Value.ToString() + "\"");
                        }
                    }
                    if (parameter.ParameterValue.GetType().ToString() == "Microsoft.SqlServer.TransactSql.ScriptDom.VariableReference")
                    {
                        VariableReference tmpParamValue = (VariableReference)parameter.ParameterValue;

                            tmpParameters.Add(tmpParamValue.Name.ToString());
  
                    }



                    Parameters[procParams.ProcedureReference.ProcedureReference.Name.BaseIdentifier.Value.ToString()] = tmpParameters;

                }

                SchemaObjectName schema = (SchemaObjectName)procParams.ProcedureReference.ProcedureReference.Name;

                string tmpBaseIdentifier = "";
                string tmpDatabaseIdentifier = "";
                string tmpSchemaIdentifier = "";
                string tmpServerIdentifier = "";

                // Proc Name
                if (schema.BaseIdentifier == null)
                    tmpBaseIdentifier = "ERROR ";
                else
                    tmpBaseIdentifier = schema.BaseIdentifier.Value;

                //Database Name
                if (schema.DatabaseIdentifier == null)
                    tmpDatabaseIdentifier = Variables.selectedDatabase + " (not defined)";
                else
                    tmpDatabaseIdentifier = schema.DatabaseIdentifier.Value;                    

                //Schema Name
                if (schema.SchemaIdentifier == null)
                    tmpSchemaIdentifier = "dbo (not defined)";
                else
                    tmpSchemaIdentifier = schema.SchemaIdentifier.Value;

                //Server Name
                if (schema.ServerIdentifier == null)
                    tmpServerIdentifier = Variables.selectedServer + " (not defined)";
                else
                    tmpServerIdentifier = schema.ServerIdentifier.Value;


                if(!tmpServerIdentifier.Contains("(not defined)"))
                {
                    appendToApplicationLog("4 part naming detected for " + tmpBaseIdentifier);
                } else if (!tmpDatabaseIdentifier.Contains("(not defined)"))
                {
                    appendToApplicationLog("3 part naming detected for " + tmpBaseIdentifier);
                }

                if (tmpSchemaIdentifier == "dbo (not defined)")
                {
                    appendToApplicationLog("Missing schema definition for " + tmpBaseIdentifier);
                }



                    grid_ProcInformation.Rows.Add(
                    tmpBaseIdentifier,
                    tmpSchemaIdentifier,
                    tmpDatabaseIdentifier,
                    tmpServerIdentifier
                    );
            }



            //    foreach (KeyValuePair<string, object> table in ProcReferences)
            //{

            //    ProcedureReferenceName proc = (ProcedureReferenceName)table.Value;

            //    string tmpBaseIdentifier = "";
            //    string tmpDatabaseIdentifier = "";
            //    string tmpSchemaIdentifier = "";
            //    string tmpServerIdentifier = "";

            //    //Table Name
            //    if (proc.ProcedureReference.Name.BaseIdentifier == null)
            //        tmpBaseIdentifier = "ERROR ";
            //    else
            //        tmpBaseIdentifier = proc.ProcedureReference.Name.BaseIdentifier.Value;

            //    //Database Name
            //    if (proc.ProcedureReference.Name.DatabaseIdentifier == null)
            //        tmpDatabaseIdentifier = Variables.selectedDatabase + " (not defined)";
            //    else
            //        tmpDatabaseIdentifier = proc.ProcedureReference.Name.DatabaseIdentifier.Value;

            //    //Schema Name
            //    if (proc.ProcedureReference.Name.SchemaIdentifier == null)
            //        tmpSchemaIdentifier = "dbo (not defined)";
            //    else
            //        tmpSchemaIdentifier = proc.ProcedureReference.Name.SchemaIdentifier.Value;

            //    //Server Name
            //    if (proc.ProcedureReference.Name.ServerIdentifier == null)
            //        tmpServerIdentifier = Variables.selectedServer + " (not defined)";                   
            //    else
            //        tmpServerIdentifier = proc.ProcedureReference.Name.ServerIdentifier.Value;

            //    grid_ProcInformation.Rows.Add(
            //        tmpBaseIdentifier,
            //        tmpSchemaIdentifier,
            //        tmpDatabaseIdentifier,
            //        tmpServerIdentifier
            //        );





            //}

            //Set up datagrid

            //View Parameters Button
            DataGridViewButtonColumn btnViewParameters = new DataGridViewButtonColumn();
            grid_ProcInformation.Columns.Add(btnViewParameters);
            btnViewParameters.HeaderText = "";
            btnViewParameters.Text = "Parameters";
            btnViewParameters.Name = "btn";
            btnViewParameters.UseColumnTextForButtonValue = true;

            //View Definition Button
            DataGridViewButtonColumn btnViewDefinition = new DataGridViewButtonColumn();
            grid_ProcInformation.Columns.Add(btnViewDefinition);
            btnViewDefinition.HeaderText = "";
            btnViewDefinition.Text = "Definition";
            btnViewDefinition.Name = "btn";
            btnViewDefinition.UseColumnTextForButtonValue = true;

            //View Release Details Button
            DataGridViewButtonColumn btnViewReleaseDetails = new DataGridViewButtonColumn();
            grid_ProcInformation.Columns.Add(btnViewReleaseDetails);
            btnViewReleaseDetails.HeaderText = "";
            btnViewReleaseDetails.Text = "Release History";
            btnViewReleaseDetails.Name = "btn";
            btnViewReleaseDetails.UseColumnTextForButtonValue = true;

            //View Release Details Button
            DataGridViewButtonColumn btnViewObjectUsage = new DataGridViewButtonColumn();
            grid_ProcInformation.Columns.Add(btnViewObjectUsage);
            btnViewObjectUsage.HeaderText = "";
            btnViewObjectUsage.Text = "Object Usage";
            btnViewObjectUsage.Name = "btn";
            btnViewObjectUsage.UseColumnTextForButtonValue = true;

           grid_ProcInformation.Sort(grid_ProcInformation.Columns["ProcName"], ListSortDirection.Ascending);

        }

        public static Dictionary<string, List<string>> Parameters = new Dictionary<string, List<string>>();

        private void button_checkObjectUsage_Click()
        {

        }

        private void button_checkReplication_Click()
        {

        }

        private void button_checkTriggers_Click()
        {


        }

        private void button_checkRowCount_Click()
        {

        }

        private void grid_TableInformation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ProcName = "";

            //parameters
            if (e.ColumnIndex == 9 && e.RowIndex != -1)
            {
                ProcName = grid_ProcInformation.Rows[e.RowIndex].Cells["ProcName"].Value.ToString();
                appendToApplicationLog("Getting parameters definition for: " + ProcName);

                string tmpText = "";

                foreach(string parameter in Parameters[ProcName])
                {
                    tmpText = tmpText + parameter + Environment.NewLine;
                }

                MessagePopup MessageBox = new MessagePopup(ProcName + " parameters", tmpText);
                MessageBox.Show();

            }
            //definition
            if (e.ColumnIndex == 10 && e.RowIndex != -1)
            {
                ProcName = grid_ProcInformation.Rows[e.RowIndex].Cells["ProcName"].Value.ToString();
                appendToApplicationLog("Getting object definition for: " + ProcName);
            }
            //release
            if (e.ColumnIndex == 11 && e.RowIndex != -1)
            {
                ProcName = grid_ProcInformation.Rows[e.RowIndex].Cells["ProcName"].Value.ToString();
                appendToApplicationLog("Getting release history for: " + ProcName);
            }
            //object usage
            if (e.ColumnIndex == 12 && e.RowIndex != -1)
            {
                ProcName = grid_ProcInformation.Rows[e.RowIndex].Cells["ProcName"].Value.ToString();
                appendToApplicationLog("Getting object usage for: " + ProcName);
            }
        }

        private void appendToApplicationLog(string message)
        {
            DateTime currentDateTime = DateTime.Now;
            TextBox_ApplicationLog.AppendText(currentDateTime.ToString() + " - " + message + Environment.NewLine);
            TextBox_ApplicationLog.ScrollToCaret();
        }

        private void button_checkProcs_Click(object sender, EventArgs e)
        {
            appendToApplicationLog("Checking proc info");

            foreach (DataGridViewRow row in grid_ProcInformation.Rows)
            { 
                checkProc(row);  
            }
            appendToApplicationLog("Finished checking selected proc info");
        }

        private void button_checkSelectedProcs_Click(object sender, EventArgs e)
        {
            appendToApplicationLog("Checking selected proc info");

            foreach (DataGridViewRow row in grid_ProcInformation.SelectedRows)
            { 
                checkProc(row); 
            }
            appendToApplicationLog("Finished checking selected proc info");
        }

        private void checkProc(DataGridViewRow row)
        {
            string tmpCellProcName = row.Cells["ProcName"].Value.ToString();
            string tmpCellDatabaseName = row.Cells["Database"].Value.ToString();
            string tmpCellServerName = row.Cells["Server"].Value.ToString();

            Dictionary<string, object> Results = Monitoring.getCaptureProcStats(tmpCellProcName, tmpCellDatabaseName, tmpCellServerName);

            Dictionary<string, string> Data = (Dictionary<string, string>)Results["Data"];
            List<string> Errors = (List<string>)Results["Errors"];

            foreach (string error in Errors)
            {
                appendToApplicationLog(error);
            }

            for (int i = 0; i <= (row.Cells.Count - 1); i++)
            {
                DataGridViewCell tmpCell = (DataGridViewCell)row.Cells[i];
                int tmpCellColIndex = tmpCell.ColumnIndex;

                if (Results.Count > 0 && Errors.Count == 0)
                {
                    grid_ProcInformation.Rows[row.Index].Cells["execPS"].Value = Data["execPS"];
                    grid_ProcInformation.Rows[row.Index].Cells["execPM"].Value = Data["execPM"];
                    grid_ProcInformation.Rows[row.Index].Cells["execPH"].Value = Data["execPH"];
                    grid_ProcInformation.Rows[row.Index].Cells["execPD"].Value = Data["execPD"];
                    grid_ProcInformation.Rows[row.Index].Cells["lastCached"].Value = Data["lastCached"];
                }
            }
        }
    }

}