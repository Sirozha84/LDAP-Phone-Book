namespace LDAP_Phone_Book
{
    public class Contact
    {
        public string name;
        public string company, dep, post;
        public string mail;
        public string phoneW, phoneG, phoneM;
        public string cabinet;
        public string PC;
        public string descriprion;

        public Contact() { }

        public Contact(string name, string company, string dep, string post, string mail, 
                       string phoneW, string phoneG, string phoneM,
                       string cabinet, string PC, string descriprion)
        {
            this.name = name;
            this.company = company;
            this.dep = dep;
            this.post = post;
            this.mail = mail;
            this.phoneW = phoneW;
            this.phoneG = phoneG;
            this.phoneM = phoneM;
            this.cabinet = cabinet;
            this.PC = PC;
            this.descriprion = descriprion;
        }

    }
}

