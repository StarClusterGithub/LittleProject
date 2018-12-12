namespace MaxthonChromeBookmarkConverter
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tbImport = new System.Windows.Forms.TextBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.rtbShowInfo = new System.Windows.Forms.RichTextBox();
            this.tbExport = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbImport
            // 
            this.tbImport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbImport.Location = new System.Drawing.Point(12, 12);
            this.tbImport.Name = "tbImport";
            this.tbImport.Size = new System.Drawing.Size(222, 21);
            this.tbImport.TabIndex = 1;
            this.tbImport.Text = "Please input Mathon bookmark directory...";
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.Location = new System.Drawing.Point(241, 13);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(91, 23);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            // 
            // rtbShowInfo
            // 
            this.rtbShowInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbShowInfo.Location = new System.Drawing.Point(12, 56);
            this.rtbShowInfo.Name = "rtbShowInfo";
            this.rtbShowInfo.ReadOnly = true;
            this.rtbShowInfo.Size = new System.Drawing.Size(320, 179);
            this.rtbShowInfo.TabIndex = 2;
            this.rtbShowInfo.Text = "";
            // 
            // tbExport
            // 
            this.tbExport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbExport.Location = new System.Drawing.Point(12, 262);
            this.tbExport.Name = "tbExport";
            this.tbExport.Size = new System.Drawing.Size(222, 21);
            this.tbExport.TabIndex = 3;
            this.tbExport.Text = "Plaese input export directory...";
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(241, 262);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(91, 23);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 321);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.tbExport);
            this.Controls.Add(this.rtbShowInfo);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.tbImport);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maxthon/Chrome Bookmark Coverter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbImport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.RichTextBox rtbShowInfo;
        private System.Windows.Forms.TextBox tbExport;
        private System.Windows.Forms.Button btnExport;
    }
}

