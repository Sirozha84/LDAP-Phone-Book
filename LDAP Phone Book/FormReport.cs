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
    public partial class FormReport : Form
    {
        public FormReport(string name)
        {
            InitializeComponent();
            textBoxName.Text = name;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            System.IO.File.AppendAllText("Messages.txt",
                DateTime.Now.ToString() + "; " +
                Environment.UserName + "; " +
                textBoxName.Text + "; " + textBoxMessage.Text + "\n");
            Close();
        }
    }
}
