namespace LDAP_Phone_Book
{
    public class Contact
    {
        public string name;
        public string company, dep, post;
        public string mail;
        public string phoneG, phoneW, phoneM;
        public string cabinet;
        public string PC;
        public string descriprion;

        public Contact() { }

        public Contact(string name, string company, string dep, string post, string mail, 
                       string phoneG, string phoneW, string phoneM,
                       string cabinet, string PC, string descriprion)
        {
            this.name = name;
            this.company = company;
            this.dep = dep;
            this.post = post;
            this.mail = mail;
            this.phoneG = phoneG;
            this.phoneW = phoneW;
            this.phoneM = phoneM;
            this.cabinet = cabinet;
            this.PC = PC;
            this.descriprion = descriprion;
        }

        public string Phones
        {
            get
            {
                string phones = phoneG;
                if (phones != "" & phoneW != "") phones += ", ";
                phones += phoneW;
                if (phones != "" & phoneM != "") phones += ", ";
                phones += phoneM;
                return phones;
            }
        }
        

    }
}

