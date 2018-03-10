namespace TaskIconMgr
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
            this.iconList = new System.Windows.Forms.ListView();
            this.lvc_iconName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvc_iconStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // iconList
            // 
            this.iconList.CheckBoxes = true;
            this.iconList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvc_iconName,
            this.lvc_iconStatus});
            this.iconList.GridLines = true;
            this.iconList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.iconList.LabelWrap = false;
            this.iconList.Location = new System.Drawing.Point(12, 12);
            this.iconList.Name = "iconList";
            this.iconList.Size = new System.Drawing.Size(472, 449);
            this.iconList.TabIndex = 0;
            this.iconList.UseCompatibleStateImageBehavior = false;
            this.iconList.View = System.Windows.Forms.View.Details;
            this.iconList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.iconList_ItemCheck);
            // 
            // lvc_iconName
            // 
            this.lvc_iconName.Text = "图标名称";
            this.lvc_iconName.Width = 379;
            // 
            // lvc_iconStatus
            // 
            this.lvc_iconStatus.Text = "图标状态";
            this.lvc_iconStatus.Width = 72;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 473);
            this.Controls.Add(this.iconList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "任务栏图标管理器";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView iconList;
        private System.Windows.Forms.ColumnHeader lvc_iconName;
        private System.Windows.Forms.ColumnHeader lvc_iconStatus;
    }
}

