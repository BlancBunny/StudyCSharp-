using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int v1 = 30, v2 = 40;
            int result = v1 + v2;
            Console.WriteLine("결과는 " + result);*/
            sbyte sbMinVal = sbyte.MinValue;
            sbyte sbMaxVal = sbyte.MaxValue;
            Console.WriteLine($"sbyte 최소, 최대값은 {sbMinVal}, {sbMaxVal} 입니다.");
            byte bMinVal = byte.MinValue, bMaxVal = byte.MaxValue;
            Console.WriteLine($"byte 최소, 최대값은 {bMinVal}, {bMaxVal} 입니다");
            // short 
            short sMinVal = short.MinValue, sMaxVal = short.MaxValue;
            Console.WriteLine($"short 최소, 최대값은 {sMinVal}, {sMaxVal} 입니다");
            ushort usMinVal = ushort.MinValue, usMaxVal = ushort.MaxValue;
            Console.WriteLine($"ushort 최소, 최대값은 {usMinVal}, {usMaxVal} 입니다");
            // int 
            int inMinVal = int.MinValue, inMaxVal = int.MaxValue;
            Console.WriteLine($"int 최소, 최대값은 {inMinVal}, {inMaxVal} 입니다");
            uint uiMinVal = uint.MinValue, uiMaxVal = uint.MaxValue;
            Console.WriteLine($"uint 최소, 최대값은 {uiMinVal}, {uiMaxVal} 입니다");
            // long
            long lMinVal = long.MinValue, lMaxVal = long.MaxValue;
            Console.WriteLine($"long 최소, 최대값은 {lMinVal}, {lMaxVal} 입니다");
            ulong ulMinVal = ulong.MinValue, ulMaxVal = ulong.MaxValue;
            Console.WriteLine($"ulong 최소, 최대값은 {ulMinVal}, {ulMaxVal} 입니다");
        }
    }
}
