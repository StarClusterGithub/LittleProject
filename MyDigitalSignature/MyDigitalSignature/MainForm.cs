using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDigitalSignature
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectFile = new OpenFileDialog();
            if (selectFile.ShowDialog() == DialogResult.OK)
            {
                rtxtResultShow.Text = ToHexString(new DigitalSignature(selectFile.FileName).SHA1);
                tbFilePath.Text = selectFile.FileName;
            }
        }

        private void tbFilePath_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                if (File.Exists(tbFilePath.Text))
                {
                    rtxtResultShow.Text = ToHexString(new DigitalSignature(tbFilePath.Text).SHA1);
                }
                else
                {
                    MessageBox.Show("文件不存在!请检查路径是否输入正确!", "错误");
                }
            }
        }

        private string ToHexString(byte[] arr)
        {
            StringBuilder str = new StringBuilder();
            foreach(byte item in arr)
            {
                str.Append(item.ToString("x2"));
            }
            return str.ToString();
        }
    }
}
