using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcTestApp
{

    class Mathz
    {
        public int Plus (int a, int b)
        {
            return a + b;
        }

        public void PrintEven(int val)
        {
            if (val % 2 == 0)
            {
                Console.WriteLine($"값 : {val}");
            }
        }

    } 

    class Program
    {
        static void Main(string[] args)
        {
            // ...

            int x;

            // ...


            /*
            if (x % 2 == 0)
                        {
                            Console.WriteLine($"x의 값 : {x}");
                        }*/
            x = 5;
            Mathz mathz = new Mathz();
            mathz.PrintEven(x);

            // ...

            x = 10;
            mathz.PrintEven(x);

            
        }
    }
}
