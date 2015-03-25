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
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace winrun
{
    [RegistryPermissionAttribute(SecurityAction.Assert)]
    // [RegistryPermissionAttribute(SecurityAction.PermitOnly, Read = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths")]
    // [FileIOPermissionAttribute(SecurityAction.Assert)]
    // [SecurityPermissionAttribute(SecurityAction.Assert)]
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
            RegistryKey regApp;
            int imgIndex;
            Object objRegValue;
            string filePath;
            Icon icon;
            foreach (string s in strApps)
            {
                regApp = regApps.OpenSubKey(s);
                objRegValue = regApp.GetValue(null);
                if (objRegValue is string) {
                    filePath = objRegValue.ToString();
                    if (File.Exists(filePath))
                    {
                        icon = System.Drawing.Icon.ExtractAssociatedIcon(filePath);// GetSystemIcon.GetIconByFileName(filePath);
                        imglstApps.Images.Add(icon);
                        imgIndex = imglstApps.Images.Count - 1;

                        lvwApps.Items.Add(s, imgIndex);
                    }
                }
            }
        }
    }
}
