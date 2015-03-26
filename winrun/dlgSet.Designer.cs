namespace winrun {
    partial class dlgSet {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "runname";
            // 
            // txtKey
            // 
            this.txtKey.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtKey.Location = new System.Drawing.Point(12, 26);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(365, 26);
            this.txtKey.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(305, 89);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(72, 28);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // dlgOpenFile
            // 
            this.dlgOpenFile.Filter = "所有文件(*.*)|*.*";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 149);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(54, 32);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnQuery.Location = new System.Drawing.Point(231, 149);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(79, 32);
            this.btnQuery.TabIndex = 9;
            this.btnQuery.Text = "Confirm";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(316, 149);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(61, 32);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(347, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "If the extension is \"exe\", then you can omit it when run.";
            // 
            // txtValue
            // 
            this.txtValue.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtValue.Location = new System.Drawing.Point(12, 90);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(287, 26);
            this.txtValue.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(9, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "destination";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(305, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "It can be set as a relative target like \"notepad\".";
            // 
            // dlgSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(389, 193);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dlgSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "winrun";
            this.Load += new System.EventHandler(this.dlgSet_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.dlgSet_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}