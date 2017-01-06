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
    public partial class TableInformation : Form
    {
        public TableInformation()
        {
            InitializeComponent();

            //grid_TableInformation.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            //grid_TableInformation.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            Dictionary<string, object> StatementInformation = Form1.StatementInformation;

            Dictionary<string, object> TableReferences = (Dictionary<string, Object>)StatementInformation["TableReferences"];

            

            foreach (KeyValuePair<string, object> table in TableReferences)
            {

                SchemaObjectName schema = (SchemaObjectName)table.Value;

                string tmpBaseIdentifier = "";
                string tmpDatabaseIdentifier = "";
                string tmpSchemaIdentifier = "";
                string tmpServerIdentifier = "";

                //Table Name
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

                grid_TableInformation.Rows.Add(
                    tmpBaseIdentifier,
                    tmpSchemaIdentifier,
                    tmpDatabaseIdentifier,
                    tmpServerIdentifier
                    );


                
                

            }

            //Set up datagrid
            //View Definition Button
            DataGridViewButtonColumn btnViewDefinition = new DataGridViewButtonColumn();
            grid_TableInformation.Columns.Add(btnViewDefinition);
            btnViewDefinition.HeaderText = "";
            btnViewDefinition.Text = "Definition";
            btnViewDefinition.Name = "btn";
            btnViewDefinition.UseColumnTextForButtonValue = true;

            //View Release Details Button
            DataGridViewButtonColumn btnViewReleaseDetails = new DataGridViewButtonColumn();
            grid_TableInformation.Columns.Add(btnViewReleaseDetails);
            btnViewReleaseDetails.HeaderText = "";
            btnViewReleaseDetails.Text = "Release History";
            btnViewReleaseDetails.Name = "btn";
            btnViewReleaseDetails.UseColumnTextForButtonValue = true;

            //View Release Details Button
            DataGridViewButtonColumn btnViewObjectUsage = new DataGridViewButtonColumn();
            grid_TableInformation.Columns.Add(btnViewObjectUsage);
            btnViewObjectUsage.HeaderText = "";
            btnViewObjectUsage.Text = "Object Usage";
            btnViewObjectUsage.Name = "btn";
            btnViewObjectUsage.UseColumnTextForButtonValue = true;


        }

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
            string TableNane = "";
            //definition
            if (e.ColumnIndex == 7 && e.RowIndex != -1)
            {
                TableNane = grid_TableInformation.Rows[e.RowIndex].Cells["TableName"].Value.ToString();
                appendToApplicationLog("Getting object definition for: " + TableNane);
            }
            //release
            if (e.ColumnIndex == 8 && e.RowIndex != -1)
            {
                TableNane = grid_TableInformation.Rows[e.RowIndex].Cells["TableName"].Value.ToString();
                appendToApplicationLog("Getting release history for: " + TableNane);
            }
            //object usage
            if (e.ColumnIndex == 9 && e.RowIndex != -1)
            {
                TableNane = grid_TableInformation.Rows[e.RowIndex].Cells["TableName"].Value.ToString();
                appendToApplicationLog("Getting object usage for: " + TableNane);
            }
        }

        private void appendToApplicationLog(string message)
        {
            DateTime currentDateTime = DateTime.Now;
            TextBox_ApplicationLog.AppendText(currentDateTime.ToString() + " - " + message + Environment.NewLine);
            TextBox_ApplicationLog.ScrollToCaret();
        }

        private void button_checkTables_Click(object sender, EventArgs e)
        {
            appendToApplicationLog("Checking table info");

            foreach(DataGridViewRow row in grid_TableInformation.Rows)
            {
                for (int i = 0; i <= (row.Cells.Count - 1); i++)
                {
                    DataGridViewCell tmpCell = (DataGridViewCell)row.Cells[i];
                    int tmpCellColIndex = tmpCell.ColumnIndex;
                    string tmpCellTableName = grid_TableInformation.Rows[row.Index].Cells["TableName"].Value.ToString();

                    grid_TableInformation.Rows[row.Index].Cells["RowCount"].Value = 1000;
                    grid_TableInformation.Rows[row.Index].Cells["SubscriberCount"].Value = 800;
                    grid_TableInformation.Rows[row.Index].Cells["TriggerCount"].Value = 9999;
                }
            }

        }

        private void button_checkSelectedTables_Click(object sender, EventArgs e)
        {
            appendToApplicationLog("Checking selected table info");

            foreach (DataGridViewRow row in grid_TableInformation.SelectedRows)
            {
                for (int i = 0; i <= (row.Cells.Count - 1); i++)
                {
                    DataGridViewCell tmpCell = (DataGridViewCell)row.Cells[i];
                    int tmpCellColIndex = tmpCell.ColumnIndex;
                    string tmpCellTableName = grid_TableInformation.Rows[row.Index].Cells["TableName"].Value.ToString();

                    grid_TableInformation.Rows[row.Index].Cells["RowCount"].Value = 1000;
                    grid_TableInformation.Rows[row.Index].Cells["SubscriberCount"].Value = 800;
                    grid_TableInformation.Rows[row.Index].Cells["TriggerCount"].Value = 9999;
                }
            }
        }
    }
}
