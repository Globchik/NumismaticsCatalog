using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using NumismaticsCatalog.ApplicationData;
using NumismaticsCatalog.Models;

namespace NumismaticsCatalog.Forms
{
    public partial class FormCoinsView : Form
    {
        List<Coin> coins_list;
        public Coin? CoinToAdd { get; set; }
        public enum FormCoinsViewType { All, Collector, PersonalCollection, AddCoin }

        private FormCoinsViewType form_type = FormCoinsViewType.All;
        public FormCoinsView(FormCoinsViewType type)
        {
            InitializeComponent();
            this.form_type = type;
            if (type == FormCoinsViewType.All ||
                type == FormCoinsViewType.AddCoin)
            {
                this.Text = "Монети";
                this.lbl_Title.Text = "Монети";
                coins_list = UserData.Data.Coins;
            }
            else if (type == FormCoinsViewType.PersonalCollection)
            {
                this.Text = "Власна колекція";
                this.lbl_Title.Text = "Власна колекція";
                coins_list = UserData.Data.MyCoins;
            }
            else
                throw new NotImplementedException();
        }

        public FormCoinsView(Collector collector)
        {
            InitializeComponent();
            form_type = FormCoinsViewType.Collector;
            this.Text = "Монети - " + collector.Name;
            this.lbl_Title.Text = collector.Name;
            coins_list = collector.CoinCollection;
        }

