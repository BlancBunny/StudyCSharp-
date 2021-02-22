using System;

namespace ConstTestApp
{
    class Program
    {

        enum Season
        {
            Spring = 1000,
            Summer = 2000,
            Fall = 3000,
            Winter = 4000
        }
        static void Main(string[] args)
        {
            Console.WriteLine("상수테스트");
            const double pi = 3.141592;  //  상수 (불변)
            Console.WriteLine($"원주율의 값은 {pi}");
            Season mySeason = Season.Summer;
            Console.WriteLine($"지금 계절은 {mySeason} 입니다");
            
            int? a = 2;
        
            Console.WriteLine($"a = {a.HasValue}"); 

        }
    }
}
