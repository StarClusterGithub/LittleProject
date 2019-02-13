using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using static System.Console;

namespace TempVoteTool
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("===============");
            WriteLine($"args length = {args.Length}");
            foreach (var line in args)
                WriteLine(line);
            if (args.Length < 1)
            {
                WriteLine("Please input argument...");
                Environment.Exit(1);
            }
            WriteLine("===============");


            string masterDir = args[0];
            ChatLogPath = Path.Combine(masterDir, "server_chat_log.txt");
            if (!Directory.Exists(masterDir) || !File.Exists(ChatLogPath))
            {
                WriteLine("chat log file not exist!");
                WriteLine($"chat log dir = {masterDir}");
                WriteLine($"chat log path = {ChatLogPath}");
                WriteLine($"dir exist = {Directory.Exists(masterDir)}");
                WriteLine($"file exist = {File.Exists(ChatLogPath)}");
                Environment.Exit(1);
            }
            WriteLine($"chat log path = {ChatLogPath}");
            WriteLine("===============");


            var curChats = File.ReadAllLines(ChatLogPath, System.Text.Encoding.UTF8);
            byte joinPlayers = 0, leavePlayers = 0;
            foreach (var line in curChats)
            {
                WriteLine(line);
                if (line.Contains("Join Announcement"))
                    ++joinPlayers;
                if (line.Contains("Leave Announcement"))
                    ++leavePlayers;
            }
            EveryoneHasVoted = joinPlayers == leavePlayers;
            WriteLine($"join players = {joinPlayers},leave players = {leavePlayers},everyone has voted = {EveryoneHasVoted}");
            WriteLine("===============");


            Thread timer = new Thread(Timer)
            {
                Name = "Timer"
            };
            timer.Start();
            WriteLine("Timer start~");
            WriteLine("===============");


            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = masterDir;
            watcher.IncludeSubdirectories = false;
            watcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.Size;
            watcher.Filter = "server_chat_log.txt";
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.EnableRaisingEvents = true;
            WriteLine("File system watcher start~");
            WriteLine("===============");

            WriteLine("Press Q quit...");
            for (; ReadKey(false).KeyChar == 'q';)
                ;
        }

        private static void OnChanged(object sender, FileSystemEventArgs e)
        {
            var curChats = File.ReadAllLines(ChatLogPath, System.Text.Encoding.UTF8);
            for (int i = OffsetCount; i < curChats.Length; ++i)
            {
                var line = curChats[i];
                var chatContent = line.Split(':');
                if (chatContent.Length < 5)
                    continue;
                switch (chatContent[4])
                {
                    case " #vote reset yes":
                    case " #vote reset no":
                    case " #vote reset abstain":
                        var playerInfo = chatContent[3].Split(' ');
                        var kid = playerInfo[2].Trim('(', ')');
                        var name = playerInfo[3];
                        var voteInfo = chatContent[4].TrimStart(' ');
                        if (AllPlayers.ContainsKey((kid, name)))
                        {
                            AllPlayers[(kid, name)] = voteInfo;
                        }
                        else
                        {
                            AllPlayers.Add((kid, name), voteInfo);
                        }
                        WriteLine($"kid = {kid},name = {name},vote info  = {voteInfo}");
                        File.AppendAllText(@"./logs.txt", $"kid = {kid},name = {name},vote info  = {voteInfo}\n", System.Text.Encoding.UTF8);
                        break;
                    default:
                        break;
                }
            }
            OffsetCount = curChats.Length;

            WriteLine();
            WriteLine(DateTime.Now.ToString());
            WriteLine($"Offset = {OffsetCount},EveryHasVoted = {EveryoneHasVoted}");
            WriteLine();
        }

        private static void Timer()
        {
            string announcement = @"\n\n\n\n\n\nHi,大家好~\n服务器越来越卡了,\n所以进行投票,\n同意请输入#vote reset yes\n反对请输入#vote reset no\n齐全请输入#vote reset abstain\n2月8日截止";
            announcement = announcement.Replace(@"\", @"\\");
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "/bin/bash";
            psi.UseShellExecute = false;
            psi.RedirectStandardInput = true;
            psi.RedirectStandardOutput = true;
            //  screen -X -S dst_hikarisakamichi_overworld stuff 'c_announce"announcement"\n'
            //  /bin/bash -c "screen -X -S dst_hikarisakamichi_overworld stuff 'c_announce\"announcement\"\n'"
            psi.Arguments = $"-c \"screen -X -S dst_hikarisakamichi_overworld stuff 'c_announce\\\"{announcement}\\\"\\n' \"";


            for (; ; )
            {
                if (EveryoneHasVoted == false)
                {
                    WriteLine();
                    WriteLine(DateTime.Now.ToString());
                    WriteLine($"Arguments = {psi.Arguments}");
                    Process proc = Process.Start(psi);
                    string strOutput = proc.StandardOutput.ReadToEnd();
                    proc.WaitForExit();
                    WriteLine($"Output = {strOutput}");
                    WriteLine();
                }
                Thread.Sleep(1000 * 60 * 4);
            }
        }

        /// <summary>
        /// <para>key:    (kid,name)</para>
        /// <para>value:  vote</para>
        /// </summary>
        private static Dictionary<(string, string), string> AllPlayers { get; set; } = new Dictionary<(string, string), string>();

        private static object locker = new object();
        private static bool everyoneHasVoted = false;
        private static bool EveryoneHasVoted
        {
            get
            {
                lock (locker)
                {
                    return everyoneHasVoted;
                }
            }
            set
            {
                lock (locker)
                {
                    everyoneHasVoted = value;
                }
            }
        }

        private static int OffsetCount { get; set; } = 0;

        private static string ChatLogPath { get; set; }
    }
}