        private void SetDGVStyle()
        {
            var grid = this.dGV_Coins;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grid.DefaultCellStyle.Font = new("Verdana", 12);
            grid.ColumnHeadersDefaultCellStyle.Font = new("Verdana", 14);
            grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid.AutoGenerateColumns = false;
            grid.ReadOnly = true;
            grid.AllowUserToOrderColumns = false;
            grid.RowHeadersVisible = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.DefaultCellStyle.Padding = new Padding(3);

            if (form_type == FormCoinsViewType.All)
            {
                ContextMenuStrip cms = new();
                ToolStripMenuItem create_coin = new()
                {
                    Text = "Створити нову монету"
                };
                create_coin.Click += (_, _) =>
                {
                    (new FormEditCoin()).ShowDialog();
                    ApplyFilters();
                };
                cms.Items.Add(create_coin);
                grid.ContextMenuStrip = cms;
            }
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
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dGV_Coins.Columns.Add(col);

            col = new()
            {
                DataPropertyName = "CountryString",
                HeaderText = "Країна",
                Name = "CountryColumn"
            };
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dGV_Coins.Columns.Add(col);

            col = new()
            {
                DataPropertyName = "AmountIssued",
                HeaderText = "Кількість виготовлених",
                Name = "AmountIssuedColumn"
            };
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dGV_Coins.Columns.Add(col);

            col = new()
            {
                DataPropertyName = "CoinValueString",
                HeaderText = "Номінал",
                Name = "CoinValueColumn"
            };
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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

        private void LoadCountriesComboBox()
        {
            this.cb_Country.DataSource = UserData.Data.Countries;
            this.cb_Country.DisplayMember = "Name";
            this.cb_Country.SelectedIndex = -1;
        }

        private void LoadMetalsSuggestions()
        {
            this.cb_Country.AutoCompleteSource
                 = AutoCompleteSource.CustomSource;
            this.cb_Country.AutoCompleteMode
                 = AutoCompleteMode.Suggest;

            AutoCompleteStringCollection metal_names = new();
            foreach (Metal m in UserData.Data.Metals)
                metal_names.Add(m.Name);
            this.cb_Country.AutoCompleteCustomSource =
                metal_names;
        }

        private void ApplyFilters()
        {
            string yearf = tb_Year.Text.ToLower().Trim();
            string countryf = cb_Country.Text.ToLower().Trim();
            string amountf = tb_Amount.Text.ToLower().Trim();
            string nominalf = tb_Nominal.Text.ToLower().Trim();

            string metalsf = tb_Metals.Text.ToLower().Trim();
            string[] metalf_arr =
                metalsf.Split(',', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < metalf_arr.Length; i++)
                metalf_arr[i] = metalf_arr[i].Trim().ToLower();

            string notesf = tb_Notes.Text.ToLower().Trim();

            List<Coin> filtered_list = new();
            foreach (Coin c in this.coins_list)
            {
                string countryn = c.Country == null ?
                    "" : c.Country.Name;
                string amount = c.AmountIssued == null ?
                    "" : c.AmountIssued.Value.ToString();


                bool filter_passsed =
                    c.YearOfIssue.ToString().Contains(yearf) &&
                    countryn.ToLower().Contains(countryf) &&
                    amount.Contains(amountf) &&
                    c.CoinValueString.Contains(nominalf) &&
                    c.Notes.Contains(notesf);

                foreach (string s in metalf_arr)
                    if (!filter_passsed)
                        break;
                    else
                        filter_passsed = c.MetalContentString.Contains(s);

                if (filter_passsed)
                    filtered_list.Add(c);
            }
            this.dGV_Coins.DataSource = filtered_list;

            if (filtered_list.Count == 0)
                MessageBox.Show("Не знайдено жодної монети!", "Пошук Завершено",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClearFilters()
        {
            tb_Year.Text = "";
            cb_Country.Text = "";
            tb_Amount.Text = "";
            tb_Nominal.Text = "";
            tb_Metals.Text = "";
            tb_Notes.Text = "";

            this.dGV_Coins.DataSource = this.coins_list;
        }

        private void DeleteCoinDialog(Coin coin)
        {
            var res =
                MessageBox.Show($"Видалити монету {coin.ToString()}?", "Увага",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (res == DialogResult.Yes)
            {
                UserData.Data.Coins.Remove(coin);
                ApplyFilters();
            }
               
        }

        private void SelectCoinToAdd(Coin coin)
        {
            CoinToAdd = coin;
            this.Close();
        }

        private void FormCoinsList_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            SetDGVStyle();
            LoadCoins();
            LoadCountriesComboBox();
            LoadMetalsSuggestions();
            ApplyFilters();
        }

        private void btn_ClearFilters_Click(object sender, EventArgs e)
        {
            ClearFilters();
        }

        private void FormCoinsView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '\r')
            {
                ApplyFilters();
                e.Handled = true;
            }
        }

        private void dGV_Coins_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            int selected_row = e.RowIndex;
            this.dGV_Coins.ClearSelection();
            this.dGV_Coins.Rows[selected_row].Selected = true;
            Coin? selected_coin = dGV_Coins.Rows[selected_row].DataBoundItem as Coin;

            ContextMenuStrip cms = new();

            if (selected_coin != null)
            {
                if (form_type == FormCoinsViewType.All)
                {
                    ToolStripMenuItem edit_coin = new()
                    {
                        Text = "Редагувати"
                    };
                    edit_coin.Click += (_, _) => {
                        (new FormEditCoin(selected_coin)).ShowDialog();
                        ApplyFilters();
                    };
                    cms.Items.Add(edit_coin);

                    ToolStripMenuItem delete_coin = new()
                    {
                        Text = "Видалити"
                    };
                    delete_coin.Click += (_, _) => DeleteCoinDialog(selected_coin);
                    cms.Items.Add(delete_coin);
                }
                if (form_type == FormCoinsViewType.AddCoin)
                {
                    ToolStripMenuItem add_coin = new()
                    {
                        Text = "Додати до колекції"
                    };
                    add_coin.Click += (_, _) => SelectCoinToAdd(selected_coin);
                    cms.Items.Add(add_coin);
                }
            }

            if (form_type == FormCoinsViewType.All)
            {
                ToolStripMenuItem create_coin = new()
                {
                    Text = "Створити нову монету"
                };
                create_coin.Click += (_, _) => {
                    (new FormEditCoin()).ShowDialog();
                    ApplyFilters();  
                    };
                cms.Items.Add(create_coin);
            }

            e.ContextMenuStrip = cms;
        }
    }
}
