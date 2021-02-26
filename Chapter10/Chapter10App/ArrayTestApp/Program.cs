using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTestApp
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[5] { 80, 420, 280, 180, 240 };
            // 원시적인 방법 
            /*array[0] = 80;
            array[1] = 420;
            array[2] = 280;
            array[3] = 180;
            array[4] = 240;

            Console.WriteLine($"0 : {array[0]}");
            Console.WriteLine($"1 : {array[1]}");
            Console.WriteLine($"2 : {array[2]}");
            Console.WriteLine($"3 : {array[3]}");
            Console.WriteLine($"4 : {array[4]}");*/

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }
            var idx = 0;
            foreach (var item in array)
            {
                Console.WriteLine($"{idx++}번째 값 : {item}");
            }

            Console.WriteLine("오름차순 정렬");
            Array.Sort(array);  
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }
            Console.WriteLine("오름차순 정렬");
            Array.Reverse(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }

            int idx2 = Array.IndexOf(array, 280);
            Console.WriteLine($"280의 인덱스 : {idx2}");

            idx2 = Array.IndexOf(array, 32);
            Console.WriteLine($"32의 인덱스 : {idx2}");

        }
    }
}

