using System.Windows.Forms;

namespace LDAP_Phone_Book
{
    public partial class FormUser : Form
    {
        public FormUser(Contact user)
        {
            InitializeComponent();
            Text = "Контакт: " + user.name;
            textFIO.Text = user.name;
            textCom.Text = user.company;
            textDep.Text = user.dep;
            textPost.Text = user.post;
            textPhoneG.Text = user.phoneG;
            textPhoneW.Text = user.phoneW;
            textPhoneM.Text = user.phoneM;
            textEmail.Text = user.mail;
            textCab.Text = user.cabinet;
            textPC.Text = user.PC;
            textDesc.Text = user.descriprion;
        }
    }
}
