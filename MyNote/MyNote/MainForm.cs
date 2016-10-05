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
        public MainForm()
        {
            InitializeComponent();
            timer.Start();//开始计时器
            loginUser.Text = "用户:  " + LoginForm.LoginUser;//显示状态栏时间
            loginDate.Text = "登录时间:  " + LoginForm.LoginDate;
            foreach (System.Drawing.FontFamily iterate in font.Families)
            {
                fontToolItem.Items.Add(iterate.Name.ToString());
            }
            fontToolItem.SelectedIndex = 0;
            fontSizeToolItem.SelectedIndex = 0;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);//将位置设为居中
        }

        private void textEditor_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
