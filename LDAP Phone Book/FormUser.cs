using System.Windows.Forms;

namespace LDAP_Phone_Book
{
    public partial class FormUser : Form
    {
        public FormUser(Contact user)
        {
            InitializeComponent();
            Text = "Контакт: " + user.name;
            textBoxFIO.Text = user.name;
            textBoxCom.Text = user.company;
            textBoxDep.Text = user.dep;
            textBoxPost.Text = user.dep;
            textBoxPhoneG.Text = user.phoneG;
            textBoxPhoneW.Text = user.phoneW;
            textBoxPhoneM.Text = user.phoneM;
            textBoxEmail.Text = user.mail;
            textBoxCab.Text = user.cabinet;
            textBoxPC.Text = user.PC;
            textBoxDesc.Text = user.descriprion;
        }
    }
}
