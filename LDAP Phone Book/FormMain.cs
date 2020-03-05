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
        private void FormMain_Shown(object sender, EventArgs e)
        {
            ShowNews();
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
                string search = textBoxSearch.Text.ToLower();
                if ( (user.name.ToLower().Contains(search) |
                      user.post.ToLower().Contains(search) |
                      user.phoneW.ToLower().Contains(search) |
                      user.phoneG.ToLower().Contains(search) |
                      user.phoneM.ToLower().Contains(search) |
                      user.mail.ToLower().Contains(search)) &
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
                    item.SubItems.Add(user.post);
                    item.SubItems.Add(phones);
                    item.SubItems.Add(user.mail);
                    item.Tag = user;
                    listViewBook.Items.Add(item);
                }
            }
            listViewBook.EndUpdate();
        }
        private void listViewBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewBook.SelectedItems.Count > 0)
            {
                User user = (User)listViewBook.SelectedItems[0].Tag;
                if (user.phoneW != "")
                {
                    menuCopyW.Enabled = true;
                    //menuCopyW.Text = "Скопировать рабочий номер: " + user.phoneW;
                }
                if (user.phoneG != "")
                {
                    menuCopyG.Enabled = true;
                    //menuCopyG.Text = "Скопировать городской номер: " + user.phoneG;
                }
                if (user.phoneM != "")
                {
                    menuCopyM.Enabled = true;
                    //menuCopyM.Text = "Скопировать мобильный номер: " + user.phoneM;
                }
                if (user.mail != "")
                {
                    menuSendMail.Enabled = true;
                    //menuSendMail.Text = "Отправить письмо на " + user.mail;
                    menuCopyMail.Enabled = true;
                    //menuCopyMail.Text = "Скопировать Email: " + user.mail;
                }
                menuSendReport.Text = "Сообщить об ошибке";
            }
            else
            {
                menuSendMail.Enabled = false;
                menuCopyW.Enabled = false;
                menuCopyG.Enabled = false;
                menuCopyM.Enabled = false;
                menuCopyMail.Enabled = false;
                menuSendReport.Text = "Сообщить о новом контакте";
            }
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = "";
            comboBoxComps.SelectedIndex = 0;
            comboBoxDeps.SelectedIndex = 0;
        }

        private void ShowNews()
        {
            if (Properties.Settings.Default.ShowTips < 1)
            {
                MessageBox.Show(
                    "Здравствуйте!\n\n" +
                    "Теперь вы можете отправить информацию об ошибках в справочнике или предложить добавить новый контакт.\n" +
                    "Для этого нажмите правой кнопкой мыши на контакт и выберите пункт \"Сообщить об ошибке\", " +
                    "или по пустому месту окна и выберите пункт \"Сообщить о новом контакте\".",
                    "Новости  обновления");

            }
            Properties.Settings.Default.ShowTips = 1;
            Properties.Settings.Default.Save();
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

        private void menuNews_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ShowTips = 0;
            ShowNews();
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            FormAbout form = new FormAbout();
            form.ShowDialog();
        }


        #endregion

        #region Контекстное меню
        private void menuSendMail_Click(object sender, EventArgs e)
        {
            User user = (User)listViewBook.SelectedItems[0].Tag;
            System.Diagnostics.Process.Start("mailto:" + user.mail);
        }
        private void menuCopyW_Click(object sender, EventArgs e)
        {
            User user = (User)listViewBook.SelectedItems[0].Tag;
            Clipboard.SetText(user.phoneW);
        }
        private void menuCopyG_Click(object sender, EventArgs e)
        {
            User user = (User)listViewBook.SelectedItems[0].Tag;
            Clipboard.SetText(user.phoneG);
        }
        private void menuCopyM_Click(object sender, EventArgs e)
        {
            User user = (User)listViewBook.SelectedItems[0].Tag;
            Clipboard.SetText(user.phoneM);
        }
        private void menuCopyMail_Click(object sender, EventArgs e)
        {
            User user = (User)listViewBook.SelectedItems[0].Tag;
            Clipboard.SetText(user.mail);
        }

        private void menuSendReport_Click(object sender, EventArgs e)
        {
            string name = "";
            if (listViewBook.SelectedItems.Count > 0)
            {
                User user = (User)listViewBook.SelectedItems[0].Tag;
                name = user.name;
            }
            FormReport form = new FormReport(name);
            form.ShowDialog();
        }


        #endregion

    }
}
