namespace Cinder
{
    partial class ProcInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcInformation));
            this.grid_ProcInformation = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_checkProcs = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TextBox_ApplicationLog = new System.Windows.Forms.RichTextBox();
            this.button_checkSelectedProcs = new System.Windows.Forms.Button();
            this.ProcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Schema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Database = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Server = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.execPS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.execPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.execPH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.execPD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastCached = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureLoading = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_ProcInformation)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_ProcInformation
            // 
            this.grid_ProcInformation.AllowUserToAddRows = false;
            this.grid_ProcInformation.AllowUserToResizeRows = false;
            this.grid_ProcInformation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grid_ProcInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_ProcInformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProcName,
            this.Schema,
            this.Database,
            this.Server,
            this.execPS,
            this.execPM,
            this.execPH,
            this.execPD,
            this.lastCached});
            this.grid_ProcInformation.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.grid_ProcInformation.Location = new System.Drawing.Point(6, 19);
            this.grid_ProcInformation.Name = "grid_ProcInformation";
            this.grid_ProcInformation.ReadOnly = true;
            this.grid_ProcInformation.RowHeadersVisible = false;
            this.grid_ProcInformation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_ProcInformation.ShowEditingIcon = false;
            this.grid_ProcInformation.Size = new System.Drawing.Size(1046, 264);
            this.grid_ProcInformation.TabIndex = 0;
            this.grid_ProcInformation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_TableInformation_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grid_ProcInformation);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1058, 289);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stored Procedures Found";
            // 
            // button_checkProcs
            // 
            this.button_checkProcs.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_checkProcs.Location = new System.Drawing.Point(18, 307);
            this.button_checkProcs.Name = "button_checkProcs";
            this.button_checkProcs.Size = new System.Drawing.Size(135, 48);
            this.button_checkProcs.TabIndex = 21;
            this.button_checkProcs.Text = "Check Procs";
            this.button_checkProcs.UseVisualStyleBackColor = true;
            this.button_checkProcs.Click += new System.EventHandler(this.button_checkProcs_Click);
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
            // button_checkSelectedProcs
            // 
            this.button_checkSelectedProcs.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_checkSelectedProcs.Location = new System.Drawing.Point(159, 307);
            this.button_checkSelectedProcs.Name = "button_checkSelectedProcs";
            this.button_checkSelectedProcs.Size = new System.Drawing.Size(135, 48);
            this.button_checkSelectedProcs.TabIndex = 28;
            this.button_checkSelectedProcs.Text = "Check Selected Procs";
            this.button_checkSelectedProcs.UseVisualStyleBackColor = true;
            this.button_checkSelectedProcs.Click += new System.EventHandler(this.button_checkSelectedProcs_Click);
            // 
            // ProcName
            // 
            this.ProcName.HeaderText = "Proc Name";
            this.ProcName.Name = "ProcName";
            this.ProcName.ReadOnly = true;
            this.ProcName.Width = 85;
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
            // execPS
            // 
            this.execPS.HeaderText = "Exec P/S";
            this.execPS.Name = "execPS";
            this.execPS.ReadOnly = true;
            this.execPS.Width = 78;
            // 
            // execPM
            // 
            this.execPM.HeaderText = "Exec P/M";
            this.execPM.Name = "execPM";
            this.execPM.ReadOnly = true;
            this.execPM.ToolTipText = "Proc executions per minute";
            this.execPM.Width = 80;
            // 
            // execPH
            // 
            this.execPH.HeaderText = "Exec P/H";
            this.execPH.Name = "execPH";
            this.execPH.ReadOnly = true;
            this.execPH.ToolTipText = "Proc executions per hour";
            this.execPH.Width = 79;
            // 
            // execPD
            // 
            this.execPD.HeaderText = "Exec P/D";
            this.execPD.Name = "execPD";
            this.execPD.ReadOnly = true;
            this.execPD.Width = 79;
            // 
            // lastCached
            // 
            this.lastCached.HeaderText = "Last Cached";
            this.lastCached.Name = "lastCached";
            this.lastCached.ReadOnly = true;
            this.lastCached.Width = 92;
            // 
            // pictureLoading
            // 
            this.pictureLoading.Image = ((System.Drawing.Image)(resources.GetObject("pictureLoading.Image")));
            this.pictureLoading.Location = new System.Drawing.Point(539, 318);
            this.pictureLoading.Name = "pictureLoading";
            this.pictureLoading.Size = new System.Drawing.Size(37, 37);
            this.pictureLoading.TabIndex = 29;
            this.pictureLoading.TabStop = false;
            this.pictureLoading.Visible = false;
            // 
            // ProcInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 561);
            this.Controls.Add(this.pictureLoading);
            this.Controls.Add(this.button_checkSelectedProcs);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button_checkProcs);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProcInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cinder - Proc Information";
            ((System.ComponentModel.ISupportInitialize)(this.grid_ProcInformation)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLoading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_ProcInformation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_checkProcs;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox TextBox_ApplicationLog;
        private System.Windows.Forms.Button button_checkSelectedProcs;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Schema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Database;
        private System.Windows.Forms.DataGridViewTextBoxColumn Server;
        private System.Windows.Forms.DataGridViewTextBoxColumn execPS;
        private System.Windows.Forms.DataGridViewTextBoxColumn execPM;
        private System.Windows.Forms.DataGridViewTextBoxColumn execPH;
        private System.Windows.Forms.DataGridViewTextBoxColumn execPD;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastCached;
        private System.Windows.Forms.PictureBox pictureLoading;
    }
}