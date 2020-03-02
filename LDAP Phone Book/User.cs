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
        public string company, dep, post;
        public string mail;
        public string phoneW, phoneG, phoneM;

        public User() { }

        public User(string name, string company, string dep, string post, string mail, string phoneW, string phoneG, string phoneM)
        {
            this.name = name;
            this.company = company;
            this.dep = dep;
            this.post = post;
            this.mail = mail;
            this.phoneW = phoneW;
            this.phoneG = phoneG;
            this.phoneM = phoneM;
        }

    }
}

