
namespace LDAP_Phone_Book
{
    partial class FormUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelFIO = new System.Windows.Forms.Label();
            this.textFIO = new System.Windows.Forms.TextBox();
            this.textCom = new System.Windows.Forms.TextBox();
            this.labelCom = new System.Windows.Forms.Label();
            this.textDep = new System.Windows.Forms.TextBox();
            this.labelDep = new System.Windows.Forms.Label();
            this.textPost = new System.Windows.Forms.TextBox();
            this.labelPost = new System.Windows.Forms.Label();
            this.textPhoneG = new System.Windows.Forms.TextBox();
            this.labelPhoneG = new System.Windows.Forms.Label();
            this.textPhoneW = new System.Windows.Forms.TextBox();
            this.labelPgoneW = new System.Windows.Forms.Label();
            this.textPhoneM = new System.Windows.Forms.TextBox();
            this.labelPhoneM = new System.Windows.Forms.Label();
            this.textDesc = new System.Windows.Forms.TextBox();
            this.labelDesc = new System.Windows.Forms.Label();
            this.textPC = new System.Windows.Forms.TextBox();
            this.labelPC = new System.Windows.Forms.Label();
            this.textCab = new System.Windows.Forms.TextBox();
            this.labelCab = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(11, 15);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(140, 13);
            this.labelFIO.TabIndex = 0;
            this.labelFIO.Text = "Фамилия, Имя, Отчество:";
            // 
            // textFIO
            // 
            this.textFIO.Location = new System.Drawing.Point(157, 12);
            this.textFIO.Name = "textFIO";
            this.textFIO.ReadOnly = true;
            this.textFIO.Size = new System.Drawing.Size(261, 20);
            this.textFIO.TabIndex = 0;
            // 
            // textCom
            // 
            this.textCom.Location = new System.Drawing.Point(157, 38);
            this.textCom.Name = "textCom";
            this.textCom.ReadOnly = true;
            this.textCom.Size = new System.Drawing.Size(261, 20);
            this.textCom.TabIndex = 1;
            // 
            // labelCom
            // 
            this.labelCom.AutoSize = true;
            this.labelCom.Location = new System.Drawing.Point(11, 41);
            this.labelCom.Name = "labelCom";
            this.labelCom.Size = new System.Drawing.Size(77, 13);
            this.labelCom.TabIndex = 2;
            this.labelCom.Text = "Организация:";
            // 
            // textDep
            // 
            this.textDep.Location = new System.Drawing.Point(157, 64);
            this.textDep.Name = "textDep";
            this.textDep.ReadOnly = true;
            this.textDep.Size = new System.Drawing.Size(261, 20);
            this.textDep.TabIndex = 2;
            // 
            // labelDep
            // 
            this.labelDep.AutoSize = true;
            this.labelDep.Location = new System.Drawing.Point(11, 67);
            this.labelDep.Name = "labelDep";
            this.labelDep.Size = new System.Drawing.Size(90, 13);
            this.labelDep.TabIndex = 4;
            this.labelDep.Text = "Подразделение:";
            // 
            // textPost
            // 
            this.textPost.Location = new System.Drawing.Point(157, 90);
            this.textPost.Name = "textPost";
            this.textPost.ReadOnly = true;
            this.textPost.Size = new System.Drawing.Size(261, 20);
            this.textPost.TabIndex = 3;
            // 
            // labelPost
            // 
            this.labelPost.AutoSize = true;
            this.labelPost.Location = new System.Drawing.Point(11, 93);
            this.labelPost.Name = "labelPost";
            this.labelPost.Size = new System.Drawing.Size(68, 13);
            this.labelPost.TabIndex = 6;
            this.labelPost.Text = "Должность:";
            // 
            // textPhoneG
            // 
            this.textPhoneG.Location = new System.Drawing.Point(157, 116);
            this.textPhoneG.Name = "textPhoneG";
            this.textPhoneG.ReadOnly = true;
            this.textPhoneG.Size = new System.Drawing.Size(261, 20);
            this.textPhoneG.TabIndex = 4;
            // 
            // labelPhoneG
            // 
            this.labelPhoneG.AutoSize = true;
            this.labelPhoneG.Location = new System.Drawing.Point(11, 119);
            this.labelPhoneG.Name = "labelPhoneG";
            this.labelPhoneG.Size = new System.Drawing.Size(111, 13);
            this.labelPhoneG.TabIndex = 8;
            this.labelPhoneG.Text = "Телефон городской:";
            // 
            // textPhoneW
            // 
            this.textPhoneW.Location = new System.Drawing.Point(157, 142);
            this.textPhoneW.Name = "textPhoneW";
            this.textPhoneW.ReadOnly = true;
            this.textPhoneW.Size = new System.Drawing.Size(261, 20);
            this.textPhoneW.TabIndex = 5;
            // 
            // labelPgoneW
            // 
            this.labelPgoneW.AutoSize = true;
            this.labelPgoneW.Location = new System.Drawing.Point(11, 145);
            this.labelPgoneW.Name = "labelPgoneW";
            this.labelPgoneW.Size = new System.Drawing.Size(116, 13);
            this.labelPgoneW.TabIndex = 10;
            this.labelPgoneW.Text = "Телефон внутренний:";
            // 
            // textPhoneM
            // 
            this.textPhoneM.Location = new System.Drawing.Point(157, 168);
            this.textPhoneM.Name = "textPhoneM";
            this.textPhoneM.ReadOnly = true;
            this.textPhoneM.Size = new System.Drawing.Size(261, 20);
            this.textPhoneM.TabIndex = 6;
            // 
            // labelPhoneM
            // 
            this.labelPhoneM.AutoSize = true;
            this.labelPhoneM.Location = new System.Drawing.Point(11, 171);
            this.labelPhoneM.Name = "labelPhoneM";
            this.labelPhoneM.Size = new System.Drawing.Size(116, 13);
            this.labelPhoneM.TabIndex = 12;
            this.labelPhoneM.Text = "Телефон мобильный:";
            // 
            // textDesc
            // 
            this.textDesc.Location = new System.Drawing.Point(157, 272);
            this.textDesc.Name = "textDesc";
            this.textDesc.ReadOnly = true;
            this.textDesc.Size = new System.Drawing.Size(261, 20);
            this.textDesc.TabIndex = 10;
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Location = new System.Drawing.Point(11, 275);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(60, 13);
            this.labelDesc.TabIndex = 18;
            this.labelDesc.Text = "Описание:";
            // 
            // textPC
            // 
            this.textPC.Location = new System.Drawing.Point(157, 246);
            this.textPC.Name = "textPC";
            this.textPC.ReadOnly = true;
            this.textPC.Size = new System.Drawing.Size(261, 20);
            this.textPC.TabIndex = 9;
            // 
            // labelPC
            // 
            this.labelPC.AutoSize = true;
            this.labelPC.Location = new System.Drawing.Point(11, 249);
            this.labelPC.Name = "labelPC";
            this.labelPC.Size = new System.Drawing.Size(145, 13);
            this.labelPC.TabIndex = 16;
            this.labelPC.Text = "Компьютер (веб страница):";
            // 
            // textCab
            // 
            this.textCab.Location = new System.Drawing.Point(157, 220);
            this.textCab.Name = "textCab";
            this.textCab.ReadOnly = true;
            this.textCab.Size = new System.Drawing.Size(261, 20);
            this.textCab.TabIndex = 8;
            // 
            // labelCab
            // 
            this.labelCab.AutoSize = true;
            this.labelCab.Location = new System.Drawing.Point(11, 223);
            this.labelCab.Name = "labelCab";
            this.labelCab.Size = new System.Drawing.Size(54, 13);
            this.labelCab.TabIndex = 14;
            this.labelCab.Text = "Комната:";
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(343, 322);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 11;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(157, 194);
            this.textEmail.Name = "textEmail";
            this.textEmail.ReadOnly = true;
            this.textEmail.Size = new System.Drawing.Size(261, 20);
            this.textEmail.TabIndex = 7;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(11, 197);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(36, 13);
            this.labelEmail.TabIndex = 21;
            this.labelEmail.Text = "EMail:";
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(430, 357);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.textDesc);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.textPC);
            this.Controls.Add(this.labelPC);
            this.Controls.Add(this.textCab);
            this.Controls.Add(this.labelCab);
            this.Controls.Add(this.textPhoneM);
            this.Controls.Add(this.labelPhoneM);
            this.Controls.Add(this.textPhoneW);
            this.Controls.Add(this.labelPgoneW);
            this.Controls.Add(this.textPhoneG);
            this.Controls.Add(this.labelPhoneG);
            this.Controls.Add(this.textPost);
            this.Controls.Add(this.labelPost);
            this.Controls.Add(this.textDep);
            this.Controls.Add(this.labelDep);
            this.Controls.Add(this.textCom);
            this.Controls.Add(this.labelCom);
            this.Controls.Add(this.textFIO);
            this.Controls.Add(this.labelFIO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUser";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.TextBox textFIO;
        private System.Windows.Forms.TextBox textCom;
        private System.Windows.Forms.Label labelCom;
        private System.Windows.Forms.TextBox textDep;
        private System.Windows.Forms.Label labelDep;
        private System.Windows.Forms.TextBox textPost;
        private System.Windows.Forms.Label labelPost;
        private System.Windows.Forms.TextBox textPhoneG;
        private System.Windows.Forms.Label labelPhoneG;
        private System.Windows.Forms.TextBox textPhoneW;
        private System.Windows.Forms.Label labelPgoneW;
        private System.Windows.Forms.TextBox textPhoneM;
        private System.Windows.Forms.Label labelPhoneM;
        private System.Windows.Forms.TextBox textDesc;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.TextBox textPC;
        private System.Windows.Forms.Label labelPC;
        private System.Windows.Forms.TextBox textCab;
        private System.Windows.Forms.Label labelCab;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label labelEmail;
    }
}