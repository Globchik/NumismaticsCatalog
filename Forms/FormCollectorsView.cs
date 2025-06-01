using NumismaticsCatalog.ApplicationData;
using NumismaticsCatalog.Forms;
using NumismaticsCatalog.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace NumismaticsCatalog
{
    public partial class FormCollectorsView : Form
    {
        private List<Collector> collectors_list = UserData.Data.Collectors;
        public FormCollectorsView()
        {
            InitializeComponent();
            this.Text = "������������";
        }

        public FormCollectorsView(Coin coin)
        {
            InitializeComponent();
            this.Text = $"������������ - ����� ������ {coin.CoinCurrency} " +
                $"{coin.CoinValueString} {coin.YearOfIssue}";

            List<Collector> collectors_by_coin = new();
            foreach(Collector c in UserData.Data.Collectors)
            {
                if (c.CoinCollection.Contains(coin))
                    collectors_by_coin.Add(c);
            }
            this.collectors_list = collectors_by_coin;
        }

        private void SetDGVStyle()
        {
            var grid = this.dGV_Collectioners;
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

        private void LoadCollactioners()
        {
            this.dGV_Collectioners.Columns.Clear();
            this.dGV_Collectioners.DataSource = this.collectors_list;

            DataGridViewTextBoxColumn col = new()
            {
                DataPropertyName = "Name",
                HeaderText = "��'�",
                Name = "NameColumn"
            };
            this.dGV_Collectioners.Columns.Add(col);

            col = new()
            {
                DataPropertyName = "CountryString",
                HeaderText = "�����",
                Name = "CountryColumn"
            };
            this.dGV_Collectioners.Columns.Add(col);

            col = new()
            {
                DataPropertyName = "ContactInformation",
                HeaderText = "��������",
                Name = "ContactColumn"
            };
            this.dGV_Collectioners.Columns.Add(col);
        }

        private void LoadCountriesComboBox()
        {
            this.cb_Countries.DataSource = UserData.Data.Countries;
            this.cb_Countries.DisplayMember = "Name";
            this.cb_Countries.SelectedIndex = -1;
        }

        private void ApplyFilters()
        {
            string namef = tbSearch.Text.ToLower();
            string countryf = cb_Countries.Text.ToLower();
            string contactf = tb_ContactInfo.Text.ToLower();

            List<Collector> filtered_list = new();
            foreach (Collector c in this.collectors_list)
            {
                string countryn = c.Country == null ?
                    "" : c.Country.Name;
                if (c.Name.ToLower().Contains(namef) &&
                    countryn.ToLower().Contains(countryf) &&
                    c.ContactInformation.ToLower().Contains(contactf))
                    filtered_list.Add(c);
            }
            this.dGV_Collectioners.DataSource = filtered_list;

            if (filtered_list.Count == 0)
                MessageBox.Show("�� �������� ������� ������������!", "����� ���������", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClearFilters()
        {
            this.tbSearch.Text = "";
            this.tb_ContactInfo.Text = "";
            this.cb_Countries.Text = "";

            this.dGV_Collectioners.DataSource = this.collectors_list;
        }

        private void dGV_Collectioners_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            ContextMenuStrip cms = new();
            ToolStripMenuItem coin_view = new()
            {
                Text = "�������� �����"
            };

            int selected_row = e.RowIndex;
            this.dGV_Collectioners.ClearSelection();
            this.dGV_Collectioners.Rows[selected_row].Selected = true;

            Collector? selected_collector = dGV_Collectioners.Rows[selected_row].DataBoundItem as Collector;
            if (selected_collector == null)
                return;

            coin_view.Click += (_, _) => (new FormCoinsView(selected_collector)).ShowDialog();
            cms.Items.Add(coin_view);
            e.ContextMenuStrip = cms;
        }


        private void btn_ClearFilters_Click(object sender, EventArgs e)
        {
            ClearFilters();
        }

        private void FormCollectorsView_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            SetDGVStyle();
            LoadCollactioners();
            LoadCountriesComboBox();
            ApplyFilters();
        }

        private void FormCollectorsView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '\r')
            {
                ApplyFilters();
                e.Handled = true;
            }
        }
    }
}
