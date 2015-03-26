using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace winrun {
    public partial class dlgSet : Form {

        public int id;
        public KeyValue kv;

        public dlgSet() {
            InitializeComponent();
            kv = new KeyValue();
        }

        public dlgSet(int id, KeyValue kv) {
            InitializeComponent();
            this.id = id;
            this.kv = kv;
            btnReset_Click(null, null);
        }

        private void dlgSet_Load(object sender, EventArgs e) {
            ;
        }

        private void btnClose_Click(object sender, EventArgs e) {
            // this.Close();
        }

        private void dlgSet_Paint(object sender, PaintEventArgs e) {
            System.Drawing.Pen pen1 = new System.Drawing.Pen(System.Drawing.Color.Black);
            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            System.Drawing.Rectangle rect1 = this.DisplayRectangle;
            rect1.Width -= 1; rect1.Height -= 1;
            formGraphics.DrawRectangle(pen1, rect1);
            pen1.Dispose();
            formGraphics.Dispose();
        }

        private void btnBrowse_Click(object sender, EventArgs e) {
            if (dlgOpenFile.ShowDialog(this) == System.Windows.Forms.DialogResult.OK) {
                //if (File.Exists(dlgOpenFile.FileName)) {
                    txtValue.Text = dlgOpenFile.FileName;
                //}
            }
        }

        private void btnReset_Click(object sender, EventArgs e) {
            txtKey.Text = kv.key;
            txtValue.Text = kv.value;
        }

        private void btnQuery_Click(object sender, EventArgs e) {
            this.DialogResult = System.Windows.Forms.DialogResult.None;
            if (txtKey.Text.Length == 0 || txtValue.Text.Length == 0) {
                MessageBox.Show("Value is required.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (id != 0 || MessageBox.Show("You will NOT be able to restore after the operation,\nReally want to continue?", "!!!ATTENTION!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
                kv.key = txtKey.Text;
                kv.value = txtValue.Text;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }
    }
}
