using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 240;
            int result1 = a << 2; 
            int result2 = a >> 2;

            Console.WriteLine($"a = {a}, a << 2 = {result1}, a >> 2 = {result2}");
        }
    }
}
