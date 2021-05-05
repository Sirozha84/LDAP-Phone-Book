using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.DirectoryServices;

namespace LDAP_Phone_Book
{
    public partial class FormRead : Form
    {
        BackgroundWorker worker = new BackgroundWorker();
        string com = "";
        public FormRead()
        {
            InitializeComponent();
            radioButtonAll.Checked = Properties.Settings.Default.AllCom;
            radioButtonSelected.Checked = !Properties.Settings.Default.AllCom;
            comboBox.DataSource = Data.comps;
            if (radioButtonSelected.Checked)
                comboBox.Text = Properties.Settings.Default.Comp;
        }

        private void Run(object sender, EventArgs e)
        {
            if (radioButtonSelected.Checked)
            {
                com = comboBox.Text;
                if (com == "Все") com = "";
                Properties.Settings.Default.AllCom = false;
                Properties.Settings.Default.Comp = com;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.AllCom = true;
                Properties.Settings.Default.Save();
            }
            radioButtonAll.Enabled = false;
            radioButtonSelected.Enabled = false;
            comboBox.Enabled = false;
            buttonRun.Enabled = false;
            worker.DoWork += new DoWorkEventHandler(AsynkRead);
            worker.ProgressChanged += new ProgressChangedEventHandler(ProgressChange);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(Complate);
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
            worker.RunWorkerAsync();
        }

        void AsynkRead(object sender, EventArgs e)
        {
            //Читаем AD
            DirectoryEntry CurrentDomain = new DirectoryEntry();
            Console.WriteLine(CurrentDomain.Name);
            var ds = new DirectorySearcher("(&(objectClass=person)(objectClass=organizationalPerson)(objectCategory=user)(!userAccountControl:1.2.840.113556.1.4.803:=2))");
            ds.CacheResults = true;
            ds.PageSize = 1000;

            //Парсим
            string name;
            string company, departament, post;
            string mail;
            string phoneW, phoneG, phoneM;
            string cabinet;
            string PC;
            string description;

            int s = 1;
            SearchResultCollection res = ds.FindAll();
            Data.book = new List<Contact>();
            int i = 0;
            int count = res.Count;
            foreach (SearchResult item in res)
            {
                if (worker.CancellationPending) return;
                using (var de = item.GetDirectoryEntry())
                {
                    try { name = de.Properties["cn"].Value.ToString(); } catch { name = ""; }
                    try { company = de.Properties["company"].Value.ToString(); } catch { company = ""; }
                    try { departament = de.Properties["department"].Value.ToString(); } catch { departament = ""; }
                    try { post = de.Properties["title"].Value.ToString(); } catch { post = ""; }
                    try { mail = de.Properties["mail"].Value.ToString(); } catch { mail = ""; }
                    try { phoneW = de.Properties["telephonenumber"].Value.ToString(); } catch { phoneW = ""; }
                    try { phoneG = de.Properties["homePhone"].Value.ToString(); } catch { phoneG = ""; }
                    try { phoneM = de.Properties["mobile"].Value.ToString(); } catch { phoneM = ""; }
                    try { cabinet = de.Properties["physicaldeliveryofficename"].Value.ToString(); } catch { cabinet = ""; }
                    try { PC = de.Properties["wWWHomePage"].Value.ToString(); } catch { PC = ""; }
                    try { description = de.Properties["description"].Value.ToString(); } catch { description = ""; }
                    if ((mail != "" | phoneW != "" | phoneG != "" | phoneM != "") &&
                        (com == "" | company == com))
                        Data.book.Add(new Contact(name, company, departament, post, mail,
                                                  phoneW, phoneG, phoneM, cabinet, PC, description));
                    s++;
                }
                if (i % 100 == 0)
                    worker.ReportProgress((int)((float)i / count * 100));
                i++;
            }
            Data.Save();
            DialogResult = DialogResult.OK;
        }

        void ProgressChange(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        void Complate(object sender, EventArgs e) { Close(); }

        private void FormRead_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (worker.IsBusy) worker.CancelAsync();
        }

        private void radioButtonAll_CheckedChanged(object sender, EventArgs e)
        {
            comboBox.Enabled = radioButtonSelected.Checked;
        }
    }
}
