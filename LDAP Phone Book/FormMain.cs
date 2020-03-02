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
                    menuCopyW.Visible = true;
                    menuCopyW.Text = "Скопировать рабочий номер: " + user.phoneW;
                }
                if (user.phoneG != "")
                {
                    menuCopyG.Visible = true;
                    menuCopyG.Text = "Скопировать городской номер: " + user.phoneG;
                }
                if (user.phoneM != "")
                {
                    menuCopyM.Visible = true;
                    menuCopyM.Text = "Скопировать мобильный номер: " + user.phoneM;
                }
                if (user.mail != "")
                {
                    menuSendMail.Visible = true;
                    menuSendMail.Text = "Отправить письмо на " + user.mail;
                    menuCopyMail.Visible = true;
                    menuCopyMail.Text = "Скопировать Email: " + user.mail;
                }
            }
            else
            {
                menuSendMail.Visible = true;
                menuCopyW.Visible = false;
                menuCopyG.Visible = false;
                menuCopyM.Visible = false;
                menuCopyMail.Visible = false;
            }
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = "";
            comboBoxComps.SelectedIndex = 0;
            comboBoxDeps.SelectedIndex = 0;
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
        #endregion

    }
}
