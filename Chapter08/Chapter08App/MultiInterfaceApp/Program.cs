using System;

namespace MultiInterfaceApp
{
    interface IRunnerable // 지상
    {
        void Run();
    }

    interface IFlyable // 공중 
    {
        void Fly();
    }

    class DroneCar : IRunnerable, IFlyable // 다중 인터페이스 
    {
        public void Run()
        {
            Console.WriteLine("Execute Run!");
        }

        public void Fly()
        {
            Console.WriteLine("Execute Fly!");
        }

        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Drone Test");
            DroneCar dc = new DroneCar();
            dc.Run();
            dc.Fly();

            Console.WriteLine("자동차로 변경(interface)");
            IRunnerable car = dc;  
            // dc는 IRunnerable, IFlyable의 메소드을 모두 가지고 있지만
            // car는 IRunnerable의 메소드만 가지므로 그 부분만 넘어간다 
            
            car.Run();
            // car.Fly();    << 에러 발생 
            

            Console.WriteLine("비행기로 변경(interface)");
            IFlyable plane = dc;
            plane.Fly();
        }
    }
}
