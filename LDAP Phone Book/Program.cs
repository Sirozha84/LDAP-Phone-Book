using System;
using System.Linq;
using System.Windows.Forms;

namespace LDAP_Phone_Book
{
    static class Program
    {
        public const string version = "2.0 (11.05.2021)";

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] param)
        {
            if (param.Count() > 0)
            {
                //Data.LDAPRead();  //Была идея запускать чтение из командной строки, чтобы запихать в планировщик задач
                return;
            }
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }

    }
}
