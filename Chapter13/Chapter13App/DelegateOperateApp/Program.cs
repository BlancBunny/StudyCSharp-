using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateChain
{
    class Program
    {
        delegate void CalcDelegate(int x, int y);

        static void Add(int x, int y) { Console.WriteLine(x+y); }
        static void Substract(int x, int y) { Console.WriteLine(x - y); }
        static void Multiple(int x, int y) { Console.WriteLine(x * y); }
        static void Divide(int x, int y) { Console.WriteLine(x / y); }
        static void Main(string[] args)
        {

            // 델리게이트 예약어 
            CalcDelegate calc = Add;
            calc += Substract;
            calc += Multiple;
            calc += Divide;

            // 함수 1회 실행으로 4회 실행 효과 
            calc(10, 5);
        }
    }
}
