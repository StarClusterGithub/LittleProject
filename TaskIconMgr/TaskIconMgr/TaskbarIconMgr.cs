using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskIconMgr
{
    public partial class MainForm : Form
    {
        private MyHotKeys hotKeys = new MyHotKeys();
        private ListViewItem activItem = null;

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载时对ListView控件进行初始化,并注册热键
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">事件</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            //将任务栏选项添加到列表
            ListViewItem taskbar = new ListViewItem();
            taskbar.SubItems[0].Text = "任务栏";
            taskbar.SubItems.Add("显示");
            iconList.Items.Add(taskbar);

            //获取并添加窗体
            foreach (MyUser32.WindowInfo item in MyUser32.WindowsInfo)
            {
                ListViewItem window = new ListViewItem();
                window.SubItems[0].Text = item.Title;
                window.SubItems.Add("显示");
                iconList.Items.Add(window);
            }

            //注册热键,Shift+Alt+T是隐藏任务栏的
            hotKeys.Regist(this.Handle,
                            (int)MyHotKeys.HotkeyModifiers.Shift +
                            (int)MyHotKeys.HotkeyModifiers.Alt,
                            Keys.T,
                            //不知道程序退出时会不会自己干掉占用的全局快捷键,所以就不用匿名函数写法了() => { iconList.Items[0].Checked = !iconList.Items[0].Checked; }
                            ChangeTaskbarStatus);

            //注册热键,Shift+Alt+S是隐藏任务栏的
            hotKeys.Regist(this.Handle,
                            (int)MyHotKeys.HotkeyModifiers.Shift +
                            (int)MyHotKeys.HotkeyModifiers.Alt,
                            Keys.S,
                            ChangeCurrentWindowStatus);
        }

        private void iconList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //选择的项是任务栏时
            if (e.Index == 0)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    //隐藏任务栏
                    MyUser32.ShowWindow(MyUser32.Taskbar, MyUser32.SW_HIDE);
                    iconList.Items[0].SubItems[1].Text = "隐藏";
                }
                if (e.NewValue == CheckState.Unchecked)
                {
                    //显示任务栏
                    MyUser32.ShowWindow(MyUser32.Taskbar, MyUser32.SW_SHOW);
                    iconList.Items[0].SubItems[1].Text = "显示";
                }
            }
            //选择的是其他窗体图标时
            if (e.Index > 0)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    //隐藏
                    MyUser32.ShowWindow(null, iconList.Items[e.Index].SubItems[0].Text, MyUser32.SW_HIDE);
                    iconList.Items[e.Index].SubItems[1].Text = "隐藏";
                }
                if (e.NewValue == CheckState.Unchecked)
                {
                    //显示
                    MyUser32.ShowWindow(null, iconList.Items[e.Index].SubItems[0].Text, MyUser32.SW_SHOWMINIMIZED);
                    iconList.Items[e.Index].SubItems[1].Text = "显示";
                }
            }
        }

        //注销全局热键
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            hotKeys.UnRegist(this.Handle, ChangeTaskbarStatus);
            hotKeys.UnRegist(this.Handle, ChangeCurrentWindowStatus);
        }

        //重载WndProc函数
        protected override void WndProc(ref Message m)
        {
            //快捷键消息处理
            hotKeys.ProcessHotKey(m);
            base.WndProc(ref m);
        }

        //热键响应处理方法Shift+Alt+T
        private void ChangeTaskbarStatus()
        {
            iconList.Items[0].Checked = !iconList.Items[0].Checked;
        }

        //热键响应处理方法Shift+Alt+S
        private void ChangeCurrentWindowStatus()
        {
            if (activItem != null)
            {
                activItem.Checked = !activItem.Checked;
                activItem = null;
            }
            else
            {
                activItem = iconList.FindItemWithText(MyUser32.ActiveWindow.Title);
                activItem.Checked = !activItem.Checked;
            }
        }
    }
}
