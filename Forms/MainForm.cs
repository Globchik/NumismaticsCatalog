using NumismaticsCatalog.Forms;
using NumismaticsCatalog.Models;
using System.Data;
using System.Windows.Forms;

namespace NumismaticsCatalog
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SetDGVStyle()
        {
            this.dGV_Collectioners.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_Collectioners.DefaultCellStyle.Font = new("Verdana", 12);
            this.dGV_Collectioners.ColumnHeadersDefaultCellStyle.Font = new("Verdana", 15);
            this.dGV_Collectioners.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dGV_Collectioners.AutoGenerateColumns = false;
        }

        private void LoadCollactioners()
        {
            this.dGV_Collectioners.Columns.Clear();
            this.dGV_Collectioners.DataSource = AppData.AppData.Collectors;

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

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetDGVStyle();
            LoadCollactioners();
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

            coin_view.Click += (_, _) => (new FormCoinsList(selected_collector)).ShowDialog();
            cms.Items.Add(coin_view);
            e.ContextMenuStrip = cms;
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                LoadCollactioners();
                CurrencyManager? currencyMan = BindingContext[dGV_Collectioners.DataSource] as CurrencyManager;
                if (currencyMan != null)
                    currencyMan.SuspendBinding();
                for (int i = 0; i < dGV_Collectioners.RowCount; i++)
                {
                    string? val = dGV_Collectioners.Rows[i].Cells[0].Value as string;
                    if (val == null)
                        continue;
                    dGV_Collectioners.Rows[i].Visible = val.ToLower().Contains(tbSearch.Text.ToLower());
                }
                if (currencyMan != null)
                    currencyMan.ResumeBinding();
            }
        }
    }
}
