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
            tlp_Layout = new TableLayoutPanel();
            lbl_Title = new Label();
            panel3 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            lbl_Country = new Label();
            cb_Countries = new ComboBox();
            dGV_Collectioners = new DataGridView();
            panel2 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel4 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            lbl_Contact = new Label();
            tb_ContactInfo = new TextBox();
            btn_ClearFilters = new Button();
            tlp_Layout.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGV_Collectioners).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_NameSearch
            // 
            lbl_NameSearch.Anchor = AnchorStyles.None;
            lbl_NameSearch.AutoSize = true;
            lbl_NameSearch.Font = new Font("Verdana", 13F);
            lbl_NameSearch.Location = new Point(132, 9);
            lbl_NameSearch.Name = "lbl_NameSearch";
            lbl_NameSearch.Size = new Size(55, 22);
            lbl_NameSearch.TabIndex = 2;
            lbl_NameSearch.Text = "Ім'я:";
            // 
            // tbSearch
            // 
            tbSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbSearch.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbSearch.Location = new Point(10, 48);
            tbSearch.Margin = new Padding(10, 3, 10, 3);
            tbSearch.MaxLength = 100;
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(300, 27);
            tbSearch.TabIndex = 1;
            // 
            // tlp_Layout
            // 
            tlp_Layout.ColumnCount = 4;
            tlp_Layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tlp_Layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tlp_Layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
            tlp_Layout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tlp_Layout.Controls.Add(lbl_Title, 0, 0);
            tlp_Layout.Controls.Add(panel3, 1, 1);
            tlp_Layout.Controls.Add(dGV_Collectioners, 0, 2);
            tlp_Layout.Controls.Add(panel2, 0, 1);
            tlp_Layout.Controls.Add(panel4, 2, 1);
            tlp_Layout.Controls.Add(btn_ClearFilters, 3, 1);
            tlp_Layout.Dock = DockStyle.Fill;
            tlp_Layout.Location = new Point(0, 0);
            tlp_Layout.Name = "tlp_Layout";
            tlp_Layout.Padding = new Padding(10);
            tlp_Layout.RowCount = 3;
            tlp_Layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlp_Layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tlp_Layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp_Layout.Size = new Size(1067, 563);
            tlp_Layout.TabIndex = 3;
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.BackColor = SystemColors.ControlDarkDark;
            lbl_Title.BorderStyle = BorderStyle.FixedSingle;
            tlp_Layout.SetColumnSpan(lbl_Title, 4);
            lbl_Title.Dock = DockStyle.Fill;
            lbl_Title.Font = new Font("Segoe UI", 22F);
            lbl_Title.ForeColor = Color.White;
            lbl_Title.Location = new Point(13, 10);
            lbl_Title.Margin = new Padding(3, 0, 3, 5);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Padding = new Padding(3);
            lbl_Title.Size = new Size(1041, 55);
            lbl_Title.TabIndex = 11;
            lbl_Title.Text = "Колекціонери";
            lbl_Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(tableLayoutPanel3);
            panel3.Location = new Point(341, 73);
            panel3.Name = "panel3";
            panel3.Size = new Size(323, 84);
            panel3.TabIndex = 8;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(lbl_Country, 0, 0);
            tableLayoutPanel3.Controls.Add(cb_Countries, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(321, 82);
            tableLayoutPanel3.TabIndex = 6;
            // 
            // lbl_Country
            // 
            lbl_Country.Anchor = AnchorStyles.None;
            lbl_Country.AutoSize = true;
            lbl_Country.Font = new Font("Verdana", 13F);
            lbl_Country.Location = new Point(121, 9);
            lbl_Country.Name = "lbl_Country";
            lbl_Country.Size = new Size(79, 22);
            lbl_Country.TabIndex = 5;
            lbl_Country.Text = "Країна:";
            // 
            // cb_Countries
            // 
            cb_Countries.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cb_Countries.AutoCompleteMode = AutoCompleteMode.Suggest;
            cb_Countries.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb_Countries.Font = new Font("Verdana", 12F);
            cb_Countries.FormattingEnabled = true;
            cb_Countries.Location = new Point(10, 48);
            cb_Countries.Margin = new Padding(10, 3, 10, 3);
            cb_Countries.MaxLength = 100;
            cb_Countries.Name = "cb_Countries";
            cb_Countries.Size = new Size(301, 26);
            cb_Countries.TabIndex = 4;
            // 
            // dGV_Collectioners
            // 
            dGV_Collectioners.AllowUserToAddRows = false;
            dGV_Collectioners.AllowUserToDeleteRows = false;
            dGV_Collectioners.AllowUserToOrderColumns = true;
            dGV_Collectioners.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tlp_Layout.SetColumnSpan(dGV_Collectioners, 4);
            dGV_Collectioners.Dock = DockStyle.Fill;
            dGV_Collectioners.Location = new Point(13, 163);
            dGV_Collectioners.Name = "dGV_Collectioners";
            dGV_Collectioners.ReadOnly = true;
            dGV_Collectioners.Size = new Size(1041, 387);
            dGV_Collectioners.TabIndex = 0;
            dGV_Collectioners.RowContextMenuStripNeeded += dGV_Collectioners_RowContextMenuStripNeeded;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(tableLayoutPanel4);
            panel2.Location = new Point(13, 73);
            panel2.Name = "panel2";
            panel2.Size = new Size(322, 84);
            panel2.TabIndex = 7;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(tbSearch, 0, 1);
            tableLayoutPanel4.Controls.Add(lbl_NameSearch, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(320, 82);
            tableLayoutPanel4.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(tableLayoutPanel2);
            panel4.Location = new Point(670, 73);
            panel4.Name = "panel4";
            panel4.Size = new Size(323, 84);
            panel4.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(lbl_Contact, 0, 0);
            tableLayoutPanel2.Controls.Add(tb_ContactInfo, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(321, 82);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // lbl_Contact
            // 
            lbl_Contact.Anchor = AnchorStyles.None;
            lbl_Contact.AutoSize = true;
            lbl_Contact.Font = new Font("Verdana", 13F);
            lbl_Contact.Location = new Point(108, 9);
            lbl_Contact.Name = "lbl_Contact";
            lbl_Contact.Size = new Size(104, 22);
            lbl_Contact.TabIndex = 6;
            lbl_Contact.Text = "Контакти:";
            // 
            // tb_ContactInfo
            // 
            tb_ContactInfo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tb_ContactInfo.Font = new Font("Verdana", 12F);
            tb_ContactInfo.Location = new Point(10, 48);
            tb_ContactInfo.Margin = new Padding(10, 3, 10, 3);
            tb_ContactInfo.MaxLength = 100;
            tb_ContactInfo.Name = "tb_ContactInfo";
            tb_ContactInfo.Size = new Size(301, 27);
            tb_ContactInfo.TabIndex = 3;
            // 
            // btn_ClearFilters
            // 
            btn_ClearFilters.Dock = DockStyle.Fill;
            btn_ClearFilters.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_ClearFilters.Location = new Point(999, 73);
            btn_ClearFilters.Name = "btn_ClearFilters";
            btn_ClearFilters.Size = new Size(55, 84);
            btn_ClearFilters.TabIndex = 10;
            btn_ClearFilters.Text = "X";
            btn_ClearFilters.UseVisualStyleBackColor = true;
            btn_ClearFilters.Click += btn_ClearFilters_Click;
            // 
            // FormCollectorsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 563);
            Controls.Add(tlp_Layout);
            MinimumSize = new Size(550, 340);
            Name = "FormCollectorsView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Колекціонери";
            Load += FormCollectorsView_Load;
            KeyDown += FormCollectorsView_KeyDown;
            tlp_Layout.ResumeLayout(false);
            tlp_Layout.PerformLayout();
            panel3.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dGV_Collectioners).EndInit();
            panel2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            panel4.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tbSearch;
        private Label lbl_NameSearch;
        private TableLayoutPanel tlp_Layout;
        private DataGridView dGV_Collectioners;
        private TextBox tb_ContactInfo;
        private ComboBox cb_Countries;
        private Label lbl_Contact;
        private Label lbl_Country;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private Button btn_ClearFilters;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label lbl_Title;
    }
}
