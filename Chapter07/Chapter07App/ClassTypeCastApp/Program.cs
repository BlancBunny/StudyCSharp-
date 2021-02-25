using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTypeCastApp
{

    class Mammal { }
    class Dog : Mammal { }
    class Cat : Mammal { }


    class Program
    {
        static void Main(string[] args)
        {
            Mammal m1 = new Dog();
            Dog dog;
            Cat cat;

            if (m1 is Dog)   // m1은 포유류(Super) 이므로 강아지(Sub) 형으로 변환 가능 
            {
                dog = (Dog)m1; // m1 : 포유류 -> 강아지 형변환하여 dog에 저장
                Console.WriteLine("m1 is dog");
            }
            else Console.WriteLine("m1 is not dog");

            if (m1 is Cat)   // m1은 강아지이므로 고양이 형으로 변환 불가능
            {
                cat = (Cat)m1;
                Console.WriteLine("m1 is cat");
            }
            else Console.WriteLine("m1 is not cat");


            Mammal m2 = new Cat();
            Console.WriteLine(m2.GetType()); 
            // m2는 Cat 형 
            dog = m2 as Dog;
            // Console.WriteLine(dog.GetType());
            // => Cat 타입 객체를 Dog 타입으로 형변환 할수 없음
            cat = m2 as Cat;
            
            Console.WriteLine(cat.GetType());

            if (dog != null) Console.WriteLine("m2 is dog");
            else Console.WriteLine("m2 is not dog");
      

            if (cat != null) Console.WriteLine("m2 is cat");
            else Console.WriteLine("m2 is not cat");



        }
    }
}
