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
            if (!Data.Load()) return;
            Redraw();
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            Redraw();
        }

        void Redraw()
        {
            listViewBook.BeginUpdate();
            listViewBook.Items.Clear();
            foreach (User user in Data.book)
            {
                //if (cn.name.ToLower().Contains(textBoxSearch.Text.ToLower()))
                if (user.name.ToLower().Substring(0, textBoxSearch.Text.Length) == textBoxSearch.Text.ToLower())
                {
                    ListViewItem item = new ListViewItem(user.name);
                    item.SubItems.Add(user.phoneW);
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
        private void menuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LDAP Phone Book\n\nВерсия 1.0 (17.02.2020)\n\nАвтор: Сергей Гордеев", "LDAP Phone Book");
        }

        #endregion

    }
}
