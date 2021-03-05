using System;
using System.Threading;

namespace BasicThread
{
    
    class Program
    {
        static void DoSomething()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"Do Something : {i}");
                Thread.Sleep(10);
            }
        }

        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(DoSomething));
            Console.WriteLine("스레드 시작");
            t1.Start();

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"Main Thread : {i}");
                Thread.Sleep(10);
            }

            Console.WriteLine("스레드 종료 대기");
            t1.Join();

            Console.WriteLine("프로세스 종료");

        }
    }
}
