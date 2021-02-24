using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifierApp
{
    class Boiler
    {
        internal int temp = 5;

        public void SetTemp(int temp)
        {
            if (temp < 30 || temp > 60)
            {
                Console.WriteLine("물의 온도가 범위를 벗어남");
                return;
            }
            this.temp = temp;
        }

        public int GetTemp()
        {

            return this.temp;
        }

        public void TurnOnBoiler()
        {
            Console.WriteLine("보일러를 켭니다.");
        }
        public void TurnOffBoiler()
        {
            Console.WriteLine("보일러를 끕니다.");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Boiler kitturami = new Boiler();
            kitturami.SetTemp(40);
            kitturami.TurnOnBoiler();
            kitturami.SetTemp(59);
            Console.WriteLine($"현재 온도는 {kitturami.GetTemp()}도 입니다"); 
            kitturami.TurnOffBoiler();
            Console.WriteLine($"현재 온도는 {kitturami.GetTemp()}도 입니다");
            
        }
    }
}
