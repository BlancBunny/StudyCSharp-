using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOutTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 22, b = 3;
            int val = 0; // out은 이전 변수 초기화 무시 (불필요한 값 할당) 
            int rem = 0; // ref는 반드시 사용 전 초기화 필요 
            Divide(a, b, out val, ref rem);
      
            #region ref / out 차이 정리
            /*
                C# 의 기본 데이터 형식 매개 변수는 값.
                두 한정자 모두 참조에 의한 함수 호출에 사용됨 
            
                ref는 함수 밖에서 변수 초기화 필수 
                함수 내에서 참조 혹은 값의 변경이 가능함 
                함수 내부와 외부에서 변수를 같이 사용할 경우 사용 

                out은 함수 내에서 변수 초기화가 이루어짐 
                이전에 변수 초기화가 불필요하며, 이미 이루어진 변수값 무시 
                사용영역이 특정 함수에만 국한 될 때 사용 
             */
            #endregion



            Console.WriteLine($"Input : {a}, {b} / a/b : {val} / a%b : {rem}");
        }

        static void Divide(int a, int b, out int quot, ref int remain)
        {
            quot = a / b;
            remain = a % b;
            return;
        }
    }
}
