namespace LDAP_Phone_Book
{
    partial class FormAbout
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
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.labelKE26 = new System.Windows.Forms.Label();
            this.linkLabelSite = new System.Windows.Forms.LinkLabel();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.tabPageHistory = new System.Windows.Forms.TabPage();
            this.history = new System.Windows.Forms.RichTextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPageAbout.SuspendLayout();
            this.tabPageHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::LDAP_Phone_Book.Properties.Resources.Phone_Book;
            this.pictureBoxLogo.Location = new System.Drawing.Point(32, 32);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(128, 128);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageAbout);
            this.tabControl.Controls.Add(this.tabPageHistory);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(460, 208);
            this.tabControl.TabIndex = 1;
            // 
            // tabPageAbout
            // 
            this.tabPageAbout.Controls.Add(this.labelKE26);
            this.tabPageAbout.Controls.Add(this.linkLabelSite);
            this.tabPageAbout.Controls.Add(this.labelInfo);
            this.tabPageAbout.Controls.Add(this.labelAuthor);
            this.tabPageAbout.Controls.Add(this.labelVersion);
            this.tabPageAbout.Controls.Add(this.labelName);
            this.tabPageAbout.Controls.Add(this.pictureBoxLogo);
            this.tabPageAbout.Location = new System.Drawing.Point(4, 22);
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAbout.Size = new System.Drawing.Size(452, 182);
            this.tabPageAbout.TabIndex = 0;
            this.tabPageAbout.Text = "О программе";
            this.tabPageAbout.UseVisualStyleBackColor = true;
            // 
            // labelKE26
            // 
            this.labelKE26.Location = new System.Drawing.Point(182, 118);
            this.labelKE26.Name = "labelKE26";
            this.labelKE26.Size = new System.Drawing.Size(226, 30);
            this.labelKE26.TabIndex = 7;
            this.labelKE26.Text = "Новую версию этой и других моих программ Вы можете загрузить на сайте";
            // 
            // linkLabelSite
            // 
            this.linkLabelSite.AutoSize = true;
            this.linkLabelSite.Location = new System.Drawing.Point(182, 144);
            this.linkLabelSite.Name = "linkLabelSite";
            this.linkLabelSite.Size = new System.Drawing.Size(100, 13);
            this.linkLabelSite.TabIndex = 6;
            this.linkLabelSite.TabStop = true;
            this.linkLabelSite.Text = "www.sg-software.ru";
            this.linkLabelSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // labelInfo
            // 
            this.labelInfo.Location = new System.Drawing.Point(182, 118);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(226, 30);
            this.labelInfo.TabIndex = 5;
            this.labelInfo.Text = "Новую версию этой и других моих программ Вы можете загрузить на сайте";
            this.labelInfo.Visible = false;
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(182, 92);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(124, 13);
            this.labelAuthor.TabIndex = 4;
            this.labelAuthor.Text = "Автор: Сергей Гордеев";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(182, 67);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(44, 13);
            this.labelVersion.TabIndex = 3;
            this.labelVersion.Text = "Версия";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(180, 32);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(190, 25);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "LDAP Phone Book";
            // 
            // tabPageHistory
            // 
            this.tabPageHistory.Controls.Add(this.history);
            this.tabPageHistory.Location = new System.Drawing.Point(4, 22);
            this.tabPageHistory.Name = "tabPageHistory";
            this.tabPageHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHistory.Size = new System.Drawing.Size(452, 182);
            this.tabPageHistory.TabIndex = 1;
            this.tabPageHistory.Text = "История версий";
            this.tabPageHistory.UseVisualStyleBackColor = true;
            // 
            // history
            // 
            this.history.BackColor = System.Drawing.Color.White;
            this.history.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.history.Dock = System.Windows.Forms.DockStyle.Fill;
            this.history.Location = new System.Drawing.Point(3, 3);
            this.history.Name = "history";
            this.history.ReadOnly = true;
            this.history.Size = new System.Drawing.Size(446, 176);
            this.history.TabIndex = 0;
            this.history.Text = "";
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(397, 226);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // FormAbout
            // 
            this.AcceptButton = this.buttonClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.buttonClose);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "FormAbout";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPageAbout.ResumeLayout(false);
            this.tabPageAbout.PerformLayout();
            this.tabPageHistory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageAbout;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TabPage tabPageHistory;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.LinkLabel linkLabelSite;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.RichTextBox history;
        private System.Windows.Forms.Label labelKE26;
    }
}