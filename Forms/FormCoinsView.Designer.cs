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
            ((System.ComponentModel.ISupportInitialize)dGV_Coins).BeginInit();
            Tlpanel.SuspendLayout();
            SuspendLayout();
            // 
            // dGV_Coins
            // 
            dGV_Coins.AllowUserToAddRows = false;
            dGV_Coins.AllowUserToDeleteRows = false;
            dGV_Coins.AllowUserToOrderColumns = true;
            dGV_Coins.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGV_Coins.Dock = DockStyle.Fill;
            dGV_Coins.Location = new Point(10, 100);
            dGV_Coins.Margin = new Padding(0);
            dGV_Coins.Name = "dGV_Coins";
            dGV_Coins.ReadOnly = true;
            dGV_Coins.Size = new Size(978, 330);
            dGV_Coins.TabIndex = 0;
            // 
            // Tlpanel
            // 
            Tlpanel.ColumnCount = 1;
            Tlpanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Tlpanel.Controls.Add(dGV_Coins, 0, 1);
            Tlpanel.Dock = DockStyle.Fill;
            Tlpanel.Location = new Point(0, 0);
            Tlpanel.Name = "Tlpanel";
            Tlpanel.Padding = new Padding(10);
            Tlpanel.RowCount = 2;
            Tlpanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            Tlpanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Tlpanel.Size = new Size(998, 440);
            Tlpanel.TabIndex = 1;
            // 
            // FormCoinsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 440);
            Controls.Add(Tlpanel);
            MinimumSize = new Size(600, 170);
            Name = "FormCoinsView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Монети";
            Load += FormCoinsList_Load;
            ((System.ComponentModel.ISupportInitialize)dGV_Coins).EndInit();
            Tlpanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dGV_Coins;
        private TableLayoutPanel Tlpanel;
    }
}