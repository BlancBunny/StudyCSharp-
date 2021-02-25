using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideTestApp
{
    class ArmorSuite
    {
        public virtual void Initialize()
        {
            Console.WriteLine("ArmorSuite initialize");
        }
    }
    
    class WarMachine : ArmorSuite
    {
        public sealed override void Initialize()
            // 재정의된 함수 봉인 : 서브 클래스에서 재정의 불가능 
        {
            base.Initialize(); // 부모(오버라이딩 전) 메소드 실행
            // base : this의 부모 버전 
            Console.WriteLine("Weapon1 added"); // 오버라이딩 : 행위 추가 
            Console.WriteLine("Weapon2 added");  
        }
    }
    
    class SupportMachine : ArmorSuite
    {
          
        public sealed override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("Support tool added");
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ArmorSuite Product");
            ArmorSuite suite = new ArmorSuite();
            suite.Initialize();
            Console.WriteLine("");
            Console.WriteLine("WarMachine Product");
            WarMachine machine1 = new WarMachine();
            machine1.Initialize();
            Console.WriteLine("");
            Console.WriteLine("SupportMachine Product");
            SupportMachine machine2 = new SupportMachine();
            machine2.Initialize();
        }
    }
}
