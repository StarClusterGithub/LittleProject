using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartShelves
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //智能终端
            Thread sst = new Thread(() => { Application.Run(new SmartShelvesTerminal()); });
            //货物管理子系统
            Thread gms = new Thread(() => { Application.Run(new GoodsManagementSubsystem()); });
            //启动线程
            sst.Start();
            gms.Start();
            //等待线程执行完毕,此处循环的空语句有意为之
            for (; sst.IsAlive && gms.IsAlive;)
                ;
        }
    }
}
