﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double doubleNum = 9999.999; //fastest data type to use in calculations
            float floatNum = 999.9F;
            decimal decimalNum = 1234.5678M;
            long longInt = -12345678;   // Int64 (64-bit)
            ulong ulongInt = 12345678;  // UInt64
            int intNum = -786;          // Int32
            uint uintNum = 786;         // UInt32
            short shortInt = -789;      // Int16
            ushort ushortInt = 456;     // UInt16
            byte byteNum = 254;         // 8-bit unsigned
            sbyte sbyteNum = -123;      // 8-bit signed

            longInt = shortInt;
            uintNum = byteNum;

            //byteNum = shortInt; 
            //cannot put a larger data type in a smaller data type

            //explicit casting
            byteNum = (byte)shortInt;

            try
            {
                byteNum = checked((byte)shortInt);
                byteNum = Convert.ToByte(shortInt);
            }
            catch
            {
                //output message that data will be lost
            }
           
        }
    }
}
