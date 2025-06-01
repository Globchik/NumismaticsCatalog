using NumismaticsCatalog.ApplicationData;
using NumismaticsCatalog.InputHandling;
using NumismaticsCatalog.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NumismaticsCatalog.Forms
{
    public partial class FormEditAdditionalTables : Form
    {
        public FormEditAdditionalTables()
        {
            InitializeComponent();
            this.KeyPreview = true;
            LoadCountries();
            LoadMetals();
            LoadCurrency();
        }

        public void LoadCountries()
        {
            SetDGVStyle(dgv_Countries);
            dgv_Countries.DataSource = UserData.Data.Countries;
        }

        public void FilterCountries()
        {
            string filter = tb_Country.Text.ToLower();

            List<Country> filtered_list = new();
            foreach (Country c in UserData.Data.Countries)
                if (c.Name.ToLower().Contains(filter))
                    filtered_list.Add(c);
            dgv_Countries.DataSource = filtered_list;
        }

        public void LoadCurrency()
        {
            SetDGVStyle(dgv_Currency);
            dgv_Currency.DataSource = UserData.Data.Currencies;
        }

        public void FilterCurrency()
        {
            string filter = tb_Currency.Text.ToLower();

            List<Currency> filtered_list = new();
            foreach (Currency c in UserData.Data.Currencies)
                if (c.Name.ToLower().Contains(filter))
                    filtered_list.Add(c);
            dgv_Currency.DataSource = filtered_list;
        }

        public void LoadMetals()
        {
            SetDGVStyle(dgv_Metals);
            dgv_Metals.DataSource = UserData.Data.Metals;
        }

        public void FilterMetals()
        {
            string filter = tb_Metal.Text.ToLower();

            List<Metal> filtered_list = new();
            foreach (Metal c in UserData.Data.Metals)
                if (c.Name.ToLower().Contains(filter))
                    filtered_list.Add(c);
            dgv_Metals.DataSource = filtered_list;
        }

        private void SetDGVStyle(DataGridView grid)
        {
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grid.DefaultCellStyle.Font = new("Verdana", 13);
            grid.ColumnHeadersDefaultCellStyle.Font = new("Verdana", 16);
            grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid.AutoGenerateColumns = false;
            grid.AllowUserToOrderColumns = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.DefaultCellStyle.Padding = new Padding(3);
            DataGridViewTextBoxColumn col = new()
            {
                DataPropertyName = "Name",
                HeaderText = "Назва",
                Name = "NameColumn"
            };
            grid.Columns.Add(col);


        }

        private void DeleteValue<T>(T val) where T : class
        {
            if (typeof(T) == typeof(Country))
            {
                Country? c = val as Country;
                if (c != null)
                {
                    UserData.RemoveCountry(c);
                    FilterCountries();
                }
            }
            else if (typeof(T) == typeof(Currency))
            {
                Currency? c = val as Currency;
                if (c != null)
                    UserData.RemoveCurrency(c);
                FilterCurrency();
            }
            else if (typeof(T) == typeof(Metal))
            {
                Metal? m = val as Metal;
                if (m != null)
                    UserData.RemoveMetal(m);
                FilterMetals();
            }
            else
                throw new NotImplementedException();
        }


        private void CreateContextDelete<T>(DataGridView grid,
            DataGridViewRowContextMenuStripNeededEventArgs e) where T : class
        {
            int selected_row = e.RowIndex;
            grid.ClearSelection();
            grid.Rows[selected_row].Selected = true;
            T? selected = grid.Rows[selected_row].DataBoundItem as T;

            if (selected == null)
                return;

            ContextMenuStrip cms = new();
            ToolStripMenuItem delete = new()
            {
                Text = "Видалити"
            };
            delete.Click += (_, _) =>
            {
                var res = MessageBox.Show("Ви впевнені?", "Видалити",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.OK)
                {
                    DeleteValue(selected);
                }
            };
            cms.Items.Add(delete);
            e.ContextMenuStrip = cms;
        }

        private void ValidateCell(DataGridView grid, DataGridViewCellValidatingEventArgs e)
        {
            string? res = e.FormattedValue?.ToString();
            if (res == null || InputConversion.ConvertString(res, false) == null)
            {
                e.Cancel = true;
                MessageBox.Show("Не порожнє поле не довше 100 символів");
                return;
            }


            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.Index != e.RowIndex &&
                    row.Cells[0].Value != null &&
                    res == row.Cells[0].Value.ToString())
                {
                    e.Cancel = true;
                    MessageBox.Show("Без дублювань");
                    return;
                }
            }

        }

        private void FormEditAdditionalTables_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == '\r')
            {
                e.Handled = true;
                FilterCountries();
                FilterCurrency();
                FilterMetals();
            }
        }

        private void dgv_Countries_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            ValidateCell(dgv_Countries, e);
        }

        private void dgv_Countries_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            CreateContextDelete<Country>(dgv_Countries, e);
        }

        private void dgv_Metals_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            ValidateCell(dgv_Metals, e);
        }

        private void dgv_Metals_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            CreateContextDelete<Metal>(dgv_Metals, e);
        }

        private void dgv_Currency_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            ValidateCell(dgv_Currency, e);
        }

        private void dgv_Currency_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            CreateContextDelete<Currency>(dgv_Currency, e);
        }
    }
}
