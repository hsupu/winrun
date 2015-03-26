using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winrun {
    public partial class dlgSet : Form {
        public dlgSet() {
            InitializeComponent();
        }

        private void dlgSet_Load(object sender, EventArgs e) {
            ;
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
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

        }
    }
}
