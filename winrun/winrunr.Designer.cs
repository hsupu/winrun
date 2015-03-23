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
            this.btnReload = new System.Windows.Forms.Button();
            this.lvwApps = new System.Windows.Forms.ListView();
            this.imglstApps = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(12, 12);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(117, 39);
            this.btnReload.TabIndex = 0;
            this.btnReload.Text = "重新加载";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // lvwApps
            // 
            this.lvwApps.Location = new System.Drawing.Point(12, 57);
            this.lvwApps.Name = "lvwApps";
            this.lvwApps.Size = new System.Drawing.Size(235, 177);
            this.lvwApps.TabIndex = 1;
            this.lvwApps.UseCompatibleStateImageBehavior = false;
            // 
            // imglstApps
            // 
            this.imglstApps.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imglstApps.ImageSize = new System.Drawing.Size(16, 16);
            this.imglstApps.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // winrunr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 261);
            this.Controls.Add(this.lvwApps);
            this.Controls.Add(this.btnReload);
            this.Name = "winrunr";
            this.Text = "winrun - 注册表模式";
            this.Load += new System.EventHandler(this.winrunr_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.ListView lvwApps;
        private System.Windows.Forms.ImageList imglstApps;
    }
}

