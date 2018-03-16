using System;
using System.Runtime.InteropServices;
using System.Collections;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskIconMgr
{
    static class MyUser32
    {
        //https://msdn.microsoft.com/en-us/library/windows/desktop/ms633548(v=vs.85).aspx
        public const int SW_HIDE = 0;
        public const int SW_SHOWNORMAL = 1;
        public const int SW_SHOWMINIMIZED = 2;
        public const int SW_SHOWMAXIMIZED = 3;
        public const int SW_SHOWNOACTIVATE = 4;
        public const int SW_SHOW = 5;

        [DllImport("user32.dll")]
        public static extern IntPtr ShowWindow(IntPtr hWnd, int nCmdShow);


        public struct WindowInfo
        {
            //lpWindowName
            public string Title;
            //lpClassName
            public string ClassName;
            //hWnd
            public IntPtr Handle;
        }

        /// <summary>
        /// 获取所有窗体信息
        /// </summary>
        static public WindowInfo[] WindowsInfo
        {
            get
            {
                if (windowsInfo == null)
                {
                    windowsInfo = new List<WindowInfo>();
                    EnumWindows(
                        delegate (IntPtr hWnd, int lParam)
                        {
                            WindowInfo item = new WindowInfo();
                            //get handle
                            item.Handle = hWnd;
                            //get title
                            StringBuilder title = new StringBuilder(256);
                            GetWindowText(hWnd, title, title.Capacity);
                            item.Title = title.ToString();
                            //get class name
                            StringBuilder className = new StringBuilder(256);
                            GetClassNameW(hWnd, className, className.Capacity);
                            item.ClassName = className.ToString();
                            if(!item.Title.Equals(""))
                                windowsInfo.Add(item);
                            return true;
                        }
                        , 0);
                }
                return windowsInfo.ToArray();
            }
        }

        static public WindowInfo ActiveWindow
        {
            get
            {
                WindowInfo item = new WindowInfo();
                //get handle
                item.Handle = GetActiveWindow();
                //get title
                StringBuilder title = new StringBuilder(256);
                GetWindowText(item.Handle, title, title.Capacity);
                item.Title = title.ToString();
                //get class name
                StringBuilder className = new StringBuilder(256);
                GetClassNameW(item.Handle, className, className.Capacity);
                item.ClassName = className.ToString();
                return item;
            }
        }

        static public IntPtr Taskbar
        {
            get
            {
                return FindWindow("Shell_TrayWnd", null);
            }
        }

        static public IntPtr ShowWindow(string lpClassName, string lpWindowName, int nCmdShow)
        {
            return ShowWindow(FindWindow(lpClassName, lpWindowName), nCmdShow);
        }

        static public void FlushWindowsInfo()
        {
            windowsInfo = null;
        }


        static private List<WindowInfo> windowsInfo = null;
        private delegate bool EnumWindowCallBack(IntPtr hWnd, int lParam);

        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll")]
        private static extern bool EnumWindows(EnumWindowCallBack lpEnumFunc, int lParam);
        [DllImport("user32.dll")]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);
        [DllImport("user32.dll")]
        private static extern int GetClassNameW(IntPtr hWnd, [MarshalAs(UnmanagedType.LPWStr)]StringBuilder lpString, int nMaxCount);
        [DllImport("user32.dll")]
        private static extern IntPtr GetActiveWindow();
    }
}
