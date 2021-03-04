using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressApp
{
    class AddressEdit
    {
        // 입력, 검색, 수정, 삭제, 전체 출력
        public void InputAddress(ref List<Address> list)
        {
            Address a = new Address(ReadWrite("이름"), ReadWrite("전화번호"), ReadWrite("주소"));
            if (CheckNull(a.Name, a.Phone, a.Addr)) return;
            else {
                list.Add(a);
                Console.Clear();
                Console.WriteLine($"{a.Name} 입력 완료");
        }
            
        } // 입력
        public void SelectAddress(ref List<Address> list)
        {
            string name = ReadWrite("이름");
            if (CheckNull(name)) return;
            else
            {
                Console.WriteLine($"{name} 검색 결과 없음");
                for (int i = 0; i < list.Count; i++)
                {
                    if (name == list[i].Name)
                    {
                        Console.Clear();
                        Console.WriteLine($"{name} 검색 결과");
                        Console.WriteLine("----------------------------");
                        Console.WriteLine($"이름 : {list[i].Name}");
                        Console.WriteLine($"전화번호 : {list[i].Phone}");
                        Console.WriteLine($"주소 : {list[i].Addr}");
                        Console.WriteLine("----------------------------");
                        break;
                    }

                }
            }
        } // 검색
        public void UpdateAddress(ref List<Address> list)
        {
            string name = ReadWrite("이름");
            if (CheckNull(name)) return;
            else
            {
                Console.WriteLine($"{name} 검색 결과 없음");
                for (int i = 0; i < list.Count; i++)
                {
                    if (name == list[i].Name)
                    {
                        Console.Clear();
                        Console.WriteLine($"{name} 검색 결과");
                        Console.WriteLine("----------------------------");
                        Console.WriteLine($"현재 이름 : {list[i].Name}");
                        Console.WriteLine($"현재 전화번호 : {list[i].Phone}");
                        Console.WriteLine($"현재 주소 : {list[i].Addr}");
                        Console.WriteLine("----------------------------");
                        break;
                    }
                }
                for (int i = 0; i < list.Count; i++)
                {
                    if (name == list[i].Name)
                    {
                        name = ReadWrite("변경할 이름");
                        string phone = ReadWrite("변경할 전화번호");
                        string addr = ReadWrite("변경할 주소");
                        if(CheckNull(name, phone, addr)) return;
                        else
                        {
                            list[i].Name = name;
                            list[i].Phone = phone;
                            list[i].Addr = addr;
                            Console.Clear();
                            Console.WriteLine($"{name} 수정 완료");
                            
                        }
                        break;
                    }
                }
            }


        } // 수정
        public void DeleteAddress(ref List<Address> list)
        {
            {
                string name = ReadWrite("이름");
                if (CheckNull(name)) return;
                else
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (name == list[i].Name)
                        {
                            Console.WriteLine("----------------------------");
                            Console.WriteLine($"이름 : {list[i].Name}");
                            Console.WriteLine($"전화번호 : {list[i].Phone}");
                            Console.WriteLine($"주소 : {list[i].Addr}");
                            Console.WriteLine("----------------------------");
                            Console.Write("Delete? [y/n] : ");
                            string del = Console.ReadLine();
                            if (del == "y" || del == "Y")
                            {
                                list.RemoveAt(i);
                                Console.Clear();
                                Console.WriteLine($"{name} 삭제 완료");
                                break;
                            }
                            Console.Clear();
                            Console.WriteLine($"{name} 삭제되지 않음");
                        }
                    }
                }
            }
        } // 삭제
        public void PrintAddress(ref List<Address> list)
        {
            Console.WriteLine("주소록 전체 출력");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"-----------[{i+1}]--------------");
                Console.WriteLine($"이름 : {list[i].Name}");
                Console.WriteLine($"전화번호 : {list[i].Phone}");
                Console.WriteLine($"주소 : {list[i].Addr}");
            }
        } // 전체 출력
        public string ReadWrite(string msg) 
        {
            Console.Write($"{msg} 입력 : ");
            string attribute = Console.ReadLine();
            return attribute;
        } // msg : [사용자 입력값] <- 반환 
        public bool CheckNull(string a)
        {
            if (string.IsNullOrEmpty(a))
            {
                Console.Clear();
                Console.WriteLine("오류 : 값이 입력되지 않았습니다.");
                return true;
            }
            else return false;
        } // 문자열을 검사하여 NULL이면 true 반환 
        public bool CheckNull(string a, string b, string c)
        {
            if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b) || string.IsNullOrEmpty(c))
            {
                Console.Clear();
                Console.WriteLine("오류 : 입력되지 않은 값이 있습니다.");
                return true;
            }
            else
            {
                return false;
            }
        } // NULL 검사 (3인수) 
    }
}
