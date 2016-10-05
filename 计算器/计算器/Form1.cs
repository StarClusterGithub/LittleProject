using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Operation : Form
    {
        bool flag = false;//当前运算是否结束
        private StringBuilder input = new StringBuilder(0, 138);
        public Operation()
        {
            InitializeComponent();
            output.TabIndex = 0;//输入框的索引值为0,默认焦点为输入框
            this.StartPosition = FormStartPosition.CenterScreen;//窗体居中
            //将MyKeyDown添加到按键事件
            output.KeyDown += MyKeyDown;
            zero.KeyDown += MyKeyDown;
            number1.KeyDown += MyKeyDown;
            number2.KeyDown += MyKeyDown;
            number3.KeyDown += MyKeyDown;
            number4.KeyDown += MyKeyDown;
            number5.KeyDown += MyKeyDown;
            number6.KeyDown += MyKeyDown;
            number7.KeyDown += MyKeyDown;
            number8.KeyDown += MyKeyDown;
            number9.KeyDown += MyKeyDown;
            add.KeyDown += MyKeyDown;
            sub.KeyDown += MyKeyDown;
            multiply.KeyDown += MyKeyDown;
            remove.KeyDown += MyKeyDown;
            back.KeyDown += MyKeyDown;
            clear.KeyDown += MyKeyDown;
            result.KeyDown += MyKeyDown;            
        }
        void MyKeyDown(object sender,KeyEventArgs e)
        {
            switch(e.KeyData)
            {
                case Keys.NumPad0:
                    zero_Click(sender, null);
                    break;
                case Keys.NumPad1:
                    number1_Click(sender, null);
                    break;
                case Keys.NumPad2:
                    number2_Click(sender, null);
                    break;
                case Keys.NumPad3:
                    number3_Click(sender, null);
                    break;
                case Keys.NumPad4:
                    number4_Click(sender, null);
                    break;
                case Keys.NumPad5:
                    number5_Click(sender, null);
                    break;
                case Keys.NumPad6:
                    number6_Click(sender, null);
                    break;
                case Keys.NumPad7:
                    number7_Click(sender, null);
                    break;
                case Keys.NumPad8:
                    number8_Click(sender, null);
                    break;
                case Keys.NumPad9:
                    number9_Click(sender, null);
                    break;
                case Keys.Add:
                    add_Click(sender, null);
                    break;
                case Keys.Subtract:
                    sub_Click(sender, null);
                    break;
                case Keys.Multiply:
                    multiply_Click(sender, null);
                    break;
                case Keys.Divide:
                    remove_Click(sender, null);
                    break;
                case Keys.Back:
                    back_Click(sender, null);
                    break;
                case Keys.Oemplus: 
                    goto case Keys.Enter;
                case Keys.Enter:
                    result_Click(sender, null);
                    break;
                case Keys.Decimal:
                    MessageBox.Show("decimal未启用!");
                    break;
            }
        }
        private void print(char ch)
        {
            if (flag)
            {
                input.Clear();
                flag = false;
            }
            input.Append(ch);
            output.Text = input.ToString();
        }
        private void number1_Click(object sender, EventArgs e)
        {
            print('1');
        }
        private void number2_Click(object sender, EventArgs e)
        {
            print('2');
        }
        private void number3_Click(object sender, EventArgs e)
        {
            print('3');
        }

        private void number4_Click(object sender, EventArgs e)
        {
            print('4');
        }

        private void number5_Click(object sender, EventArgs e)
        {
            print('5');
        }

        private void number6_Click(object sender, EventArgs e)
        {
            print('6');
        }

        private void number7_Click(object sender, EventArgs e)
        {
            print('7');
        }

        private void number8_Click(object sender, EventArgs e)
        {
            print('8');
        }

        private void number9_Click(object sender, EventArgs e)
        {
            print('9');
        }
        private void zero_Click(object sender, EventArgs e)
        {
            print('0');
        }


        private void add_Click(object sender, EventArgs e)
        {
            print('+');
        }

        private void sub_Click(object sender, EventArgs e)
        {
            print('-');
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            print('×');
        }
        private void remove_Click(object sender, EventArgs e)
        {
            print('÷');
        }


        private void back_Click(object sender, EventArgs e)//退格键
        {
            if (input.Length > 0)//字符串为空时input.Length - 1会出错
            {
                input.Remove(input.Length - 1, 1);
                output.Text = input.ToString();
            }
            if (flag)
                clear_Click(sender, e);
        }

        private void clear_Click(object sender, EventArgs e)//清空键,清空输入
        {
            input.Clear();
            output.Text = null;
        }

        private void result_Click(object sender, EventArgs e)
        {
            int counter = 0;//计数器,用于下标号
            double first = 0, second = 0;//第一个数和第二个数
            /*循环结束条件为遇到加减乘除运算符,或者已经遍历完整个input*/
            for (counter = 0; counter < input.Length && input[counter] != '+' && input[counter] != '-' && input[counter] != '×' && input[counter] != '÷'; ++counter)
            {
                first = first * 10 + (double)(input[counter] - '0');
            }
            if (counter >= input.Length - 1 || flag)//如果末位是运算符号或者没有运算符号,则终止此方法
            {
                if (flag)
                    clear_Click(sender, e);
                else
                    output.Text = "不完整的输入!";
            }
            else
            {
                second = Convert.ToDouble(input.ToString(counter + 1, input.Length - counter - 1));//把剩下的字符串转变为第二个数
                output.Text += " = ";
                switch (input[counter])
                {
                    case '+':
                        output.Text += Convert.ToString(first + second);
                        break;
                    case '-':
                        output.Text += Convert.ToString(first - second);
                        break;
                    case '×':
                        output.Text += Convert.ToString(first * second);
                        break;
                    case '÷':
                        if (second == 0)
                            MessageBox.Show("0不能做除数!", "错误!");
                        else
                            output.Text += Convert.ToString(first / second);
                        break;
                }
            }
            flag = true;
        }
        private void operation_Load(object sender, EventArgs e)
        {

        }
        private void output_TextChanged(object sender, EventArgs e)
        {

        }

        private void author_Click(object sender, EventArgs e)
        {

        }
    }
}
