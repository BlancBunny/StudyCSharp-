using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;


namespace ArrayListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList();
            array.Add(80);
            array.Add(40);
            array.Add(20);
            array.Add(60);
            array.Add(10);

            var loc = array.IndexOf(40);

        }
    }
}
