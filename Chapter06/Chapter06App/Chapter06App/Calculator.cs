using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter06App
{
    class Calculator
    {

        
        static void Main(string[] args)
        {
            int x = Calculator.Plus(3, 4);
            int y = Calculator.Plus(5, 6);
            int z = Calculator.Plus(7, 8);

            int result = x + y + z;
            Console.WriteLine($"결과는 {result}");
        }
        private static int Plus(int a, int b)
        {
            Console.WriteLine($"Input : {a} {b}");
            return a + b;
        }

    }
}
