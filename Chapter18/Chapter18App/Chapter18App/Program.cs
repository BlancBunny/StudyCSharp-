using System;

namespace Chapter18App
{
    class Program
    {
        // var tmp2 = "x" var 타입은 지역변수 전용
        static void Main(string[] args)
        {
            Console.WriteLine("문자열 연습 시작");

            string message1 = null;
            Console.WriteLine($"null 문자열 : {message1}");
            string message2 = string.Empty;
            Console.WriteLine($"null 문자열 : {message2}");

            string oldPath = "C:\\Program Files\\Bandizip";
            string newPath = @"C:\Program Files\Bandizip";

            var tmp1 = "Local Variable String";

            char[] letters = { 'h', 'e', 'l', 'l', 'o' };
            string hello = new string(letters);
            Console.WriteLine(hello);
        }
    }
} 