using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateChain2App
{
    class Program
    {
        delegate void ThereIsAFire(string location); // 대리자 

        static void Call119(string location)
        {
            Console.WriteLine($"119에 화재발생 주소 전송 : {location}");
        }

        static void ShotOut(string location)
        {
            Console.WriteLine($"화재발생 대피! {location}에 화재발생");
        }

        static void Escape(string location)
        {
            Console.WriteLine($"{location}에서 탈출");
        }

        static void Main(string[] args)
        {
            ThereIsAFire fire = new ThereIsAFire(ShotOut);
            fire += Call119;
            fire += Escape;

            fire("교실");
        }
    }
}
