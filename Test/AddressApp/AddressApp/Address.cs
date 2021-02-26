using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressApp
{
    class Address
    {
        private string name;
        private string phone;
        private string addr;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Addr
        {
            get { return addr; }
            set { addr = value; }
        }
    }
}
