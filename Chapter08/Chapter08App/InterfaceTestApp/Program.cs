using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTestApp
{
    interface ILogger
    {
        void WriteLog(string msg);
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string msg)
        {
            Console.WriteLine($"[{DateTime.Now.ToShortDateString()}] log - {msg}");
        }
    }

    class CustomLogger : ILogger
    {
        public void WriteLog(string msg)
        {
            Console.WriteLine($"log - {msg}\a\a");
        }
    }
    class ClimateLogger
    {
        private ILogger logger;
        public ClimateLogger(ILogger logger)
        {
            this.logger = logger; 
        }
        public void Start()
        {
            while(true)
            {
                Console.Write($"온도를 입력 : ");
                string temp = Console.ReadLine();
                if (string.IsNullOrEmpty(temp)) break;
                logger.WriteLog($"현재온도 : {temp}도");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();
            logger.WriteLog("new log 1");
            // 내가 직접 코드로 로그를 입력 

            ClimateLogger clogger = new ClimateLogger(new CustomLogger());
            clogger.Start();
            // 프레임워크(ClimateLogger)가 로그를 입력 
            // IoC (Inversion of Control) : 제어 역전 
        }
    }
}
