using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Control c = new Control();
            List<Address> addressArray = c.ListLoad();
            // 파일로부터 리스트 불러오기
            c.Start(addressArray);
            c.Start(ref addressArray);
            // 루프 실행 

            c.ListSave(addressArray);
            // 리스트를 파일로 저장 
        }
    }
}
