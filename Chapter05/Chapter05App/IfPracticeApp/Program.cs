using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfPracticeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("수를 입력하세요 : ");
                string line = Console.ReadLine();

                if (line == "quit") break;
                
                // int number = int.Parse(line);
                int number = 0;
                int.TryParse(line, out number);
                // Console.WriteLine(number);
                if (number >= 0)
                {
                    if (number % 2 == 0) Console.WriteLine("양의 짝수");
                    else Console.WriteLine("양의 홀수");
                }
                else Console.WriteLine("0보다 작은 수");
            }
            Console.WriteLine("계산 종료!");
        }
    }
}
