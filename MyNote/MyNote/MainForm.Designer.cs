namespace MyNote
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenuStript = new System.Windows.Forms.MenuStrip();
            this.fileItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newChildItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openChildItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveChildItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsChildItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitChildItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editItem = new System.Windows.Forms.ToolStripMenuItem();
            this.untoChildItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoChildItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllChildItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutChildItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyChildItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteChildItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteChildItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertChildItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoWordWrapChildItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontChildItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shapeChildItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorChildItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStriptChildItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpChildItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitChildItem = new System.Windows.Forms.ToolStripSeparator();
            this.abortChildItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.loginUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.loginDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.newToolItem = new System.Windows.Forms.ToolStripButton();
            this.openToolItem = new System.Windows.Forms.ToolStripButton();
            this.saveToolItem = new System.Windows.Forms.ToolStripButton();
            this.printToolItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolItem = new System.Windows.Forms.ToolStripButton();
            this.copyToolItem = new System.Windows.Forms.ToolStripButton();
            this.pasteToolItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.fontToolItem = new System.Windows.Forms.ToolStripComboBox();
            this.fontSizeToolItem = new System.Windows.Forms.ToolStripComboBox();
            this.leftAlignmentToolItem = new System.Windows.Forms.ToolStripButton();
            this.centerAlignmentToolItem = new System.Windows.Forms.ToolStripButton();
            this.rightAlignmentToolItem = new System.Windows.Forms.ToolStripButton();
            this.overstrikingToolItem = new System.Windows.Forms.ToolStripButton();
            this.italicToolItem = new System.Windows.Forms.ToolStripButton();
            this.colorToolItem = new System.Windows.Forms.ToolStripButton();
            this.helpToolItem = new System.Windows.Forms.ToolStripButton();
            this.nowTime = new System.Windows.Forms.ToolStripLabel();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.untoShortCutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoShortCutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllShortCutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutShortCutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyShortCutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteShortCutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteShortCutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textEditor = new System.Windows.Forms.RichTextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.colorSelect = new System.Windows.Forms.ColorDialog();
            this.mainMenuStript.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStript
            // 
            this.mainMenuStript.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileItem,
            this.editItem,
            this.formItem,
            this.viewItem,
            this.helpItem});
            this.mainMenuStript.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStript.Name = "mainMenuStript";
            this.mainMenuStript.Size = new System.Drawing.Size(704, 25);
            this.mainMenuStript.TabIndex = 0;
            this.mainMenuStript.Text = "menuText";
            // 
            // fileItem
            // 
            this.fileItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newChildItem,
            this.openChildItem,
            this.saveChildItem,
            this.saveAsChildItem,
            this.exitChildItem});
            this.fileItem.Name = "fileItem";
            this.fileItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.fileItem.Size = new System.Drawing.Size(58, 21);
            this.fileItem.Text = "文件(&F)";
            this.fileItem.Click += new System.EventHandler(this.fileItem_Click);
            // 
            // newChildItem
            // 
            this.newChildItem.Name = "newChildItem";
            this.newChildItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newChildItem.Size = new System.Drawing.Size(206, 22);
            this.newChildItem.Text = "新建(&N)";
            this.newChildItem.Click += new System.EventHandler(this.newChildItem_Click);
            // 
            // openChildItem
            // 
            this.openChildItem.Name = "openChildItem";
            this.openChildItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openChildItem.Size = new System.Drawing.Size(206, 22);
            this.openChildItem.Text = "打开(&O)";
            this.openChildItem.Click += new System.EventHandler(this.openChildItem_Click);
            // 
            // saveChildItem
            // 
            this.saveChildItem.Name = "saveChildItem";
            this.saveChildItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveChildItem.Size = new System.Drawing.Size(206, 22);
            this.saveChildItem.Text = "保存(&S)";
            this.saveChildItem.Click += new System.EventHandler(this.saveChildItem_Click);
            // 
            // saveAsChildItem
            // 
            this.saveAsChildItem.Name = "saveAsChildItem";
            this.saveAsChildItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsChildItem.Size = new System.Drawing.Size(206, 22);
            this.saveAsChildItem.Text = "另存为(&A)";
            this.saveAsChildItem.Click += new System.EventHandler(this.saveAsChildItem_Click);
            // 
            // exitChildItem
            // 
            this.exitChildItem.Name = "exitChildItem";
            this.exitChildItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitChildItem.Size = new System.Drawing.Size(206, 22);
            this.exitChildItem.Text = "退出(&X)";
            this.exitChildItem.Click += new System.EventHandler(this.exitChildItem_Click);
            // 
            // editItem
            // 
            this.editItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.untoChildItem,
            this.redoChildItem,
            this.selectAllChildItem,
            this.cutChildItem,
            this.copyChildItem,
            this.pasteChildItem,
            this.deleteChildItem,
            this.insertChildItem});
            this.editItem.Name = "editItem";
            this.editItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.editItem.Size = new System.Drawing.Size(59, 21);
            this.editItem.Text = "编辑(&E)";
            this.editItem.Click += new System.EventHandler(this.editItem_Click);
            // 
            // untoChildItem
            // 
            this.untoChildItem.Name = "untoChildItem";
            this.untoChildItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.untoChildItem.Size = new System.Drawing.Size(177, 22);
            this.untoChildItem.Text = "撤销(&U)";
            this.untoChildItem.Click += new System.EventHandler(this.untoChildItem_Click);
            // 
            // redoChildItem
            // 
            this.redoChildItem.Name = "redoChildItem";
            this.redoChildItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoChildItem.Size = new System.Drawing.Size(177, 22);
            this.redoChildItem.Text = "重做(&R)";
            this.redoChildItem.Click += new System.EventHandler(this.redoChildItem_Click);
            // 
            // selectAllChildItem
            // 
            this.selectAllChildItem.Name = "selectAllChildItem";
            this.selectAllChildItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllChildItem.Size = new System.Drawing.Size(177, 22);
            this.selectAllChildItem.Text = "全选(&L)";
            this.selectAllChildItem.Click += new System.EventHandler(this.selectAllChildItem_Click);
            // 
            // cutChildItem
            // 
            this.cutChildItem.Name = "cutChildItem";
            this.cutChildItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutChildItem.Size = new System.Drawing.Size(177, 22);
            this.cutChildItem.Text = "剪切(&T)";
            this.cutChildItem.Click += new System.EventHandler(this.cutChildItem_Click);
            // 
            // copyChildItem
            // 
            this.copyChildItem.Name = "copyChildItem";
            this.copyChildItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyChildItem.Size = new System.Drawing.Size(177, 22);
            this.copyChildItem.Text = "复制(&C)";
            this.copyChildItem.Click += new System.EventHandler(this.copyChildItem_Click);
            // 
            // pasteChildItem
            // 
            this.pasteChildItem.Name = "pasteChildItem";
            this.pasteChildItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteChildItem.Size = new System.Drawing.Size(177, 22);
            this.pasteChildItem.Text = "粘贴(&P)";
            this.pasteChildItem.Click += new System.EventHandler(this.pasteChildItem_Click);
            // 
            // deleteChildItem
            // 
            this.deleteChildItem.Name = "deleteChildItem";
            this.deleteChildItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteChildItem.Size = new System.Drawing.Size(177, 22);
            this.deleteChildItem.Text = "删除(&D)";
            this.deleteChildItem.Click += new System.EventHandler(this.deleteChildItem_Click);
            // 
            // insertChildItem
            // 
            this.insertChildItem.Name = "insertChildItem";
            this.insertChildItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.insertChildItem.Size = new System.Drawing.Size(177, 22);
            this.insertChildItem.Text = "插入图片(&I)";
            this.insertChildItem.Click += new System.EventHandler(this.insertChildItem_Click);
            // 
            // formItem
            // 
            this.formItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoWordWrapChildItem,
            this.fontChildItem,
            this.shapeChildItem,
            this.colorChildItem});
            this.formItem.Name = "formItem";
            this.formItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.formItem.Size = new System.Drawing.Size(62, 21);
            this.formItem.Text = "格式(&O)";
            this.formItem.Click += new System.EventHandler(this.formItem_Click);
            // 
            // autoWordWrapChildItem
            // 
            this.autoWordWrapChildItem.Checked = true;
            this.autoWordWrapChildItem.CheckOnClick = true;
            this.autoWordWrapChildItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoWordWrapChildItem.Name = "autoWordWrapChildItem";
            this.autoWordWrapChildItem.Size = new System.Drawing.Size(124, 22);
            this.autoWordWrapChildItem.Text = "自动换行";
            this.autoWordWrapChildItem.Click += new System.EventHandler(this.autoWordWrapChildItem_Click);
            // 
            // fontChildItem
            // 
            this.fontChildItem.Name = "fontChildItem";
            this.fontChildItem.Size = new System.Drawing.Size(124, 22);
            this.fontChildItem.Text = "字体大小";
            this.fontChildItem.Click += new System.EventHandler(this.fontChildItem_Click);
            // 
            // shapeChildItem
            // 
            this.shapeChildItem.Name = "shapeChildItem";
            this.shapeChildItem.Size = new System.Drawing.Size(124, 22);
            this.shapeChildItem.Text = "形状";
            this.shapeChildItem.Click += new System.EventHandler(this.shapeChildItem_Click);
            // 
            // colorChildItem
            // 
            this.colorChildItem.Name = "colorChildItem";
            this.colorChildItem.Size = new System.Drawing.Size(124, 22);
            this.colorChildItem.Text = "颜色";
            this.colorChildItem.Click += new System.EventHandler(this.colorChildItem_Click);
            // 
            // viewItem
            // 
            this.viewItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStriptChildItem});
            this.viewItem.Name = "viewItem";
            this.viewItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.V)));
            this.viewItem.Size = new System.Drawing.Size(60, 21);
            this.viewItem.Text = "查看(&V)";
            // 
            // statusStriptChildItem
            // 
            this.statusStriptChildItem.Name = "statusStriptChildItem";
            this.statusStriptChildItem.Size = new System.Drawing.Size(112, 22);
            this.statusStriptChildItem.Text = "状态栏";
            this.statusStriptChildItem.Click += new System.EventHandler(this.statusStriptChildItem_Click);
            // 
            // helpItem
            // 
            this.helpItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpChildItem,
            this.splitChildItem,
            this.abortChildItem});
            this.helpItem.Name = "helpItem";
            this.helpItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.helpItem.Size = new System.Drawing.Size(61, 21);
            this.helpItem.Text = "帮助(&H)";
            // 
            // viewHelpChildItem
            // 
            this.viewHelpChildItem.Name = "viewHelpChildItem";
            this.viewHelpChildItem.Size = new System.Drawing.Size(136, 22);
            this.viewHelpChildItem.Text = "查看帮助";
            this.viewHelpChildItem.Click += new System.EventHandler(this.viewHelpChildItem_Click);
            // 
            // splitChildItem
            // 
            this.splitChildItem.Name = "splitChildItem";
            this.splitChildItem.Size = new System.Drawing.Size(133, 6);
            // 
            // abortChildItem
            // 
            this.abortChildItem.Name = "abortChildItem";
            this.abortChildItem.Size = new System.Drawing.Size(136, 22);
            this.abortChildItem.Text = "关于记事本";
            this.abortChildItem.Click += new System.EventHandler(this.abortChildItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginUser,
            this.loginDate});
            this.statusStrip.Location = new System.Drawing.Point(0, 660);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(704, 22);
            this.statusStrip.TabIndex = 1;
            // 
            // loginUser
            // 
            this.loginUser.Name = "loginUser";
            this.loginUser.Size = new System.Drawing.Size(0, 17);
            // 
            // loginDate
            // 
            this.loginDate.Name = "loginDate";
            this.loginDate.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolItem,
            this.openToolItem,
            this.saveToolItem,
            this.printToolItem,
            this.toolStripSeparator,
            this.cutToolItem,
            this.copyToolItem,
            this.pasteToolItem,
            this.toolStripSeparator1,
            this.fontToolItem,
            this.fontSizeToolItem,
            this.toolStripSeparator2,
            this.leftAlignmentToolItem,
            this.centerAlignmentToolItem,
            this.rightAlignmentToolItem,
            this.overstrikingToolItem,
            this.italicToolItem,
            this.colorToolItem,
            this.helpToolItem,
            this.nowTime});
            this.toolStrip.Location = new System.Drawing.Point(0, 25);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(704, 25);
            this.toolStrip.Stretch = true;
            this.toolStrip.TabIndex = 3;
            // 
            // newToolItem
            // 
            this.newToolItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolItem.Image")));
            this.newToolItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolItem.Name = "newToolItem";
            this.newToolItem.Size = new System.Drawing.Size(23, 22);
            this.newToolItem.Text = "新建(&N)";
            this.newToolItem.Click += new System.EventHandler(this.newToolItem_Click);
            // 
            // openToolItem
            // 
            this.openToolItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolItem.Image")));
            this.openToolItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolItem.Name = "openToolItem";
            this.openToolItem.Size = new System.Drawing.Size(23, 22);
            this.openToolItem.Text = "打开(&O)";
            this.openToolItem.Click += new System.EventHandler(this.openToolItem_Click);
            // 
            // saveToolItem
            // 
            this.saveToolItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolItem.Image")));
            this.saveToolItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolItem.Name = "saveToolItem";
            this.saveToolItem.Size = new System.Drawing.Size(23, 22);
            this.saveToolItem.Text = "保存(&S)";
            this.saveToolItem.Click += new System.EventHandler(this.saveToolItem_Click);
            // 
            // printToolItem
            // 
            this.printToolItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolItem.Image")));
            this.printToolItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolItem.Name = "printToolItem";
            this.printToolItem.Size = new System.Drawing.Size(23, 22);
            this.printToolItem.Text = "打印(&P)";
            this.printToolItem.Click += new System.EventHandler(this.printToolItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // cutToolItem
            // 
            this.cutToolItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolItem.Image")));
            this.cutToolItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolItem.Name = "cutToolItem";
            this.cutToolItem.Size = new System.Drawing.Size(23, 22);
            this.cutToolItem.Text = "剪切(&U)";
            this.cutToolItem.Click += new System.EventHandler(this.cutToolItem_Click);
            // 
            // copyToolItem
            // 
            this.copyToolItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolItem.Image")));
            this.copyToolItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolItem.Name = "copyToolItem";
            this.copyToolItem.Size = new System.Drawing.Size(23, 22);
            this.copyToolItem.Text = "复制(&C)";
            this.copyToolItem.Click += new System.EventHandler(this.copyToolItem_Click);
            // 
            // pasteToolItem
            // 
            this.pasteToolItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolItem.Image")));
            this.pasteToolItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolItem.Name = "pasteToolItem";
            this.pasteToolItem.Size = new System.Drawing.Size(23, 22);
            this.pasteToolItem.Text = "粘贴(&P)";
            this.pasteToolItem.Click += new System.EventHandler(this.pasteToolItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // fontToolItem
            // 
            this.fontToolItem.Items.AddRange(new object[] {
            "宋体"});
            this.fontToolItem.Name = "fontToolItem";
            this.fontToolItem.Size = new System.Drawing.Size(121, 25);
            this.fontToolItem.Click += new System.EventHandler(this.fontToolItem_Click);
            // 
            // fontSizeToolItem
            // 
            this.fontSizeToolItem.Items.AddRange(new object[] {
            "56",
            "45",
            "36",
            "30",
            "27",
            "24",
            "21",
            "18",
            "15",
            "12",
            "9",
            "6",
            "3",
            "1"});
            this.fontSizeToolItem.Name = "fontSizeToolItem";
            this.fontSizeToolItem.Size = new System.Drawing.Size(121, 25);
            this.fontSizeToolItem.Click += new System.EventHandler(this.fontSizeToolItem_Click);
            // 
            // leftAlignmentToolItem
            // 
            this.leftAlignmentToolItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.leftAlignmentToolItem.Image = global::MyNote.Properties.Resources.align_left;
            this.leftAlignmentToolItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.leftAlignmentToolItem.Name = "leftAlignmentToolItem";
            this.leftAlignmentToolItem.Size = new System.Drawing.Size(23, 22);
            this.leftAlignmentToolItem.Text = "左对齐";
            this.leftAlignmentToolItem.Click += new System.EventHandler(this.leftAlignmentToolItem_Click);
            // 
            // centerAlignmentToolItem
            // 
            this.centerAlignmentToolItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.centerAlignmentToolItem.Image = global::MyNote.Properties.Resources.align_center;
            this.centerAlignmentToolItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.centerAlignmentToolItem.Name = "centerAlignmentToolItem";
            this.centerAlignmentToolItem.Size = new System.Drawing.Size(23, 22);
            this.centerAlignmentToolItem.Text = "居中对齐";
            this.centerAlignmentToolItem.Click += new System.EventHandler(this.centerAlignmentToolItem_Click);
            // 
            // rightAlignmentToolItem
            // 
            this.rightAlignmentToolItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rightAlignmentToolItem.Image = global::MyNote.Properties.Resources.align_right;
            this.rightAlignmentToolItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rightAlignmentToolItem.Name = "rightAlignmentToolItem";
            this.rightAlignmentToolItem.Size = new System.Drawing.Size(23, 22);
            this.rightAlignmentToolItem.Text = "右对齐";
            this.rightAlignmentToolItem.Click += new System.EventHandler(this.rightAlignmentToolItem_Click);
            // 
            // overstrikingToolItem
            // 
            this.overstrikingToolItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.overstrikingToolItem.Image = global::MyNote.Properties.Resources.overstriking_;
            this.overstrikingToolItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.overstrikingToolItem.Name = "overstrikingToolItem";
            this.overstrikingToolItem.Size = new System.Drawing.Size(23, 22);
            this.overstrikingToolItem.Text = "加粗";
            this.overstrikingToolItem.Click += new System.EventHandler(this.overstrikingToolItem_Click);
            // 
            // italicToolItem
            // 
            this.italicToolItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.italicToolItem.Image = global::MyNote.Properties.Resources.italic;
            this.italicToolItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italicToolItem.Name = "italicToolItem";
            this.italicToolItem.Size = new System.Drawing.Size(23, 22);
            this.italicToolItem.Text = "斜体";
            this.italicToolItem.Click += new System.EventHandler(this.italicToolItem_Click);
            // 
            // colorToolItem
            // 
            this.colorToolItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colorToolItem.Image = global::MyNote.Properties.Resources.color;
            this.colorToolItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colorToolItem.Name = "colorToolItem";
            this.colorToolItem.Size = new System.Drawing.Size(23, 22);
            this.colorToolItem.Text = "颜色";
            this.colorToolItem.Click += new System.EventHandler(this.colorToolItem_Click);
            // 
            // helpToolItem
            // 
            this.helpToolItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolItem.Image = ((System.Drawing.Image)(resources.GetObject("helpToolItem.Image")));
            this.helpToolItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolItem.Name = "helpToolItem";
            this.helpToolItem.Size = new System.Drawing.Size(23, 22);
            this.helpToolItem.Text = "帮助(&L)";
            this.helpToolItem.Click += new System.EventHandler(this.helpToolItem_Click);
            // 
            // nowTime
            // 
            this.nowTime.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.nowTime.Name = "nowTime";
            this.nowTime.Size = new System.Drawing.Size(0, 22);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.untoShortCutMenuItem,
            this.redoShortCutMenuItem,
            this.selectAllShortCutMenuItem,
            this.cutShortCutMenuItem,
            this.copyShortCutMenuItem,
            this.pasteShortCutMenuItem,
            this.deleteShortCutMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(118, 158);
            // 
            // untoShortCutMenuItem
            // 
            this.untoShortCutMenuItem.Name = "untoShortCutMenuItem";
            this.untoShortCutMenuItem.Size = new System.Drawing.Size(117, 22);
            this.untoShortCutMenuItem.Text = "撤销(&U)";
            this.untoShortCutMenuItem.Click += new System.EventHandler(this.untoShortCutMenuItem_Click);
            // 
            // redoShortCutMenuItem
            // 
            this.redoShortCutMenuItem.Name = "redoShortCutMenuItem";
            this.redoShortCutMenuItem.Size = new System.Drawing.Size(117, 22);
            this.redoShortCutMenuItem.Text = "重做(&R)";
            this.redoShortCutMenuItem.Click += new System.EventHandler(this.redoShortCutMenuItem_Click);
            // 
            // selectAllShortCutMenuItem
            // 
            this.selectAllShortCutMenuItem.Name = "selectAllShortCutMenuItem";
            this.selectAllShortCutMenuItem.Size = new System.Drawing.Size(117, 22);
            this.selectAllShortCutMenuItem.Text = "全选(&L)";
            this.selectAllShortCutMenuItem.Click += new System.EventHandler(this.selectAllShortCutMenuItem_Click);
            // 
            // cutShortCutMenuItem
            // 
            this.cutShortCutMenuItem.Name = "cutShortCutMenuItem";
            this.cutShortCutMenuItem.Size = new System.Drawing.Size(117, 22);
            this.cutShortCutMenuItem.Text = "剪切(&T)";
            this.cutShortCutMenuItem.Click += new System.EventHandler(this.cutShortCutMenuItem_Click);
            // 
            // copyShortCutMenuItem
            // 
            this.copyShortCutMenuItem.Name = "copyShortCutMenuItem";
            this.copyShortCutMenuItem.Size = new System.Drawing.Size(117, 22);
            this.copyShortCutMenuItem.Text = "复制(&C)";
            this.copyShortCutMenuItem.Click += new System.EventHandler(this.copyShortCutMenuItem_Click);
            // 
            // pasteShortCutMenuItem
            // 
            this.pasteShortCutMenuItem.Name = "pasteShortCutMenuItem";
            this.pasteShortCutMenuItem.Size = new System.Drawing.Size(117, 22);
            this.pasteShortCutMenuItem.Text = "粘贴(&P)";
            this.pasteShortCutMenuItem.Click += new System.EventHandler(this.pasteShortCutMenuItem_Click);
            // 
            // deleteShortCutMenuItem
            // 
            this.deleteShortCutMenuItem.Name = "deleteShortCutMenuItem";
            this.deleteShortCutMenuItem.Size = new System.Drawing.Size(117, 22);
            this.deleteShortCutMenuItem.Text = "删除(&D)";
            this.deleteShortCutMenuItem.Click += new System.EventHandler(this.deleteShortCutMenuItem_Click);
            // 
            // textEditor
            // 
            this.textEditor.AcceptsTab = true;
            this.textEditor.ContextMenuStrip = this.contextMenuStrip;
            this.textEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEditor.HideSelection = false;
            this.textEditor.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textEditor.Location = new System.Drawing.Point(0, 50);
            this.textEditor.Name = "textEditor";
            this.textEditor.Size = new System.Drawing.Size(704, 610);
            this.textEditor.TabIndex = 2;
            this.textEditor.Text = "";
            this.textEditor.Visible = false;
            this.textEditor.TextChanged += new System.EventHandler(this.textEditor_TextChanged);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyNote.Properties.Resources.kotomi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(704, 682);
            this.Controls.Add(this.textEditor);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.mainMenuStript);
            this.MainMenuStrip = this.mainMenuStript;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StarrySkyNoteBook";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenuStript.ResumeLayout(false);
            this.mainMenuStript.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStript;
        private System.Windows.Forms.ToolStripMenuItem fileItem;
        private System.Windows.Forms.ToolStripMenuItem newChildItem;
        private System.Windows.Forms.ToolStripMenuItem openChildItem;
        private System.Windows.Forms.ToolStripMenuItem saveChildItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsChildItem;
        private System.Windows.Forms.ToolStripMenuItem exitChildItem;
        private System.Windows.Forms.ToolStripMenuItem editItem;
        private System.Windows.Forms.ToolStripMenuItem formItem;
        private System.Windows.Forms.ToolStripMenuItem viewItem;
        private System.Windows.Forms.ToolStripMenuItem helpItem;
        private System.Windows.Forms.ToolStripMenuItem statusStriptChildItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpChildItem;
        private System.Windows.Forms.ToolStripMenuItem abortChildItem;
        private System.Windows.Forms.ToolStripMenuItem untoChildItem;
        private System.Windows.Forms.ToolStripMenuItem cutChildItem;
        private System.Windows.Forms.ToolStripMenuItem copyChildItem;
        private System.Windows.Forms.ToolStripMenuItem pasteChildItem;
        private System.Windows.Forms.ToolStripMenuItem deleteChildItem;
        private System.Windows.Forms.ToolStripMenuItem insertChildItem;
        private System.Windows.Forms.ToolStripMenuItem autoWordWrapChildItem;
        private System.Windows.Forms.ToolStripMenuItem fontChildItem;
        private System.Windows.Forms.ToolStripMenuItem shapeChildItem;
        private System.Windows.Forms.ToolStripMenuItem colorChildItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel loginDate;
        private System.Windows.Forms.ToolStripStatusLabel loginUser;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem untoShortCutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutShortCutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyShortCutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteShortCutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteShortCutMenuItem;
        private System.Windows.Forms.RichTextBox textEditor;
        private System.Windows.Forms.ToolStripMenuItem selectAllChildItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllShortCutMenuItem;
        private System.Windows.Forms.ToolStripButton newToolItem;
        private System.Windows.Forms.ToolStripButton openToolItem;
        private System.Windows.Forms.ToolStripButton saveToolItem;
        private System.Windows.Forms.ToolStripButton printToolItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton cutToolItem;
        private System.Windows.Forms.ToolStripButton copyToolItem;
        private System.Windows.Forms.ToolStripButton pasteToolItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolItem;
        private System.Windows.Forms.ToolStripSeparator splitChildItem;
        private System.Windows.Forms.ToolStripLabel nowTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Drawing.Text.InstalledFontCollection font = new System.Drawing.Text.InstalledFontCollection();
        private System.Windows.Forms.ToolStripComboBox fontToolItem;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ToolStripButton leftAlignmentToolItem;
        private System.Windows.Forms.ToolStripButton centerAlignmentToolItem;
        private System.Windows.Forms.ToolStripButton rightAlignmentToolItem;
        private System.Windows.Forms.ToolStripButton overstrikingToolItem;
        private System.Windows.Forms.ToolStripButton colorToolItem;
        private System.Windows.Forms.ColorDialog colorSelect;
        private System.Windows.Forms.ToolStripComboBox fontSizeToolItem;
        private System.Windows.Forms.ToolStripMenuItem redoChildItem;
        private System.Windows.Forms.ToolStripMenuItem redoShortCutMenuItem;
        private System.Windows.Forms.ToolStripButton italicToolItem;
    }
}

