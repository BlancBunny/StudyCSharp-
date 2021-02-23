using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
           /* // while
            int a = 10;
            while (a>0)
            {
                Console.WriteLine($"숫자는 {a--}");
                a -= 2;
            }
            Console.WriteLine("출력 종료!");

            do // do-while : 최초 1회 실행 후 조건문 검사 
            {
                Console.WriteLine($"숫자 {a}");
                a++;
            } while (a < 10);
           
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"i 값은 {i}");
            }*/

            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.Write($"{i} x {j} = {i*j} ");
                }
                Console.WriteLine();
            }
        }


    }
}
