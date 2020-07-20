﻿using System;
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
    public partial class FormNews : Form
    {
        public FormNews()
        {
            InitializeComponent();
            listBoxDates.SelectedIndex = 0;
        }

        private void listBoxDates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDates.Text == "20.07.2020") news.Text = "Обновление 1.3 (20.07.2020)\n\n" +
                "Появилась возможность печатать! Печататься будут те контакты, которые выбраны фильтрами или поиском.\n\n" +
                "Исправлена ошибка обновления фильтров, к тому же, обновление можно теперь делать \"лёгкое\", нажав F5. " +
                "LDAP при этом не перечитывается, не замедляя работу. Это можно сделать отдельно.\n\n" +
                "Вводить слово для поиска можно даже если активен список контактов.\n\n" +
                "Размеры окна и колонок теперь могут сохраняться (можно использовать, например, " +
                "для того, чтобы скрыть не нужные колонки)." +
                "Небольшой редизайн главного окна и новое окно вот с этими новостями.";

            if (listBoxDates.Text == "05.03.2020") news.Text = "Обновление 1.4 (05.03.2020)\n\n" +
                "Теперь вы можете отправить информацию об ошибках в справочнике или предложить добавить новый контакт. " +
                "Для этого нажмите правой кнопкой мыши на контакт и выберите пункт \"Сообщить об ошибке\", " +
                "или по пустому месту окна и выберите пункт \"Сообщить о новом контакте\".";
        }
    }
}
