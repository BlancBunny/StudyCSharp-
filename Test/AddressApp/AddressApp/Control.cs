using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace AddressApp
{
    class Control
    {
        public void Start(ref List<Address> list)
            {
            AddressEdit ae = new AddressEdit();
            while (true)
                {
                    
                    PrintMenu();
                    int menu = SelectMenu();
                    System.Console.Clear();
                    switch (menu)
                    {
                        case 0:
                            // 주소 입력 
                            ae.InputAddress(ref list);
                            break;
                        case 1:
                            // 주소 검색 
                            ae.SelectAddress(ref list);
                            break;
                        case 2:
                            // 주소 수정 
                            ae.UpdateAddress(ref list);
                            break;
                        case 3:
                            // 주소 삭제 
                            ae.DeleteAddress(ref list);
                            break;
                        case 4:
                            // 주소 전체 출력 
                            ae.PrintAddress(ref list);
                            break;
                        case 5:
                            // 프로그램 종료 
                            System.Console.WriteLine("프로그램이 종료되었습니다.");
                            return;
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

            
            } // 프로그램 메인 루프 (while)
        public List<Address> ListLoad()
            {
                List<Address> list = new List<Address>();
                using (FileStream fs = new FileStream("address.dat", FileMode.OpenOrCreate, FileAccess.Read))
                {
                    StreamReader sr = new StreamReader(fs);
                    while (sr.EndOfStream == false)
                    {
                        var temp = sr.ReadLine(); 
                        string[] splits = temp.Split('|');
                        list.Add(new Address() { Name = splits[0], Phone = splits[1], Addr = splits[2] });
                    }
                    // 파일로부터 리스트 작성
                    fs.Close();
                    return list;
                }
            } // 파일 -> 리스트
        public void ListSave(List<Address> list)
            {
                using (FileStream fs = new FileStream("address.dat", FileMode.Truncate, FileAccess.Write))
                {
                    // 리스트를 파일로 저장
                    StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                    for (int i = 0; i < list.Count; i++)
                    {
                        sw.WriteLine($"{list[i].Name}|{list[i].Phone}|{list[i].Addr}");
                        sw.Flush();
                    }
                }
            } // 리스트 -> 파일
    }
}
