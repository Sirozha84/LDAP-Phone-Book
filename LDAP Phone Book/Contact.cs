using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDAP_Phone_Book
{
    class Contact
    {
        public string name;
        public string phone;
        public string email;

        public Contact(string name, string phone, string email)
        {
            this.name = name;
            this.phone = phone;
            this.email = email;
        }
    }
}
