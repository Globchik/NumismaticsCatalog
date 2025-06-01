namespace NumismaticsCatalog.Forms
{
    partial class FormEditCollector
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
            tlp_Layout = new System.Windows.Forms.TableLayoutPanel();
            btn_Save = new System.Windows.Forms.Button();
            lbl_Title = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            lbl_Country = new System.Windows.Forms.Label();
            cb_Country = new System.Windows.Forms.ComboBox();
            panel2 = new System.Windows.Forms.Panel();
            tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            tb_Name = new System.Windows.Forms.TextBox();
            lbl_NameSearch = new System.Windows.Forms.Label();
            panel4 = new System.Windows.Forms.Panel();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            lbl_Contact = new System.Windows.Forms.Label();
            tb_ContactInfo = new System.Windows.Forms.TextBox();
            btn_Cancel = new System.Windows.Forms.Button();
            tlp_Layout.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tlp_Layout
            // 
            tlp_Layout.ColumnCount = 4;
            tlp_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tlp_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3333359F));
            tlp_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            tlp_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            tlp_Layout.Controls.Add(btn_Save, 3, 1);
            tlp_Layout.Controls.Add(lbl_Title, 0, 0);
            tlp_Layout.Controls.Add(panel3, 1, 1);
            tlp_Layout.Controls.Add(panel2, 0, 1);
            tlp_Layout.Controls.Add(panel4, 2, 1);
            tlp_Layout.Controls.Add(btn_Cancel, 3, 2);
            tlp_Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            tlp_Layout.Location = new System.Drawing.Point(0, 0);
            tlp_Layout.Name = "tlp_Layout";
            tlp_Layout.Padding = new System.Windows.Forms.Padding(10);
            tlp_Layout.RowCount = 3;
            tlp_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            tlp_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlp_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlp_Layout.Size = new System.Drawing.Size(882, 184);
            tlp_Layout.TabIndex = 4;
            // 
            // btn_Save
            // 
            btn_Save.Dock = System.Windows.Forms.DockStyle.Fill;
            btn_Save.Font = new System.Drawing.Font("Segoe UI", 12F);
            btn_Save.Location = new System.Drawing.Point(761, 75);
            btn_Save.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new System.Drawing.Size(101, 42);
            btn_Save.TabIndex = 12;
            btn_Save.Text = "Зберегти";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            lbl_Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tlp_Layout.SetColumnSpan(lbl_Title, 4);
            lbl_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            lbl_Title.Font = new System.Drawing.Font("Segoe UI", 22F);
            lbl_Title.ForeColor = System.Drawing.Color.White;
            lbl_Title.Location = new System.Drawing.Point(13, 10);
            lbl_Title.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Padding = new System.Windows.Forms.Padding(3);
            lbl_Title.Size = new System.Drawing.Size(856, 55);
            lbl_Title.TabIndex = 11;
            lbl_Title.Text = "Колекціонер";
            lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel3.Controls.Add(tableLayoutPanel3);
            panel3.Location = new System.Drawing.Point(260, 73);
            panel3.Name = "panel3";
            tlp_Layout.SetRowSpan(panel3, 2);
            panel3.Size = new System.Drawing.Size(241, 98);
            panel3.TabIndex = 8;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(lbl_Country, 0, 0);
            tableLayoutPanel3.Controls.Add(cb_Country, 0, 1);
            tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new System.Drawing.Size(239, 96);
            tableLayoutPanel3.TabIndex = 6;
            // 
            // lbl_Country
            // 
            lbl_Country.Anchor = System.Windows.Forms.AnchorStyles.None;
            lbl_Country.AutoSize = true;
            lbl_Country.Font = new System.Drawing.Font("Verdana", 13F);
            lbl_Country.Location = new System.Drawing.Point(80, 13);
            lbl_Country.Name = "lbl_Country";
            lbl_Country.Size = new System.Drawing.Size(79, 22);
            lbl_Country.TabIndex = 5;
            lbl_Country.Text = "Країна:";
            // 
            // cb_Country
            // 
            cb_Country.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cb_Country.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            cb_Country.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            cb_Country.Font = new System.Drawing.Font("Verdana", 12F);
            cb_Country.FormattingEnabled = true;
            cb_Country.Location = new System.Drawing.Point(10, 59);
            cb_Country.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            cb_Country.MaxLength = 100;
            cb_Country.Name = "cb_Country";
            cb_Country.Size = new System.Drawing.Size(219, 26);
            cb_Country.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel2.Controls.Add(tableLayoutPanel4);
            panel2.Location = new System.Drawing.Point(13, 73);
            panel2.Name = "panel2";
            tlp_Layout.SetRowSpan(panel2, 2);
            panel2.Size = new System.Drawing.Size(241, 98);
            panel2.TabIndex = 7;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(tb_Name, 0, 1);
            tableLayoutPanel4.Controls.Add(lbl_NameSearch, 0, 0);
            tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new System.Drawing.Size(239, 96);
            tableLayoutPanel4.TabIndex = 7;
            // 
            // tb_Name
            // 
            tb_Name.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tb_Name.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            tb_Name.Location = new System.Drawing.Point(10, 58);
            tb_Name.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            tb_Name.MaxLength = 100;
            tb_Name.Name = "tb_Name";
            tb_Name.Size = new System.Drawing.Size(219, 27);
            tb_Name.TabIndex = 1;
            // 
            // lbl_NameSearch
            // 
            lbl_NameSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            lbl_NameSearch.AutoSize = true;
            lbl_NameSearch.Font = new System.Drawing.Font("Verdana", 13F);
            lbl_NameSearch.Location = new System.Drawing.Point(92, 13);
            lbl_NameSearch.Name = "lbl_NameSearch";
            lbl_NameSearch.Size = new System.Drawing.Size(55, 22);
            lbl_NameSearch.TabIndex = 2;
            lbl_NameSearch.Text = "Ім'я:";
            // 
            // panel4
            // 
            panel4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel4.Controls.Add(tableLayoutPanel2);
            panel4.Location = new System.Drawing.Point(507, 73);
            panel4.Name = "panel4";
            tlp_Layout.SetRowSpan(panel4, 2);
            panel4.Size = new System.Drawing.Size(241, 98);
            panel4.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(lbl_Contact, 0, 0);
            tableLayoutPanel2.Controls.Add(tb_ContactInfo, 0, 1);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new System.Drawing.Size(239, 96);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // lbl_Contact
            // 
            lbl_Contact.Anchor = System.Windows.Forms.AnchorStyles.None;
            lbl_Contact.AutoSize = true;
            lbl_Contact.Font = new System.Drawing.Font("Verdana", 13F);
            lbl_Contact.Location = new System.Drawing.Point(67, 13);
            lbl_Contact.Name = "lbl_Contact";
            lbl_Contact.Size = new System.Drawing.Size(104, 22);
            lbl_Contact.TabIndex = 6;
            lbl_Contact.Text = "Контакти:";
            // 
            // tb_ContactInfo
            // 
            tb_ContactInfo.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tb_ContactInfo.Font = new System.Drawing.Font("Verdana", 12F);
            tb_ContactInfo.Location = new System.Drawing.Point(10, 58);
            tb_ContactInfo.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            tb_ContactInfo.MaxLength = 100;
            tb_ContactInfo.Name = "tb_ContactInfo";
            tb_ContactInfo.Size = new System.Drawing.Size(219, 27);
            tb_ContactInfo.TabIndex = 3;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 12F);
            btn_Cancel.Location = new System.Drawing.Point(761, 127);
            btn_Cancel.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new System.Drawing.Size(101, 42);
            btn_Cancel.TabIndex = 13;
            btn_Cancel.Text = "Скасувати";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // FormEditCollector
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(882, 184);
            Controls.Add(tlp_Layout);
            MaximumSize = new System.Drawing.Size(1369, 249);
            MinimumSize = new System.Drawing.Size(544, 199);
            Name = "FormEditCollector";
            Text = "FormEditCollector";
            Load += FormEditCollector_Load;
            tlp_Layout.ResumeLayout(false);
            tlp_Layout.PerformLayout();
            panel3.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            panel4.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_Layout;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lbl_Country;
        private System.Windows.Forms.ComboBox cb_Country;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lbl_NameSearch;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_Contact;
        private System.Windows.Forms.TextBox tb_ContactInfo;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
    }
}