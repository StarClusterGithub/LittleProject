using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarByStarCluster
{
    internal class MyDate
    {
        private int year,month,day;


        public MyDate(string year,string month,string day):this(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day))
        {

        }


        public MyDate(int year,int month,int day)
        {
            if (!(IsGregorianCalendar(year, month, day) && 1 <= month && month <= 12 && day >= 1 && day <= MonthDays))
                throw new Exception("invalid date!");
            this.year = year;
            this.month = month;
            this.day = day;
        }


        /// <summary>
        /// 判断是不是格里历(1582年10月15日以后)
        /// </summary>
        /// <param name="year">年</param>
        /// <param name="month">月</param>
        /// <param name="day">日</param>
        /// <returns>是则返回真,否则返回假</returns>
        public static bool IsGregorianCalendar(int year,int month,int day)
        {
            if (year > 1582 || (year == 1582 && month >= 10 && day >= 15))
                return true;
            else
                return false;
        }


        /// <summary>
        /// 判断是不是闰年
        /// </summary>
        /// <param name="year">要判断的年份</param>
        /// <returns>是则返回真,否则返回假</returns>
        public static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
        }


        /// <summary>
        /// 平年每月的天数
        /// </summary>
        private static int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        /// <summary>
        /// 返回当前实例当月最大天数
        /// </summary>
        public int MonthDays
        {
            get { return (IsLeapYear(year) ? 1 : 0) + days[month - 1]; }
        }


        /// <summary>
        /// 儒略日
        /// </summary>
        public int JulianDay
        {
            get { return (153 * month + 2) / 5 + 365 * year + day + 32045 + year / 4 - year / 100 + year / 400; }
        }


        /// <summary>
        /// 星期几
        /// </summary>
        public byte Week
        {
            get { return (byte)(JulianDay % 7); }
        }

    }
}
