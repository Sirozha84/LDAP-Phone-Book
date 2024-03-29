﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LDAP_Phone_Book
{
    public partial class FormMain : Form
    {
        List<Contact> viewedContacts = new List<Contact>();
        bool isProgramUpdate = false;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Left = Properties.Settings.Default.Left;
            Top = Properties.Settings.Default.Top;
            if (Left < 0) Left = 300;
            if (Top < 0) Top = 300;
            Width = Properties.Settings.Default.Width;
            Height = Properties.Settings.Default.Height;

            if (Properties.Settings.Default.FontName != "")
                listViewBook.Font = new Font(Properties.Settings.Default.FontName, Properties.Settings.Default.FontSize);

            listViewBook.Columns[0].Width = Properties.Settings.Default.C0;
            listViewBook.Columns[1].Width = Properties.Settings.Default.C1;
            listViewBook.Columns[2].Width = Properties.Settings.Default.C2;
            listViewBook.Columns[3].Width = Properties.Settings.Default.C3;
            listViewBook.Columns[4].Width = Properties.Settings.Default.C4;
            listViewBook.Columns[5].Width = Properties.Settings.Default.C5;
            
            Refresh();
        }

        void Refresh()
        {
            Data.Load();
            isProgramUpdate = true;
            //Выпадающие списки с компаниями и подразделениями
            toolListComp.Items.Clear();
            foreach (string c in Data.comps)
                toolListComp.Items.Add(c);
            toolListComp.SelectedIndex = 0;
            toolListDep.Items.Clear();
            foreach (string d in Data.deps)
                toolListDep.Items.Add(d);
            toolListDep.SelectedIndex = 0;
            isProgramUpdate = false;
            Redraw();
        }

        void Redraw()
        {
            if (isProgramUpdate) return;
            viewedContacts.Clear();
            listViewBook.BeginUpdate();
            listViewBook.Items.Clear();
            string search = toolTextSearch.Text.ToLower();
            foreach (Contact user in Data.book)
            {
                
                if ( (user.name.ToLower().Contains(search) |
                      user.post.ToLower().Contains(search) |
                      user.phoneW.ToLower().Contains(search) |
                      user.phoneG.ToLower().Contains(search) |
                      user.phoneM.ToLower().Contains(search) |
                      user.mail.ToLower().Contains(search)) &
                    (toolListComp.Text == "Все" || toolListComp.Text == user.company) &
                    (toolListDep.Text == "Все" || toolListDep.Text == user.dep))
                {
                    ListViewItem item = new ListViewItem(user.name);
                    item.SubItems.Add(user.company);
                    item.SubItems.Add(user.dep);
                    item.SubItems.Add(user.post);
                    item.SubItems.Add(user.Phones);
                    item.SubItems.Add(user.mail);
                    item.Tag = user;
                    listViewBook.Items.Add(item);
                    viewedContacts.Add(user);
                }
            }
            listViewBook.EndUpdate();
        }
        private void listViewBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewBook.SelectedItems.Count > 0)
            {
                Contact user = (Contact)listViewBook.SelectedItems[0].Tag;
                cmenuSendMail.Enabled = user.mail != "";
                cmenuConnectToPC.Enabled = user.PC != "";
                cmenuOpenDesktop.Enabled = user.PC != "" & user.mail != "";
                cmenuSkype.Enabled = user.mail != "";
                cmenuPing.Enabled = user.PC != "";

                cmenuCopyName.Enabled = true;
                cmenuCopyG.Enabled = user.phoneW != "";
                cmenuCopyW.Enabled = user.phoneG != "";
                cmenuCopyM.Enabled = user.phoneM != "";
                cmenuCopyMail.Enabled = user.mail != "";
            }
            else
            {
                cmenuSendMail.Enabled = false;
                cmenuConnectToPC.Enabled = false;
                cmenuOpenDesktop.Enabled = false;
                cmenuSkype.Enabled = false;
                cmenuPing.Enabled = false;

                cmenuCopyName.Enabled = false;
                cmenuCopyG.Enabled = false;
                cmenuCopyW.Enabled = false;
                cmenuCopyM.Enabled = false;
                cmenuCopyMail.Enabled = false;
            }
        }

        #region Меню
        private void menuSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog diag = new SaveFileDialog() { Filter = "Значения, разделённые запятыми (*.csv)|*.csv|Все файлы|*.*" };
            if (diag.ShowDialog() == DialogResult.OK) Data.Export(diag.FileName);
        }

        private void menuPrint_Click(object sender, EventArgs e)
        {
            Print.Start(viewedContacts);
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuFont_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            if (dialog.ShowDialog() == DialogResult.OK) 
            {
                listViewBook.Font = dialog.Font;
                Properties.Settings.Default.FontName = dialog.Font.Name;
                Properties.Settings.Default.FontSize = dialog.Font.Size;
                Properties.Settings.Default.Save();
            }
        }

        private void menuRefresh_Click(object sender, EventArgs e) { Refresh(); }

        private void menuForceUpdate_Click(object sender, EventArgs e)
        {
            FormRead form = new FormRead();
            if (form.ShowDialog() == DialogResult.OK) Refresh();
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            FormAbout form = new FormAbout();
            form.ShowDialog();
        }
        #endregion

        #region Панель инструментов
        private void toolListComp_SelectedIndexChanged(object sender, EventArgs e) { Redraw(); }
        private void toolListDep_SelectedIndexChanged(object sender, EventArgs e) { Redraw(); }
        private void toolTextSearch_Click(object sender, EventArgs e) { Redraw(); }
        private void toolTextSearch_TextChanged(object sender, EventArgs e)
        {
            Redraw();
        }
        private void toolReset_Click(object sender, EventArgs e)
        {
            isProgramUpdate = true;
            toolTextSearch.Text = "";
            toolListComp.SelectedIndex = 0;
            toolListDep.SelectedIndex = 0;
            isProgramUpdate = false;
            Redraw();
        }
        #endregion

        #region Контекстное меню
        private void SendMail(object sender, EventArgs e)
        {
            Contact user = (Contact)listViewBook.SelectedItems[0].Tag;
            System.Diagnostics.Process.Start("mailto:" + user.mail);
        }

        private void cmenuConnectToPC_Click(object sender, EventArgs e)
        {
            Contact user = (Contact)listViewBook.SelectedItems[0].Tag;
            string mcm = "C:\\Program Files (x86)\\Microsoft Configuration Manager\\AdminConsole\\bin\\i386\\CmRcViewer.exe";
            try
            {
                System.Diagnostics.Process.Start(mcm, user.PC);
            }
            catch
            {
                MessageBox.Show("Программа \"Удалённое управление MC\" не обнаружена.");
            }
        }

        private void cmenuOpenDesktop_Click(object sender, EventArgs e)
        {
            Contact user = (Contact)listViewBook.SelectedItems[0].Tag;
            string path = @"\\"+user.PC+@"\c$\Users\"+ user.mail.Split('@')[0]+@"\Desktop";
            System.Diagnostics.Process.Start(path);
        }

        private void cmenuSkype_Click(object sender, EventArgs e)
        {
            Contact user = (Contact)listViewBook.SelectedItems[0].Tag;
            string lync = "C:\\Program Files (x86)\\Microsoft Office\\Office16\\lync.exe";
            try
            {
                System.Diagnostics.Process.Start(lync, "sip:" + user.mail);
            }
            catch
            {
                MessageBox.Show("Программа \"Skype для бизнеса\" не обнаружена.");
            }
        }

        private void cmenuPing_Click(object sender, EventArgs e)
        {
            Contact user = (Contact)listViewBook.SelectedItems[0].Tag;
            try
            {
                System.Diagnostics.Process.Start("ping", user.PC + " -t");
            }
            catch
            {
                MessageBox.Show("Произошла непредвиденная ошибка.");
            }
        }

        private void CopyName(object sender, EventArgs e)
        {
            Contact user = (Contact)listViewBook.SelectedItems[0].Tag;
            Clipboard.SetText(user.name);
        }

        private void CopyW(object sender, EventArgs e)
        {
            Contact user = (Contact)listViewBook.SelectedItems[0].Tag;
            Clipboard.SetText(user.phoneG);
        }

        private void CopyG(object sender, EventArgs e)
        {
            Contact user = (Contact)listViewBook.SelectedItems[0].Tag;
            Clipboard.SetText(user.phoneW);
        }

        private void CopyM(object sender, EventArgs e)
        {
            Contact user = (Contact)listViewBook.SelectedItems[0].Tag;
            Clipboard.SetText(user.phoneM);
        }

        private void CopyMail(object sender, EventArgs e)
        {
            Contact user = (Contact)listViewBook.SelectedItems[0].Tag;
            Clipboard.SetText(user.mail);
        }
        #endregion

        private void listViewBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27) toolTextSearch.Text = "";
            if (e.KeyChar >= 32)
                toolTextSearch.Text += e.KeyChar.ToString();
            toolTextSearch.Focus();
            toolTextSearch.SelectionStart = toolTextSearch.Text.Length;
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Left = Left;
            Properties.Settings.Default.Top = Top;
            Properties.Settings.Default.Width = Width;
            Properties.Settings.Default.Height = Height;
            Properties.Settings.Default.C0 = listViewBook.Columns[0].Width;
            Properties.Settings.Default.C1 = listViewBook.Columns[1].Width;
            Properties.Settings.Default.C2 = listViewBook.Columns[2].Width;
            Properties.Settings.Default.C3 = listViewBook.Columns[3].Width;
            Properties.Settings.Default.C4 = listViewBook.Columns[4].Width;
            Properties.Settings.Default.C5 = listViewBook.Columns[5].Width;
            Properties.Settings.Default.Save();
        }

        private void listViewBook_DoubleClick(object sender, EventArgs e)
        {
            if (listViewBook.SelectedItems.Count == 0) return;
            Contact user = (Contact)listViewBook.SelectedItems[0].Tag;
            FormUser form = new FormUser(user);
            form.ShowDialog();
        }

    }
}
