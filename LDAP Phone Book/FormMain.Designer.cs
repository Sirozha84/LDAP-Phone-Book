namespace LDAP_Phone_Book
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.listViewBook = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderComp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuCopyW = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCopyG = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCopyM = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCopyMail = new System.Windows.Forms.ToolStripMenuItem();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuService = new System.Windows.Forms.ToolStripMenuItem();
            this.menuForceUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxComps = new System.Windows.Forms.ComboBox();
            this.comboBoxDeps = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.menuSendMail = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenu.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Location = new System.Drawing.Point(60, 28);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(226, 20);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // listViewBook
            // 
            this.listViewBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewBook.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderComp,
            this.columnHeaderDep,
            this.columnHeaderPost,
            this.columnHeaderNum,
            this.columnHeaderEmail});
            this.listViewBook.ContextMenuStrip = this.contextMenu;
            this.listViewBook.FullRowSelect = true;
            this.listViewBook.HideSelection = false;
            this.listViewBook.Location = new System.Drawing.Point(12, 53);
            this.listViewBook.Name = "listViewBook";
            this.listViewBook.Size = new System.Drawing.Size(910, 447);
            this.listViewBook.TabIndex = 4;
            this.listViewBook.UseCompatibleStateImageBehavior = false;
            this.listViewBook.View = System.Windows.Forms.View.Details;
            this.listViewBook.SelectedIndexChanged += new System.EventHandler(this.listViewBook_SelectedIndexChanged);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "ФИО";
            this.columnHeaderName.Width = 200;
            // 
            // columnHeaderComp
            // 
            this.columnHeaderComp.Text = "Организация";
            this.columnHeaderComp.Width = 120;
            // 
            // columnHeaderDep
            // 
            this.columnHeaderDep.Text = "Подразделение";
            this.columnHeaderDep.Width = 120;
            // 
            // columnHeaderPost
            // 
            this.columnHeaderPost.Text = "Должность";
            this.columnHeaderPost.Width = 160;
            // 
            // columnHeaderNum
            // 
            this.columnHeaderNum.Text = "Номера телефонов";
            this.columnHeaderNum.Width = 120;
            // 
            // columnHeaderEmail
            // 
            this.columnHeaderEmail.Text = "Email";
            this.columnHeaderEmail.Width = 160;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSendMail,
            this.menuSep1,
            this.menuCopyW,
            this.menuCopyG,
            this.menuCopyM,
            this.menuCopyMail});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(255, 142);
            // 
            // menuCopyW
            // 
            this.menuCopyW.Name = "menuCopyW";
            this.menuCopyW.Size = new System.Drawing.Size(254, 22);
            this.menuCopyW.Text = "Скопировать внутренний номер";
            this.menuCopyW.Visible = false;
            this.menuCopyW.Click += new System.EventHandler(this.menuCopyW_Click);
            // 
            // menuCopyG
            // 
            this.menuCopyG.Name = "menuCopyG";
            this.menuCopyG.Size = new System.Drawing.Size(254, 22);
            this.menuCopyG.Text = "Скопировать городской номер";
            this.menuCopyG.Visible = false;
            this.menuCopyG.Click += new System.EventHandler(this.menuCopyG_Click);
            // 
            // menuCopyM
            // 
            this.menuCopyM.Name = "menuCopyM";
            this.menuCopyM.Size = new System.Drawing.Size(254, 22);
            this.menuCopyM.Text = "Скопировать мобильный номер";
            this.menuCopyM.Visible = false;
            this.menuCopyM.Click += new System.EventHandler(this.menuCopyM_Click);
            // 
            // menuCopyMail
            // 
            this.menuCopyMail.Name = "menuCopyMail";
            this.menuCopyMail.Size = new System.Drawing.Size(254, 22);
            this.menuCopyMail.Text = "Скопировать Email";
            this.menuCopyMail.Visible = false;
            this.menuCopyMail.Click += new System.EventHandler(this.menuCopyMail_Click);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuService,
            this.menuHelp});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(934, 24);
            this.menu.TabIndex = 2;
            this.menu.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(48, 20);
            this.menuFile.Text = "Файл";
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuExit.Size = new System.Drawing.Size(150, 22);
            this.menuExit.Text = "Выход";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuService
            // 
            this.menuService.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuForceUpdate});
            this.menuService.Name = "menuService";
            this.menuService.Size = new System.Drawing.Size(59, 20);
            this.menuService.Text = "Сервис";
            // 
            // menuForceUpdate
            // 
            this.menuForceUpdate.Name = "menuForceUpdate";
            this.menuForceUpdate.Size = new System.Drawing.Size(268, 22);
            this.menuForceUpdate.Text = "Форсированное обновление книги";
            this.menuForceUpdate.Click += new System.EventHandler(this.menuForceUpdate_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(65, 20);
            this.menuHelp.Text = "Справка";
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(149, 22);
            this.menuAbout.Text = "О программе";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Поиск:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Компания:";
            // 
            // comboBoxComps
            // 
            this.comboBoxComps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxComps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComps.FormattingEnabled = true;
            this.comboBoxComps.Location = new System.Drawing.Point(359, 28);
            this.comboBoxComps.Name = "comboBoxComps";
            this.comboBoxComps.Size = new System.Drawing.Size(200, 21);
            this.comboBoxComps.TabIndex = 1;
            this.comboBoxComps.SelectedIndexChanged += new System.EventHandler(this.comboBoxComps_SelectedIndexChanged);
            // 
            // comboBoxDeps
            // 
            this.comboBoxDeps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxDeps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDeps.FormattingEnabled = true;
            this.comboBoxDeps.Location = new System.Drawing.Point(661, 28);
            this.comboBoxDeps.Name = "comboBoxDeps";
            this.comboBoxDeps.Size = new System.Drawing.Size(200, 21);
            this.comboBoxDeps.TabIndex = 2;
            this.comboBoxDeps.SelectedIndexChanged += new System.EventHandler(this.comboBoxDeps_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(565, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Подразделение:";
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReset.Location = new System.Drawing.Point(867, 26);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(55, 23);
            this.buttonReset.TabIndex = 3;
            this.buttonReset.Text = "Сброс";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // menuSendMail
            // 
            this.menuSendMail.Name = "menuSendMail";
            this.menuSendMail.Size = new System.Drawing.Size(254, 22);
            this.menuSendMail.Text = "Отправить письмо на";
            this.menuSendMail.Visible = false;
            this.menuSendMail.Click += new System.EventHandler(this.menuSendMail_Click);
            // 
            // menuSep1
            // 
            this.menuSep1.Name = "menuSep1";
            this.menuSep1.Size = new System.Drawing.Size(251, 6);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 512);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxDeps);
            this.Controls.Add(this.comboBoxComps);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewBook);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "FormMain";
            this.Text = "LDAP Phone Book";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.contextMenu.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ListView listViewBook;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderNum;
        private System.Windows.Forms.ColumnHeader columnHeaderEmail;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxComps;
        private System.Windows.Forms.ComboBox comboBoxDeps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeaderDep;
        private System.Windows.Forms.ColumnHeader columnHeaderComp;
        private System.Windows.Forms.ToolStripMenuItem menuService;
        private System.Windows.Forms.ToolStripMenuItem menuForceUpdate;
        private System.Windows.Forms.ColumnHeader columnHeaderPost;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem menuCopyMail;
        private System.Windows.Forms.ToolStripMenuItem menuCopyW;
        private System.Windows.Forms.ToolStripMenuItem menuCopyG;
        private System.Windows.Forms.ToolStripMenuItem menuCopyM;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.ToolStripMenuItem menuSendMail;
        private System.Windows.Forms.ToolStripSeparator menuSep1;
    }
}

