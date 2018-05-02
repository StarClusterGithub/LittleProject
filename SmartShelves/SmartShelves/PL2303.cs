using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;

namespace SmartShelves
{
    /// <summary>
    /// PL2303串口通信类,基于System.IO.Ports;
    /// </summary>
    class PL2303
    {
        private SerialPort pl2303 = new SerialPort();

        public PL2303(string portName = "COM3",int baudRate = 9600,int dataBits = 8,StopBits stopBits=StopBits.One,int readTimeout = 500)
        {
            pl2303.PortName = portName;
            pl2303.BaudRate = baudRate;
            pl2303.DataBits = dataBits;
            pl2303.StopBits = stopBits;
            this.ReadTimeout = readTimeout;
        }

        /// <summary>
        /// 获取串口打开状态
        /// </summary>
        public bool IsOpen
        {
            get
            {
                return pl2303.IsOpen;
            }
        }

        /// <summary>
        /// 获取或设置读取操作未完成时发生超时之前的毫秒数。
        /// </summary>
        public int ReadTimeout
        {
            get
            {
                return pl2303.ReadTimeout;
            }
            set
            {
                pl2303.ReadTimeout = value;
            }
        }

        /// <summary>
        /// 打开串口连接
        /// </summary>
        public void Open()
        {
            if (!pl2303.IsOpen)
                pl2303.Open();
        }

        /// <summary>
        /// 关闭串口连接
        /// </summary>
        public void Close()
        {
            if (pl2303.IsOpen)
                pl2303.Close();
        }

        /// <summary>
        /// 将指定字符串写入串口
        /// </summary>
        /// <param name="text">要写入的字符串</param>
        public void Write(string text)
        {
            this.Open();
            if (!text.EndsWith("\r\n"))
                text = text.TrimEnd('\r').TrimEnd('\n') + "\r\n";
            Byte[] data = Encoding.Default.GetBytes(text);
            pl2303.Write(data,0,data.Length);
            //等待发送完毕
            for (; pl2303.BytesToWrite > 0;)
                ;
        }

        /// <summary>
        /// 将串口缓存区所有数据读入
        /// </summary>
        /// <returns>存在于串口缓存区的所有数据</returns>
        public string ReadAllData()
        {
            this.Open();
            return pl2303.ReadExisting();
        }

    }
}
