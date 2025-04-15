namespace NumismaticsCatalog.Forms
{
    partial class FormCoinsList
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
            ((System.ComponentModel.ISupportInitialize)dGV_Coins).BeginInit();
            SuspendLayout();
            // 
            // dGV_Coins
            // 
            dGV_Coins.AllowUserToAddRows = false;
            dGV_Coins.AllowUserToDeleteRows = false;
            dGV_Coins.AllowUserToOrderColumns = true;
            dGV_Coins.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGV_Coins.Location = new Point(12, 12);
            dGV_Coins.Name = "dGV_Coins";
            dGV_Coins.ReadOnly = true;
            dGV_Coins.Size = new Size(809, 326);
            dGV_Coins.TabIndex = 0;
            // 
            // FormCoinsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 350);
            Controls.Add(dGV_Coins);
            Name = "FormCoinsList";
            Text = "Монети";
            Load += FormCoinsList_Load;
            ((System.ComponentModel.ISupportInitialize)dGV_Coins).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dGV_Coins;
    }
}