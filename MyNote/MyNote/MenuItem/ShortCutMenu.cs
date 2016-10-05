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
        private void untoShortCutMenuItem_Click(object sender, EventArgs e)
        {
            untoChildItem_Click(default(object), default(EventArgs));
        }

        private void redoShortCutMenuItem_Click(object sender, EventArgs e)
        {
            redoChildItem_Click(default(object),default(EventArgs));
        }
        private void selectAllShortCutMenuItem_Click(object sender, EventArgs e)
        {
            selectAllChildItem_Click(default(object), default(EventArgs));
        }
        private void cutShortCutMenuItem_Click(object sender, EventArgs e)
        {
            cutChildItem_Click(default(object), default(EventArgs));
        }

        private void copyShortCutMenuItem_Click(object sender, EventArgs e)
        {
            copyChildItem_Click(default(object), default(EventArgs));
        }

        private void pasteShortCutMenuItem_Click(object sender, EventArgs e)
        {
            pasteChildItem_Click(default(object), default(EventArgs));
        }

        private void deleteShortCutMenuItem_Click(object sender, EventArgs e)
        {
            deleteChildItem_Click(default(object), default(EventArgs));
        }
    }
}
