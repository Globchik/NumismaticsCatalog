using System;
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
            this.dGV_Coins.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_Coins.DefaultCellStyle.Font = new("Verdana", 10);
            this.dGV_Coins.ColumnHeadersDefaultCellStyle.Font = new("Verdana", 12);
            this.dGV_Coins.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dGV_Coins.AutoGenerateColumns = false;
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
