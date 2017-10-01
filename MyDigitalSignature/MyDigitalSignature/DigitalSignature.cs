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
        //输入的数据
        private byte[] data = null;


        public DigitalSignature(string filePath)
        {
            try
            {
                FileStream fileRead = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
                data = new byte[fileRead.Length];
                fileRead.Read(data, 0, data.Length);
                fileRead.Close();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
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
                //160bit初始sha1
                byte[] sha1 = new byte[160/8]
                {
                    0x67, 0x45, 0x23, 0x01,
                    0xef, 0xcd, 0xab, 0x89,
                    0x98, 0xba, 0xdc, 0xfe,
                    0x10, 0x32, 0x54, 0x76,
                    0xc3, 0xd2, 0xe1, 0xf0
                };
                //消息分组
                byte[][] groups = new byte[data.Length / (512 / 8) + (data.Length % (512 / 8) == 0 ? 0 : 1)][];
                
                //填充分组
                SHA1FillGroups(ref groups);

                //计算每个分组的W0_W79,并迭代计算160bit内部状态
                for(int i = 0;i<groups.Length;++i)
                {
                    byte[][] w0_w79 = SHA1W0_W79(groups[i]);
                    sha1 = SHA1GroupProcessing(sha1, w0_w79);
                }

                return sha1;
            }
        }// end of SHA1

        private void SHA1FillGroups(ref byte[][] groups)
        {
            //  填充分组
            for (int i = 0, dataLeng = data.Length; i < groups.Length; ++i)
            {
                groups[i] = new byte[512 / 8];
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
                Int32 wt =
                    BitConverter.ToInt32(w0_w79[i - 16], 0) ^
                    BitConverter.ToInt32(w0_w79[i - 14], 0) ^
                    BitConverter.ToInt32(w0_w79[i - 8], 0) ^
                    BitConverter.ToInt32(w0_w79[i - 3], 0);
                wt = (wt << 1) & ((wt >> 31) & 0x01);
                //对W_t进行赋值
                w0_w79[i] = BitConverter.GetBytes(wt);
            }
            return w0_w79;
        }

        private byte[] SHA1GroupProcessing(byte[] statuBit,byte[][] w0_w79)
        {
            byte[] result = new byte[160 / 8];
            Array.Copy(statuBit, result, 160 / 8);
            //处理分组时的80个步骤
            for (int i = 0; i < 80; ++i)
            {
                //将160bit(20Byte)分成5个缓存区
                int buffA = BitConverter.ToInt32(result, 0),
                    buffB = BitConverter.ToInt32(result, 4),
                    buffC = BitConverter.ToInt32(result, 8),
                    buffD = BitConverter.ToInt32(result, 12),
                    buffE = BitConverter.ToInt32(result, 16);

                //将buffB循环左移30位
                buffB = (buffB << 30) & ((buffB >> 2) & ~(0x03 << 30));

                //将缓存区A,B,C,D复制到B,C,D,E中
                Array.Copy(BitConverter.GetBytes(buffA), 0, result, 4, 4);
                Array.Copy(BitConverter.GetBytes(buffB), 0, result, 8, 4);
                Array.Copy(BitConverter.GetBytes(buffC), 0, result, 12, 4);
                Array.Copy(BitConverter.GetBytes(buffD), 0, result, 16, 4);

                //计算逻辑函数Fi和步骤相关的Ki,wt
                int fi = 0, ki = 0, wt = BitConverter.ToInt32(w0_w79[i], 0);
                if (i < 20)
                {
                    fi = (buffB & buffC) | (~buffB & buffD);
                    ki = BitConverter.ToInt32(new byte[] { 0x5a, 0x82, 0x79, 0x99 }, 0);
                }
                else if (i < 40)
                {
                    fi = buffB ^ buffC ^ buffD;
                    ki = BitConverter.ToInt32(new byte[] { 0x6e, 0xd9, 0xeb, 0xa1 }, 0);
                }
                else if (i < 60)
                {
                    fi = (buffB & buffC) | (buffC & buffD) | (buffD & buffB);
                    ki = BitConverter.ToInt32(new byte[] { 0x8f, 0x1b, 0xbc, 0xdc }, 0);
                }
                else if (i < 80)
                {
                    fi = buffB ^ buffC ^ buffD;
                    ki = BitConverter.ToInt32(new byte[] { 0xca, 0x62, 0xc1, 0xd6 }, 0);
                }

                //将缓存区A循环左移5位
                buffA = (buffA << 5) & ((buffB >> 27) & 0x1f);
                
                //计算E并将结果复制到A中
                buffE = buffE + fi + buffA + wt + ki;
                Array.Copy(BitConverter.GetBytes(buffE), 0, result, 0, 4);
            }

            //将处理前160bit状态和处理后160bit状态相加
            for (int i = 0; i < 5; ++i)
            {
                int oldNum = BitConverter.ToInt32(result, 4 * i), newNum = BitConverter.ToInt32(statuBit, 4 * i);
                Array.Copy(BitConverter.GetBytes(oldNum + newNum), 0, result, 4 * i, 4);
            }
            return result;
        }
    }// end of class
}
