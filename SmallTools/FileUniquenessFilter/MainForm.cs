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

namespace FileUniquenessFilter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();



            tbInputDir.KeyDown += TbInputDir_KeyDown;
            tbOutputDir.KeyDown += TbOutputDir_KeyDown;

            btnInputDir.Click += BtnInputDir_Click;
            btnOutputDir.Click += BtnOutputDir_Click;

            btnStartFilter.Click += BtnStartFilter_Click;



            tbInputDir.Enter += (x,y)=>(x as TextBox).Text = "";
            tbOutputDir.Enter += (x, y) => (x as TextBox).Text = "";

            tbInputDir.Leave += (x, y) => InputDir = (x as TextBox).Text;
            tbOutputDir.Leave += (x, y) => OutputDir = (x as TextBox).Text;
        }

        private string InputDir { get; set; } = "";
        private string OutputDir { get; set; } = "";

        private void BtnStartFilter_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(InputDir))
            {
                MessageBox.Show("Please set the input directory!");
                return;
            }
            if(!Directory.Exists(OutputDir))
            {
                try
                {
                    Directory.CreateDirectory(OutputDir);
                }
                catch
                {
                    MessageBox.Show("Please set the output directory!");
                    return;
                }
            }
            Filter(InputDir,OutputDir);
            MessageBox.Show("completed~");
        }

        private void TbInputDir_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var self = sender as TextBox;
                if(Directory.Exists(self.Text))
                {
                    InputDir = self.Text;
                }
                else
                {
                    MessageBox.Show("Directory does not exist!");
                }
            }
        }

        private void TbOutputDir_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var self = sender as TextBox;
                if (Directory.Exists(self.Text))
                {
                    OutputDir = self.Text;
                }
                else
                {
                    MessageBox.Show("Directory does not exist!");
                }
            }
        }

        private void BtnInputDir_Click(object sender, EventArgs e)
        {
            var path = SelectDir();
            if (path != null)
            {
                tbInputDir.Text = InputDir = path;
            }
        }

        private void BtnOutputDir_Click(object sender, EventArgs e)
        {
            var path = SelectDir();
            if(path!=null)
            {
                tbOutputDir.Text = OutputDir = path;
            }
        }

        private string SelectDir()
        {
            string path = null;
            var dirSelDialog = new FolderBrowserDialog();
            dirSelDialog.Description = "Please select directory...";
            dirSelDialog.RootFolder = Environment.SpecialFolder.MyComputer;
            var res = dirSelDialog.ShowDialog();
            if(res==DialogResult.OK||res==DialogResult.Yes)
            {
                path = dirSelDialog.SelectedPath;
            }
            return path;
        }

        private string ComputeSHA1(string path)
        {
            FileStream file = new FileStream(path, FileMode.Open);
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            byte[] tmp = sha1.ComputeHash(file);
            file.Close();
            return tmp.ToHexString();
        }

        private void Filter(string inputDir,string outputDir)
        {
            var sha1List = new List<string>();
            foreach(var item in new DirectoryInfo(inputDir).GetFileSystemInfos())
            {
                switch (item.Attributes)
                {
                    case FileAttributes.Archive:
                        string sha1 = ComputeSHA1(item.FullName);
                        if (!sha1List.Contains(sha1))
                        {
                            //rtbDisplay.AppendText($"coping file {item.Name}...\r\n");
                            //rtbDisplay.ScrollToCaret();

                            sha1List.Add(sha1);
                            File.Copy(item.FullName, Path.Combine(outputDir, item.Name), true);
                        }
                        break;
                    case FileAttributes.Directory:
                        string destDir = Path.Combine(outputDir,item.Name);
                        if (!Directory.Exists(destDir))
                            Directory.CreateDirectory(destDir);

                        rtbDisplay.AppendText($"coping directory \r\n'{item.FullName}'\r\n to \r\n'{destDir}'\r\n\r\n");
                        rtbDisplay.ScrollToCaret();
                        Filter(item.FullName, destDir);
                        break;
                    default:
                        MessageBox.Show($"unknow error: {item.Attributes}");
                        break;
                }
            }
        }
    }
}
