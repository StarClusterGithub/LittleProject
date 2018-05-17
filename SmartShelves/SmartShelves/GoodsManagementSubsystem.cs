using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartShelves
{
    public partial class GoodsManagementSubsystem : Form
    {
        //串口操作实例
        PL2303 serialPort = null;
        //查询条件,查询内容
        private string querySpecies = null;
        private string queryCondition = null;
        //rowCount数据库中的行的行数;isAdd指示是否在添加行,true为是;
        private int rowCount = 0;
        private bool isAdd = false;
        //cardId配合定时器写入卡id
        private string curCardId = null;

        public GoodsManagementSubsystem()
        {
            InitializeComponent();

            //行状态事件,用户添加新行时进行标记
            dgvAddItem.UserAddedRow += (x, y) => isAdd = true;

            //窗体加载时的动作
            this.Load += (x, y) =>
            {
                serialPort = new PL2303();
                DGVDataSource = USDataAccess.Select("select id as 商品代码,name as 商品名,price as 价格,manufacturer as 生产厂家,productiondate as 生产日期,validuntil as 有效期,shelflife as 保质期,inventory as 库存数 from [commodity];");
            };

            //串口随窗体焦点改变而开/关
            this.Activated += (x, y) => { serialPort?.Open(); timerBindingCard.Enabled = true; };
            this.Deactivate += (x, y) => { serialPort?.Close(); timerBindingCard.Enabled = false; };

            //记录输入的查询内容
            tbConditionAtMgr.LostFocus += (x, y) => queryCondition = $"'{tbConditionAtMgr.Text}'";
            tbConditionAtDel.LostFocus += (x, y) => queryCondition = $"'{tbConditionAtDel.Text}'";
            tbConditionAtBinding.LostFocus += (x, y) => queryCondition = $"'{tbConditionAtBinding.Text}'";

            //输入时自动清空原有内容
            tbConditionAtMgr.Click += (x, y) => tbConditionAtMgr.Text = "";
            tbConditionAtDel.Click += (x, y) => tbConditionAtDel.Text = "";
            tbConditionAtBinding.Click += (x, y) => tbConditionAtBinding.Text = "";
        }

        /// <summary>
        /// 数据源设置属性器
        /// </summary>
        private object DGVDataSource
        {
            set
            {
                dgvAddItem.DataSource = dgvMgrItem.DataSource = dgvDelItem.DataSource = dgvBindingItem.DataSource = value;
                rowCount = ((DataTable)value).Rows.Count;
            }
        }

        /// <summary>
        /// 下拉菜单项-根据选择的种类生成查询语句的一部分
        /// 商品名称|生产厂家|最高价格|最低价格
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbQuerySpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox curCmb = (ComboBox)sender;
            string[] queryStr = { "[name] like ", "[manufacturer] like ", "[price] <= ", "[price] >= " };
            string[] items = { "商品名称", "生产厂家", "最高价格", "最低价格" };
            for (int i = 0; i < curCmb.Items.Count; ++i)
            {
                if (curCmb.Text.Equals(items[i]))
                {
                    querySpecies = queryStr[i];
                    break;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (queryCondition == null || querySpecies == null)
            {
                MessageBox.Show("请设定查询条件!");
                return;
            }
            try
            {
                DGVDataSource = USDataAccess.Select($"select  id as 商品代码,name as 商品名,price as 价格,manufacturer as 生产厂家,productiondate as 生产日期,validuntil as 有效期,shelflife as 保质期,inventory as 库存数  from [commodity] where {querySpecies + queryCondition};");
            }
            catch (Exception)
            {
                MessageBox.Show("查询失败,请检查输入是否正确.");
            }
            querySpecies = queryCondition = null;
        }

        /// <summary>
        /// 数据源更改时触发,以调整列宽自适应
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_DataSourceChanged(object sender, EventArgs e)
        {
            DataGridView curDgv = (DataGridView)sender;
            foreach (DataGridViewColumn item in curDgv.Columns)
                item.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        /// <summary>
        /// 添加新的数据行到数据库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvAddItem_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAddItem.CurrentRow != null && dgvAddItem.CurrentRow.Index == rowCount && isAdd == true)
            {
                string values = "";
                foreach (DataGridViewCell item in dgvAddItem.Rows[rowCount].Cells)
                {
                    if (item.Value.Equals(System.DBNull.Value))
                    {
                        MessageBox.Show("数据不完整!", "添加新行失败");
                        dgvAddItem.ClearSelection();
                        dgvAddItem.Rows[item.RowIndex].Selected = true;
                        item.Selected = true;
                        return;
                    }
                    if (item.ValueType.Equals(typeof(int)))
                        values += item.Value.ToString() + ',';
                    else
                        values += $"'{item.Value.ToString()}',";
                }
                try
                {
                    USDataAccess.Insert($"insert into [commodity] values({values.Trim(',')});");
                    BeginInvoke(new MethodInvoker(() => DGVDataSource = USDataAccess.Select("select id as 商品代码,name as 商品名,price as 价格,manufacturer as 生产厂家,productiondate as 生产日期,validuntil as 有效期,shelflife as 保质期,inventory as 库存数 from [commodity];")));
                    isAdd = false;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// 当用户改变了单元格的值时对数据库进行更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMgrItem_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvMgrItem.Rows[e.RowIndex].Cells[0].Value.ToString();
            string newCellValue = dgvMgrItem.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            //USDataAccess.Update("update [commodity] set [xx] = xxxx where [xxx] = 'xxx';");
            USDataAccess.Update($"update [commodity] set {USDataAccess.CommodityColumns[e.ColumnIndex]} = '{newCellValue}' where [id] = {id};");
            BeginInvoke(new MethodInvoker(() => DGVDataSource = USDataAccess.Select("select id as 商品代码,name as 商品名,price as 价格,manufacturer as 生产厂家,productiondate as 生产日期,validuntil as 有效期,shelflife as 保质期,inventory as 库存数 from [commodity];")));
        }

        /// <summary>
        /// 用户删除行时获取id并从数据库中移除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvDelItem_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            string delId = dgvDelItem.CurrentRow.Cells[0].Value.ToString();
            BeginInvoke(new MethodInvoker(
                () =>
                {
                    USDataAccess.Delete($"delete from [commodity] where [id] = {delId};");
                    DGVDataSource = USDataAccess.Select("select id as 商品代码,name as 商品名,price as 价格,manufacturer as 生产厂家,productiondate as 生产日期,validuntil as 有效期,shelflife as 保质期,inventory as 库存数 from [commodity];");
                }
                ));
        }

        /// <summary>
        /// 绑定RFID卡与商品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBindingRfid_Click(object sender, EventArgs e)
        {
            if(curCardId == null)
            {
                MessageBox.Show("请放卡!");
                return;
            }
            if(dgvBindingItem.CurrentRow == null)
            {
                MessageBox.Show("请选择商品!");
            }
            if(curCardId.Equals(""))
            {
                Random rand = new Random();
                int temp = rand.Next(1,10000);
                for (; USDataAccess.Select($"select * from [terminal] where [cardId] like '{temp}';").Rows.Count > 0;)
                    temp = rand.Next(1, 10000);
                curCardId = temp.ToString();
            }
            
            for(; !serialPort.ReadAllData().Contains("addr:0x0001 para:0x");)
                serialPort.Write($"CM+WRITE -addr=0x01 -value=0x{curCardId}"); 
            USDataAccess.Insert($"insert into [terminal] values(0,'{curCardId}',{dgvBindingItem.CurrentRow.Cells[0].Value.ToString()});");

            curCardId = null;
        }

        /// <summary>
        /// 定时器,
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerBindingCard_Tick(object sender, EventArgs e)
        {
            if (dgvBindingItem.CurrentRow != null && dgvBindingItem.CurrentRow.Index >= 0)
            {
                try
                {
                    //读取RFID标签数据
                    foreach (var str in serialPort.ReadAllData().Split('\n'))
                    {
                        if (str.Contains("addr:0x0001 read data:0x"))
                        {
                            string cardId = str.Substring(24, 4);
                            //查询数据库中有无此rfid标签的识别码
                            DataTable table = USDataAccess.Select($"select * from [terminal] where [cardId] like '{cardId}'");
                            if(table.Rows.Count==0)
                            {
                                curCardId = "";
                                rtbShowAtBinding.Text = "卡片尚未绑定.";
                                return;
                            }
                            curCardId = cardId;

                            //卡如果属于已经绑定的卡,则将商品id与表中数据比较然后输出商品信息
                            string cid = table.Rows[0][2].ToString();
                            foreach(DataGridViewRow row in dgvBindingItem.Rows)
                            {
                                if(row.Cells[0].Value.ToString().Equals(cid))
                                {
                                    rtbShowAtBinding.Text = "rfid标签当前绑定的商品为:\n";
                                    foreach (DataGridViewCell cell in row.Cells)
                                    {
                                        rtbShowAtBinding.AppendText(dgvBindingItem.Columns[cell.ColumnIndex].Name + ":\t");
                                        rtbShowAtBinding.AppendText(cell.Value + "\n");
                                    }
                                }
                            }
                        }
                    }
                    serialPort.Write("CM+READ -addr=0x01");
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("遇到了一些问题,请检查串口是否被占用!", "异常");
                    return;
                }
            }
        }// end of timer
    }

}
