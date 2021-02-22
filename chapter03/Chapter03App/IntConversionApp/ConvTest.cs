using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntConversionApp
{
    class ConvTest
    {
        static void Main(string[] args)
        {
            short shMaxVal = short.MaxValue;
            int inCastVal = 0;

            inCastVal = shMaxVal;
            Console.WriteLine($"short값 변환한 int값 : {inCastVal}");

            inCastVal += 5;
            short shCastVal = (short)inCastVal;
            Console.WriteLine($"int 값 변환한 short 값 : {shCastVal}");

            // float, double (실수형) 
            float flVal = 3.141592f;
            inCastVal = (int)flVal;
            Console.WriteLine($"float값 변환한 int 값 : {inCastVal}");
            
            // obj : 
            object obj = 20; // boxing 
            int intUnboxingVal = (int)obj;

            // str -> int 
            string strVal = "200";
            int result = int.Parse(strVal) * 3;
            Console.WriteLine($"result = {result}");
        }
    }
}
