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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public static string LoginUser//对外部只读的自动属性
        {
            get;
            private set;
        }
        public static string LoginDate//对外部只读的自动属性
        {
            get;
            private set;
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (account.Text != "Administrator" && password.Text != "Master")
            {
                MessageBox.Show("帐号或密码错误!", "Incorrect");
                account.Text = password.Text = default(string);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("登录成功!");
                LoginDate = DateTime.Now.ToString();//记录登录时间
                LoginUser = account.Text;
            }
        }

        private void quit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
