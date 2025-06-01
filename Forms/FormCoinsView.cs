using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NumismaticsCatalog.ApplicationData;
using NumismaticsCatalog.Models;

namespace NumismaticsCatalog.Forms
{
    public partial class FormCoinsView : Form
    {
        List<Coin> coins_list = new();

        public enum FormCoinsViewType { All, Collector, PersonalCollection}

        private FormCoinsViewType form_type = FormCoinsViewType.All;
        public FormCoinsView(FormCoinsViewType type)
        {
            InitializeComponent();
            this.form_type = type;
            if (type == FormCoinsViewType.All)
            {
                this.Text = "Монети";
                coins_list = UserData.Data.Coins;
            }
            else if(type == FormCoinsViewType.PersonalCollection)
            {
                this.Text = "Власна колекція";
                coins_list = UserData.Data.MyCoins;
            }
               
        }

        public FormCoinsView(Collector collector)
        {
            InitializeComponent();
            form_type = FormCoinsViewType.Collector;
            this.Text = "Монети - " + collector.Name;
            coins_list = collector.CoinCollection;
        }

        private void SetDGVStyle()
        {
            var grid = this.dGV_Coins;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grid.DefaultCellStyle.Font = new("Verdana", 13);
            grid.ColumnHeadersDefaultCellStyle.Font = new("Verdana", 16);
            grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid.AutoGenerateColumns = false;
            grid.ReadOnly = true;
            grid.AllowUserToOrderColumns = false;
            grid.RowHeadersVisible = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.DefaultCellStyle.Padding = new Padding(3);
        }

        private void LoadCoins()
        {
            this.dGV_Coins.Columns.Clear();
            this.dGV_Coins.Rows.Clear();

            this.dGV_Coins.DataSource = coins_list;

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
