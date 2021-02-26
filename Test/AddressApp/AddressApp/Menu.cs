using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressApp
{
    class Menu
    {
        AddressEdit ae = new AddressEdit();
        public void Start()
        {
            while (true)
            {
                PrintMenu();
                int menu = SelectMenu();
                System.Console.Clear();
                switch (menu)
                {
                    case 0:
                        // 주소 입력 
                        ae.InputAddress();
                        break;
                    case 1:
                        // 주소 검색 
                        ae.SelectAddress();
                        break;
                    case 2:
                        // 주소 수정 
                        ae.UpdateAddress();
                        break;
                    case 3:
                        // 주소 삭제 
                        ae.DeleteAddress();
                        break;
                    case 4:
                        // 주소 전체 출력 
                        ae.PrintAddress();
                        break;
                    case 5:
                        // 프로그램 종료 
                        System.Console.WriteLine("프로그램이 종료되었습니다.");
                        Environment.Exit(0);
                        break;
                    default:
                        System.Console.WriteLine("올바른 숫자를 입력하세요.");
                        break;

                }
            }
            void PrintMenu()
            {
                System.Console.WriteLine("==================");
                System.Console.WriteLine("0. 주소록 입력");
                System.Console.WriteLine("1. 주소록 검색");
                System.Console.WriteLine("2. 주소록 수정");
                System.Console.WriteLine("3. 주소록 삭제");
                System.Console.WriteLine("4. 주소록 전체 출력");
                System.Console.WriteLine("5. 프로그램 종료");
                System.Console.WriteLine("==================");

            }
            int SelectMenu()
            {
                bool a;
                System.Console.Write("메뉴를 선택하세요 >>> ");
                a = int.TryParse(System.Console.ReadLine(), out int menu);
                if (!a) menu = -1;
                return menu;
            }
        }
    }
}
