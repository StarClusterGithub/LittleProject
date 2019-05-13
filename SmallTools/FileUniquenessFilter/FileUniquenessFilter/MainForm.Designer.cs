namespace FileUniquenessFilter
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbInputDir = new System.Windows.Forms.TextBox();
            this.btnInputDir = new System.Windows.Forms.Button();
            this.tbOutputDir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOutputDir = new System.Windows.Forms.Button();
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.btnStartFilter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Directory:";
            // 
            // tbInputDir
            // 
            this.tbInputDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInputDir.Location = new System.Drawing.Point(12, 54);
            this.tbInputDir.Name = "tbInputDir";
            this.tbInputDir.Size = new System.Drawing.Size(391, 21);
            this.tbInputDir.TabIndex = 2;
            this.tbInputDir.Text = "Please input or select directory...";
            // 
            // btnInputDir
            // 
            this.btnInputDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInputDir.Location = new System.Drawing.Point(409, 52);
            this.btnInputDir.Name = "btnInputDir";
            this.btnInputDir.Size = new System.Drawing.Size(75, 23);
            this.btnInputDir.TabIndex = 1;
            this.btnInputDir.Text = "Select";
            this.btnInputDir.UseVisualStyleBackColor = true;
            // 
            // tbOutputDir
            // 
            this.tbOutputDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOutputDir.Location = new System.Drawing.Point(12, 117);
            this.tbOutputDir.Name = "tbOutputDir";
            this.tbOutputDir.Size = new System.Drawing.Size(391, 21);
            this.tbOutputDir.TabIndex = 3;
            this.tbOutputDir.Text = "Please input or select directory...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output Directory:";
            // 
            // btnOutputDir
            // 
            this.btnOutputDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOutputDir.Location = new System.Drawing.Point(409, 117);
            this.btnOutputDir.Name = "btnOutputDir";
            this.btnOutputDir.Size = new System.Drawing.Size(75, 23);
            this.btnOutputDir.TabIndex = 5;
            this.btnOutputDir.Text = "Select";
            this.btnOutputDir.UseVisualStyleBackColor = true;
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbDisplay.Location = new System.Drawing.Point(12, 202);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.ReadOnly = true;
            this.rtbDisplay.Size = new System.Drawing.Size(472, 259);
            this.rtbDisplay.TabIndex = 6;
            this.rtbDisplay.Text = "";
            // 
            // btnStartFilter
            // 
            this.btnStartFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartFilter.Location = new System.Drawing.Point(195, 160);
            this.btnStartFilter.Name = "btnStartFilter";
            this.btnStartFilter.Size = new System.Drawing.Size(75, 23);
            this.btnStartFilter.TabIndex = 7;
            this.btnStartFilter.Text = "Start";
            this.btnStartFilter.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 473);
            this.Controls.Add(this.btnStartFilter);
            this.Controls.Add(this.rtbDisplay);
            this.Controls.Add(this.btnOutputDir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbOutputDir);
            this.Controls.Add(this.btnInputDir);
            this.Controls.Add(this.tbInputDir);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Uniqueness Filter By Kuranado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbInputDir;
        private System.Windows.Forms.Button btnInputDir;
        private System.Windows.Forms.TextBox tbOutputDir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOutputDir;
        private System.Windows.Forms.RichTextBox rtbDisplay;
        private System.Windows.Forms.Button btnStartFilter;
    }
}

