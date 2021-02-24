using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintProfile("김현수", "010-4942-0767");
            // 일반적인 호출 (매개변수 순서에 맞춰 입력)
            if (PrintProfile(null, "010-1111-2222") == -1)
            {
                Console.WriteLine("프로필 출력 시 오류 발생!");
            }

            PrintProfile(phone: "010-4942-0767", name: "김현수");
            // 명명된 매개변수 

            PrintProfile("홍길동");
            // 매개변수 디폴트값 설정 가능 
        }

       

        public static int PrintProfile(string name, string phone = "010-7979-2424")
        {
            if (string.IsNullOrEmpty(name)) {
                Console.WriteLine("이름을 정확히 입력하세요.");
                return -1;  // 더 이상 함수를 실행하지 않고 리턴(void) 
            }
            
            Console.WriteLine($"이름 : {name}, 폰번호 : {phone}");
            return 0;
        }
    }
}
