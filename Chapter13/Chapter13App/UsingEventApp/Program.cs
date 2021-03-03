using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingEventApp
{
    delegate void EventHandler(string message);
    class CustomNotifier
    { // 이벤트 선언, 사용하는 객체 
        public event EventHandler SomeThing;

        public void DoSomething (int number)
        {
            int temp = number % 10;
            if(temp != 0 && temp % 3 == 0) // temp 일의자리가 3? 
            {
                SomeThing($"{number} : 짝!"); 
            }


        }
    }
    class Program
    {
        /// <summary>
        /// 이벤트가 발생했을때 실행되는 메서드 (이벤트 핸들러)
        /// </summary>
        /// <param name="message"></param>
        public static void MyHandler (string message)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("이벤트 사용!");
            CustomNotifier notifier = new CustomNotifier();
            notifier.SomeThing += new EventHandler(MyHandler);

            for (int i = 1; i<=100; i++)
            {
                notifier.DoSomething(i);
            }
        }
    }
}
