namespace SmartShelves
{
    partial class SmartShelvesTerminal
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
            this.components = new System.ComponentModel.Container();
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.tbQueryCondition = new System.Windows.Forms.TextBox();
            this.cmbQuerySpecies = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timerSerialPort = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.AllowUserToAddRows = false;
            this.dgvDisplay.AllowUserToDeleteRows = false;
            this.dgvDisplay.AllowUserToResizeRows = false;
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.GridColor = System.Drawing.SystemColors.Control;
            this.dgvDisplay.Location = new System.Drawing.Point(13, 123);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.ReadOnly = true;
            this.dgvDisplay.RowTemplate.Height = 23;
            this.dgvDisplay.Size = new System.Drawing.Size(471, 338);
            this.dgvDisplay.TabIndex = 0;
            // 
            // tbQueryCondition
            // 
            this.tbQueryCondition.Location = new System.Drawing.Point(151, 46);
            this.tbQueryCondition.Name = "tbQueryCondition";
            this.tbQueryCondition.Size = new System.Drawing.Size(252, 21);
            this.tbQueryCondition.TabIndex = 1;
            this.tbQueryCondition.Text = "请输入查询条件...";
            // 
            // cmbQuerySpecies
            // 
            this.cmbQuerySpecies.FormattingEnabled = true;
            this.cmbQuerySpecies.Items.AddRange(new object[] {
            "商品名称",
            "生产厂家",
            "最高价格",
            "最低价格"});
            this.cmbQuerySpecies.Location = new System.Drawing.Point(13, 47);
            this.cmbQuerySpecies.Name = "cmbQuerySpecies";
            this.cmbQuerySpecies.Size = new System.Drawing.Size(132, 20);
            this.cmbQuerySpecies.TabIndex = 2;
            this.cmbQuerySpecies.Text = "请选择查询类别";
            this.cmbQuerySpecies.SelectedIndexChanged += new System.EventHandler(this.cmbQuerySpecies_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(409, 44);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "查找商品";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.Search_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(11, 32);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(59, 12);
            this.label.TabIndex = 4;
            this.label.Text = "商品查询:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "此货柜商品:";
            // 
            // timerSerialPort
            // 
            this.timerSerialPort.Interval = 1000;
            this.timerSerialPort.Tick += new System.EventHandler(this.timerSerialPort_Tick);
            // 
            // SmartShelvesTerminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 473);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbQuerySpecies);
            this.Controls.Add(this.tbQueryCondition);
            this.Controls.Add(this.dgvDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SmartShelvesTerminal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "智能货柜终端";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.TextBox tbQueryCondition;
        private System.Windows.Forms.ComboBox cmbQuerySpecies;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timerSerialPort;
    }
}

