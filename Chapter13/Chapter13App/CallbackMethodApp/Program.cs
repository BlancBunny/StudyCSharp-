using System;

namespace CallbackMethodApp
{
    delegate int MyDelegate(int a, int b);
    class Program
    {
        public static void Calculator (int a, int b, MyDelegate dele)
        {
            Console.WriteLine(dele(a,b));
        }
        public static int plus(int a, int b) { return a + b; }
        public static int minus(int a, int b) { return a - b; }
        public static int multifle(int a, int b) { return a * b; }
        static void Main(string[] args)
        {
            MyDelegate Plus = new MyDelegate(plus);
            MyDelegate Minus = new MyDelegate(minus);
            MyDelegate Multifle = new MyDelegate(multifle);

            Calculator(11, 22, Plus);
            Calculator(11, 22, Minus);
            Calculator(11, 22, Multifle);
        }
    }
}
