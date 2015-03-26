namespace winrun
{
    partial class winrunr
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(winrunr));
            this.btnReload = new System.Windows.Forms.Button();
            this.lvwApps = new System.Windows.Forms.ListView();
            this.imglstApps = new System.Windows.Forms.ImageList(this.components);
            this.btnHelp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mnuApp = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuAppEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAppDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new System.Windows.Forms.Button();
            this.imglstReserved = new System.Windows.Forms.ImageList(this.components);
            this.mnuApp.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(11, 12);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(117, 39);
            this.btnReload.TabIndex = 0;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // lvwApps
            // 
            this.lvwApps.LargeImageList = this.imglstApps;
            this.lvwApps.Location = new System.Drawing.Point(12, 57);
            this.lvwApps.MultiSelect = false;
            this.lvwApps.Name = "lvwApps";
            this.lvwApps.ShowGroups = false;
            this.lvwApps.Size = new System.Drawing.Size(552, 439);
            this.lvwApps.TabIndex = 1;
            this.lvwApps.UseCompatibleStateImageBehavior = false;
            this.lvwApps.SelectedIndexChanged += new System.EventHandler(this.lvwApps_SelectedIndexChanged);
            this.lvwApps.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvwApps_MouseClick);
            // 
            // imglstApps
            // 
            this.imglstApps.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imglstApps.ImageSize = new System.Drawing.Size(32, 32);
            this.imglstApps.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(448, 12);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(117, 39);
            this.btnHelp.TabIndex = 8;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(10, 502);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tips: Right-click on the item you want to edit or delete.";
            // 
            // mnuApp
            // 
            this.mnuApp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAppEdit,
            this.mnuAppDelete});
            this.mnuApp.Name = "mnuApp";
            this.mnuApp.ShowImageMargin = false;
            this.mnuApp.Size = new System.Drawing.Size(88, 48);
            // 
            // mnuAppEdit
            // 
            this.mnuAppEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuAppEdit.Name = "mnuAppEdit";
            this.mnuAppEdit.Size = new System.Drawing.Size(87, 22);
            this.mnuAppEdit.Text = "&edit";
            this.mnuAppEdit.Click += new System.EventHandler(this.mnuAppEdit_Click);
            // 
            // mnuAppDelete
            // 
            this.mnuAppDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuAppDelete.Name = "mnuAppDelete";
            this.mnuAppDelete.Size = new System.Drawing.Size(87, 22);
            this.mnuAppDelete.Text = "&delete";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(134, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 39);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // imglstReserved
            // 
            this.imglstReserved.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglstReserved.ImageStream")));
            this.imglstReserved.TransparentColor = System.Drawing.Color.Transparent;
            this.imglstReserved.Images.SetKeyName(0, "exe");
            // 
            // winrunr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 523);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lvwApps);
            this.Controls.Add(this.btnReload);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "winrunr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "winrun r\'method ver.1";
            this.Load += new System.EventHandler(this.winrunr_Load);
            this.mnuApp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.ListView lvwApps;
        private System.Windows.Forms.ImageList imglstApps;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip mnuApp;
        private System.Windows.Forms.ToolStripMenuItem mnuAppEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuAppDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ImageList imglstReserved;
    }
}

