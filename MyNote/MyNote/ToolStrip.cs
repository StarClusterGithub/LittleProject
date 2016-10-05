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
        private void newToolItem_Click(object sender, EventArgs e)
        {
            newChildItem_Click(sender, e);
        }

        private void openToolItem_Click(object sender, EventArgs e)
        {
            openChildItem_Click(sender, e);
        }

        private void saveToolItem_Click(object sender, EventArgs e)
        {
            saveChildItem_Click(sender, e);
        }

        private void printToolItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("没有打印机!");
        }

        private void cutToolItem_Click(object sender, EventArgs e)
        {
            cutChildItem_Click(sender, e);
        }

        private void copyToolItem_Click(object sender, EventArgs e)
        {
            copyChildItem_Click(sender, e);
        }

        private void pasteToolItem_Click(object sender, EventArgs e)
        {
            pasteChildItem_Click(sender, e);
        }
        private void fontToolItem_Click(object sender, EventArgs e)
        {
            textEditor.Font = new Font(fontToolItem.SelectedItem.ToString(), textEditor.Font.Size, textEditor.Font.Style);
        }
        private void fontSizeToolItem_Click(object sender, EventArgs e)
        {
            textEditor.Font = new Font(textEditor.Font.FontFamily, Convert.ToSingle(fontSizeToolItem.SelectedItem.ToString()), textEditor.Font.Style);
        }

        private void leftAlignmentToolItem_Click(object sender, EventArgs e)
        {
            textEditor.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void centerAlignmentToolItem_Click(object sender, EventArgs e)
        {
            textEditor.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void rightAlignmentToolItem_Click(object sender, EventArgs e)
        {
            textEditor.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void overstrikingToolItem_Click(object sender, EventArgs e)
        {
            if(textEditor.Font.Bold==Font.Bold)
                textEditor.SelectionFont = new Font(Font, FontStyle.Regular);
            else
                textEditor.SelectionFont = new Font(Font, FontStyle.Bold);
        }

        private void italicToolItem_Click(object sender, EventArgs e)
        {
            textEditor.SelectionFont = new Font(Font, FontStyle.Italic);
        }
        private void colorToolItem_Click(object sender, EventArgs e)
        {
            colorChildItem_Click(sender, e);
        }

        private void helpToolItem_Click(object sender, EventArgs e)
        {
            viewHelpChildItem_Click(sender, e);
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            nowTime.Text = DateTime.Now.ToString();
        }
    }
}
