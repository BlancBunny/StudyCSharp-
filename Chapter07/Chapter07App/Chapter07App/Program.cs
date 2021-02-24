using System;

namespace Chapter07App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("객체 사용 기초");

            Cat cat1 = new Cat();
            cat1.name = "나비";
            cat1.Meow();

            Cat kitty = new Cat();
            kitty.name = "키티";
            kitty.color = "하얀색";
            kitty.Meow();

            Cat nero = new Cat();
            nero.name = "네로";
            nero.color = "검정색";
            nero.Meow();

            Cat enduring = new Cat(name: "enduring", color: "Gray");
            enduring.Meow();
        }
    }


    

    class Cat
    {
        public string name;         //  이름
        public string color;        //  색상
        public string gender;       //  성별

        public Cat() { } 
        public Cat(string name, string color) // 생성자 오버로딩 
        {
            this.name = name; // this : 참조된 객체를 가리키는 대명사
            this.color = color;
        }
        public Cat(string _name, string _color, string _gender) // 생성자 오버로딩 
        {
            this.name = _name;
            this.color = _color;
            this.gender = _gender;
        }

        
        public void Meow()
        {
            Console.WriteLine($"{this.name} | 색상 : {this.color} | 성별 : {this.gender}");
        }
    }
}
