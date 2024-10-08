﻿//#define NUMERIC_TYPES
//#define LITERALS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Program
    {
        static readonly string delimiter1 = "\n-------------------------------\n";
        static readonly string delimiter2 = "\n===============================\n";
        static void Main(string[] args)
        {
            Console.WriteLine("C# Data Types");

            #region Boolean
            //Console.WriteLine(bool.TrueString);
            //Console.WriteLine(Convert.ToBoolean(1));
            //Console.WriteLine(bool.Parse("false")); 
            #endregion

            #region Char
            //Unicode
            //Console.WriteLine(char.GetNumericValue(char.MinValue));
            //Console.WriteLine(char.GetNumericValue(char.MaxValue)); 
            #endregion

            #region IntegralTypes
            //Console.Write($"Переменная типа 'short' занимает {sizeof(short)} 2 Байта памяти,");
            //Console.WriteLine($"и принимает значения в диапазоне: {short.MinValue}...{short.MaxValue}");
            //Console.Write($"диапазон принимаемых значений 'ushort': {ushort.MinValue}...{ushort.MaxValue}");
            //Console.WriteLine(delimiter1);
            //Console.Write($"Переменная типа 'Int16' занимает {sizeof(Int16)} 2 Байта памяти,");
            //Console.WriteLine($"и принимает значения в диапазоне: {Int16.MinValue}...{Int16.MaxValue}");
            //Console.Write($"диапазон принимаемых значений 'UInt16': {UInt16.MinValue}...{UInt16.MaxValue}");
            //Console.WriteLine();
            //Console.WriteLine(delimiter2);

            //Console.Write($"Переменная типа 'int' занимает {sizeof(int)} 2 Байта памяти,");
            //Console.WriteLine($"и принимает значения в диапазоне: {int.MinValue}...{int.MaxValue}");
            //Console.Write($"диапазон принимаемых значений 'uint': {uint.MinValue}...{uint.MaxValue}");
            //Console.WriteLine(delimiter1);
            //Console.Write($"Переменная типа 'Int32' занимает {sizeof(Int32)} 2 Байта памяти,");
            //Console.WriteLine($"и принимает значения в диапазоне: {Int32.MinValue}...{Int32.MaxValue}");
            //Console.Write($"диапазон принимаемых значений 'UInt32': {UInt32.MinValue}...{UInt32.MaxValue}");
            //Console.WriteLine();
            //Console.WriteLine(delimiter2);

            //Console.Write($"Переменная типа 'long' занимает {sizeof(long)} 2 Байта памяти,");
            //Console.WriteLine($"и принимает значения в диапазоне: {long.MinValue}...{long.MaxValue}");
            //Console.Write($"диапазон принимаемых значений 'uint': {ulong.MinValue}...{ulong.MaxValue}");
            //Console.WriteLine(delimiter1);
            //Console.Write($"Переменная типа 'Int64' занимает {sizeof(Int64)} 2 Байта памяти,");
            //Console.WriteLine($"и принимает значения в диапазоне: {Int64.MinValue}...{Int32.MaxValue}");
            //Console.Write($"диапазон принимаемых значений 'UInt64': {UInt64.MinValue}...{UInt64.MaxValue}");
            //Console.WriteLine();
            //Console.WriteLine(delimiter2); 
            #endregion

#if NUMERIC_TYPES
            double a = 12.56;
            Console.WriteLine(a * 100000);

            //Single precision
            Console.Write($"Переменная типа 'float' занимает {sizeof(float)} Байта памяти,");
            Console.WriteLine($"и принимает значения в диапазоне: {float.MinValue}...{float.MaxValue}");
            Console.WriteLine(delimiter1);
            Console.Write($"Переменная типа 'Int16' занимает {sizeof(Single)}  Байта памяти,");
            Console.WriteLine($"и принимает значения в диапазоне: {Single.MinValue}...{Single.MaxValue}");
            Console.WriteLine();
            Console.WriteLine(delimiter2);

            Console.Write($"Переменная типа 'double' занимает {sizeof(double)} Байта памяти,");
            Console.WriteLine($"и принимает значения в диапазоне: {double.MinValue}...{double.MaxValue}");
            Console.WriteLine(delimiter1);
            Console.Write($"Переменная типа 'Double' занимает {sizeof(Double)}  Байта памяти,");
            Console.WriteLine($"и принимает значения в диапазоне: {Double.MinValue}...{Double.MaxValue}");
            Console.WriteLine();
            Console.WriteLine(delimiter1);

            Console.WriteLine($"Переменная типа 'decimal' занимает {sizeof(decimal)} Байта памяти,");
            Console.WriteLine($"и принимает значения в диапазоне: {decimal.MinValue}...{decimal.MaxValue}");
            Console.WriteLine(delimiter1);
            Console.WriteLine($"Переменная типа 'Decimal' занимает {sizeof(Decimal)}  Байта памяти,");
            Console.WriteLine($"и принимает значения в диапазоне: {Decimal.MinValue}...{Decimal.MaxValue}");
            Console.WriteLine();
            Console.WriteLine(delimiter1);
#endif
#if LITERALS
            Console.WriteLine(123.GetType());     //int
            Console.WriteLine(123u.GetType());    //int
            Console.WriteLine(123L.GetType());    //long
            Console.WriteLine(123ul.GetType());   //long
            Console.WriteLine(123.4.GetType());   //double
            Console.WriteLine(123.4f.GetType());  //flout
            Console.WriteLine(123f.GetType());    //flout
            Console.WriteLine(123.4m.GetType());  //decimal 
            Console.WriteLine(delimiter1);
            Console.WriteLine(5d.GetType());       //double
            Console.WriteLine(123.4.GetType());    //double
            Console.WriteLine(123.4f.GetType());   //flout
            Console.WriteLine(123f.GetType());     //flout
            Console.WriteLine(123m.GetType());     //decimal
            Console.WriteLine(delimiter1);
            Console.WriteLine('+'.GetType());      //
            Console.WriteLine("Hello".GetType());  //  
#endif
            #region MyRegion
            //Console.WriteLine(((byte)5).GetType().Name);
            //byte a = 2;
            //uint b = uint.MaxValue;
            //Console.WriteLine(a + "\t" + b);
            //a = (byte)b; //
            //Console.WriteLine(a + "\t" + b);
            #endregion

            try
            {
                int a = int.MaxValue;
                uint b = uint.MaxValue;
                Console.WriteLine(a + b);
                Console.WriteLine((a + b).GetType().Name);
                long c = long.MaxValue;
                Console.WriteLine(b + c);
                Console.WriteLine((b + c).GetType().Name);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Buy");
        }
    }
}
