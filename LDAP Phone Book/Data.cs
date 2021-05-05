using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.Text;

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

        public static void Export(string fileName)
        {
            try
            {
                StreamWriter file = new StreamWriter(fileName, false, Encoding.Default);
                file.WriteLine("ФИО;Организация;Подразделение;Внутренний;Внешний;Мобильный;Электронная почта");
                foreach (Contact contact in book)
                {
                    string s = contact.name + ";";
                    s += contact.company + ";";
                    s += contact.dep + ";";
                    s += contact.phoneW + ";";
                    s += contact.phoneG + ";";
                    s += contact.phoneM + ";";
                    s += contact.mail;
                    file.WriteLine(s);
                }
                file.Close();
            }
            catch
            {
                MessageBox.Show("Произошла ошибка при сохранении файла");
            }
        }
    }
}
