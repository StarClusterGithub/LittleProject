using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNote
{
    public partial class MainForm : Form
    {
        private void statusStriptChildItem_Click(object sender, EventArgs e)//查看项,查看工具栏子项
        {
            MessageBox.Show(loginUser.Text + "\n" + loginDate.Text,"状态栏信息");
        }

        private void viewHelpChildItem_Click(object sender, EventArgs e)//帮助项,查看帮助子项
        {
            MessageBox.Show("本程序使用方法基本与Windows记事本一样,详情请百度.","Help");
        }

        private void abortChildItem_Click(object sender, EventArgs e)//帮助项,关于记事本子项
        {
            MessageBox.Show("名称:StarrySkyNoteBook\n作者:StarCluster\n介绍:14级物联网工程1班\nQQ:  603013480\n完成时间:2015/12/18.","About");
        }

    }
}
