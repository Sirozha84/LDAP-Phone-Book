using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDAP_Phone_Book
{
    public class User
    {
        public string name;
        public string company, dep;
        public string mail;
        public string phoneW, phoneG, phoneM;

        public User(string name, string company, string dep, string mail, string phoneW, string phoneG, string phoneM)
        {
            this.name = name;
            this.company = company;
            this.dep = dep;
            this.mail = mail;
            this.phoneW = phoneW;
            this.phoneG = phoneG;
            this.phoneM = phoneM;
        }

    }
}

