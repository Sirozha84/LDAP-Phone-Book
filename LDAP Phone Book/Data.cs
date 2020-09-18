using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.DirectoryServices;


namespace LDAP_Phone_Book
{
    static class Data
    {
        static public List<Contact> book;
        static public List<string> comps;
        static public List<string> deps;

        static public void Load()
        {
            try
            {
                var serializer = new XmlSerializer(typeof(List<Contact>));
                using (var reader = new StreamReader("Book.xml"))
                    book = (List<Contact>)serializer.Deserialize(reader);
            }
            catch 
            {
                book = new List<Contact>();
            }
            PrepareFilters();
        }

        static public void Save()
        {
            book.Sort((o1, o2) => o1.name.CompareTo(o2.name));
            try
            {
                var serializer = new XmlSerializer(typeof(List<Contact>));
                using (var writer = new StreamWriter("Book.xml"))
                    serializer.Serialize(writer, book);
            }
            catch
            {
                MessageBox.Show("Ошибка при сохранении данных");
            }
        }

        static void PrepareFilters()
        {
            comps = new List<string>();
            deps = new List<string>();
            foreach (Contact user in book)
            {
                if (comps.Find(o => o == user.company) == null) comps.Add(user.company);
                if (deps.Find(o => o == user.dep) == null) deps.Add(user.dep);
            }
            comps.Sort((o1, o2) => o1.CompareTo(o2));
            comps.Insert(0, "Все");
            deps.Sort((o1, o2) => o1.CompareTo(o2));
            deps.Insert(0, "Все");
        }

        public static void LDAPRead()
        {

            //Читаем AD
            DirectoryEntry CurrentDomain = new DirectoryEntry();
            Console.WriteLine(CurrentDomain.Name);
            //var ds = new DirectorySearcher("(&(objectClass=person)(objectClass=organizationalPerson)(objectCategory=user))");
            var ds = new DirectorySearcher("(&(objectClass=person)(objectClass=organizationalPerson)(objectCategory=user)(!userAccountControl:1.2.840.113556.1.4.803:=2))");
            ds.CacheResults = true;
            ds.PageSize = 1000;

            //Парсим
            string name;
            string company, departament, post;
            string mail;
            string phoneW, phoneG, phoneM;

            int s = 1;
            SearchResultCollection res = ds.FindAll();
            Data.book = new List<Contact>();
            foreach (SearchResult item in res)
            {
                using (var de = item.GetDirectoryEntry())
                {
                    try { name = de.Properties["cn"].Value.ToString(); } catch { name = ""; }
                    try { company = de.Properties["company"].Value.ToString(); } catch { company = ""; }
                    try { departament = de.Properties["department"].Value.ToString(); } catch { departament = ""; }
                    try { post = de.Properties["title"].Value.ToString(); } catch { post = ""; }
                    try { mail = de.Properties["mail"].Value.ToString(); } catch { mail = ""; }
                    try { phoneW = de.Properties["telephonenumber"].Value.ToString(); } catch { phoneW = ""; }
                    try { phoneG = de.Properties["homePhone"].Value.ToString(); } catch { phoneG = ""; }
                    try { phoneM = de.Properties["mobile"].Value.ToString(); } catch { phoneM = ""; }

                    if (mail != "" | phoneW != "" | phoneG != "" | phoneM != "")
                        Data.book.Add(new Contact(name, company, departament, post, mail, phoneW, phoneG, phoneM));
                    s++;
                }
            }

            Save();

            PrepareFilters();
        }
    }
}
