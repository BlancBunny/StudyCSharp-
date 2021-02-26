using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesApp
{
    class Circle
    {
        private int radius;
        private double pi = 3.14;
        
        public Circle(int radius)
        {
            this.radius = radius;
        }

        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public double Pi
        {
            get { return pi; }
            set { pi = value; }
        }

        public double Round()
        {
            return 2 * this.radius * this.pi;
        }
        
        public double Area()
        {
            return this.pi * this.radius * this.radius;
        }
         
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle o = new Circle(3);
            o.Pi = 3.141592f;  // -> o.SetPi(3.141592f);
            double piValue = o.Pi;  // -> piValue = o.getPi();
            Console.WriteLine(piValue);
            Console.WriteLine($"원의 둘레는 {o.Round()}");
            Console.WriteLine($"원의 넓이는 {o.Area()}");
            
        }
    }
}
