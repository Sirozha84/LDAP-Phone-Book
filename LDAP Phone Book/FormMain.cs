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
        List<Contact> book;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            string[] strings = System.IO.File.ReadAllText("c:\\Users\\SG\\Desktop\\ist_users.csv").Split('\r');
            book = new List<Contact>();
            for (int i = 2; i < strings.Count(); i++)
            {
                strings[i] = strings[i].Replace("\",\"", ",");
                strings[i] = strings[i].Replace("\n", "");
                strings[i] = strings[i].Replace("\"", "");
                string[] s = strings[i].Split(',');
                if (s.Count() > 5)
                    book.Add(new Contact(s[3], s[4], s[0]));
            }
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
            foreach (Contact cn in book)
            {
                //if (cn.name.ToLower().Contains(textBoxSearch.Text.ToLower()))
                if (cn.name.ToLower().Substring(0, textBoxSearch.Text.Length) == textBoxSearch.Text.ToLower())
                {
                    ListViewItem item = new ListViewItem(cn.name);
                    item.SubItems.Add(cn.phone);
                    item.SubItems.Add(cn.email);
                    listViewBook.Items.Add(item);
                }
            }
            listViewBook.EndUpdate();
        }
    }
}
