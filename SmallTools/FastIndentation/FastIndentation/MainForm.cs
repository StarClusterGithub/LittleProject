using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastIndentation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            rbtnSpace.CheckedChanged += (x, y) => Delimiter = rbtnSpace.Checked ? ' ' : '\t';
            tbDelimiterNumber.LostFocus +=
                (x, y) =>
                {
                    Int32 count = 0;
                    if (!int.TryParse(tbDelimiterNumber.Text, out count))
                        MessageBox.Show("无法转换的输入!请确认它是一个合法数字.");
                    else
                        DelimiterCount = count;
                };
            rtbProcess.TextChanged +=
                (x, y) =>
                {
                    string indentation = new string(Delimiter, DelimiterCount);
                    string output = "";
                    foreach (string str in rtbProcess.Lines)
                        output += indentation + str+"\r\n";
                    this.Invoke(new Action(() => rtbProcess.Text = output.TrimEnd('\r','\n')));
                };
            Delimiter = '\t';
            DelimiterCount = 2;
        }

        private Int32 DelimiterCount { get; set; }
        private char Delimiter { get; set; }
    }
}
