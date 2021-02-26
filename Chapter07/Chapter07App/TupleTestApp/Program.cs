using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var tuple1 = (1, "성명건", "010-6683-7732", "부산시 해운대구", true);
            var tuple2 = (idx: 2, name: "홍길동", phone: "010-9999-9999", address: "부산시 사하구", marriage: false);
            Console.WriteLine($"{tuple1.Item1} / {tuple1.Item2} / {tuple1.Item3} / {tuple1.Item4} / {tuple1.Item5}");
            Console.WriteLine($"{tuple2.idx} / {tuple2.name} / {tuple2.phone} / {tuple2.address} / {tuple2.marriage}");
        }
    }
}
