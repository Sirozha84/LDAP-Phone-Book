using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.DirectoryServices;


namespace LDAP_Phone_Book
{
    static class Data
    {
        static public List<User> book;
        static public List<string> comps;
        static public List<string> deps;

        static public void Load()
        {
            try
            {
                var serializer = new XmlSerializer(typeof(List<User>));
                using (var reader = new StreamReader("Book.xml"))
                    book = (List<User>)serializer.Deserialize(reader);
            }
            catch 
            {
                book = new List<User>();
            }
            PrepareFilters();
        }

        static public void Save()
        {
            book.Sort((o1, o2) => o1.name.CompareTo(o2.name));
            try
            {
                var serializer = new XmlSerializer(typeof(List<User>));
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
            //comps.Add("Все");
            deps = new List<string>();
            //deps.Add("Все");
            bool find;
            foreach (User user in book)
            {
                find = false;
                foreach (string comp in comps) if (user.company == comp) { find = true; break; }
                if (!find & user.company != "") comps.Add(user.company);
                find = false;
                foreach (string dep in deps) if (user.dep == dep) { find = true; break; }
                if (!find & user.dep != "") deps.Add(user.dep);
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
            //var ds = new DirectorySearcher("(&(objectClass=person)(objectClass=organizationalPerson)(objectClass=user))");
            var ds = new DirectorySearcher("(&(objectClass=person)(objectClass=organizationalPerson)(objectCategory=user))");
            ds.CacheResults = true;
            ds.PageSize = 1000;

            //Парсим
            string name;
            string company, departament, post;
            string mail;
            string phoneW, phoneG, phoneM;

            int s = 1;
            SearchResultCollection res = ds.FindAll();
            Data.book = new List<User>();
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
                        Data.book.Add(new User(name, company, departament, post, mail, phoneW, phoneG, phoneM));
                    s++;
                }
            }

            Save();

            PrepareFilters();
        }
    }
}
