using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressApp
{
    class AddressEdit
    {
        List<Address> addressArray = new List<Address>();
        // 입력, 검색, 수정, 삭제, 전체 출력
        public void InputAddress()
        {
            string name = ReadWrite("이름");
            string phone = ReadWrite("전화번호");
            string addr = ReadWrite("주소");
            Address a = new Address();
            a.Name = name;
            a.Phone = phone;
            a.Addr = addr;
            addressArray.Add(a);
            Console.Clear();
            Console.WriteLine($"{name} 입력 완료");
        }
        public void SelectAddress()
        {
            string name = ReadWrite("이름");
            Console.Clear();
            Console.WriteLine($"{name} 검색 결과 없음");
            for (int i = 0; i < addressArray.Count; i++)
            {
                if (name == addressArray[i].Name)
                {
                    Console.Clear();
                    Console.WriteLine($"{name} 검색 결과");
                    Console.WriteLine("----------------------------");
                    Console.WriteLine($"이름 : {addressArray[i].Name}");
                    Console.WriteLine($"전화번호 : {addressArray[i].Phone}");
                    Console.WriteLine($"주소 : {addressArray[i].Addr}");
                    Console.WriteLine("----------------------------");
                    break;
                }

            }
        }
        public void UpdateAddress()
        {
            string name = ReadWrite("이름");
            Console.WriteLine($"{name} 검색 결과 없음");

            for (int i = 0; i < addressArray.Count; i++)
            {
                if (name == addressArray[i].Name)
                {
                    Console.Clear();
                    Console.WriteLine($"{name} 검색 결과");
                    Console.WriteLine("----------------------------");
                    Console.WriteLine($"현재 이름 : {addressArray[i].Name}");
                    Console.WriteLine($"현재 전화번호 : {addressArray[i].Phone}");
                    Console.WriteLine($"현재 주소 : {addressArray[i].Addr}");
                    Console.WriteLine("----------------------------");
                    break;
                }

            }

            for (int i = 0; i < addressArray.Count; i++)
            {
                if (name == addressArray[i].Name)
                {
                    name = ReadWrite("변경할 이름");
                    addressArray[i].Name = name;
                    string phone = ReadWrite("변경할 전화번호");
                    addressArray[i].Phone = phone;
                    string addr = ReadWrite("변경할 주소");
                    addressArray[i].Addr = addr;
                    Console.Clear();
                    Console.WriteLine($"{name} 수정 완료");
                    break;

                }

            }
        }
        public void DeleteAddress()
        {
            {
                string name = ReadWrite("이름");

                for (int i = 0; i < addressArray.Count; i++)
                {
                    if (name == addressArray[i].Name)
                    {
                        Console.WriteLine("----------------------------");
                        Console.WriteLine($"이름 : {addressArray[i].Name}");
                        Console.WriteLine($"전화번호 : {addressArray[i].Phone}");
                        Console.WriteLine($"주소 : {addressArray[i].Addr}");
                        Console.WriteLine("----------------------------");
                        Console.Write("Delete? [y/n] : ");
                        string del = Console.ReadLine();
                        if (del == "y" || del == "Y")
                        {
                            addressArray.RemoveAt(i);
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
        public void PrintAddress()
        {
            Console.WriteLine("주소록 전체 출력");
            for (int i = 0; i < addressArray.Count; i++)
            {
                Console.WriteLine($"-----------[{i+1}]--------------");
                Console.WriteLine($"이름 : {addressArray[i].Name}");
                Console.WriteLine($"전화번호 : {addressArray[i].Phone}");
                Console.WriteLine($"주소 : {addressArray[i].Addr}");
            }
        }

        public string ReadWrite(string msg) 
        {
            Console.Write($"{msg} 입력 : ");
            string attribute = Console.ReadLine();
            return attribute;
        }
    }
}
