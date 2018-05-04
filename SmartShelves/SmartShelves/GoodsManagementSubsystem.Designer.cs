namespace SmartShelves
{
    partial class GoodsManagementSubsystem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableControls = new System.Windows.Forms.TabControl();
            this.tpAdd = new System.Windows.Forms.TabPage();
            this.dgvAddItem = new System.Windows.Forms.DataGridView();
            this.tpMgr = new System.Windows.Forms.TabPage();
            this.lableAtMgr = new System.Windows.Forms.Label();
            this.btnSearchAtMgr = new System.Windows.Forms.Button();
            this.cmbQuerySpeciesAtMgr = new System.Windows.Forms.ComboBox();
            this.tbConditionAtMgr = new System.Windows.Forms.TextBox();
            this.dgvMgrItem = new System.Windows.Forms.DataGridView();
            this.tpDel = new System.Windows.Forms.TabPage();
            this.labelAtDel = new System.Windows.Forms.Label();
            this.btnSearchAtDel = new System.Windows.Forms.Button();
            this.cmbQuerySpeciesAtDel = new System.Windows.Forms.ComboBox();
            this.tbConditionAtDel = new System.Windows.Forms.TextBox();
            this.dgvDelItem = new System.Windows.Forms.DataGridView();
            this.tpBinding = new System.Windows.Forms.TabPage();
            this.rtbShowAtBinding = new System.Windows.Forms.RichTextBox();
            this.btnBindingRfid = new System.Windows.Forms.Button();
            this.labelRfid = new System.Windows.Forms.Label();
            this.dgvBindingItem = new System.Windows.Forms.DataGridView();
            this.labelAtBinding = new System.Windows.Forms.Label();
            this.btnSearchAtBinding = new System.Windows.Forms.Button();
            this.cmbQuerySpeciesAtBinding = new System.Windows.Forms.ComboBox();
            this.tbConditionAtBinding = new System.Windows.Forms.TextBox();
            this.timerBindingCard = new System.Windows.Forms.Timer(this.components);
            this.tableControls.SuspendLayout();
            this.tpAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddItem)).BeginInit();
            this.tpMgr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMgrItem)).BeginInit();
            this.tpDel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelItem)).BeginInit();
            this.tpBinding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBindingItem)).BeginInit();
            this.SuspendLayout();
            // 
            // tableControls
            // 
            this.tableControls.Controls.Add(this.tpAdd);
            this.tableControls.Controls.Add(this.tpMgr);
            this.tableControls.Controls.Add(this.tpDel);
            this.tableControls.Controls.Add(this.tpBinding);
            this.tableControls.Location = new System.Drawing.Point(12, 12);
            this.tableControls.Name = "tableControls";
            this.tableControls.SelectedIndex = 0;
            this.tableControls.Size = new System.Drawing.Size(472, 449);
            this.tableControls.TabIndex = 0;
            // 
            // tpAdd
            // 
            this.tpAdd.Controls.Add(this.dgvAddItem);
            this.tpAdd.Location = new System.Drawing.Point(4, 22);
            this.tpAdd.Name = "tpAdd";
            this.tpAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdd.Size = new System.Drawing.Size(464, 423);
            this.tpAdd.TabIndex = 0;
            this.tpAdd.Text = "增加商品";
            this.tpAdd.UseVisualStyleBackColor = true;
            // 
            // dgvAddItem
            // 
            this.dgvAddItem.AllowUserToDeleteRows = false;
            this.dgvAddItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAddItem.Location = new System.Drawing.Point(3, 3);
            this.dgvAddItem.Name = "dgvAddItem";
            this.dgvAddItem.RowTemplate.Height = 23;
            this.dgvAddItem.Size = new System.Drawing.Size(458, 417);
            this.dgvAddItem.TabIndex = 0;
            this.dgvAddItem.DataSourceChanged += new System.EventHandler(this.dgv_DataSourceChanged);
            this.dgvAddItem.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAddItem_RowEnter);
            // 
            // tpMgr
            // 
            this.tpMgr.Controls.Add(this.lableAtMgr);
            this.tpMgr.Controls.Add(this.btnSearchAtMgr);
            this.tpMgr.Controls.Add(this.cmbQuerySpeciesAtMgr);
            this.tpMgr.Controls.Add(this.tbConditionAtMgr);
            this.tpMgr.Controls.Add(this.dgvMgrItem);
            this.tpMgr.Location = new System.Drawing.Point(4, 22);
            this.tpMgr.Name = "tpMgr";
            this.tpMgr.Padding = new System.Windows.Forms.Padding(3);
            this.tpMgr.Size = new System.Drawing.Size(464, 423);
            this.tpMgr.TabIndex = 1;
            this.tpMgr.Text = "管理商品";
            this.tpMgr.UseVisualStyleBackColor = true;
            // 
            // lableAtMgr
            // 
            this.lableAtMgr.AutoSize = true;
            this.lableAtMgr.Location = new System.Drawing.Point(7, 6);
            this.lableAtMgr.Name = "lableAtMgr";
            this.lableAtMgr.Size = new System.Drawing.Size(59, 12);
            this.lableAtMgr.TabIndex = 12;
            this.lableAtMgr.Text = "商品查询:";
            // 
            // btnSearchAtMgr
            // 
            this.btnSearchAtMgr.Location = new System.Drawing.Point(386, 21);
            this.btnSearchAtMgr.Name = "btnSearchAtMgr";
            this.btnSearchAtMgr.Size = new System.Drawing.Size(75, 23);
            this.btnSearchAtMgr.TabIndex = 11;
            this.btnSearchAtMgr.Text = "查找商品";
            this.btnSearchAtMgr.UseVisualStyleBackColor = true;
            this.btnSearchAtMgr.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbQuerySpeciesAtMgr
            // 
            this.cmbQuerySpeciesAtMgr.FormattingEnabled = true;
            this.cmbQuerySpeciesAtMgr.Items.AddRange(new object[] {
            "商品名称",
            "生产厂家",
            "最高价格",
            "最低价格"});
            this.cmbQuerySpeciesAtMgr.Location = new System.Drawing.Point(9, 21);
            this.cmbQuerySpeciesAtMgr.Name = "cmbQuerySpeciesAtMgr";
            this.cmbQuerySpeciesAtMgr.Size = new System.Drawing.Size(151, 20);
            this.cmbQuerySpeciesAtMgr.TabIndex = 10;
            this.cmbQuerySpeciesAtMgr.Text = "请选择查询类别";
            this.cmbQuerySpeciesAtMgr.SelectedIndexChanged += new System.EventHandler(this.cmbQuerySpecies_SelectedIndexChanged);
            // 
            // tbConditionAtMgr
            // 
            this.tbConditionAtMgr.Location = new System.Drawing.Point(166, 21);
            this.tbConditionAtMgr.Name = "tbConditionAtMgr";
            this.tbConditionAtMgr.Size = new System.Drawing.Size(214, 21);
            this.tbConditionAtMgr.TabIndex = 9;
            this.tbConditionAtMgr.Text = "请输入查询条件...";
            // 
            // dgvMgrItem
            // 
            this.dgvMgrItem.AllowUserToAddRows = false;
            this.dgvMgrItem.AllowUserToDeleteRows = false;
            this.dgvMgrItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMgrItem.Location = new System.Drawing.Point(6, 50);
            this.dgvMgrItem.Name = "dgvMgrItem";
            this.dgvMgrItem.RowTemplate.Height = 23;
            this.dgvMgrItem.Size = new System.Drawing.Size(451, 367);
            this.dgvMgrItem.TabIndex = 0;
            this.dgvMgrItem.DataSourceChanged += new System.EventHandler(this.dgv_DataSourceChanged);
            this.dgvMgrItem.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMgrItem_CellValueChanged);
            // 
            // tpDel
            // 
            this.tpDel.Controls.Add(this.labelAtDel);
            this.tpDel.Controls.Add(this.btnSearchAtDel);
            this.tpDel.Controls.Add(this.cmbQuerySpeciesAtDel);
            this.tpDel.Controls.Add(this.tbConditionAtDel);
            this.tpDel.Controls.Add(this.dgvDelItem);
            this.tpDel.Location = new System.Drawing.Point(4, 22);
            this.tpDel.Name = "tpDel";
            this.tpDel.Padding = new System.Windows.Forms.Padding(3);
            this.tpDel.Size = new System.Drawing.Size(464, 423);
            this.tpDel.TabIndex = 2;
            this.tpDel.Text = "删除商品";
            this.tpDel.UseVisualStyleBackColor = true;
            // 
            // labelAtDel
            // 
            this.labelAtDel.AutoSize = true;
            this.labelAtDel.Location = new System.Drawing.Point(6, 13);
            this.labelAtDel.Name = "labelAtDel";
            this.labelAtDel.Size = new System.Drawing.Size(59, 12);
            this.labelAtDel.TabIndex = 12;
            this.labelAtDel.Text = "商品查询:";
            // 
            // btnSearchAtDel
            // 
            this.btnSearchAtDel.Location = new System.Drawing.Point(385, 28);
            this.btnSearchAtDel.Name = "btnSearchAtDel";
            this.btnSearchAtDel.Size = new System.Drawing.Size(75, 23);
            this.btnSearchAtDel.TabIndex = 11;
            this.btnSearchAtDel.Text = "查找商品";
            this.btnSearchAtDel.UseVisualStyleBackColor = true;
            this.btnSearchAtDel.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbQuerySpeciesAtDel
            // 
            this.cmbQuerySpeciesAtDel.FormattingEnabled = true;
            this.cmbQuerySpeciesAtDel.Items.AddRange(new object[] {
            "商品名称",
            "生产厂家",
            "最高价格",
            "最低价格"});
            this.cmbQuerySpeciesAtDel.Location = new System.Drawing.Point(8, 28);
            this.cmbQuerySpeciesAtDel.Name = "cmbQuerySpeciesAtDel";
            this.cmbQuerySpeciesAtDel.Size = new System.Drawing.Size(151, 20);
            this.cmbQuerySpeciesAtDel.TabIndex = 10;
            this.cmbQuerySpeciesAtDel.Text = "请选择查询类别";
            this.cmbQuerySpeciesAtDel.SelectedIndexChanged += new System.EventHandler(this.cmbQuerySpecies_SelectedIndexChanged);
            // 
            // tbConditionAtDel
            // 
            this.tbConditionAtDel.Location = new System.Drawing.Point(165, 28);
            this.tbConditionAtDel.Name = "tbConditionAtDel";
            this.tbConditionAtDel.Size = new System.Drawing.Size(214, 21);
            this.tbConditionAtDel.TabIndex = 9;
            this.tbConditionAtDel.Text = "请输入查询条件...";
            // 
            // dgvDelItem
            // 
            this.dgvDelItem.AllowUserToAddRows = false;
            this.dgvDelItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDelItem.Location = new System.Drawing.Point(7, 57);
            this.dgvDelItem.Name = "dgvDelItem";
            this.dgvDelItem.ReadOnly = true;
            this.dgvDelItem.RowTemplate.Height = 23;
            this.dgvDelItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDelItem.Size = new System.Drawing.Size(450, 360);
            this.dgvDelItem.TabIndex = 0;
            this.dgvDelItem.DataSourceChanged += new System.EventHandler(this.dgv_DataSourceChanged);
            this.dgvDelItem.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvDelItem_UserDeletingRow);
            // 
            // tpBinding
            // 
            this.tpBinding.Controls.Add(this.rtbShowAtBinding);
            this.tpBinding.Controls.Add(this.btnBindingRfid);
            this.tpBinding.Controls.Add(this.labelRfid);
            this.tpBinding.Controls.Add(this.dgvBindingItem);
            this.tpBinding.Controls.Add(this.labelAtBinding);
            this.tpBinding.Controls.Add(this.btnSearchAtBinding);
            this.tpBinding.Controls.Add(this.cmbQuerySpeciesAtBinding);
            this.tpBinding.Controls.Add(this.tbConditionAtBinding);
            this.tpBinding.Location = new System.Drawing.Point(4, 22);
            this.tpBinding.Name = "tpBinding";
            this.tpBinding.Padding = new System.Windows.Forms.Padding(3);
            this.tpBinding.Size = new System.Drawing.Size(464, 423);
            this.tpBinding.TabIndex = 3;
            this.tpBinding.Text = "标签绑定";
            this.tpBinding.UseVisualStyleBackColor = true;
            // 
            // rtbShowAtBinding
            // 
            this.rtbShowAtBinding.Location = new System.Drawing.Point(87, 316);
            this.rtbShowAtBinding.Name = "rtbShowAtBinding";
            this.rtbShowAtBinding.Size = new System.Drawing.Size(371, 101);
            this.rtbShowAtBinding.TabIndex = 13;
            this.rtbShowAtBinding.Text = "";
            // 
            // btnBindingRfid
            // 
            this.btnBindingRfid.Location = new System.Drawing.Point(6, 370);
            this.btnBindingRfid.Name = "btnBindingRfid";
            this.btnBindingRfid.Size = new System.Drawing.Size(75, 23);
            this.btnBindingRfid.TabIndex = 12;
            this.btnBindingRfid.Text = "绑定标签";
            this.btnBindingRfid.UseVisualStyleBackColor = true;
            this.btnBindingRfid.Click += new System.EventHandler(this.btnBindingRfid_Click);
            // 
            // labelRfid
            // 
            this.labelRfid.AutoSize = true;
            this.labelRfid.Location = new System.Drawing.Point(22, 330);
            this.labelRfid.Name = "labelRfid";
            this.labelRfid.Size = new System.Drawing.Size(59, 12);
            this.labelRfid.TabIndex = 10;
            this.labelRfid.Text = "标签信息:";
            // 
            // dgvBindingItem
            // 
            this.dgvBindingItem.AllowUserToAddRows = false;
            this.dgvBindingItem.AllowUserToDeleteRows = false;
            this.dgvBindingItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBindingItem.Location = new System.Drawing.Point(6, 51);
            this.dgvBindingItem.MultiSelect = false;
            this.dgvBindingItem.Name = "dgvBindingItem";
            this.dgvBindingItem.ReadOnly = true;
            this.dgvBindingItem.RowTemplate.Height = 23;
            this.dgvBindingItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBindingItem.Size = new System.Drawing.Size(452, 259);
            this.dgvBindingItem.TabIndex = 9;
            this.dgvBindingItem.DataSourceChanged += new System.EventHandler(this.dgv_DataSourceChanged);
            // 
            // labelAtBinding
            // 
            this.labelAtBinding.AutoSize = true;
            this.labelAtBinding.Location = new System.Drawing.Point(4, 9);
            this.labelAtBinding.Name = "labelAtBinding";
            this.labelAtBinding.Size = new System.Drawing.Size(59, 12);
            this.labelAtBinding.TabIndex = 8;
            this.labelAtBinding.Text = "商品查询:";
            // 
            // btnSearchAtBinding
            // 
            this.btnSearchAtBinding.Location = new System.Drawing.Point(383, 24);
            this.btnSearchAtBinding.Name = "btnSearchAtBinding";
            this.btnSearchAtBinding.Size = new System.Drawing.Size(75, 23);
            this.btnSearchAtBinding.TabIndex = 7;
            this.btnSearchAtBinding.Text = "查找商品";
            this.btnSearchAtBinding.UseVisualStyleBackColor = true;
            this.btnSearchAtBinding.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbQuerySpeciesAtBinding
            // 
            this.cmbQuerySpeciesAtBinding.FormattingEnabled = true;
            this.cmbQuerySpeciesAtBinding.Items.AddRange(new object[] {
            "商品名称",
            "生产厂家",
            "最高价格",
            "最低价格"});
            this.cmbQuerySpeciesAtBinding.Location = new System.Drawing.Point(6, 24);
            this.cmbQuerySpeciesAtBinding.Name = "cmbQuerySpeciesAtBinding";
            this.cmbQuerySpeciesAtBinding.Size = new System.Drawing.Size(151, 20);
            this.cmbQuerySpeciesAtBinding.TabIndex = 6;
            this.cmbQuerySpeciesAtBinding.Text = "请选择查询类别";
            this.cmbQuerySpeciesAtBinding.SelectedIndexChanged += new System.EventHandler(this.cmbQuerySpecies_SelectedIndexChanged);
            // 
            // tbConditionAtBinding
            // 
            this.tbConditionAtBinding.Location = new System.Drawing.Point(163, 24);
            this.tbConditionAtBinding.Name = "tbConditionAtBinding";
            this.tbConditionAtBinding.Size = new System.Drawing.Size(214, 21);
            this.tbConditionAtBinding.TabIndex = 5;
            this.tbConditionAtBinding.Text = "请输入查询条件...";
            // 
            // timerBindingCard
            // 
            this.timerBindingCard.Interval = 256;
            this.timerBindingCard.Tick += new System.EventHandler(this.timerBindingCard_Tick);
            // 
            // GoodsManagementSubsystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 473);
            this.Controls.Add(this.tableControls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GoodsManagementSubsystem";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "货物管理子系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.tableControls.ResumeLayout(false);
            this.tpAdd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddItem)).EndInit();
            this.tpMgr.ResumeLayout(false);
            this.tpMgr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMgrItem)).EndInit();
            this.tpDel.ResumeLayout(false);
            this.tpDel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelItem)).EndInit();
            this.tpBinding.ResumeLayout(false);
            this.tpBinding.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBindingItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tableControls;
        private System.Windows.Forms.TabPage tpAdd;
        private System.Windows.Forms.DataGridView dgvAddItem;
        private System.Windows.Forms.TabPage tpMgr;
        private System.Windows.Forms.DataGridView dgvMgrItem;
        private System.Windows.Forms.TabPage tpDel;
        private System.Windows.Forms.TabPage tpBinding;
        private System.Windows.Forms.Label lableAtMgr;
        private System.Windows.Forms.Button btnSearchAtMgr;
        private System.Windows.Forms.ComboBox cmbQuerySpeciesAtMgr;
        private System.Windows.Forms.TextBox tbConditionAtMgr;
        private System.Windows.Forms.Label labelAtDel;
        private System.Windows.Forms.Button btnSearchAtDel;
        private System.Windows.Forms.ComboBox cmbQuerySpeciesAtDel;
        private System.Windows.Forms.TextBox tbConditionAtDel;
        private System.Windows.Forms.Label labelAtBinding;
        private System.Windows.Forms.Button btnSearchAtBinding;
        private System.Windows.Forms.ComboBox cmbQuerySpeciesAtBinding;
        private System.Windows.Forms.TextBox tbConditionAtBinding;
        private System.Windows.Forms.Button btnBindingRfid;
        private System.Windows.Forms.Label labelRfid;
        private System.Windows.Forms.DataGridView dgvBindingItem;
        private System.Windows.Forms.RichTextBox rtbShowAtBinding;
        private System.Windows.Forms.DataGridView dgvDelItem;
        private System.Windows.Forms.Timer timerBindingCard;
    }
}