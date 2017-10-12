using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDigitalSignature
{
    /// <summary>
    /// 数字签名类,仅包含SHA1算法
    /// </summary>
    class DigitalSignature
    {
        //输入的数据
        private byte[] data = null;

        /// <summary>
        /// 读取指定路劲的文件并计算摘要
        /// </summary>
        /// <param name="filePath">文件路径,若不存在则抛出异常</param>
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
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// 读取指定字节流并计算摘要
        /// </summary>
        /// <param name="data">需要计算的字节流数据</param>
        public DigitalSignature(byte[] data)
        {
            if (data == null)
                throw new NullReferenceException("不能对一个空值进行计算!");
            this.data = data;
        }

        /// <summary>
        /// 只读类型的自动属性,根据构造器所获得的数据计算出SHA-1值
        /// </summary>
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
                //获取明文分组
                byte[][] groups = SHA1FillGroups();

                //计算每个分组的W0_W79,并迭代计算160bit内部状态
                for(int i = 0;i<groups.Length;++i)
                {
                    byte[][] w0_w79 = SHA1W0_W79(groups[i]);
                    sha1 = SHA1GroupProcessing(sha1, w0_w79);
                }

                return sha1;
            }
        }// end of SHA1

        /// <summary>
        /// SHA1算法的填充分组方法,将this对象的data按照sha1需要进行分组
        /// </summary>
        /// <returns>分组后的数据</returns>
        private byte[][] SHA1FillGroups()
        {
            //划定分组
            byte[][] groups;
            if ((data.Length % (512 / 8)) >= (448 / 8))
                groups = new byte[data.Length / (512 / 8) + 2][];
            else
                groups = new byte[data.Length / (512 / 8) + 1][];

            //  填充分组
            for (int i = 0; i < groups.Length; ++i)
            {
                groups[i] = new byte[512 / 8];
                //填充分组i,当剩余数据不足以填满一个512bit分组时执行else
                if (data.Length - i * (512 / 8) >= 512 / 8)
                {
                    Array.Copy(data, 512 / 8 * i, groups[i], 0, 512 / 8);
                }
                else
                {
                    Array.Copy(data, 512 / 8 * i, groups[i], 0, data.Length - i * (512 / 8));
                    //原文末尾添加1
                    groups[i][data.Length - i * (512 / 8)] = 0x80;
                    //若该分组不够64bit记录原文长度, 则再填充一个分组
                    if ((data.Length - i * (512 / 8)) >= (448 / 8))
                    {
                        groups[++i] = new byte[512 / 8];
                    }
                    //最后一个分组的最后8个字节填充数据长度(以bit为单位)
                    Array.Copy(MyBitConverter.GetBytes(Convert.ToUInt64(data.Length * 8)), 0, groups[i], 512 / 8 - 8, 8);
                }
            }
            return groups;
        }

        /// <summary>
        /// SHA1算法计算指定分组的w0~w79数据的方法
        /// </summary>
        /// <param name="group">需要计算的分组</param>
        /// <returns>计算得到的w0~w79</returns>
        private byte[][] SHA1W0_W79(byte[] group)
        {
            byte[][] w0_w79 = new byte[80][];
            //将输入分组的512bit作为w0_w15
            for (int i = 0; i < 16; ++i)
            {
                w0_w79[i] = new byte[32 / 8];
                Array.Copy(group, i * 4, w0_w79[i], 0, 32 / 8);
            }
            for (int i = 16; i < 80; ++i)
            {
                //异或求值后循环左移1bit
                UInt32 wt =
                    MyBitConverter.ToUInt32(w0_w79[i - 16]) ^
                    MyBitConverter.ToUInt32(w0_w79[i - 14]) ^
                    MyBitConverter.ToUInt32(w0_w79[i - 8]) ^
                    MyBitConverter.ToUInt32(w0_w79[i - 3]);
                wt = (wt << 1) | (wt >> 31);
                //对W_t进行赋值
                w0_w79[i] = MyBitConverter.GetBytes(wt);
            }
            return w0_w79;
        }

        /// <summary>
        /// SHA1算法的分组处理方法,分为4轮,每轮20个步骤,总计80个步骤
        /// </summary>
        /// <param name="statuBit">初始状态位</param>
        /// <param name="w0_w79">与某个分组对应的w0~w79的值</param>
        /// <returns>计算得到的状态位,若该分组为最后一个分组,则此返回值为最终SHA1值</returns>
        private byte[] SHA1GroupProcessing(byte[] statuBit,byte[][] w0_w79)
        {
            byte[] result = new byte[160 / 8];
            Array.Copy(statuBit, result, 160 / 8);
            //处理分组时的80个步骤
            for (int i = 0; i < 80; ++i)
            {
                //将160bit(20Byte)分成5个缓存区(5个UInt32)
                UInt32 buffA = MyBitConverter.ToUInt32(result, 0),
                    buffB = MyBitConverter.ToUInt32(result, 4),
                    buffC = MyBitConverter.ToUInt32(result, 8),
                    buffD = MyBitConverter.ToUInt32(result, 12),
                    buffE = MyBitConverter.ToUInt32(result, 16);

                //将缓存区A,B,C,D复制到B,C,D,E中
                Array.Copy(MyBitConverter.GetBytes(buffA), 0, result, 4, 4);
                Array.Copy(MyBitConverter.GetBytes((buffB << 30) | (buffB >> 2)), 0, result, 8, 4);
                Array.Copy(MyBitConverter.GetBytes(buffC), 0, result, 12, 4);
                Array.Copy(MyBitConverter.GetBytes(buffD), 0, result, 16, 4);

                //计算逻辑函数Fi和步骤相关的Ki,wt
                UInt32 fi = 0, ki = 0, wt = MyBitConverter.ToUInt32(w0_w79[i], 0);
                if (i < 20)
                {
                    fi = (buffB & buffC) | (~buffB & buffD);
                    ki = 0x5a827999;
                }
                else if (i < 40)
                {
                    fi = buffB ^ buffC ^ buffD;
                    ki =0x6ed9eba1;
                }
                else if (i < 60)
                {
                    fi = (buffB & buffC) | (buffC & buffD) | (buffD & buffB);
                    ki = 0x8f1bbcdc;
                }
                else if (i < 80)
                {
                    fi = buffB ^ buffC ^ buffD;
                    ki = 0xca62c1d6;
                }

                //将缓存区A循环左移5位
                buffA = (buffA << 5) | (buffA >> 27);
                
                //计算E并将结果复制到A中
                buffE = buffE + fi + buffA + wt + ki;
                Array.Copy(MyBitConverter.GetBytes(buffE), 0, result, 0, 4);
            }

            //将处理前160bit状态和处理后160bit状态相加
            for (int i = 0; i < 5; ++i)
            {
                UInt32 oldNum = MyBitConverter.ToUInt32(statuBit, 4 * i), newNum = MyBitConverter.ToUInt32(result, 4 * i);
                Array.Copy(MyBitConverter.GetBytes(oldNum + newNum), 0, result, 4 * i, 4);
            }
            return result;
        }
    }// end of class
}
