using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinder
{
    public partial class MessagePopup : Form
    {
        public MessagePopup(string title,string text)
        {
            InitializeComponent();
            this.Text = "Cinder - " + title;
            richTextBox1.Text = text;
        }

        private void buttonCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCopyToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.Text);
        }
    }
}
