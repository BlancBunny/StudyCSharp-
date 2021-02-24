using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticFieldApp
{
    class MyClass        // 인스턴스 소속 필드
    {
        public int a;
        public int b;
        public void Method()
        {
            Console.WriteLine("인스턴스 메소드 호출");
            // 인스턴스 변수(a,b) 와 관련된 작업을 하는 메소드
        }
    }

    class Card
    {
        public string shape;
        public short number;

        // 문양, 숫자 | 뒷면, 가로세로 길이, 두께 
        public Card() { }
        public Card(string shape, short number)  // 생성자 오버로딩 
        {
            this.shape = shape;
            this.number = number;
        }

        public static void Back()
        {
            Console.WriteLine("뒷면은 하트모양");
        }
        public static void Large()
        {
            Console.WriteLine("크기는 A4");
        }


    }

    

    class MyClass_static        
        // 클래스 소속 필드 : 프로그램 전체에 공유하는 변수에 사용 
    {
        public static int a;
        public static int b;
        
        public static void StaticMethod()
        {
            Console.WriteLine("정적 메소드 호출");
            // 인스턴스 멤버와 관련 없는 작업을 하는 메소드 
            // ex) Math.Random()
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Card card1 = new Card("하트", 9);
            Console.WriteLine(card1.number);
            Card card2 = new Card(shape: "클로버", number: 11);
            Card card3 = new Card();
            Card card4 = new Card();
            Card card5 = new Card();

        
            MyClass obj = new MyClass();
            obj.a = 1;
            obj.b = 2;
            obj.Method();
             // MyClass.a = 1;  -> 오류: static이 아닌 속성에 개체 참조가 필요함


            MyClass_static.a = 1;
            MyClass_static.b = 2;
            MyClass_static.StaticMethod();

        }
    }
}
