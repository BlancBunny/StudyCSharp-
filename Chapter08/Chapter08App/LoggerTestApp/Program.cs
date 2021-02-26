using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerTestApp
{
    interface ILogger
    {
        void WriteLog(string message);
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine($"{DateTime.Now} : {message}");
        }
    }

    interface IFormatableLogger : ILogger
    {
        void WriteLog(string format, params Object[] args);
    }

    class ConsoleFormatLogger : IFormatableLogger
    {
        
        public void WriteLog(string format, params object[] args)
        {
            string message = String.Format(format, args);
            Console.WriteLine($"{DateTime.Now.ToLocalTime()} / {message}");
        }

        public void WriteLog(string message)
        {
            Console.WriteLine($"{DateTime.Now} : {message}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ConsoleLogger 테스트");
            ConsoleLogger logger = new ConsoleLogger();
            logger.WriteLog("로그 메시지");

            ConsoleFormatLogger logger2 = new ConsoleFormatLogger();
            logger2.WriteLog("{0} * {1} = {2}", 3, 4, 12);
        }
    }
}
