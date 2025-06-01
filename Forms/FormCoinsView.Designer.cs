using System.Drawing;
using System.Windows.Forms;

namespace NumismaticsCatalog.Forms
{
    partial class FormCoinsView
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
            dGV_Coins = new DataGridView();
            Tlpanel = new TableLayoutPanel();
            btn_ClearFilters = new Button();
            lbl_Title = new Label();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            tb_Notes = new TextBox();
            panel6 = new Panel();
            tableLayoutPanel6 = new TableLayoutPanel();
            label6 = new Label();
            tb_Metals = new TextBox();
            panel5 = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            label5 = new Label();
            tb_Nominal = new TextBox();
            panel4 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            label4 = new Label();
            tb_Amount = new TextBox();
            panel3 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            label3 = new Label();
            cb_Country = new ComboBox();
            panel2 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            tb_Year = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dGV_Coins).BeginInit();
            Tlpanel.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel6.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // dGV_Coins
            // 
            dGV_Coins.AllowUserToAddRows = false;
            dGV_Coins.AllowUserToDeleteRows = false;
            dGV_Coins.AllowUserToOrderColumns = true;
            dGV_Coins.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Tlpanel.SetColumnSpan(dGV_Coins, 7);
            dGV_Coins.Dock = DockStyle.Fill;
            dGV_Coins.Location = new Point(10, 152);
            dGV_Coins.Margin = new Padding(0, 7, 0, 0);
            dGV_Coins.Name = "dGV_Coins";
            dGV_Coins.ReadOnly = true;
            dGV_Coins.Size = new Size(1178, 412);
            dGV_Coins.TabIndex = 0;
            dGV_Coins.RowContextMenuStripNeeded += dGV_Coins_RowContextMenuStripNeeded;
            // 
            // Tlpanel
            // 
            Tlpanel.ColumnCount = 7;
            Tlpanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666718F));
            Tlpanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            Tlpanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            Tlpanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            Tlpanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            Tlpanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            Tlpanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            Tlpanel.Controls.Add(btn_ClearFilters, 6, 1);
            Tlpanel.Controls.Add(lbl_Title, 0, 0);
            Tlpanel.Controls.Add(panel1, 5, 1);
            Tlpanel.Controls.Add(panel6, 4, 1);
            Tlpanel.Controls.Add(panel5, 3, 1);
            Tlpanel.Controls.Add(panel4, 2, 1);
            Tlpanel.Controls.Add(panel3, 1, 1);
            Tlpanel.Controls.Add(dGV_Coins, 0, 2);
            Tlpanel.Controls.Add(panel2, 0, 1);
            Tlpanel.Dock = DockStyle.Fill;
            Tlpanel.Location = new Point(0, 0);
            Tlpanel.Name = "Tlpanel";
            Tlpanel.Padding = new Padding(10);
            Tlpanel.RowCount = 3;
            Tlpanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            Tlpanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            Tlpanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Tlpanel.Size = new Size(1198, 574);
            Tlpanel.TabIndex = 1;
            // 
            // btn_ClearFilters
            // 
            btn_ClearFilters.Dock = DockStyle.Fill;
            btn_ClearFilters.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_ClearFilters.Location = new Point(1147, 73);
            btn_ClearFilters.Name = "btn_ClearFilters";
            btn_ClearFilters.Size = new Size(38, 69);
            btn_ClearFilters.TabIndex = 11;
            btn_ClearFilters.Text = "X";
            btn_ClearFilters.UseVisualStyleBackColor = true;
            btn_ClearFilters.Click += btn_ClearFilters_Click;
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.BackColor = SystemColors.ControlDarkDark;
            lbl_Title.BorderStyle = BorderStyle.FixedSingle;
            Tlpanel.SetColumnSpan(lbl_Title, 7);
            lbl_Title.Dock = DockStyle.Fill;
            lbl_Title.Font = new Font("Segoe UI", 22F);
            lbl_Title.ForeColor = Color.White;
            lbl_Title.Location = new Point(13, 10);
            lbl_Title.Margin = new Padding(3, 0, 3, 5);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Padding = new Padding(3);
            lbl_Title.Size = new Size(1172, 55);
            lbl_Title.TabIndex = 4;
            lbl_Title.Text = "Монети";
            lbl_Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(958, 73);
            panel1.MinimumSize = new Size(120, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 73);
            panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tb_Notes, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(181, 71);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 13F);
            label1.Location = new Point(42, 6);
            label1.Name = "label1";
            label1.Size = new Size(97, 22);
            label1.TabIndex = 0;
            label1.Text = "Примітки";
            // 
            // tb_Notes
            // 
            tb_Notes.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tb_Notes.Font = new Font("Verdana", 12F);
            tb_Notes.Location = new Point(3, 39);
            tb_Notes.Name = "tb_Notes";
            tb_Notes.Size = new Size(175, 27);
            tb_Notes.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(tableLayoutPanel6);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(769, 73);
            panel6.MinimumSize = new Size(120, 73);
            panel6.Name = "panel6";
            panel6.Size = new Size(183, 73);
            panel6.TabIndex = 3;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(label6, 0, 0);
            tableLayoutPanel6.Controls.Add(tb_Metals, 0, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(181, 71);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 13F);
            label6.Location = new Point(57, 6);
            label6.Name = "label6";
            label6.Size = new Size(67, 22);
            label6.TabIndex = 0;
            label6.Text = "Склад";
            // 
            // tb_Metals
            // 
            tb_Metals.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tb_Metals.Font = new Font("Verdana", 12F);
            tb_Metals.Location = new Point(3, 39);
            tb_Metals.Name = "tb_Metals";
            tb_Metals.Size = new Size(175, 27);
            tb_Metals.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(tableLayoutPanel5);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(580, 73);
            panel5.MinimumSize = new Size(120, 73);
            panel5.Name = "panel5";
            panel5.Size = new Size(183, 73);
            panel5.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(label5, 0, 0);
            tableLayoutPanel5.Controls.Add(tb_Nominal, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(181, 71);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 13F);
            label5.Location = new Point(47, 6);
            label5.Name = "label5";
            label5.Size = new Size(86, 22);
            label5.TabIndex = 0;
            label5.Text = "Номінал";
            // 
            // tb_Nominal
            // 
            tb_Nominal.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tb_Nominal.Font = new Font("Verdana", 12F);
            tb_Nominal.Location = new Point(3, 39);
            tb_Nominal.Name = "tb_Nominal";
            tb_Nominal.Size = new Size(175, 27);
            tb_Nominal.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(tableLayoutPanel4);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(391, 73);
            panel4.MinimumSize = new Size(120, 73);
            panel4.Name = "panel4";
            panel4.Size = new Size(183, 73);
            panel4.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(label4, 0, 0);
            tableLayoutPanel4.Controls.Add(tb_Amount, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(181, 71);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 13F);
            label4.Location = new Point(44, 6);
            label4.Name = "label4";
            label4.Size = new Size(93, 22);
            label4.TabIndex = 0;
            label4.Text = "Кількість";
            // 
            // tb_Amount
            // 
            tb_Amount.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tb_Amount.Font = new Font("Verdana", 12F);
            tb_Amount.Location = new Point(3, 39);
            tb_Amount.Name = "tb_Amount";
            tb_Amount.Size = new Size(175, 27);
            tb_Amount.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(tableLayoutPanel3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(202, 73);
            panel3.MinimumSize = new Size(120, 73);
            panel3.Name = "panel3";
            panel3.Size = new Size(183, 73);
            panel3.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(label3, 0, 0);
            tableLayoutPanel3.Controls.Add(cb_Country, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(181, 71);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 13F);
            label3.Location = new Point(55, 6);
            label3.Name = "label3";
            label3.Size = new Size(71, 22);
            label3.TabIndex = 0;
            label3.Text = "Країна";
            // 
            // cb_Country
            // 
            cb_Country.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cb_Country.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb_Country.Font = new Font("Verdana", 12F);
            cb_Country.FormattingEnabled = true;
            cb_Country.Location = new Point(3, 40);
            cb_Country.Name = "cb_Country";
            cb_Country.Size = new Size(175, 26);
            cb_Country.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(13, 73);
            panel2.MinimumSize = new Size(120, 73);
            panel2.Name = "panel2";
            panel2.Size = new Size(183, 73);
            panel2.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(tb_Year, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(181, 71);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 13F);
            label2.Location = new Point(72, 6);
            label2.Name = "label2";
            label2.Size = new Size(37, 22);
            label2.TabIndex = 0;
            label2.Text = "Рік";
            // 
            // tb_Year
            // 
            tb_Year.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tb_Year.Font = new Font("Verdana", 12F);
            tb_Year.Location = new Point(6, 39);
            tb_Year.Margin = new Padding(6, 3, 6, 3);
            tb_Year.MaxLength = 4;
            tb_Year.Name = "tb_Year";
            tb_Year.Size = new Size(169, 27);
            tb_Year.TabIndex = 1;
            // 
            // FormCoinsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 574);
            Controls.Add(Tlpanel);
            MinimumSize = new Size(909, 286);
            Name = "FormCoinsView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Монети";
            Load += FormCoinsList_Load;
            KeyDown += FormCoinsView_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dGV_Coins).EndInit();
            Tlpanel.ResumeLayout(false);
            Tlpanel.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel6.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            panel5.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            panel4.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            panel3.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dGV_Coins;
        private TableLayoutPanel Tlpanel;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox tb_Notes;
        private Panel panel6;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label6;
        private TextBox tb_Metals;
        private Panel panel5;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label5;
        private TextBox tb_Nominal;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label4;
        private TextBox tb_Amount;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label3;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private TextBox tb_Year;
        private Label lbl_Title;
        private Button btn_ClearFilters;
        private ComboBox cb_Country;
    }
}