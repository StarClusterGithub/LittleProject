using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDigitalSignature
{
    /// <summary>
    /// 处理bit数据转换的静态类,
    /// 目前包含byte数组转换为UInt类型以及UInt类型转换为byte数组的方法
    /// 默认转换规则为大端序而非小端序
    /// </summary>
    static class MyBitConverter
    {
        /// <summary>
        /// 将指定byte数组前四个字节转换为UInt32类型
        /// </summary>
        /// <param name="value">需要转换的byte数组</param>
        /// <returns>转换结果</returns>
        static public UInt32 ToUInt32(byte[] value)
        {
            return ToUInt32(value, 0);
        }

        /// <summary>
        /// 将指定byte数组从startIndex开始的四个字节转换为UInt32
        /// </summary>
        /// <param name="value">需要转换的byte数组</param>
        /// <param name="startIndex">开始索引</param>
        /// <returns>转换结果</returns>
        static public UInt32 ToUInt32(byte[] value,int startIndex)
        {
            UInt32 result = 0;
            result |= value[0 + startIndex]; result <<= 8;
            result |= value[1 + startIndex]; result <<= 8;
            result |= value[2 + startIndex]; result <<= 8;
            result |= value[3 + startIndex];
            return result;
        }

        /// <summary>
        /// 获取UInt32的byte[]形式
        /// </summary>
        /// <param name="value">待转换UInt32数据</param>
        /// <returns>转换后的byte数组</returns>
        static public byte[] GetBytes(UInt32 value)
        {
            return new byte[]
            {
                (byte)((value >> 24)&0xff),
                (byte)((value >> 16)&0xff),
                (byte)((value >> 8)&0xff),
                (byte)(value &0xff)
            };
        }

        /// <summary>
        /// 获取UInt64的byte[]形式
        /// </summary>
        /// <param name="value">待转换UInt64数据</param>
        /// <returns>转换后的byte数组</returns>
        static public byte[] GetBytes(UInt64 value)
        {
            return new byte[]
            {
                (byte)((value >> 56)&0xff),
                (byte)((value >> 48)&0xff),
                (byte)((value >> 40)&0xff),
                (byte)((value >> 32)&0xff),
                (byte)((value >> 24)&0xff),
                (byte)((value >> 16)&0xff),
                (byte)((value >> 8)&0xff),
                (byte)(value &0xff)
            };
        }
    }
}
