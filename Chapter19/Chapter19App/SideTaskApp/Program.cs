using System;
using System.Threading;

namespace SideTaskApp
{
    class SideTask
    {
        int Count { get; set; }
        
        public SideTask(int count)
        {
            this.Count = count;
        }

        public void KeepAlive()
        {
            while(Count>0)
            {
                Console.WriteLine($"{Count} 남음");
                Count--;
                Thread.Sleep(10);
            }
            Console.WriteLine($"Count : {Count}");
        }

        public void CountDown()
        {
            while(Count>0)
            {
                Console.WriteLine($"{Count} 남음");

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SideTask task = new SideTask(100);
            Thread th = new Thread(task.CountDown);
        }
    }
}
