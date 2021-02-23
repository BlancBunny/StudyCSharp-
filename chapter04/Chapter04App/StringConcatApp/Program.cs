using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConcatApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int p2 = 456;
            Console.WriteLine("숫자 더하기");
            Console.WriteLine(123+p2);
            Console.WriteLine("123"+p2);
            Console.WriteLine("123"+"456");
            Console.WriteLine($"123{p2}");

            int a = 30, b = 30;
            Console.WriteLine(a<b);
            Console.WriteLine(a>b);
            Console.WriteLine(a==b);
            Console.WriteLine(a!=b);

            Console.WriteLine(10 > 9 && a > 0);

            // 삼항연산자
            int c = 30;
            string result = (c == 30) ? "삼십" : "삼십아님";
            Console.WriteLine(result);


        }
    }
}
