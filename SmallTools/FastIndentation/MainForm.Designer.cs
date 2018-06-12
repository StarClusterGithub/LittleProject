namespace FastIndentation
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
            this.tbDelimiterNumber = new System.Windows.Forms.TextBox();
            this.rbtnSpace = new System.Windows.Forms.RadioButton();
            this.rbtnTabs = new System.Windows.Forms.RadioButton();
            this.rtbProcess = new System.Windows.Forms.RichTextBox();
            this.gbDelimiter = new System.Windows.Forms.GroupBox();
            this.labelDelimiterNumber = new System.Windows.Forms.Label();
            this.labelDelimiterType = new System.Windows.Forms.Label();
            this.gbDelimiter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDelimiterNumber
            // 
            this.tbDelimiterNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDelimiterNumber.Location = new System.Drawing.Point(6, 46);
            this.tbDelimiterNumber.Name = "tbDelimiterNumber";
            this.tbDelimiterNumber.Size = new System.Drawing.Size(59, 21);
            this.tbDelimiterNumber.TabIndex = 0;
            this.tbDelimiterNumber.Text = "2";
            // 
            // rbtnSpace
            // 
            this.rbtnSpace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rbtnSpace.AutoSize = true;
            this.rbtnSpace.Location = new System.Drawing.Point(6, 101);
            this.rbtnSpace.Name = "rbtnSpace";
            this.rbtnSpace.Size = new System.Drawing.Size(47, 16);
            this.rbtnSpace.TabIndex = 1;
            this.rbtnSpace.Tag = "";
            this.rbtnSpace.Text = "空格";
            this.rbtnSpace.UseVisualStyleBackColor = true;
            // 
            // rbtnTabs
            // 
            this.rbtnTabs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rbtnTabs.AutoSize = true;
            this.rbtnTabs.Checked = true;
            this.rbtnTabs.Location = new System.Drawing.Point(6, 123);
            this.rbtnTabs.Name = "rbtnTabs";
            this.rbtnTabs.Size = new System.Drawing.Size(59, 16);
            this.rbtnTabs.TabIndex = 2;
            this.rbtnTabs.TabStop = true;
            this.rbtnTabs.Tag = "";
            this.rbtnTabs.Text = "制表符";
            this.rbtnTabs.UseVisualStyleBackColor = true;
            // 
            // rtbProcess
            // 
            this.rtbProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbProcess.Location = new System.Drawing.Point(91, 12);
            this.rtbProcess.Name = "rtbProcess";
            this.rtbProcess.Size = new System.Drawing.Size(393, 449);
            this.rtbProcess.TabIndex = 3;
            this.rtbProcess.Text = "";
            // 
            // gbDelimiter
            // 
            this.gbDelimiter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbDelimiter.Controls.Add(this.labelDelimiterType);
            this.gbDelimiter.Controls.Add(this.labelDelimiterNumber);
            this.gbDelimiter.Controls.Add(this.rbtnSpace);
            this.gbDelimiter.Controls.Add(this.rbtnTabs);
            this.gbDelimiter.Controls.Add(this.tbDelimiterNumber);
            this.gbDelimiter.Location = new System.Drawing.Point(12, 139);
            this.gbDelimiter.Name = "gbDelimiter";
            this.gbDelimiter.Size = new System.Drawing.Size(73, 159);
            this.gbDelimiter.TabIndex = 4;
            this.gbDelimiter.TabStop = false;
            this.gbDelimiter.Text = "分隔符";
            // 
            // labelDelimiterNumber
            // 
            this.labelDelimiterNumber.AutoSize = true;
            this.labelDelimiterNumber.Location = new System.Drawing.Point(4, 31);
            this.labelDelimiterNumber.Name = "labelDelimiterNumber";
            this.labelDelimiterNumber.Size = new System.Drawing.Size(29, 12);
            this.labelDelimiterNumber.TabIndex = 3;
            this.labelDelimiterNumber.Text = "数量";
            // 
            // labelDelimiterType
            // 
            this.labelDelimiterType.AutoSize = true;
            this.labelDelimiterType.Location = new System.Drawing.Point(6, 86);
            this.labelDelimiterType.Name = "labelDelimiterType";
            this.labelDelimiterType.Size = new System.Drawing.Size(29, 12);
            this.labelDelimiterType.TabIndex = 4;
            this.labelDelimiterType.Text = "类型";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 473);
            this.Controls.Add(this.gbDelimiter);
            this.Controls.Add(this.rtbProcess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "快速缩进";
            this.gbDelimiter.ResumeLayout(false);
            this.gbDelimiter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbDelimiterNumber;
        private System.Windows.Forms.RadioButton rbtnSpace;
        private System.Windows.Forms.RadioButton rbtnTabs;
        private System.Windows.Forms.RichTextBox rtbProcess;
        private System.Windows.Forms.GroupBox gbDelimiter;
        private System.Windows.Forms.Label labelDelimiterNumber;
        private System.Windows.Forms.Label labelDelimiterType;
    }
}

