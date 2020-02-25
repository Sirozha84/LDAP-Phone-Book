using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace LDAP_Phone_Book
{
    static class Data
    {
        static public List<User> book;
        static public bool Load()
        {
            try
            {
                var serializer = new XmlSerializer(typeof(Data));
                using (var reader = new StreamReader("Book.xml"))
                    book = (List<User>)serializer.Deserialize(reader);
                return true;
            }
            catch
            {
                return false;
            }
        }

        static public void Save()
        {
            try
            {
                var serializer = new XmlSerializer(typeof(Data));
                using (var writer = new StreamWriter("Book.xml"))
                    serializer.Serialize(writer, book);
            }
            catch
            {
                MessageBox.Show("Ошибка при сохранении данных");
            }
        }
    }
}
