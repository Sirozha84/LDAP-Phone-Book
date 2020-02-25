using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices;
using System.Runtime.InteropServices;

namespace LDAP_Phone_Book
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] param)
        {
            if (param.Count() > 0)
            {
                LDAPRead();
                return;
            }
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool FreeConsole();

        static void LDAPRead()
        {
            //Покажем консоль
            AllocConsole();

            //Читаем AD
            DirectoryEntry CurrentDomain = new DirectoryEntry();
            Console.WriteLine(CurrentDomain.Name);
            var ds = new DirectorySearcher("(&(objectClass=person)(objectClass=organizationalPerson)(objectClass=user))");
            ds.CacheResults = true;
            ds.PageSize = 1000;
            
            //Парсим
            string name;
            string company, departament;
            string mail;
            string phoneW, phoneG, phoneM;

            foreach (SearchResult item in ds.FindAll())
            {
                using (var de = item.GetDirectoryEntry())
                {
                    Console.WriteLine();
                    //Console.WriteLine("Name: " + de.Name);
                    //Console.WriteLine(de.Username);

                    try { name = de.Properties["cn"].Value.ToString(); } catch { name = ""; }
                    try { company = de.Properties["company"].Value.ToString(); } catch { company = ""; }
                    try { departament = de.Properties["department"].Value.ToString(); } catch { departament = ""; }
                    try { mail = de.Properties["mail"].Value.ToString(); } catch { mail = ""; }
                    try { phoneW = de.Properties["telephonenumber"].Value.ToString(); } catch { phoneW = ""; }
                    try { phoneG = de.Properties["homePhone"].Value.ToString(); } catch { phoneG = ""; }
                    try { phoneM = de.Properties["mobile"].Value.ToString(); } catch { phoneM = ""; }
                }
            }
        }
    }
}
