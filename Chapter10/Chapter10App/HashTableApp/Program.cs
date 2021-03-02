using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hashtable 예제");
            Hashtable ht = new Hashtable();
            ht["일"] = "One";

            Console.WriteLine(ht["일"]);
        }
    }
}
