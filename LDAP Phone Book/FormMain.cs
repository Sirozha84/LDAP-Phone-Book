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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Data.Load();
            comboBoxComps.DataSource = Data.comps;
            comboBoxDeps.DataSource = Data.deps;
            Redraw();
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e) { Redraw(); }
        private void comboBoxComps_SelectedIndexChanged(object sender, EventArgs e) { Redraw(); }
        private void comboBoxDeps_SelectedIndexChanged(object sender, EventArgs e) { Redraw(); }

        void Redraw()
        {
            if (comboBoxDeps.Items.Count == 0) return;

            listViewBook.BeginUpdate();
            listViewBook.Items.Clear();
            foreach (User user in Data.book)
            {
                //if (user.name.ToLower().Substring(0, textBoxSearch.Text.Length) == textBoxSearch.Text.ToLower())
                if (user.name.ToLower().Contains(textBoxSearch.Text.ToLower()) &
                    (comboBoxComps.SelectedValue.ToString() == "Все" || comboBoxComps.SelectedValue.ToString() == user.company) &
                    (comboBoxDeps.SelectedValue.ToString() == "Все" || comboBoxDeps.SelectedValue.ToString() == user.dep))
                {
                    string phones = user.phoneW;
                    if (phones != "" & user.phoneG != "") phones += ", ";
                    phones += user.phoneG;
                    if (phones != "" & user.phoneM != "") phones += ", ";
                    phones += user.phoneM;

                    ListViewItem item = new ListViewItem(user.name);
                    item.SubItems.Add(user.company);
                    item.SubItems.Add(user.dep);
                    item.SubItems.Add(phones);
                    item.SubItems.Add(user.mail);
                    listViewBook.Items.Add(item);
                }
            }
            listViewBook.EndUpdate();
        }

        #region Меню

        private void menuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuForceUpdate_Click(object sender, EventArgs e)
        {
            Data.LDAPRead();
            Redraw();
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            /* Версия 1.1 (25.02.2020)
             * * Самостоятельное чтение книги без сторонних средств
             * * Чтение трёх видов телефонных номеров
             * * Фильтры по организациям и подразделениям
             * * Поиск по имени или отчеству
             * Версия 1.0 (17.02.2020)
             * * Отображение списка ФИО, номера телефона и электронной почты
             * * Поиск по фамилии
             */
            MessageBox.Show("LDAP Phone Book\n\nВерсия 1.1 (25.02.2020)\n\nАвтор: Сергей Гордеев", "LDAP Phone Book");
        }

        #endregion


    }
}
