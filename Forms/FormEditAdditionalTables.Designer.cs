namespace NumismaticsCatalog.Forms
{
    partial class FormEditAdditionalTables
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
            components = new System.ComponentModel.Container();
            tab_Panel = new System.Windows.Forms.TabControl();
            tab_Country = new System.Windows.Forms.TabPage();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            dgv_Countries = new System.Windows.Forms.DataGridView();
            tb_Country = new System.Windows.Forms.TextBox();
            tab_Currency = new System.Windows.Forms.TabPage();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            dgv_Currency = new System.Windows.Forms.DataGridView();
            tb_Currency = new System.Windows.Forms.TextBox();
            tab_Metal = new System.Windows.Forms.TabPage();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            dgv_Metals = new System.Windows.Forms.DataGridView();
            tb_Metal = new System.Windows.Forms.TextBox();
            countryBindingSource = new System.Windows.Forms.BindingSource(components);
            tab_Panel.SuspendLayout();
            tab_Country.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Countries).BeginInit();
            tab_Currency.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Currency).BeginInit();
            tab_Metal.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Metals).BeginInit();
            ((System.ComponentModel.ISupportInitialize)countryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tab_Panel
            // 
            tab_Panel.Controls.Add(tab_Country);
            tab_Panel.Controls.Add(tab_Currency);
            tab_Panel.Controls.Add(tab_Metal);
            tab_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            tab_Panel.Location = new System.Drawing.Point(0, 0);
            tab_Panel.Name = "tab_Panel";
            tab_Panel.SelectedIndex = 0;
            tab_Panel.Size = new System.Drawing.Size(410, 383);
            tab_Panel.TabIndex = 0;
            // 
            // tab_Country
            // 
            tab_Country.Controls.Add(tableLayoutPanel1);
            tab_Country.Location = new System.Drawing.Point(4, 24);
            tab_Country.Name = "tab_Country";
            tab_Country.Padding = new System.Windows.Forms.Padding(3);
            tab_Country.Size = new System.Drawing.Size(402, 355);
            tab_Country.TabIndex = 0;
            tab_Country.Text = "Країни";
            tab_Country.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dgv_Countries, 0, 1);
            tableLayoutPanel1.Controls.Add(tb_Country, 0, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(396, 349);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // dgv_Countries
            // 
            dgv_Countries.AllowUserToAddRows = false;
            dgv_Countries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Countries.ColumnHeadersVisible = false;
            dgv_Countries.Dock = System.Windows.Forms.DockStyle.Fill;
            dgv_Countries.Location = new System.Drawing.Point(3, 53);
            dgv_Countries.MultiSelect = false;
            dgv_Countries.Name = "dgv_Countries";
            dgv_Countries.RowHeadersVisible = false;
            dgv_Countries.Size = new System.Drawing.Size(390, 293);
            dgv_Countries.TabIndex = 0;
            dgv_Countries.CellValidating += dgv_Countries_CellValidating;
            dgv_Countries.RowContextMenuStripNeeded += dgv_Countries_RowContextMenuStripNeeded;
            // 
            // tb_Country
            // 
            tb_Country.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tb_Country.Font = new System.Drawing.Font("Segoe UI", 12F);
            tb_Country.Location = new System.Drawing.Point(3, 10);
            tb_Country.Name = "tb_Country";
            tb_Country.Size = new System.Drawing.Size(390, 29);
            tb_Country.TabIndex = 1;
            // 
            // tab_Currency
            // 
            tab_Currency.Controls.Add(tableLayoutPanel3);
            tab_Currency.Location = new System.Drawing.Point(4, 24);
            tab_Currency.Name = "tab_Currency";
            tab_Currency.Padding = new System.Windows.Forms.Padding(3);
            tab_Currency.Size = new System.Drawing.Size(301, 296);
            tab_Currency.TabIndex = 1;
            tab_Currency.Text = "Валюти";
            tab_Currency.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(dgv_Currency, 0, 1);
            tableLayoutPanel3.Controls.Add(tb_Currency, 0, 0);
            tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new System.Drawing.Size(295, 290);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // dgv_Currency
            // 
            dgv_Currency.AllowUserToAddRows = false;
            dgv_Currency.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Currency.ColumnHeadersVisible = false;
            dgv_Currency.Dock = System.Windows.Forms.DockStyle.Fill;
            dgv_Currency.Location = new System.Drawing.Point(3, 53);
            dgv_Currency.MultiSelect = false;
            dgv_Currency.Name = "dgv_Currency";
            dgv_Currency.RowHeadersVisible = false;
            dgv_Currency.Size = new System.Drawing.Size(289, 234);
            dgv_Currency.TabIndex = 0;
            dgv_Currency.CellValidating += dgv_Currency_CellValidating;
            dgv_Currency.RowContextMenuStripNeeded += dgv_Currency_RowContextMenuStripNeeded;
            // 
            // tb_Currency
            // 
            tb_Currency.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tb_Currency.Font = new System.Drawing.Font("Segoe UI", 12F);
            tb_Currency.Location = new System.Drawing.Point(3, 10);
            tb_Currency.Name = "tb_Currency";
            tb_Currency.Size = new System.Drawing.Size(289, 29);
            tb_Currency.TabIndex = 1;
            // 
            // tab_Metal
            // 
            tab_Metal.Controls.Add(tableLayoutPanel2);
            tab_Metal.Location = new System.Drawing.Point(4, 24);
            tab_Metal.Name = "tab_Metal";
            tab_Metal.Size = new System.Drawing.Size(394, 411);
            tab_Metal.TabIndex = 2;
            tab_Metal.Text = "Метали";
            tab_Metal.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(dgv_Metals, 0, 1);
            tableLayoutPanel2.Controls.Add(tb_Metal, 0, 0);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new System.Drawing.Size(394, 411);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // dgv_Metals
            // 
            dgv_Metals.AllowUserToAddRows = false;
            dgv_Metals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Metals.ColumnHeadersVisible = false;
            dgv_Metals.Dock = System.Windows.Forms.DockStyle.Fill;
            dgv_Metals.Location = new System.Drawing.Point(3, 53);
            dgv_Metals.MultiSelect = false;
            dgv_Metals.Name = "dgv_Metals";
            dgv_Metals.RowHeadersVisible = false;
            dgv_Metals.Size = new System.Drawing.Size(388, 355);
            dgv_Metals.TabIndex = 0;
            dgv_Metals.CellValidating += dgv_Metals_CellValidating;
            dgv_Metals.RowContextMenuStripNeeded += dgv_Metals_RowContextMenuStripNeeded;
            // 
            // tb_Metal
            // 
            tb_Metal.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tb_Metal.Font = new System.Drawing.Font("Segoe UI", 12F);
            tb_Metal.Location = new System.Drawing.Point(3, 10);
            tb_Metal.Name = "tb_Metal";
            tb_Metal.Size = new System.Drawing.Size(388, 29);
            tb_Metal.TabIndex = 1;
            // 
            // countryBindingSource
            // 
            countryBindingSource.DataSource = typeof(Models.Country);
            // 
            // FormEditAdditionalTables
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(410, 383);
            Controls.Add(tab_Panel);
            MinimumSize = new System.Drawing.Size(325, 363);
            Name = "FormEditAdditionalTables";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Інше";
            KeyDown += FormEditAdditionalTables_KeyDown;
            tab_Panel.ResumeLayout(false);
            tab_Country.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Countries).EndInit();
            tab_Currency.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Currency).EndInit();
            tab_Metal.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Metals).EndInit();
            ((System.ComponentModel.ISupportInitialize)countryBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tab_Panel;
        private System.Windows.Forms.TabPage tab_Country;
        private System.Windows.Forms.TabPage tab_Currency;
        private System.Windows.Forms.TabPage tab_Metal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgv_Countries;
        private System.Windows.Forms.TextBox tb_Country;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView dgv_Currency;
        private System.Windows.Forms.TextBox tb_Currency;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgv_Metals;
        private System.Windows.Forms.TextBox tb_Metal;
    }
}