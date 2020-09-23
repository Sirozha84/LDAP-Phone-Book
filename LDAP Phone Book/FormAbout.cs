using System.Windows.Forms;
using System.Drawing;

namespace LDAP_Phone_Book
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
            
            Font fontR = new Font(history.Font.FontFamily, history.Font.Size, FontStyle.Regular);
            Font fontB = new Font(history.Font.FontFamily, history.Font.Size, FontStyle.Bold);

            labelVersion.Text = "Версия: " + Application.ProductVersion;

            history.SelectionFont = fontB;
            history.AppendText("Версия 1.7 (23.09.2020)\n\n");
            history.SelectionFont = fontR;
            history.AppendText("• Возможность изменить шрифт\n" +
                "• Книгу теперь можно сохранить в CSV файл\n" +
                "• Сброс поиска клавишей Esc (если в фокусе список)\n" +
                "• Теперь отключенные пользователи не попадают в книгу\n" +
                "• Новые иконки\n\n");
            history.SelectionFont = fontB;
            history.AppendText("Версия 1.6 (28.07.2020)\n\n");
            history.SelectionFont = fontR;
            history.AppendText("• Исправлена ошибка загрузки приложения в свёрнутом состоянии\n" +
                "• Немножко уменьшена минимальная ширина окна\n\n");
            history.SelectionFont = fontB; 
            history.AppendText("Версия 1.5 (20.07.2020)\n\n");
            history.SelectionFont = fontR;
            history.AppendText("• Печать телефонной книги\n" +
                "• Небольшой редизайн главного окна\n" +
                "• Размеры окна и колонок теперь запоминаются\n" +
                "• Поиск даже если в фокусе список контактов\n" +
                "• Добавлена возможность \"лёгкого\"обновления книги без перечитывания LDAP " +
                "(например если кто-то уже перечитал LDAP, не обязательно это делать ещё раз, достаточно обновить только список)\n" +
                "• Новое окно для новостей обновлений\n" +
                "• Исправлено обновление списка компаний и подразделений при обновлении книги (обновлялись только при запуске приложения)\n\n");
            history.SelectionFont = fontB;
            history.AppendText("Версия 1.4 (05.03.2020)\n\n");
            history.SelectionFont = fontR;
            history.AppendText("• Возможность отправлять сообщения об ошибках и предложениях\n" +
                "• Новости обновлений\n" +
                "• Исправлена ошибка контекстного меню\n\n");
            history.SelectionFont = fontB;
            history.AppendText("Версия 1.3 (02.03.2020)\n\n");
            history.SelectionFont = fontR;
            history.AppendText("• Создание письма в почтовом клиенте через контекстное меню\n" +
                "• Копирование номеров и email в буфер обмена через контекстное меню\n" +
                "• Отображение должности\n" +
                "• Поиск по номеру, должности, почте\n" +
                "• Сброс поиска и фильтров, выпадающие списки стали крупней\n" +
                "• Исправлено формирование списка подразделений (попадали не все)\n" +
                "• Сортировка списка компаний и подразделений по алфавиту\n" +
                "• Вот это окно \"О программе\"\n\n");
            history.SelectionFont = fontB;
            history.AppendText("Верися 1.2 (27.02.2020)\n\n");
            history.SelectionFont = fontR;
            history.AppendText("• Форсированное обновление книги\n\n");
            history.SelectionFont = fontB;
            history.AppendText("Версия 1.1 (25.02.2020)\n\n");
            history.SelectionFont = fontR;
            history.AppendText("• Самостоятельное чтение книги без сторонних средств\n" +
                "• Чтение трёх видов телефонных номеров\n" +
                "• Фильтры по организациям и подразделениям\n" +
                "• Поиск по имени или отчеству\n\n");
            history.SelectionFont = fontB;
            history.AppendText("Версия 1.0 (17.02.2020)\n\n");
            history.SelectionFont = fontR;
            history.AppendText("• Отображение списка ФИО, номера телефона и электронной почты\n" +
                "• Поиск по фамилии");
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.sg-software.ru");
        }
    }
}
