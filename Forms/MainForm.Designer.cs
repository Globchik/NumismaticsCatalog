namespace NumismaticsCatalog
{
    partial class MainForm
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
            panel1 = new Panel();
            lblSearch = new Label();
            tbSearch = new TextBox();
            dGV_Collectioners = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGV_Collectioners).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblSearch);
            panel1.Controls.Add(tbSearch);
            panel1.Controls.Add(dGV_Collectioners);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 384);
            panel1.TabIndex = 0;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblSearch.Location = new Point(5, 6);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(67, 18);
            lblSearch.TabIndex = 2;
            lblSearch.Text = "Пошук:";
            // 
            // tbSearch
            // 
            tbSearch.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbSearch.Location = new Point(78, 3);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(252, 27);
            tbSearch.TabIndex = 1;
            tbSearch.KeyPress += tbSearch_KeyPress;
            // 
            // dGV_Collectioners
            // 
            dGV_Collectioners.AllowUserToAddRows = false;
            dGV_Collectioners.AllowUserToDeleteRows = false;
            dGV_Collectioners.AllowUserToOrderColumns = true;
            dGV_Collectioners.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGV_Collectioners.Location = new Point(3, 36);
            dGV_Collectioners.Name = "dGV_Collectioners";
            dGV_Collectioners.ReadOnly = true;
            dGV_Collectioners.Size = new Size(770, 345);
            dGV_Collectioners.TabIndex = 0;
            dGV_Collectioners.RowContextMenuStripNeeded += dGV_Collectioners_RowContextMenuStripNeeded;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 408);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "Довідник Нумізмата";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dGV_Collectioners).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dGV_Collectioners;
        private TextBox tbSearch;
        private Label lblSearch;
    }
}
