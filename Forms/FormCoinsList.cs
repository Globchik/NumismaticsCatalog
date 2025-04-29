using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NumismaticsCatalog.Models;

namespace NumismaticsCatalog.Forms
{
    public partial class FormCoinsList : Form
    {
        List<Coin> coins = new();
        public FormCoinsList()
        {
            InitializeComponent();
        }

        public FormCoinsList(Collector collector)
        {
            InitializeComponent();
            this.Text = "Монети - " + collector.Name;
            coins = collector.CoinCollection;
        }
        private void SetDGVStyle()
        {
            var grid = this.dGV_Coins;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.DefaultCellStyle.Font = new("Verdana", 10);
            grid.ColumnHeadersDefaultCellStyle.Font = new("Verdana", 12);
            grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid.AutoGenerateColumns = false;
            grid.ReadOnly = true;
            grid.AllowUserToOrderColumns = false;
            grid.RowHeadersVisible = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadCoins()
        {
            this.dGV_Coins.Columns.Clear();
            this.dGV_Coins.Rows.Clear();

            this.dGV_Coins.DataSource = coins;

            DataGridViewTextBoxColumn col = new()
            {
                DataPropertyName = "YearOfIssue",
                HeaderText = "Рік",
                Name = "YearOfIssueColumn"
            };
            this.dGV_Coins.Columns.Add(col);

            col = new()
            {
                DataPropertyName = "CountryString",
                HeaderText = "Країна",
                Name = "CountryColumn"
            };
            this.dGV_Coins.Columns.Add(col);

            col = new()
            {
                DataPropertyName = "AmountIssued",
                HeaderText = "Кількість виготовлених",
                Name = "AmountIssuedColumn"
            };
            this.dGV_Coins.Columns.Add(col);

            col = new()
            {
                DataPropertyName = "CoinValueString",
                HeaderText = "Номінал",
                Name = "CoinValueColumn"
            };
            this.dGV_Coins.Columns.Add(col);

            col = new()
            {
                DataPropertyName = "MetalContentString",
                HeaderText = "Склад",
                Name = "MetalContentColumn"
            };
            this.dGV_Coins.Columns.Add(col);

            col = new()
            {
                DataPropertyName = "Notes",
                HeaderText = "Примітки",
                Name = "NotesColumn"
            };
            this.dGV_Coins.Columns.Add(col);
        }

        private void FormCoinsList_Load(object sender, EventArgs e)
        {
            SetDGVStyle();
            LoadCoins();
        }
    }
}
