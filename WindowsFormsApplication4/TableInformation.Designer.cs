namespace Cinder
{
    partial class TableInformation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableInformation));
            this.grid_TableInformation = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_checkTables = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TextBox_ApplicationLog = new System.Windows.Forms.RichTextBox();
            this.TableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Schema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Database = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Server = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubscriberCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TriggerCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_checkSelectedTables = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_TableInformation)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_TableInformation
            // 
            this.grid_TableInformation.AllowUserToAddRows = false;
            this.grid_TableInformation.AllowUserToResizeRows = false;
            this.grid_TableInformation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grid_TableInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_TableInformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TableName,
            this.Schema,
            this.Database,
            this.Server,
            this.rowCount,
            this.SubscriberCount,
            this.TriggerCount});
            this.grid_TableInformation.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.grid_TableInformation.Location = new System.Drawing.Point(6, 19);
            this.grid_TableInformation.Name = "grid_TableInformation";
            this.grid_TableInformation.ReadOnly = true;
            this.grid_TableInformation.RowHeadersVisible = false;
            this.grid_TableInformation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_TableInformation.ShowEditingIcon = false;
            this.grid_TableInformation.Size = new System.Drawing.Size(1046, 264);
            this.grid_TableInformation.TabIndex = 0;
            this.grid_TableInformation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_TableInformation_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grid_TableInformation);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1058, 289);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tables Found";
            // 
            // button_checkTables
            // 
            this.button_checkTables.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_checkTables.Location = new System.Drawing.Point(18, 307);
            this.button_checkTables.Name = "button_checkTables";
            this.button_checkTables.Size = new System.Drawing.Size(135, 48);
            this.button_checkTables.TabIndex = 21;
            this.button_checkTables.Text = "Check Tables";
            this.button_checkTables.UseVisualStyleBackColor = true;
            this.button_checkTables.Click += new System.EventHandler(this.button_checkTables_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TextBox_ApplicationLog);
            this.groupBox3.Location = new System.Drawing.Point(12, 361);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(564, 188);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Application Log";
            // 
            // TextBox_ApplicationLog
            // 
            this.TextBox_ApplicationLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TextBox_ApplicationLog.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_ApplicationLog.Location = new System.Drawing.Point(6, 19);
            this.TextBox_ApplicationLog.Name = "TextBox_ApplicationLog";
            this.TextBox_ApplicationLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.TextBox_ApplicationLog.Size = new System.Drawing.Size(552, 163);
            this.TextBox_ApplicationLog.TabIndex = 9;
            this.TextBox_ApplicationLog.Text = "";
            this.TextBox_ApplicationLog.WordWrap = false;
            // 
            // TableName
            // 
            this.TableName.HeaderText = "Table Name";
            this.TableName.Name = "TableName";
            this.TableName.ReadOnly = true;
            this.TableName.Width = 90;
            // 
            // Schema
            // 
            this.Schema.HeaderText = "Schema";
            this.Schema.Name = "Schema";
            this.Schema.ReadOnly = true;
            this.Schema.Width = 71;
            // 
            // Database
            // 
            this.Database.HeaderText = "Database";
            this.Database.Name = "Database";
            this.Database.ReadOnly = true;
            this.Database.Width = 78;
            // 
            // Server
            // 
            this.Server.HeaderText = "Server";
            this.Server.Name = "Server";
            this.Server.ReadOnly = true;
            this.Server.Width = 63;
            // 
            // rowCount
            // 
            this.rowCount.HeaderText = "Row Count";
            this.rowCount.Name = "rowCount";
            this.rowCount.ReadOnly = true;
            this.rowCount.Width = 85;
            // 
            // SubscriberCount
            // 
            this.SubscriberCount.HeaderText = "# Subscribers";
            this.SubscriberCount.Name = "SubscriberCount";
            this.SubscriberCount.ReadOnly = true;
            this.SubscriberCount.Width = 97;
            // 
            // TriggerCount
            // 
            this.TriggerCount.HeaderText = "# Triggers";
            this.TriggerCount.Name = "TriggerCount";
            this.TriggerCount.ReadOnly = true;
            this.TriggerCount.Width = 80;
            // 
            // button_checkSelectedTables
            // 
            this.button_checkSelectedTables.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_checkSelectedTables.Location = new System.Drawing.Point(159, 307);
            this.button_checkSelectedTables.Name = "button_checkSelectedTables";
            this.button_checkSelectedTables.Size = new System.Drawing.Size(135, 48);
            this.button_checkSelectedTables.TabIndex = 28;
            this.button_checkSelectedTables.Text = "Check Selected Tables";
            this.button_checkSelectedTables.UseVisualStyleBackColor = true;
            this.button_checkSelectedTables.Click += new System.EventHandler(this.button_checkSelectedTables_Click);
            // 
            // TableInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 561);
            this.Controls.Add(this.button_checkSelectedTables);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button_checkTables);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TableInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cinder - Table Information";
            ((System.ComponentModel.ISupportInitialize)(this.grid_TableInformation)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_TableInformation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_checkTables;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox TextBox_ApplicationLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Schema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Database;
        private System.Windows.Forms.DataGridViewTextBoxColumn Server;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubscriberCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TriggerCount;
        private System.Windows.Forms.Button button_checkSelectedTables;
    }
}