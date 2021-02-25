using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp
{

    class Parent
    {
        protected string name;
        public Parent() { }
        public Parent(string name)
        {
            this.name = name;
            Console.WriteLine($"{this.name}.Parent() 생성자");
        }

        public void ParentMethod()
        {
            //... 여기에 실제 함수 코드
            Console.WriteLine($"{this.name}.ParentMethod() 실행");
        }

        ~Parent()
        {
            Console.WriteLine($"{this.name} 소멸자 실행");
        }
    }

    class Child : Parent
    {
        private string color;
        public Child(string name, string color) : base(name)
        {
            this.color = color;
            Console.WriteLine($"{this.color}, {this.name}.Child() 생성자");
        }
        public void ChildMethod()
        {
            Console.WriteLine($"{color}, {name}.ChildMethod() 실행");
        }

        ~Child() {
            Console.WriteLine($"{this.color}, {this.name} 소멸자 실행");
        }
        // 소멸자 : 생성자의 반대 순서로 진행, 컴파일러가 자동으로 실행해줌
            
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Parent p = new Parent("Super Class");
            p.ParentMethod();
            Child c = new Child(name: "Sub Class", color: "Yellow");
            
            // 서브 클래스의 생성자가 실행 될때는 슈퍼 클래스의 생성자도 같이 실행된다. 
            // 그래서 부모 클래스의 name 변수에 접근할 수 있게 된다. 
            // 부모 클래스의 변수의 접근 제한자 protected(권장) / public 이어야 한다. 
            c.ParentMethod();
            c.ChildMethod();

        }
    }
}
