using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartShelves
{
    public partial class SmartShelvesTerminal : Form
    {
        //串口操作实例
        PL2303 serialPort = null;
        //查询种类;当前货柜id
        private string querySpecies = null;
        private int curTid = default(int);

        public SmartShelvesTerminal()
        {
            InitializeComponent();

            //debug
            //USDataAccess.Delete("delete from [terminal] where tid = 0;");

            //登记并显示货柜
            curTid = USDataAccess.Select("select distinct [tid] from [terminal] where [tid] != 0;").Rows.Count + 1;

            //相关事件
            tbQueryCondition.Click += (x, y) => tbQueryCondition.Text = "";
            this.Load += (x, y) =>
            {
                serialPort = new PL2303();
                dgvDisplay.DataSource = USDataAccess.Select("select tid as 所在货柜,name as 商品名,price as 价格,manufacturer as 生产厂家,productiondate as 生产日期,validuntil as 有效期,shelflife as 保质期,inventory as 库存数 from [terminal] as t1 join [commodity] as t2 on t1.commodityId = t2.id;");
            };
            this.Activated += (x, y) => { serialPort?.Open(); timerSerialPort.Enabled = true; };
            this.Deactivate += (x, y) => { serialPort?.Close(); timerSerialPort.Enabled = false; };
        }

        /// <summary>
        /// 数据源更改时触发,以调整列宽自适应
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvDisplay_DataSourceChanged(object sender, EventArgs e)
        {

            DataGridView curDgv = (DataGridView)sender;
            foreach (DataGridViewColumn item in curDgv.Columns)
                item.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        /// <summary>
        /// 下拉菜单项-根据选择的种类生成查询语句的一部分
        /// 商品名称|生产厂家|最高价格|最低价格
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbQuerySpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] queryStr = { "[name] like ", "[manufacturer] like ", "[price] <= ", "[price] >= " };
            string[] items = { "商品名称", "生产厂家", "最高价格", "最低价格" };
            for (int i = 0; i < cmbQuerySpecies.Items.Count; ++i)
            {
                if (cmbQuerySpecies.Text.Equals(items[i]))
                {
                    querySpecies = queryStr[i];
                    break;
                }
            }
        }

        /// <summary>
        /// 从数据库中查询相关信息并刷新datagridview的数据源
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Search_Click(object sender, EventArgs e)
        {
            if (tbQueryCondition.Text.Equals("") || cmbQuerySpecies.Text.Equals("请选择查询类别"))
            {
                MessageBox.Show("请设定查询条件!");
                return;
            }
            try
            {
                dgvDisplay.DataSource = USDataAccess.Select($"select tid as 所在货柜,name as 商品名,price as 价格,manufacturer as 生产厂家,productiondate as 生产日期,validuntil as 有效期,shelflife as 保质期,inventory as 库存数 from [terminal] as t1 join [commodity] as t2 on t1.commodityId = t2.id where {querySpecies} '{tbQueryCondition.Text}';");
            }
            catch (Exception)
            {
                MessageBox.Show("查询失败,请检查输入是否正确.");
            }
        }

        /// <summary>
        /// 定时器,负责检查货柜上商品变动情况
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerSerialPort_Tick(object sender, EventArgs e)
        {
            try
            {
                //读取数据,看看有没有新的RFID标签添加到货柜上
                foreach (var str in serialPort.ReadAllData().Split('\n'))
                {
                    if (str.Contains("addr:0x0001 read data:0x"))
                    {
                        //查询对应卡id的信息
                        string cardId = str.Substring(24,4);
                        //判断rfid标签是否绑定
                        if(cardId.Equals("0000"))
                        {
                            return;
                        }

                        var dataTable = USDataAccess.Select($"select * from [terminal] where [cardId] like {cardId}");
                        if (dataTable.Rows.Count > 0)
                        {
                            //判断是添加商品到货柜还是拿走商品
                            if (int.Parse(dataTable.Rows[0][0].ToString()) == 0)
                            {
                                USDataAccess.Update($"update [terminal] set [tid] = {curTid} where [cardId] like {cardId};");
                            }
                            else
                            {
                                USDataAccess.Delete($"delete from [terminal] where [cardId] like {cardId};");
                                serialPort.Write("CM+WRITE -addr=0x01 -value=0x0000");
                            }
                            dgvDisplay.DataSource = USDataAccess.Select("select tis as 所在货柜,name as 商品名,price as 价格,manufacturer as 生产厂家,productiondate as 生产日期,validuntil as 有效期,shelflife as 保质期,inventory as 库存数 from [terminal] as t1 join [commodity] as t2 on t1.commodityId = t2.id;");
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

    }
}
