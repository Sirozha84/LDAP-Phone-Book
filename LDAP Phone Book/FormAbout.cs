using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LDAP_Phone_Book
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
            label2.Text = "Версия: " + Program.Version;
            richTextBoxHostory.Text =
                //"• \n" +
                "Версия 1.3 (02.03.2020)\n\n" +
                "• Создание письма в почтовом клиенте через контекстное меню\n" +
                "• Копирование номеров и email в буфер обмена через контекстное меню\n" +
                "• Отображение должности\n" +
                "• Поиск по номеру, должности, почте\n" +
                "• Сброс поиска и фильтров, выпадающие списки стали крупней\n" +
                "• Исправлено формирование списка подразделений (попадали не все)\n" +
                "• Сортировка списка компаний и подразделений по алфавиту\n" +
                "• Вот это окно \"О программе\"\n\n" +
                "Верися 1.2 (27.02.2020)\n\n" +
                "• Форсированное обновление книги\n\n" +
                "Версия 1.1 (25.02.2020)\n\n" +
                "• Самостоятельное чтение книги без сторонних средств\n" +
                "• Чтение трёх видов телефонных номеров\n" +
                "• Фильтры по организациям и подразделениям\n" +
                "• Поиск по имени или отчеству\n\n" +
                "Версия 1.0 (17.02.2020)\n\n" +
                "• Отображение списка ФИО, номера телефона и электронной почты\n" +
                "• Поиск по фамилии";
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.sg-software.ru");
        }
    }
}
