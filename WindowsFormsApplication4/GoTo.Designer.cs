namespace Cinder
{
    partial class GoTo
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
            this.txt_gotoline = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_goto_go = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_gotoline
            // 
            this.txt_gotoline.Location = new System.Drawing.Point(85, 12);
            this.txt_gotoline.Name = "txt_gotoline";
            this.txt_gotoline.Size = new System.Drawing.Size(167, 20);
            this.txt_gotoline.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Line Number";
            // 
            // button_goto_go
            // 
            this.button_goto_go.Location = new System.Drawing.Point(258, 12);
            this.button_goto_go.Name = "button_goto_go";
            this.button_goto_go.Size = new System.Drawing.Size(75, 20);
            this.button_goto_go.TabIndex = 2;
            this.button_goto_go.Text = "Go";
            this.button_goto_go.UseVisualStyleBackColor = true;
            this.button_goto_go.Click += new System.EventHandler(this.button_goto_go_Click);
            // 
            // GoTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 44);
            this.Controls.Add(this.button_goto_go);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_gotoline);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GoTo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Go to line #";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_goto_go;
        public System.Windows.Forms.TextBox txt_gotoline;
    }
}