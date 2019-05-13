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
using System.Xml;

namespace MaxthonChromeBookmarkConverter
{
    public partial class MainForm : Form
    {
        private static string flag = "##IMPORT##\n";

        /// <summary>
        /// chrome书签格式
        /// </summary>
        private string Bookmark { get; set; } =
            "<!DOCTYPE NETSCAPE-Bookmark-file-1>\n" +
            "<!-- This is an automatically generated file.\n" +
            "     It will be read and overwritten.\n" +
            "     DO NOT EDIT! -->\n" +
            "<META HTTP-EQUIV=\"Content - Type\" CONTENT=\"text / html; charset = UTF - 8\">\n" +
             "<TITLE>Bookmarks</TITLE>\n" +
            "<H1>Bookmarks</H1>\n" +
            "<DL><p>\n" +
            "    <DT><H3 ADD_DATE=\"1519379300\" LAST_MODIFIED=\"1544504910\" PERSONAL_TOOLBAR_FOLDER=\"true\">书签栏</H3>\n" +
            "    <DL><p>\n" +
             flag +
            "    </DL><p>\n" +
            "</DL><p>\n";


        public MainForm()
        {
            InitializeComponent();

            this.btnImport.Click += BtnImport_Click;
            this.btnExport.Click += BtnExport_Click;
            this.tbImport.KeyDown += TbImport_KeyDown;
            this.tbExport.KeyDown += TbExport_KeyDown;

            this.tbImport.Enter += (x, y) => (x as TextBox).Text = "";
            this.tbExport.Enter += (x, y) => (x as TextBox).Text = "";

            this.rtbShowInfo.AppendText(Bookmark);
        }

        /// <summary>
        /// 弹出选择目录对话框,并返回选择的目录路径,若未选择则返回null
        /// </summary>
        /// <returns>directory path or null</returns>
        private string SelectDir()
        {
            string dir = null;

            FolderBrowserDialog selDir = new FolderBrowserDialog();
            selDir.Description = "Please select directory";

            if (selDir.ShowDialog() == DialogResult.OK)
                dir = selDir.SelectedPath;

            return dir;
        }

        /// <summary>
        /// 从指定目录导入Maxthon书签,并将其转为html格式的chrome书签
        /// </summary>
        /// <param name="dir">maxthon书签目录</param>
        /// <param name="indentation">缩进字符串</param>
        /// <returns>chrome书签的html描述格式(不包含头和尾)</returns>
        private string Import(string dir, string indentation = "    ")
        {
            var bookmark = "";

            DirectoryInfo bookmarkInfo = new DirectoryInfo(dir);
            foreach (var itm in bookmarkInfo.GetFileSystemInfos())
            {
                long timesetamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
                switch (itm.Attributes)
                {
                    case FileAttributes.Archive:
                        var url = File.ReadAllText(itm.FullName).Trim('\r', '\n');
                        url = url.Substring(url.IndexOf("URL=") + 4);
                        bookmark += $"<DT><A HREF=\"{url}\" ADD_DATE=\"{timesetamp}\">{Path.GetFileNameWithoutExtension(itm.Name)}</A>\n";
                        break;
                    case FileAttributes.Directory:
                        bookmark += $"<DT><H3 ADD_DATE=\"{timesetamp} \" LAST_MODIFIED=\"{timesetamp} \">{itm.Name}</H3>\n";
                        var tmp = Import(itm.FullName);
                        bookmark += $"<DL><p>\n{tmp}</DL><p>\n";
                        break;
                    default:
                        throw new FileLoadException("Unexpected file type!");
                }
            }

            //  Indentation
            bookmark = string.Join("\n" + indentation, bookmark.Split('\n'));
            bookmark = indentation + bookmark.TrimEnd(' ');

            return bookmark;
        }

        /// <summary>
        /// 将结果保存至指定目录
        /// </summary>
        /// <param name="dir">目录路径</param>
        private void Export(string dir)
        {
            string fileName = "bookmarks_" + DateTime.Now.ToString("yyyy_MM_dd") + ".html";
            File.WriteAllText(Path.Combine(dir,fileName), Bookmark);
        }

        private void TbImport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var dir = (sender as TextBox).Text;
                if (Directory.Exists(dir))
                {
                    Bookmark = Bookmark.Replace(flag, Import(dir, "        "));
                    rtbShowInfo.Text = Bookmark;
                }
            }
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            var dir = SelectDir();
            if (dir != null)
            {
                tbImport.Text = dir;
                Bookmark = Bookmark.Replace(flag, Import(dir, "        "));
                rtbShowInfo.Text = Bookmark;
            }
        }

        private void TbExport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var dir = (sender as TextBox).Text;
                if (Directory.Exists(dir))
                {
                    Export(dir);
                }
                else
                {
                    MessageBox.Show("Not a valid directory!");
                }
            }
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            var dir = SelectDir();
            if (dir != null)
            {
                tbExport.Text = dir;
                Export(dir);
            }
        }
    }
}
