using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDigitalSignature
{
    class DigitalSignature
    {
        //  160bitSHA-1的初始值
        private readonly byte[] initValue = new byte[20]
            {
                0x67, 0x45, 0x23, 0x01,
                0xef, 0xcd, 0xab, 0x89,
                0x98, 0xba, 0xdc, 0xfe,
                0x10, 0x32, 0x54, 0x76,
                0xc3, 0xd2, 0xe1, 0xf0
            };
        private byte[] data = null;


        public DigitalSignature(string filePath)
        {
            using (FileStream fileRead = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                try
                {
                    data = new byte[fileRead.Length];
                    fileRead.Read(data, 0, data.Length);
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e.ToString());
                }
            }
        }

        public DigitalSignature(byte[] data)
        {
            if (data == null)
                throw new NullReferenceException("不能对一个空值进行计算!");
            this.data = data;
        }

        public byte[] SHA1
        {
            get
            {
                byte[] sha1 = new byte[20];
                byte[][] groups = new byte[data.Length / (512 / 8) + (data.Length % (512 / 8) == 0 ? 0 : 1)][];//消息分组
                SHA1FillGroups(ref groups);//填充分组
                //  TODO
                //  获取w0_w79
                return sha1;
            }
        }// end of SHA1

        private void SHA1FillGroups(ref byte[][] groups)
        {
            //  填充分组
            for (int i = 0, dataLeng = data.Length; i < groups.Length; ++i)
            {
                groups[i] = new byte[512 / 8];//分配空间
                if (dataLeng >= 512 / 8)
                {
                    //如果剩余数据大于等于512bit,则将之复制到分组i
                    Array.Copy(data, 512 / 8 * i, groups[i], 0, 512 / 8);
                    dataLeng -= 512 / 8;
                }
                else
                {
                    //如果剩余数据不足512bit,则填充
                    Array.Copy(data, 512 / 8 * i, groups[i], 0, dataLeng);
                    //消息末尾添加1,分组末尾添加消息长度
                    groups[i][dataLeng] = 0x80;
                    Array.Copy(BitConverter.GetBytes(Convert.ToInt64(data.Length)), 0, groups[i], 512 / 8 - 8, 8);
                }
            }
        }

        private byte[][] SHA1W0_W79(byte[] group)
        {
            byte[][] w0_w79 = new byte[80][];
            //将输入分组的512bit作为w0_w15
            for (int i = 0; i < 16; ++i)
            {
                w0_w79[i] = new byte[32 / 8];
                Array.Copy(group, 0, w0_w79[i], 0, 32 / 8);
            }
            for (int i = 16; i < 80; ++i)
            {
                //异或求值后循环左移1bit
                Int32 temp = Convert.ToInt32(w0_w79[i - 16])^ Convert.ToInt32(w0_w79[i - 14]) ^ Convert.ToInt32(w0_w79[i - 8]) ^ Convert.ToInt32(w0_w79[i - 3]);
                temp = (temp << 0x01) & ((temp >> 31) & ~0x01);
                //对W_t进行赋值
                w0_w79[i] = BitConverter.GetBytes(temp);
            }
            return w0_w79;
        }
    }// end of class
}
