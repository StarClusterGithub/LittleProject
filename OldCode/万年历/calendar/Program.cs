using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CalendarSpace;


namespace MainProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Program fun = new Program();
            Console.Title = "万年历";
            Console.SetBufferSize(90,120);
            Console.SetWindowSize(90,30);
            while (true)
            {
                switch (fun.menu())
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("欢迎使用年历功能!请输入您要查询的年份：");
                        Calendar.Year = Convert.ToInt32(Console.ReadLine());
                        Calendar.YearCalendar();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("欢迎使用月历功能!请输入您要查询的年和月，用空格隔开：");
                        string[] str = new string[2];
                        str = Console.ReadLine().Split(' ');
                        Calendar.Year = Convert.ToInt32(str[0]);
                        Calendar.Month = Convert.ToInt32(str[1]);
                        Calendar.MonthCalendar();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("欢迎使用日期测距功能!请输入起始时间(年月日),并用空格隔开:");
                        string[] startdate = Console.ReadLine().Split(' ');
                        Console.WriteLine("请输入终止日期,用空格隔开:");
                        string[] enddate = Console.ReadLine().Split(' ');
                        Calendar.Distance(Convert.ToInt32(startdate[0]), Convert.ToInt32(startdate[1]), Convert.ToInt32(startdate[2]), Convert.ToInt32(enddate[0]), Convert.ToInt32(enddate[1]), Convert.ToInt32(enddate[2]));
                        break;
                    case 7:
                        Console.Write("\t\t\t\t   确定要退出吗?(Y/N)");
                        for (char choose = (char)Console.Read(); choose != 'N' && choose != 'n'; choose = (char)Console.Read())
                        {
                            if (choose == 'Y' || choose == 'y')
                                Environment.Exit(Environment.ExitCode);
                            Console.Write("\t\t\t\t   确定要退出吗?(Y/N)");
                            while ((choose = (char)Console.Read()) != '\n') ;//清空缓存区残留字符
                        }
                        for (char choose = '\0'; (choose = (char)Console.Read()) != '\n'; ) ;//清空缓存区残留字符
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Error!Please input again.");
                        break;
                }
                pause();
            }
        }
        public int menu()
        {
            int select = 0;
            for (; ; )
            {
                Console.Clear();
                Console.Write("\n\t\t\t\t  欢迎使用万年历!");
                Console.Write("\n\t\t\t\tMade in Star-cluster\n\n");
                Console.Write("\n\t\t\t\t      1.年历");
                Console.Write("\n\t\t\t\t      2.月历");
                Console.Write("\n\t\t\t\t      3.日历");
                Console.Write("\n\t\t\t\t      4.周历");
                Console.Write("\n\t\t\t\t      5.当前时间");
                Console.Write("\n\t\t\t\t      6.日期测距");
                Console.Write("\n\t\t\t\t      7.退出\n");
                Console.Write("\n\n\t\t\t\t   请输入你的选择:");
                if(int.TryParse(Console.ReadLine(),out select)&&(select<1||select>7))
                {
                    Console.WriteLine("\n\t\t\t\t输入错误!请重新输入!");
                    pause();
                }
                else 
                {
                    break;
                }
            }
            return select;
        }
        private static void pause()
        {
            Console.Write("请按任意键继续. . .");
            Console.ReadKey(true);
        }
    }
}
