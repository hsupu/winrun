using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Permissions;
using Microsoft.Win32;

namespace winrun
{
    [RegistryPermissionAttribute(SecurityAction.PermitOnly, Read = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths")]
    [FileIOPermissionAttribute(SecurityAction.PermitOnly, AllFiles = FileIOPermissionAccess.AllAccess)]
    public partial class winrunr : Form
    {
        RegistryKey regApps = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths");
        public winrunr()
        {
            InitializeComponent();
        }

        private void winrunr_Load(object sender, EventArgs e)
        {
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            string[] strApps = regApps.GetSubKeyNames();
            foreach (string s in strApps)
            {
                RegistryKey regApp = regApps.OpenSubKey(s);
                int imgIndex;

                    Icon icon = System.Drawing.Icon.ExtractAssociatedIcon(regApp.GetValue("").ToString());
                    imglstApps.Images.Add(icon);
                    imgIndex = imglstApps.Images.Count;

                lvwApps.Items.Add(s, imgIndex);
            }
        }
    }
}
