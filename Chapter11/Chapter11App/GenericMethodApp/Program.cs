using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethodApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] source = { 11, 21, 33, 45, 56 };
            int[] target = new int[source.Length];

            Copyarray(source, target);
            Console.WriteLine("배열 복사");
            foreach (var item in target)
            {
                Console.WriteLine("item");
            }

            string[] source2 = { "일", "이", "삼", "사", "오" };
            string[] target2 = new string[source2.Length];

            Copyarray(source2, target2);
            Console.WriteLine("string 배열 복사");
            foreach (var item in target2)
            {
                Console.WriteLine(item);
            }
        }
/*
        private static void Copyarray(int[] source, int[] target)
        {
            for (int i = 0; i< source.Length; i++)
            {
                target[i] = source[i];
            }
        }
        private static void Copyarray(string[] source, string[] target)
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }
        타입별로 여러번 중복정의하는 상황을 막기 위해 
        제네릭 타입을 활용 
        
*/ 
        private static void Copyarray<T>(T[] source, T[] target)
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }
    }
}
