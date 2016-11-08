namespace CalendarByStarCluster
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
            this.DateList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DateList)).BeginInit();
            this.SuspendLayout();
            // 
            // DateList
            // 
            this.DateList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DateList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DateList.Location = new System.Drawing.Point(12, 73);
            this.DateList.Margin = new System.Windows.Forms.Padding(8);
            this.DateList.Name = "DateList";
            this.DateList.RowTemplate.Height = 23;
            this.DateList.Size = new System.Drawing.Size(520, 360);
            this.DateList.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.DateList);
            this.Name = "MainForm";
            this.Text = "Calendar by StarCluster";
            ((System.ComponentModel.ISupportInitialize)(this.DateList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DateList;
    }
}

