namespace Cinder
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_releaseManagerServer = new System.Windows.Forms.TextBox();
            this.textBox_MonitoringServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_saveSettings = new System.Windows.Forms.Button();
            this.button_cancelSettings = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_releaseManagerServer);
            this.groupBox1.Controls.Add(this.textBox_MonitoringServer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connections";
            // 
            // textBox_releaseManagerServer
            // 
            this.textBox_releaseManagerServer.Location = new System.Drawing.Point(144, 50);
            this.textBox_releaseManagerServer.Name = "textBox_releaseManagerServer";
            this.textBox_releaseManagerServer.Size = new System.Drawing.Size(128, 21);
            this.textBox_releaseManagerServer.TabIndex = 3;
            // 
            // textBox_MonitoringServer
            // 
            this.textBox_MonitoringServer.Location = new System.Drawing.Point(144, 23);
            this.textBox_MonitoringServer.Name = "textBox_MonitoringServer";
            this.textBox_MonitoringServer.Size = new System.Drawing.Size(128, 21);
            this.textBox_MonitoringServer.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Release Manager server: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monitoring server: ";
            // 
            // button_saveSettings
            // 
            this.button_saveSettings.Location = new System.Drawing.Point(223, 102);
            this.button_saveSettings.Name = "button_saveSettings";
            this.button_saveSettings.Size = new System.Drawing.Size(75, 23);
            this.button_saveSettings.TabIndex = 1;
            this.button_saveSettings.Text = "Save";
            this.button_saveSettings.UseVisualStyleBackColor = true;
            this.button_saveSettings.Click += new System.EventHandler(this.button_saveSettings_Click);
            // 
            // button_cancelSettings
            // 
            this.button_cancelSettings.Location = new System.Drawing.Point(12, 102);
            this.button_cancelSettings.Name = "button_cancelSettings";
            this.button_cancelSettings.Size = new System.Drawing.Size(75, 23);
            this.button_cancelSettings.TabIndex = 2;
            this.button_cancelSettings.Text = "Cancel";
            this.button_cancelSettings.UseVisualStyleBackColor = true;
            this.button_cancelSettings.Click += new System.EventHandler(this.button_cancelSettings_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 134);
            this.Controls.Add(this.button_cancelSettings);
            this.Controls.Add(this.button_saveSettings);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cinder - Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_releaseManagerServer;
        private System.Windows.Forms.TextBox textBox_MonitoringServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_saveSettings;
        private System.Windows.Forms.Button button_cancelSettings;
    }
}