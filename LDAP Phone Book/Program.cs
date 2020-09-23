﻿using System;
using System.Linq;
using System.Windows.Forms;

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
                Data.LDAPRead();
                return;
            }
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }

    }
}
