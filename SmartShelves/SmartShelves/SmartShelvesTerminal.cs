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
        PL2303 serialPort = new PL2303();
        private string querySpecies = null;
        private int curTid = default(int);

        public SmartShelvesTerminal()
        {
            InitializeComponent();

            //登记货柜
            curTid = USDataAccess.Select("select * from [terminal] where [tid] < 1000;").Rows.Count + 1;
            USDataAccess.Insert($"insert into [terminal] values({curTid},'0x0000',0);");

            //监听事件
            tbQueryCondition.Click += (x, y) => tbQueryCondition.Text = "";
            this.GotFocus += (x, y) => serialPort.Open();
            this.LostFocus += (x, y) => serialPort.Close();
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
            //if (tbQueryCondition.Text.Equals("") || cmbQuerySpecies.Text.Equals("请选择查询类别"))
            //{
            //    MessageBox.Show("请设定查询条件!");
            //}
            //try
            //{
            //dgvDisplay.DataSource = USDataAccess.Select($"select * from [commodity] where {querySpecies + tbQueryCondition.Text};");
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("查询失败,请检查输入是否正确.");
            //}

            //USDataAccess.Insert("insert into [terminal] values(1234,'0x01',1234);");
            //USDataAccess.Insert("insert into [terminal] values(2234,'0x02',2234);");
            //USDataAccess.Insert("insert into [terminal] values(4234,'0x03',3234);");
            //USDataAccess.Delete("delete from [terminal] where tid = 1234;");
            //USDataAccess.Insert("insert into [commodity] values(3234,'测试',12.34,'china','2018-01-01','2018-03-01',2,40);");
            //dgvDisplay.DataSource = USDataAccess.Select("select * from [terminal] as t1 join [commodity] as t2 on t1.commodityId = t2.id");
            //USDataAccess.Update("update [terminal] set [tid] = 3234 where [cardId] = '0x03';");

            dgvDisplay.DataSource = USDataAccess.Select("select * from [terminal];");
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
                        string cardId = str.Substring(24,4);
                        var dataTable = USDataAccess.Select($"select * from [terminal] where [cardId] like {cardId}");
                        //判断rfid标签是否绑定
                        if (dataTable.Rows.Count > 0)
                        {
                            //判断是添加商品到货柜还是拿走商品
                            if (int.Parse(dataTable.Rows[0][0].ToString()) >= 1000)
                            {
                                USDataAccess.Update($"update [terminal] set [tid] = {curTid} where [cardId] like {cardId};");
                            }
                            else
                            {
                                USDataAccess.Update($"update [terminal] set [tid] = {1000 + curTid} where [cardId] like {cardId};");
                            }
                        }
                        else
                        {
                            MessageBox.Show("该商品未登记在册!");
                            return;
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
