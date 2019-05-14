using System;
using System.IO;
using System.Text.RegularExpressions;
using static System.Console;

namespace BandwidthCalculator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var regex = new Regex
            (
                @"  ^
                    (?<date>
                        [\d]{4}
                        [-/ \\]
                        [\d]{2}
                        [-/ \\]
                        [\d]{2}
                        [-T/ \\]
                        [\d]{2}:[\d]{2}:[\d]{2}
                        [-+]
                        [\d]{2}:[\d]{2}
                    )
                    ,
                    (?<avgBandwidth>[0-9]+\.[0-9]*)
                    $",
                RegexOptions.IgnorePatternWhitespace | RegexOptions.ExplicitCapture | RegexOptions.Compiled
            );

            var input = "";
            for (; input != "quit";)
            {
                Clear();
                WriteLine("please input bandwidth csv file path:");
                input = ReadLine();

                if (!File.Exists(input))
                {
                    WriteLine("file not exist!");
                    Pause(out input);
                    continue;
                }

                var time = DateTime.MinValue;
                var traffic = 0d;
                var contents = File.ReadAllLines(input);
                foreach (var line in contents)
                {
                    var match = regex.Match(line);
                    if (!match.Success)
                        continue;
                    if (time == DateTime.MinValue)
                        time = Convert.ToDateTime(match.Groups["date"].Value);
                    var curTime = Convert.ToDateTime(match.Groups["date"].Value);
                    var bandwidth = float.Parse(match.Groups["avgBandwidth"].Value);
                    traffic += bandwidth * (curTime - time).TotalSeconds / 8;
                    time = curTime;
                }
                WriteLine($"total traffic(MB):  {traffic:#.000}MB");
                WriteLine($"total traffic(GB):  {(traffic / 1024):#.000}GB");

                Pause(out input);
            }
        }

        /// <summary>
        /// Pause
        /// </summary>
        private static void Pause(out string input)
        {
            WriteLine("enter quit to exit and enter the other to continue...");
            input = ReadLine();
        }
    }
}
