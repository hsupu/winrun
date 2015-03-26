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
// using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace winrun {

    // [RegistryPermissionAttribute(SecurityAction.Assert)]
    // [RegistryPermissionAttribute(SecurityAction.PermitOnly, Read = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths")]
    // [FileIOPermissionAttribute(SecurityAction.Assert)]
    // [SecurityPermissionAttribute(SecurityAction.Assert)]
    public partial class winrunr : Form {
        RegistryKey regApps = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths", true);
        RegistryKey regAppsEx = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths", true);
        RegistryKey regApp;
        List<KeyValue> kvs = new List<KeyValue>();

        public winrunr() {
            InitializeComponent();
        }

        private void winrunr_Load(object sender, EventArgs e) {
            // this.Text += Application.ProductVersion;
            btnReload_Click(sender, e);
        }

        private void btnReload_Click(object sender, EventArgs e) {
            checkRegistry(regApps, true);
            if (chkGlobal.Checked) {
                checkRegistry(regAppsEx, false, true);
            }
        }

        public void checkRegistry(RegistryKey rk, bool cls = false, bool localMachine = false) {
            string[] appNames = rk.GetSubKeyNames();
            int appCount = appNames.Count();
            if (cls) {
                kvs.Clear();
                lvwApps.Items.Clear();
                copyImageListByKey(imglstReserved, imglstApps);
            }
            Object regValue;
            for (int i = 0; i < appCount; i++) {
                kvs.Add(new KeyValue());
                kvs[i].localMachine = localMachine;
                kvs[i].key = appNames[i];
                regApp = rk.OpenSubKey(kvs[i].key);
                regValue = regApp.GetValue(null);
                if (regValue is string) {
                    kvs[i].value = regValue.ToString();
                }
                setItem(kvs[i]);
            }
        }

        public void copyImageListByKey(ImageList src, ImageList dst) {
            dst.Images.Clear();
            foreach (string key in src.Images.Keys) {
                dst.Images.Add(src.Images[src.Images.IndexOfKey(key)]);
            }
        }

        private void setItem(KeyValue kv, int id = 0) {
            int imgIndex = 0;
            string filePath = kv.value;
            if (File.Exists(filePath)) {
                Icon icon = System.Drawing.Icon.ExtractAssociatedIcon(filePath);
                imglstApps.Images.Add(icon);
                imgIndex = imglstApps.Images.Count - 1;
            }
            if (id == 0) {
                lvwApps.Items.Add(kv.key, imgIndex);
            } else {
                lvwApps.Items[id].Text = kv.key;
                lvwApps.Items[id].ImageIndex = imgIndex;
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
            int id = lvwApps.SelectedItems[0].Index;
            dlgSet dlg = new dlgSet(id, kvs[id]);
            if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK) {
                regApps.SetValue(dlg.kv.key, dlg.kv.value);
                kvs[id] = dlg.kv;
                setItem(kvs[id], id);
            }
        }

        private void chkGlobal_CheckedChanged(object sender, EventArgs e) {
            btnReload_Click(sender, e);
        }

    }

    public class KeyValue {
        public bool localMachine;
        public string key;
        public string value;
    }

}
