using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infiniteLoopApp
{
    class Program
    {

        int Cal(int a, int b)
        {
            int result = 0;
            return result;
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 3) continue;
                if (i == 7) break;
                Console.WriteLine(i);
                
            }
        }
    }
}

