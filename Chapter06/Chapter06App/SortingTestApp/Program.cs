using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 45, y = 3;
            Console.WriteLine($"x={x}, y={y}");

            Swap(ref x, ref y); // C언어의 포인터 개념 
            Console.WriteLine($"x={x}, y={y}");
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
