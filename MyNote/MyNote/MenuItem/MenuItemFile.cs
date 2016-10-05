using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MyNote
{
    public partial class MainForm : Form
    {
        private string NowFilePath
        {
            get;
            set;
        }
        private void fileItem_Click(object sender, EventArgs e)
        {

        }

        private void newChildItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog file = new SaveFileDialog();
            file.Title = "新建";
            file.InitialDirectory = Environment.SpecialFolder.DesktopDirectory.ToString();
            file.Filter = "txt files(*.txt)|*.txt|All files (*.*)|*.*";
            file.AddExtension = false;
            if (file.ShowDialog() == DialogResult.OK)
            {
                new StreamWriter(file.FileName).Close();
                NowFilePath = file.FileName;
                textEditor.Visible = true;
                textEditor.Focus();
            }
        }

        private void openChildItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = Environment.SpecialFolder.DesktopDirectory.ToString();
            file.Filter = "txt files(*.txt)|*.txt|All files (*.*)|*.*";
            if (file.ShowDialog() == DialogResult.OK)
            {
                StreamReader read = new StreamReader(file.FileName, Encoding.GetEncoding("gb2312"));
                textEditor.Text = read.ReadToEnd();
                read.Close();
                NowFilePath = file.FileName;
                textEditor.Visible = true;
                textEditor.Focus();
            }

        }

        private void saveChildItem_Click(object sender, EventArgs e)
        {
            if (NowFilePath == default(string))
            {
                if (MessageBox.Show("文件不存在,是否创建?", "Prompt", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    newChildItem_Click(sender, e);
            }
            else
            {
                StreamWriter write = new StreamWriter(NowFilePath, false);
                write.Write(textEditor.Text);
                write.Flush();
                write.Close();
                MessageBox.Show("保存成功!");
            }
            textEditor.Focus();
        }

        private void saveAsChildItem_Click(object sender, EventArgs e)
        {
            if (NowFilePath == default(string))
            {
                if (MessageBox.Show("文件不存在,是否创建?", "Prompt", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    newChildItem_Click(sender, e);
                return;
            }
            SaveFileDialog file = new SaveFileDialog();
            file.InitialDirectory = Environment.SpecialFolder.DesktopDirectory.ToString();
            file.Filter = "txt files(*.txt)|*.txt|All files (*.*)|*.*";
            file.AddExtension = false;
            if(file.ShowDialog()==DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(file.FileName);
                write.Write(textEditor.Text);
                write.Flush();
                write.Close();
                textEditor.Focus();
            }
        }

        private void exitChildItem_Click(object sender, EventArgs e)
        {
            string lod = "";
            if (NowFilePath != default(string))
            {
                StreamReader read = new StreamReader(NowFilePath);
                lod = read.ReadToEnd();
                read.Close();
            }
            if (textEditor.Text != lod && MessageBox.Show("文本已更改,是否保存?", "Prompt", MessageBoxButtons.OKCancel) == DialogResult.OK)
                saveChildItem_Click(sender, e);
            if (MessageBox.Show("确定要退出吗?", "Prompt", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
        }

    }
}
