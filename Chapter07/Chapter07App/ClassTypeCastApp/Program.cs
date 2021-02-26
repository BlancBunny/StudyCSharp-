using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTypeCastApp
{

    class Mammal {  }
    class Dog : Mammal {  }
    class Cat : Mammal {  }


    class Program
    {
        static void Main(string[] args)
        {
            Mammal m1 = new Dog();
            
            if (m1 is Dog)   // m1은 강아지 클래스 Dog()로 만들었으므로 형변환 가능
            {
                Console.WriteLine("m1 is dog");
            }
            else Console.WriteLine("m1 is not dog");

            if (m1 is Cat)   // m1은 강아지 클래스로 만들었으므로 
                             // 고양이형으로 변환 할 수 없음
            {
                Console.WriteLine("m1 is cat");
            }
            else Console.WriteLine("m1 is not cat");

            Mammal m2 = new Cat();
            Dog dog;
            Cat cat;
            
            // m2는 Cat 형 
            dog = m2 as Dog;
            
            // Console.WriteLine(dog.GetType());
            // => Cat 타입 객체를 Dog 타입으로 형변환 할수 없음
            cat = m2 as Cat;
            
            
            
            

            if (dog != null) Console.WriteLine("m2 is dog");
            else Console.WriteLine("m2 is not dog");
      

            if (cat != null) Console.WriteLine("m2 is cat");
            else Console.WriteLine("m2 is not cat");



        }
    }
}
