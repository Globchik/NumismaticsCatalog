using System.Drawing;
using System.Windows.Forms;

namespace NumismaticsCatalog
{
    partial class FormCollectorsView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_NameSearch = new Label();
            tbSearch = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            lbl_Contact = new Label();
            lbl_Country = new Label();
            dGV_Collectioners = new DataGridView();
            tb_ContactInfo = new TextBox();
            cb_Countries = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGV_Collectioners).BeginInit();
            SuspendLayout();
            // 
            // lbl_NameSearch
            // 
            lbl_NameSearch.Anchor = AnchorStyles.None;
            lbl_NameSearch.AutoSize = true;
            lbl_NameSearch.Font = new Font("Verdana", 13F);
            lbl_NameSearch.Location = new Point(138, 12);
            lbl_NameSearch.Name = "lbl_NameSearch";
            lbl_NameSearch.Size = new Size(55, 22);
            lbl_NameSearch.TabIndex = 2;
            lbl_NameSearch.Text = "Ім'я:";
            // 
            // tbSearch
            // 
            tbSearch.Anchor = AnchorStyles.None;
            tbSearch.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbSearch.Location = new Point(71, 44);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(189, 27);
            tbSearch.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(lbl_Contact, 2, 0);
            tableLayoutPanel1.Controls.Add(lbl_Country, 1, 0);
            tableLayoutPanel1.Controls.Add(dGV_Collectioners, 0, 2);
            tableLayoutPanel1.Controls.Add(tbSearch, 0, 1);
            tableLayoutPanel1.Controls.Add(lbl_NameSearch, 0, 0);
            tableLayoutPanel1.Controls.Add(tb_ContactInfo, 2, 1);
            tableLayoutPanel1.Controls.Add(cb_Countries, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(955, 538);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // lbl_Contact
            // 
            lbl_Contact.Anchor = AnchorStyles.None;
            lbl_Contact.AutoSize = true;
            lbl_Contact.Font = new Font("Verdana", 13F);
            lbl_Contact.Location = new Point(736, 12);
            lbl_Contact.Name = "lbl_Contact";
            lbl_Contact.Size = new Size(104, 22);
            lbl_Contact.TabIndex = 6;
            lbl_Contact.Text = "Контакти:";
            // 
            // lbl_Country
            // 
            lbl_Country.Anchor = AnchorStyles.None;
            lbl_Country.AutoSize = true;
            lbl_Country.Font = new Font("Verdana", 13F);
            lbl_Country.Location = new Point(437, 12);
            lbl_Country.Name = "lbl_Country";
            lbl_Country.Size = new Size(79, 22);
            lbl_Country.TabIndex = 5;
            lbl_Country.Text = "Країна:";
            // 
            // dGV_Collectioners
            // 
            dGV_Collectioners.AllowUserToAddRows = false;
            dGV_Collectioners.AllowUserToDeleteRows = false;
            dGV_Collectioners.AllowUserToOrderColumns = true;
            dGV_Collectioners.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dGV_Collectioners, 3);
            dGV_Collectioners.Dock = DockStyle.Fill;
            dGV_Collectioners.Location = new Point(13, 81);
            dGV_Collectioners.Name = "dGV_Collectioners";
            dGV_Collectioners.ReadOnly = true;
            dGV_Collectioners.Size = new Size(929, 444);
            dGV_Collectioners.TabIndex = 0;
            dGV_Collectioners.RowContextMenuStripNeeded += dGV_Collectioners_RowContextMenuStripNeeded;
            // 
            // tb_ContactInfo
            // 
            tb_ContactInfo.Anchor = AnchorStyles.None;
            tb_ContactInfo.Font = new Font("Verdana", 12F);
            tb_ContactInfo.Location = new Point(701, 44);
            tb_ContactInfo.Name = "tb_ContactInfo";
            tb_ContactInfo.Size = new Size(174, 27);
            tb_ContactInfo.TabIndex = 3;
            // 
            // cb_Countries
            // 
            cb_Countries.Anchor = AnchorStyles.None;
            cb_Countries.Font = new Font("Verdana", 12F);
            cb_Countries.FormattingEnabled = true;
            cb_Countries.Location = new Point(395, 44);
            cb_Countries.Name = "cb_Countries";
            cb_Countries.Size = new Size(162, 26);
            cb_Countries.TabIndex = 4;
            // 
            // FormCollectorsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 538);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(550, 190);
            Name = "FormCollectorsView";
            Text = "Довідник Нумізмата";
            Load += MainForm_Load;
            KeyPress += MainForm_KeyPress;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dGV_Collectioners).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox tbSearch;
        private Label lbl_NameSearch;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dGV_Collectioners;
        private TextBox tb_ContactInfo;
        private ComboBox cb_Countries;
        private Label lbl_Contact;
        private Label lbl_Country;
    }
}
