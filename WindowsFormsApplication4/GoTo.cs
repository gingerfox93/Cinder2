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
    public partial class GoTo : Form
    {
        public int ReturnValue { get; set; }

        public GoTo()
        {
            InitializeComponent();
        }

        private void button_goto_go_Click(object sender, EventArgs e)
        {

            this.ReturnValue = Int32.Parse(txt_gotoline.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
