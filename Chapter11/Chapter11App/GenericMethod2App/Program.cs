using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassApp
{
    class ArrayGeneric<T>
    {
        private T[] array;

        public ArrayGeneric()
        {
            array = new T[10];
        }

        public T getElement(int index) { return array[index]; }
        public int Length { get { return array.Length; } }
    }


    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
