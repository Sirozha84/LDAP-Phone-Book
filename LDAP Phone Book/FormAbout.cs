﻿using System.Windows.Forms;

namespace LDAP_Phone_Book
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
            label2.Text = "Версия: " + Program.Version;
            richTextBoxHostory.Text =
                "Версия 1.6 (28.07.2020)\n\n" +
                "• Исправлена ошибка загрузки приложения в свёрнутом состоянии\n" +
                "• Немножко уменьшена минимальная ширина окна\n\n" +
                "Версия 1.5 (20.07.2020)\n\n" +
                "• Печать телефонной книги\n" +
                "• Небольшой редизайн главного окна\n" +
                "• Размеры окна и колонок теперь запоминаются\n" +
                "• Поиск даже если в фокусе список контактов\n" +
                "• Добавлена возможность \"лёгкого\"обновления книги без перечитывания LDAP " +
                "(например если кто-то уже перечитал LDAP, не обязательно это делать ещё раз, достаточно обновить только список)\n" +
                "• Новое окно для новостей обновлений\n" +
                "• Исправлено обновление списка компаний и подразделений при обновлении книги (обновлялись только при запуске приложения)\n\n" +
                "Версия 1.4 (05.03.2020)\n\n" +
                "• Возможность отправлять сообщения об ошибках и предложениях\n" +
                "• Новости обновлений\n" +
                "• Исправлена ошибка контекстного меню\n\n" +
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
