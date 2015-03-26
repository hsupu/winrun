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
        RegistryKey regApps = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths", RegistryKeyPermissionCheck.ReadWriteSubTree, System.Security.AccessControl.RegistryRights.FullControl);
        RegistryKey regAppsEx = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths", RegistryKeyPermissionCheck.ReadWriteSubTree, System.Security.AccessControl.RegistryRights.FullControl);
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
                kvs.Last().localMachine = localMachine;
                kvs.Last().key = appNames[i];
                regApp = rk.OpenSubKey(kvs.Last().key);
                regValue = regApp.GetValue(null);
                if (regValue is string) {
                    kvs.Last().value = regValue.ToString();
                }
                showItem(kvs.Last());
            }
        }

        public void copyImageListByKey(ImageList src, ImageList dst) {
            dst.Images.Clear();
            foreach (string key in src.Images.Keys) {
                dst.Images.Add(src.Images[src.Images.IndexOfKey(key)]);
            }
        }

        private void showItem(KeyValue kv, int id = -1) {
            int imgIndex = 0;
            string filePath = kv.value;
            if (File.Exists(filePath)) {
                Icon icon = System.Drawing.Icon.ExtractAssociatedIcon(filePath);
                imglstApps.Images.Add(icon);
                imgIndex = imglstApps.Images.Count - 1;
            }
            if (id == -1) {
                lvwApps.Items.Add(kv.key, imgIndex);
            } else {
                lvwApps.Items[id].Text = kv.key;
                lvwApps.Items[id].ImageIndex = imgIndex;
            }
        }

        private void lvwApps_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                int id = lvwApps.SelectedItems[0].Index;
                if (!kvs[id].localMachine) {
                    mnuApp.Show(lvwApps, e.Location);
                }
            }
        }

        private void mnuAppEdit_Click(object sender, EventArgs e) {
            int id = lvwApps.SelectedItems[0].Index;
            dlgSet dlg = new dlgSet(id, kvs[id]);
            if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK) {
                if (dlg.kv.localMachine) {
                    regApp = regAppsEx.CreateSubKey(dlg.kv.key, RegistryKeyPermissionCheck.ReadWriteSubTree);
                } else {
                    regApp = regApps.CreateSubKey(dlg.kv.key, RegistryKeyPermissionCheck.ReadWriteSubTree);
                }
                System.Security.AccessControl.RegistrySecurity rs = regApp.GetAccessControl();
                regApp.SetValue(null, dlg.kv.value);
                kvs[id] = dlg.kv;
                showItem(kvs[id], id);
            }
        }

        private void mnuAppDelete_Click(object sender, EventArgs e) {
            if (MessageBox.Show("You will NOT be able to restore after the operation,\nReally want to continue?", "!!!ATTENTION!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
                int id = lvwApps.SelectedItems[0].Index;
                if (kvs[id].localMachine) {
                    regAppsEx.DeleteSubKeyTree(kvs[id].key, false);
                } else {
                    regApps.DeleteSubKeyTree(kvs[id].key, false);
                }
                lvwApps.Items.RemoveAt(id);
            }
        }

        private void chkGlobal_CheckedChanged(object sender, EventArgs e) {
            btnReload_Click(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            dlgSet dlg = new dlgSet();
            if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK) {
                regApp = regApps.CreateSubKey(dlg.kv.key, RegistryKeyPermissionCheck.ReadWriteSubTree);
                regApp.SetValue(null, dlg.kv.value);
                kvs.Add(dlg.kv);
                showItem(kvs.Last());
            }
        }

    }

    public class KeyValue {
        public bool localMachine;
        public string key;
        public string value;
    }

}
