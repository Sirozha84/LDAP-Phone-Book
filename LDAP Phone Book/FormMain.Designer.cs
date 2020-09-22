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
            this.listViewBook = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderComp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmenuSendMail = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmenuCopyName = new System.Windows.Forms.ToolStripMenuItem();
            this.cmenuCopyW = new System.Windows.Forms.ToolStripMenuItem();
            this.cmenuCopyG = new System.Windows.Forms.ToolStripMenuItem();
            this.cmenuCopyM = new System.Windows.Forms.ToolStripMenuItem();
            this.cmenuCopyMail = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSendReport = new System.Windows.Forms.ToolStripMenuItem();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.sep2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFont = new System.Windows.Forms.ToolStripMenuItem();
            this.sep1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.menuService = new System.Windows.Forms.ToolStripMenuItem();
            this.menuForceUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNews = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolLabelComp = new System.Windows.Forms.ToolStripLabel();
            this.toolListComp = new System.Windows.Forms.ToolStripComboBox();
            this.toolLabelDep = new System.Windows.Forms.ToolStripLabel();
            this.toolListDep = new System.Windows.Forms.ToolStripComboBox();
            this.toolReset = new System.Windows.Forms.ToolStripButton();
            this.toolTextSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolLabelSearch = new System.Windows.Forms.ToolStripLabel();
            this.contextMenu.SuspendLayout();
            this.menu.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
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
            this.listViewBook.Location = new System.Drawing.Point(0, 52);
            this.listViewBook.Name = "listViewBook";
            this.listViewBook.Size = new System.Drawing.Size(934, 409);
            this.listViewBook.TabIndex = 0;
            this.listViewBook.UseCompatibleStateImageBehavior = false;
            this.listViewBook.View = System.Windows.Forms.View.Details;
            this.listViewBook.SelectedIndexChanged += new System.EventHandler(this.listViewBook_SelectedIndexChanged);
            this.listViewBook.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listViewBook_KeyPress);
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
            this.cmenuSendMail,
            this.menuSep1,
            this.cmenuCopyName,
            this.cmenuCopyW,
            this.cmenuCopyG,
            this.cmenuCopyM,
            this.cmenuCopyMail,
            this.menuSep2,
            this.menuSendReport});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(255, 170);
            // 
            // cmenuSendMail
            // 
            this.cmenuSendMail.Enabled = false;
            this.cmenuSendMail.Name = "cmenuSendMail";
            this.cmenuSendMail.Size = new System.Drawing.Size(254, 22);
            this.cmenuSendMail.Text = "Отправить письмо";
            this.cmenuSendMail.Click += new System.EventHandler(this.SendMail);
            // 
            // menuSep1
            // 
            this.menuSep1.Name = "menuSep1";
            this.menuSep1.Size = new System.Drawing.Size(251, 6);
            // 
            // cmenuCopyName
            // 
            this.cmenuCopyName.Enabled = false;
            this.cmenuCopyName.Name = "cmenuCopyName";
            this.cmenuCopyName.Size = new System.Drawing.Size(254, 22);
            this.cmenuCopyName.Text = "Скопировать ФИО";
            this.cmenuCopyName.Click += new System.EventHandler(this.CopyName);
            // 
            // cmenuCopyW
            // 
            this.cmenuCopyW.Enabled = false;
            this.cmenuCopyW.Name = "cmenuCopyW";
            this.cmenuCopyW.Size = new System.Drawing.Size(254, 22);
            this.cmenuCopyW.Text = "Скопировать внутренний номер";
            this.cmenuCopyW.Click += new System.EventHandler(this.CopyW);
            // 
            // cmenuCopyG
            // 
            this.cmenuCopyG.Enabled = false;
            this.cmenuCopyG.Name = "cmenuCopyG";
            this.cmenuCopyG.Size = new System.Drawing.Size(254, 22);
            this.cmenuCopyG.Text = "Скопировать городской номер";
            this.cmenuCopyG.Click += new System.EventHandler(this.CopyG);
            // 
            // cmenuCopyM
            // 
            this.cmenuCopyM.Enabled = false;
            this.cmenuCopyM.Name = "cmenuCopyM";
            this.cmenuCopyM.Size = new System.Drawing.Size(254, 22);
            this.cmenuCopyM.Text = "Скопировать мобильный номер";
            this.cmenuCopyM.Click += new System.EventHandler(this.CopyM);
            // 
            // cmenuCopyMail
            // 
            this.cmenuCopyMail.Enabled = false;
            this.cmenuCopyMail.Name = "cmenuCopyMail";
            this.cmenuCopyMail.Size = new System.Drawing.Size(254, 22);
            this.cmenuCopyMail.Text = "Скопировать Email";
            this.cmenuCopyMail.Click += new System.EventHandler(this.CopyMail);
            // 
            // menuSep2
            // 
            this.menuSep2.Name = "menuSep2";
            this.menuSep2.Size = new System.Drawing.Size(251, 6);
            // 
            // menuSendReport
            // 
            this.menuSendReport.Name = "menuSendReport";
            this.menuSendReport.Size = new System.Drawing.Size(254, 22);
            this.menuSendReport.Text = "Сообщить о новом контакте";
            this.menuSendReport.Click += new System.EventHandler(this.SendReport);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuView,
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
            this.menuSave,
            this.menuPrint,
            this.sep2,
            this.menuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(48, 20);
            this.menuFile.Text = "Файл";
            // 
            // menuSave
            // 
            this.menuSave.Image = global::LDAP_Phone_Book.Properties.Resources.save;
            this.menuSave.Name = "menuSave";
            this.menuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuSave.Size = new System.Drawing.Size(181, 22);
            this.menuSave.Text = "Сохранить...";
            this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
            // 
            // menuPrint
            // 
            this.menuPrint.Image = global::LDAP_Phone_Book.Properties.Resources.printer;
            this.menuPrint.Name = "menuPrint";
            this.menuPrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.menuPrint.Size = new System.Drawing.Size(181, 22);
            this.menuPrint.Text = "Печать...";
            this.menuPrint.Click += new System.EventHandler(this.menuPrint_Click);
            // 
            // sep2
            // 
            this.sep2.Name = "sep2";
            this.sep2.Size = new System.Drawing.Size(178, 6);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuExit.Size = new System.Drawing.Size(181, 22);
            this.menuExit.Text = "Выход";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuView
            // 
            this.menuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFont,
            this.sep1,
            this.menuRefresh});
            this.menuView.Name = "menuView";
            this.menuView.Size = new System.Drawing.Size(39, 20);
            this.menuView.Text = "Вид";
            // 
            // menuFont
            // 
            this.menuFont.Name = "menuFont";
            this.menuFont.Size = new System.Drawing.Size(147, 22);
            this.menuFont.Text = "Шрифт...";
            this.menuFont.Click += new System.EventHandler(this.menuFont_Click);
            // 
            // sep1
            // 
            this.sep1.Name = "sep1";
            this.sep1.Size = new System.Drawing.Size(144, 6);
            // 
            // menuRefresh
            // 
            this.menuRefresh.Image = global::LDAP_Phone_Book.Properties.Resources.update;
            this.menuRefresh.Name = "menuRefresh";
            this.menuRefresh.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.menuRefresh.Size = new System.Drawing.Size(147, 22);
            this.menuRefresh.Text = "Обновить";
            this.menuRefresh.Click += new System.EventHandler(this.menuRefresh_Click);
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
            this.menuForceUpdate.Size = new System.Drawing.Size(170, 22);
            this.menuForceUpdate.Text = "Перечитать LDAP";
            this.menuForceUpdate.Click += new System.EventHandler(this.menuForceUpdate_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNews,
            this.menuAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(65, 20);
            this.menuHelp.Text = "Справка";
            // 
            // menuNews
            // 
            this.menuNews.Name = "menuNews";
            this.menuNews.Size = new System.Drawing.Size(192, 22);
            this.menuNews.Text = "Новости обновлений";
            this.menuNews.Click += new System.EventHandler(this.menuNews_Click);
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(192, 22);
            this.menuAbout.Text = "О программе";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolLabelComp,
            this.toolListComp,
            this.toolLabelDep,
            this.toolListDep,
            this.toolReset,
            this.toolTextSearch,
            this.toolLabelSearch});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(934, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolLabelComp
            // 
            this.toolLabelComp.Name = "toolLabelComp";
            this.toolLabelComp.Size = new System.Drawing.Size(82, 22);
            this.toolLabelComp.Text = "Организация:";
            // 
            // toolListComp
            // 
            this.toolListComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolListComp.Name = "toolListComp";
            this.toolListComp.Size = new System.Drawing.Size(180, 25);
            this.toolListComp.SelectedIndexChanged += new System.EventHandler(this.toolListComp_SelectedIndexChanged);
            // 
            // toolLabelDep
            // 
            this.toolLabelDep.Name = "toolLabelDep";
            this.toolLabelDep.Size = new System.Drawing.Size(95, 22);
            this.toolLabelDep.Text = "Подразделение:";
            // 
            // toolListDep
            // 
            this.toolListDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolListDep.Name = "toolListDep";
            this.toolListDep.Size = new System.Drawing.Size(180, 25);
            this.toolListDep.SelectedIndexChanged += new System.EventHandler(this.toolListDep_SelectedIndexChanged);
            // 
            // toolReset
            // 
            this.toolReset.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolReset.Image = global::LDAP_Phone_Book.Properties.Resources.clear;
            this.toolReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolReset.Name = "toolReset";
            this.toolReset.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolReset.Size = new System.Drawing.Size(23, 22);
            this.toolReset.Text = "Сброс";
            this.toolReset.Click += new System.EventHandler(this.toolReset_Click);
            // 
            // toolTextSearch
            // 
            this.toolTextSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolTextSearch.Name = "toolTextSearch";
            this.toolTextSearch.Size = new System.Drawing.Size(180, 25);
            this.toolTextSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolTextSearch_KeyDown);
            this.toolTextSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolTextSearch_KeyPress);
            this.toolTextSearch.Click += new System.EventHandler(this.toolTextSearch_Click);
            this.toolTextSearch.TextChanged += new System.EventHandler(this.toolTextSearch_TextChanged);
            // 
            // toolLabelSearch
            // 
            this.toolLabelSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolLabelSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolLabelSearch.Image = global::LDAP_Phone_Book.Properties.Resources.search;
            this.toolLabelSearch.Name = "toolLabelSearch";
            this.toolLabelSearch.Size = new System.Drawing.Size(16, 22);
            this.toolLabelSearch.Text = "Поиск:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 461);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.listViewBook);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MinimumSize = new System.Drawing.Size(800, 200);
            this.Name = "FormMain";
            this.Text = "LDAP Phone Book";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.contextMenu.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listViewBook;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderNum;
        private System.Windows.Forms.ColumnHeader columnHeaderEmail;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.ColumnHeader columnHeaderDep;
        private System.Windows.Forms.ColumnHeader columnHeaderComp;
        private System.Windows.Forms.ToolStripMenuItem menuService;
        private System.Windows.Forms.ToolStripMenuItem menuForceUpdate;
        private System.Windows.Forms.ColumnHeader columnHeaderPost;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem cmenuCopyMail;
        private System.Windows.Forms.ToolStripMenuItem cmenuCopyW;
        private System.Windows.Forms.ToolStripMenuItem cmenuCopyG;
        private System.Windows.Forms.ToolStripMenuItem cmenuCopyM;
        private System.Windows.Forms.ToolStripMenuItem cmenuSendMail;
        private System.Windows.Forms.ToolStripSeparator menuSep1;
        private System.Windows.Forms.ToolStripSeparator menuSep2;
        private System.Windows.Forms.ToolStripMenuItem menuSendReport;
        private System.Windows.Forms.ToolStripMenuItem menuNews;
        private System.Windows.Forms.ToolStripMenuItem menuPrint;
        private System.Windows.Forms.ToolStripSeparator sep2;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel toolLabelComp;
        private System.Windows.Forms.ToolStripComboBox toolListComp;
        private System.Windows.Forms.ToolStripLabel toolLabelDep;
        private System.Windows.Forms.ToolStripComboBox toolListDep;
        private System.Windows.Forms.ToolStripLabel toolLabelSearch;
        private System.Windows.Forms.ToolStripTextBox toolTextSearch;
        private System.Windows.Forms.ToolStripButton toolReset;
        private System.Windows.Forms.ToolStripMenuItem menuView;
        private System.Windows.Forms.ToolStripMenuItem menuFont;
        private System.Windows.Forms.ToolStripSeparator sep1;
        private System.Windows.Forms.ToolStripMenuItem menuRefresh;
        private System.Windows.Forms.ToolStripMenuItem menuSave;
        private System.Windows.Forms.ToolStripMenuItem cmenuCopyName;
    }
}

