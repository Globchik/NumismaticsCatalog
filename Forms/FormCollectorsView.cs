using NumismaticsCatalog.AppData;
using NumismaticsCatalog.Forms;
using NumismaticsCatalog.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace NumismaticsCatalog
{
    public partial class FormCollectorsView : Form
    {
        public FormCollectorsView()
        {
            InitializeComponent();
        }

        private void SetDGVStyle()
        {
            var grid = this.dGV_Collectioners;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.DefaultCellStyle.Font = new("Verdana", 12);
            grid.ColumnHeadersDefaultCellStyle.Font = new("Verdana", 15);
            grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid.AutoGenerateColumns = false;
            grid.ReadOnly = true;
            grid.AllowUserToOrderColumns = false;
            grid.RowHeadersVisible = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadCollactioners()
        {
            this.dGV_Collectioners.Columns.Clear();
            this.dGV_Collectioners.DataSource = UserData.Data.Collectors;

            DataGridViewTextBoxColumn col = new()
            {
                DataPropertyName = "Name",
                HeaderText = "Ім'я",
                Name = "NameColumn"
            };
            this.dGV_Collectioners.Columns.Add(col);

            col = new()
            {
                DataPropertyName = "CountryString",
                HeaderText = "Країна",
                Name = "CountryColumn"
            };
            this.dGV_Collectioners.Columns.Add(col);

            col = new()
            {
                DataPropertyName = "ContactInformation",
                HeaderText = "Контакти",
                Name = "ContactColumn"
            };
            this.dGV_Collectioners.Columns.Add(col);
        }

        private void LoadCountriesComboBox()
        {
            this.cb_Countries.DataSource = AppData.UserData.Data.Countries;
            this.cb_Countries.DisplayMember = "Name";
            this.cb_Countries.SelectedIndex = -1;
        }

        private void ApplySearchFilter()
        {
            CurrencyManager? currencyMan = BindingContext?[dGV_Collectioners.DataSource] as CurrencyManager;
            if (currencyMan != null)
                currencyMan.SuspendBinding();

            for (int i = 0; i < dGV_Collectioners.RowCount; i++)
            {
                bool is_visible = true;
                string? val = dGV_Collectioners.Rows[i].Cells[0].Value as string;
                if (val != null)
                    is_visible = val.ToLower().Contains(tbSearch.Text.ToLower());

                val = dGV_Collectioners.Rows[i].Cells[1].Value as string;
                if (val != null)
                    is_visible = is_visible && val.ToLower().Contains(cb_Countries.Text.ToLower());

                val = dGV_Collectioners.Rows[i].Cells[2].Value as string;
                if (val != null)
                    is_visible = is_visible && val.ToLower().Contains(tb_ContactInfo.Text.ToLower());

                dGV_Collectioners.Rows[i].Visible = is_visible;
            }

            if (currencyMan != null)
                currencyMan.ResumeBinding();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            SetDGVStyle();
            LoadCollactioners();
            LoadCountriesComboBox();
        }

        private void dGV_Collectioners_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            ContextMenuStrip cms = new();
            ToolStripMenuItem coin_view = new()
            {
                Text = "Перегляд монет"
            };
            int selected_row = e.RowIndex;
            Collector? selected_collector = dGV_Collectioners.Rows[selected_row].DataBoundItem as Collector;
            if (selected_collector == null)
                return;

            coin_view.Click += (_, _) => (new FormCoinsView(selected_collector)).ShowDialog();
            cms.Items.Add(coin_view);
            e.ContextMenuStrip = cms;
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                ApplySearchFilter();
                e.Handled = true;
            }
            
        }
    }
}
