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

namespace winrun {

    [RegistryPermissionAttribute(SecurityAction.Assert)]
    // [RegistryPermissionAttribute(SecurityAction.PermitOnly, Read = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths")]
    // [FileIOPermissionAttribute(SecurityAction.Assert)]
    // [SecurityPermissionAttribute(SecurityAction.Assert)]
    public partial class winrunr : Form {
        RegistryKey regApps = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths");
        RegistryKey regApp;
        KeyValue[] kv;

        public winrunr() {
            InitializeComponent();
        }

        private void winrunr_Load(object sender, EventArgs e) {
            // this.Text += Application.ProductVersion;
            btnReload_Click(sender, e);
        }

        private void btnReload_Click(object sender, EventArgs e) {
            string[] appNames = regApps.GetSubKeyNames();
            int appCount = appNames.Count();
            kv = new KeyValue[appCount];

            int imgIndex;
            Object regValue;
            string filePath;
            Icon icon;
            for (int i = 0; i < appCount; i++) {
                kv[i] = new KeyValue();
                kv[i].key = appNames[i];
                imgIndex = 0;
                regApp = regApps.OpenSubKey(kv[i].key);
                regValue = regApp.GetValue(null);
                if (regValue is string) {
                    kv[i].value = regValue.ToString();
                    filePath = kv[i].value;
                    if (File.Exists(filePath)) {
                        icon = System.Drawing.Icon.ExtractAssociatedIcon(filePath);
                        // icon = GetSystemIcon.GetIconByFileName(filePath);
                        imglstApps.Images.Add(icon);
                        imgIndex = imglstApps.Images.Count - 1;
                    }
                }
                lvwApps.Items.Add(kv[i].key, imgIndex);
            }
        }

        private void lvwApps_SelectedIndexChanged(object sender, EventArgs e) {
            if (lvwApps.SelectedItems.Count != 0) {
                ListViewItem i = lvwApps.SelectedItems[0];
                System.Console.WriteLine(lvwApps.SelectedItems[0].Text);
            }
        }

        private void lvwApps_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                mnuApp.Show(lvwApps, e.Location);
            }
        }

        private void mnuAppEdit_Click(object sender, EventArgs e) {
            Form dlg = new dlgSet();
            dlg.ShowDialog(this);
        }

    }

    public class KeyValue {
        public string key;
        public string value;
    }

}
