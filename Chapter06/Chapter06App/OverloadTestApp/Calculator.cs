using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadTestApp // 메소드 오버로딩 : 같은 이름의 메소드를 
                          // 다른 자료형의 같은 동작으로 만들 수 있다. 
{
    class Calculator
    {
        static void Main(string[] args)
        {
            int x = Calculator.Plus(3, 4);
            Console.WriteLine($"3 + 4 = {x}");
            float y = Calculator.Plus(3.4f, 4.12f);
            Console.WriteLine($"3.4 + 4.12 = {y}");
            double z = Calculator.Plus(6.122, 2.24);
            Console.WriteLine($"6.122 + 2.24 = {z}");
            Console.WriteLine($"{Calculator.Plus(3.14, "5")}");

            int w = Calculator.Plus(3, 4, 5);
            Console.WriteLine($"3+4+5={w}");

            // 가변길이 매개변수 
            Console.WriteLine(Sum(1,3,4,5,6,7));

        }

        private static int Sum(params int[] args)
        {
            int result = 0;
            foreach (var item in args)
            {
                result += item;
            }
            return result;
        }

        private static int Plus(int v1, int v2, int v3)
        {
            return v1 + v2 + v3;
        }

        private static object Plus(double v1, string v2)
        {
            double.TryParse(v2, out double p2);
            return v1 + p2;
        }
        private static double Plus(double v1, double v2)
        {
            return v1 + v2;
            // throw new NotImplementedException();
        }
        private static float Plus(float v1, float v2)
        {
            return v1 + v2;
            //throw new NotImplementedException();
        }
        private static int Plus(int v1, int v2)
        {
            return v1 + v2;
            // throw new NotImplementedException();
        }
    }
}
