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
        private void editItem_Click(object sender, EventArgs e)
        {

        }

        private void untoChildItem_Click(object sender, EventArgs e)
        {
            textEditor.Undo();
        }
        private void redoChildItem_Click(object sender, EventArgs e)
        {
            textEditor.Redo();
        }

        private void selectAllChildItem_Click(object sender, EventArgs e)
        {
            textEditor.SelectAll();
        }

        private void cutChildItem_Click(object sender, EventArgs e)
        {
            if (textEditor.SelectedText.Length > 0)
                textEditor.Cut();
        }

        private void copyChildItem_Click(object sender, EventArgs e)
        {
            if (textEditor.SelectedText.Length > 0)
                textEditor.Copy();
        }

        private void pasteChildItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
                textEditor.Paste();
        }

        private void deleteChildItem_Click(object sender, EventArgs e)
        {
            if (textEditor.SelectedText.Length > 0)
            {
                textEditor.SelectedText = "";
            }
        }

        private void insertChildItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openImageDlg = new OpenFileDialog();
            openImageDlg.Filter = "所有图片(*.bmp,*.gif,*.jpg)|*.bmp;*.gif;*jpg";
            openImageDlg.Title = "选择图片";
            if (openImageDlg.ShowDialog() == DialogResult.OK)
            {
                string fileName = openImageDlg.FileName;
                if (null == fileName || fileName.Trim().Length == 0)
                    return;
                try
                {
                    Bitmap bmp = new Bitmap(fileName);
                    Clipboard.SetDataObject(bmp);
                    DataFormats.Format dataFormat = DataFormats.GetFormat(DataFormats.Bitmap);
                    if (textEditor.CanPaste(dataFormat))
                        textEditor.Paste(dataFormat);
                }
                catch (Exception exc)
                {
                    MessageBox.Show("图片插入失败。" + exc.Message, "Prompt",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
