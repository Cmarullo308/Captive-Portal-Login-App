using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Captive_Portal_Login
{
    public partial class captivePortalWindow : Form
    {
        static string version = "1.0";

        public captivePortalWindow()
        {
            InitializeComponent();
            webBrowser.ScriptErrorsSuppressed = true;
            ServicePointManager.ServerCertificateValidationCallback = (sender, cert, chain, sslPolicyErrors) => true;
            versionLabel.Text = "Version: " + version;
        }

        private void refreshButtonClick(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            webBrowser.Url = new Uri("https://10.123.0.1/logout");
        }

        private void captivePortalWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
