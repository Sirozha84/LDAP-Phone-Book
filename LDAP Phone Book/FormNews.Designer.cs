namespace LDAP_Phone_Book
{
    partial class FormNews
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
            this.listBoxDates = new System.Windows.Forms.ListBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.news = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // listBoxDates
            // 
            this.listBoxDates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxDates.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxDates.FormattingEnabled = true;
            this.listBoxDates.ItemHeight = 15;
            this.listBoxDates.Location = new System.Drawing.Point(12, 12);
            this.listBoxDates.Name = "listBoxDates";
            this.listBoxDates.Size = new System.Drawing.Size(77, 300);
            this.listBoxDates.TabIndex = 0;
            this.listBoxDates.SelectedIndexChanged += new System.EventHandler(this.listBoxDates_SelectedIndexChanged);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(497, 326);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // news
            // 
            this.news.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.news.BackColor = System.Drawing.SystemColors.Window;
            this.news.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.news.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.news.Location = new System.Drawing.Point(95, 12);
            this.news.Name = "news";
            this.news.ReadOnly = true;
            this.news.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.news.Size = new System.Drawing.Size(477, 308);
            this.news.TabIndex = 3;
            this.news.Text = "";
            // 
            // FormNews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.news);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.listBoxDates);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FormNews";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Новости обновлений";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDates;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.RichTextBox news;
    }
}