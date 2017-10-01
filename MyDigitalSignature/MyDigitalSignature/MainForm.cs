using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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
                //计算SHA1
                rtxtResultShow.Text += "MySHA1:" + ToHexString(new DigitalSignature(selectFile.FileName).SHA1) + "\n";
                tbFilePath.Text = selectFile.FileName;
                //用c#提供的API计算SHA1
                var hash = HashAlgorithm.Create();
                var stream = new FileStream(selectFile.FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                byte[] hashByte = hash.ComputeHash(stream);
                stream.Close();
                rtxtResultShow.Text += "C#SHA1:" + ToHexString(hashByte);
            }
        }

        private void tbFilePath_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                if (File.Exists(tbFilePath.Text))
                {
                    //计算SHA1
                    rtxtResultShow.Text += "MySHA1:"+ToHexString(new DigitalSignature(tbFilePath.Text).SHA1) + "\n";
                    //用c#提供的API计算SHA1
                    var hash = HashAlgorithm.Create();
                    var stream = new FileStream(tbFilePath.Text, FileMode.Open, FileAccess.Read, FileShare.Read);
                    byte[] hashByte = hash.ComputeHash(stream);
                    stream.Close();
                    rtxtResultShow.Text += "C#SHA1:"+ ToHexString(hashByte);
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
