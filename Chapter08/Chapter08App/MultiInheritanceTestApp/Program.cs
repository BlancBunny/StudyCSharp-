using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiInheritanceTestApp
{
    class Ridable
    {
        public virtual void Ride()
        {
            Console.WriteLine("탈것!");
        }
    }

    class Car : Ridable
    {
        public void Run()
        {
            Console.WriteLine("Run!");
        }
        public override void Ride()
        {
            base.Ride();
            this.Run();
        }
    }

    class Plane : Ridable
    {
        public void Fly()
        {
            Console.WriteLine("Fly");
        }
        public override void Ride()
        {
            base.Ride();
            this.Fly();
        }
    }

    /*class DroneCar : Plane, Car
    {
    << 다중 상속은 C# 에서 못하게 막아놓음 -> 인터페이스로 전환 >>
    }*/


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
