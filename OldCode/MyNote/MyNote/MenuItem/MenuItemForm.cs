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
        private void formItem_Click(object sender, EventArgs e)
        {

        }
        private void autoWordWrapChildItem_Click(object sender, EventArgs e)
        {
            textEditor.WordWrap = !textEditor.WordWrap;
        }
        
        private void fontChildItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("轻挪尊鼠,点击工具栏->字号设置字体大小.");
        }

        private void shapeChildItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("轻挪尊鼠,点击工具栏->斜体设置字形.");
        }

        private void colorChildItem_Click(object sender, EventArgs e)
        {
            colorSelect.ShowDialog();
            textEditor.ForeColor = colorSelect.Color;
        }
    }
}
