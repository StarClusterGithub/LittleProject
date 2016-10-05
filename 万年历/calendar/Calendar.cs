using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarSpace
{
    public class Calendar
    {
        private static int year = 0, month = 0, day = 0, week = 0;//年月日周变量存放用户输入的年月日周
        public static int Year
        {
            get { return year; }
            set
            {
                if (value != 0)
                    year = value;
                month = day = 0;
            }
        }
        public static int Month
        {
            get { return month; }
            set
            {
                if (1 <= value && value <= 12)
                    month = value;
                day = 0;
            }
        }
        public static int Day
        {
            get { return day; }
            set
            {
                int[] MonthDay = { 31, LeapYear() ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                if (1 <= value && value <= MonthDay[month - 1])
                    day = value;
            }
        }
        public static int Week
        {
            get { return week; }
            set
            {
                if (1 <= value && value <= 54 && LeapYear())
                    week = value;
                else
                {
                    if (1 <= value && value <= 53)
                        week = value;
                }
            }
        }

        private int converter(int date)
        {
            int equative = date >= 0 ? date : date + 1;
            for (; equative <= 0; )//400(闰年)年和7天(星期)和60年(甲子)和12年(生肖)的最小公倍数8400
                equative += 8400;
            return equative;
        }
        public static bool LeapYear()
        {
            return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
        }
        private string HeavenTrunk(int date)//天干
        {
            Calendar calendar = new Calendar();
            string[] Heaven = new string[10] { "庚", "辛", "壬", "癸", "甲", "乙", "丙", "丁", "戊", "己" };
            return Heaven[calendar.converter(date) % 10];
        }
        private string TerrestrialBranch(int date)//地支
        {
            Calendar calendar = new Calendar();
            string[] Terrestrial = new string[12] { "申", "酉", "戌", "亥", "子", "丑", "寅", "卯", "辰", "巳", "午", "未" };
            return Terrestrial[calendar.converter(date) % 12];
        }
        private string YearOfBirch(int date)//生肖
        {
            Calendar calendar = new Calendar();
            string[] Birch = new string[12] { "猴", "鸡", "狗", "猪", "鼠", "牛", "虎", "兔", "龙", "蛇", "马", "羊" };
            return Birch[calendar.converter(date) % 12];
        }
        private int LeapNum(int StartYear,int EndYear)
        {
            int number = 0;

            return number;
        }
        private int WhatDay()//返回值代表了当年第一天是星期几
        {
            Calendar calendar = new Calendar();
            int ReferYear = calendar.converter(year);
            ReferYear += LeapYear() ? ReferYear / 4 : ReferYear / 4 + 1;//一年365天等于52周多一天,年份即多余天数,闰年每年多出一天,所以加上闰年数,平年的闰年数少了公元0年,要加上
            ReferYear = (ReferYear+ 5) % 7 ;//因为公元0年(公元前1年)1月1日是星期五,所以+5,对7取余得到星期几(星期天为0)
            return ReferYear == 0 ? 7 : ReferYear;
        }
        private int NowDay(int nowyear,int nowmonth,int nowday)//返回值为给定日期为当年第几天
        {
            int days = 0;
            int[] MonthDay = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if ((nowyear % 4 == 0 && nowyear % 100 != 0) || (nowyear % 400 == 0))//闰年2月+1
                ++MonthDay[1];
            for (int i = 1; i < nowmonth; ++i)
            {
                days += MonthDay[i - 1];
            }
            days += nowday;
            return days;            
        }
        public static void YearCalendar()//年历
        {
            Calendar calendar = new Calendar();
            Console.Clear();
            Console.WriteLine("\t\t\t\t{0}\t{1}年", year > 0 ? "公元" : "公元前", year > 0 ? year : -year);
            Console.WriteLine("\t\t\t\t   " + calendar.HeavenTrunk(year) + calendar.TerrestrialBranch(year) + calendar.YearOfBirch(year) + "年");//输出天干地支和生肖
            Console.WriteLine("\t\t\t\t     {0}\n\n", LeapYear() ? "闰年" : "平年");
            int temp = month;
            for (int putmonth = 1; putmonth <= 12; ++putmonth)//输出本年1到12月的月份
            {
                month = putmonth;
                MonthCalendar();
            }
            month = temp;
        }
        public static void MonthCalendar()//月历
        {
            Console.WriteLine("\n{0}{1}年\t{2}月份", year > 0 ? "公元" : "公元前", year > 0 ? year : -year, month);
            Console.WriteLine("星期天      星期一      星期二      星期三      星期四      星期五      星期六");
            Calendar calendar = new Calendar();
            int whatday = calendar.WhatDay() + calendar.NowDay(year, month, 1) - 1;//用于表示本月第一天是星期几
            whatday = whatday % 7 == 0 ? 7 : whatday % 7;//星期0即星期天
            for (int i = (whatday == 7 ? 0 : whatday); i > 0; --i)//计算whatday是第几天,星期天是第一天,只需多打印0个,星期一第一天,只需打印一次...以此类推
            {
                Console.Write("            ");
            }
            int temp = day;
            int[] MonthDay = { 31, LeapYear() ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };//当年每个月的最大天数
            for (day = 1; day <= MonthDay[month - 1]; ++day, ++whatday)
            {
                if (whatday > 7)
                    whatday -= 7;
                Console.Write("{0}          ",day);
                if (day < 10)
                    Console.Write(" ");
                if (whatday == 6)
                    Console.WriteLine();
            }
            Console.WriteLine("\n");
            day = temp;
        }
        public static void DayCalendar()//日历
        {
            Calendar calendar = new Calendar();
            Console.Clear();
            Console.WriteLine("\t\t\t\t{0}\t{1}年", year > 0 ? "公元" : "公元前", year > 0 ? year : -year);
            Console.WriteLine("\t\t\t\t   " + calendar.HeavenTrunk(year) + calendar.TerrestrialBranch(year) + calendar.YearOfBirch(year) + "年");//输出天干地支和生肖
        }
        public static void WeekCalendar()//周历
        {

        }
        public static void Distance(int StartYear, int StartMonth, int StartDay, int EndYear, int EndMonth, int EndDay)//测量两个日期的间隔
        {
            Calendar calendar = new Calendar();
            int ReferStartYear = StartYear < 0 ? StartYear + 1 : StartYear, ReferEndYear = EndYear < 0 ? EndYear + 1 : EndYear;
            for (; ReferStartYear <= 0 || ReferEndYear <= 0; )//保证两个数均为正数
            {
                ReferStartYear += 420;//公元历法日历每隔28年则日期星期和平闰年相等,而生肖则是12年,天干地支纪年法的周期为60年,最小公倍数为420
                ReferEndYear += 420;
            }
            int distance = calendar.NowDay(ReferEndYear, EndMonth, EndDay) - calendar.NowDay(ReferStartYear, StartMonth, StartDay);
            while (ReferStartYear < ReferEndYear)//循环累加
            {
                if (ReferStartYear % 4 == 0)
                    distance += 366;
                else
                    distance += 365;
                ++ReferStartYear;
            }
            Console.WriteLine("\n{0}{1}年{2}月{3}日到{4}{5}年{6}月{7}日之间的差距为:\t{8}天", StartYear > 0 ? "公元" : "公元前", StartYear > 0 ? StartYear : -StartYear, StartMonth, StartDay, EndYear > 0 ? "公元" : "公元前", EndYear > 0 ? EndYear : -EndYear, EndMonth, EndDay, distance);
        }
    }
}
