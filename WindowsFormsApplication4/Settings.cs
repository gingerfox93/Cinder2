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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();

            //Pre populate settings
            textBox_MonitoringServer.Text = Properties.Settings.Default.MonitoringServer;
            textBox_releaseManagerServer.Text = Properties.Settings.Default.ReleaseManagerServer;

        }

        private void button_cancelSettings_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_saveSettings_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.MonitoringServer = textBox_MonitoringServer.Text;
            Properties.Settings.Default.ReleaseManagerServer = textBox_releaseManagerServer.Text;

            //Persist settings across app sessions
            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
