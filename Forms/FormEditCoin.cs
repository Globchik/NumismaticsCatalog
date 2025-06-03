using NumismaticsCatalog.ApplicationData;
using NumismaticsCatalog.Models;
using NumismaticsCatalog.InputHandling;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NumismaticsCatalog.Forms
{
    public partial class FormEditCoin : Form
    {
        public Coin CoinToEdit { get; set; }
        bool create_new;

        public FormEditCoin()
        {
            InitializeComponent();
            CoinToEdit = new();
            create_new = true;
        }

        public FormEditCoin(Coin coin_to_edit)
        {
            InitializeComponent();
            CoinToEdit = coin_to_edit;
            create_new = false;
        }

        private void ClearInputs()
        {
            tb_Year.Text = String.Empty;
            cb_Country.Text = String.Empty;
            tb_Nominal.Text = String.Empty;
            cb_Currency.Text = String.Empty;
            tb_Metals.Text = String.Empty;
            tb_Amount.Text = String.Empty;
            tb_Notes.Text = String.Empty;
        }

        private void LoadCoinToInputs()
        {
            tb_Year.Text = CoinToEdit.YearOfIssue.ToString();
            cb_Country.Text = CoinToEdit.CountryString;
            tb_Nominal.Text = CoinToEdit.CoinValue.ToString();
            cb_Currency.Text = CoinToEdit.CoinCurrency?.Name;
            tb_Metals.Text = CoinToEdit.MetalContentString;
            tb_Amount.Text = CoinToEdit.AmountIssued.ToString();
            tb_Notes.Text = CoinToEdit.Notes;
        }

        private void LoadCoinData()
        {
            if (create_new)
                ClearInputs();
            else
                LoadCoinToInputs();
        }

        private void LoadCountrySuggestions()
        {
            cb_Country.DataSource = UserData.Data.Countries;
            cb_Country.DisplayMember = "Name";
            cb_Country.SelectedIndex = -1;
        }

        private void LoadCurrencySuggestions()
        {
            cb_Currency.DataSource = UserData.Data.Currencies;
            cb_Currency.DisplayMember = "Name";
            cb_Currency.SelectedIndex = -1;
        }

        private void LoadMetalsSuggestions()
        {
            this.tb_Metals.AutoCompleteSource
                 = AutoCompleteSource.CustomSource;
            this.tb_Metals.AutoCompleteMode
                 = AutoCompleteMode.Append;

            AutoCompleteStringCollection metal_names = new();
            foreach (Metal m in UserData.Data.Metals)
                metal_names.Add(m.Name);
            this.tb_Metals.AutoCompleteCustomSource =
                metal_names;
        }

        public void ApplyEditing()
        {
            //Check all fields
            int? year = InputConversion.ConvertToYear(tb_Year.Text);
            if (year == null)
                throw new ArgumentException("Не вірно визначено рік виготовлення монети!");

            string? country = InputConversion.ConvertString(cb_Country.Text, false);
            if (country == null)
                throw new ArgumentException("Не вірно визначено країну виготовлення монети!");

            float? nominal = InputConversion.ConvertToCoinValue(tb_Nominal.Text);
            if (nominal == null)
                throw new ArgumentException("Не вірно визначено номінал монети!");

            string? currency = InputConversion.ConvertString(cb_Currency.Text, false);
            if (currency == null)
                throw new ArgumentException("Не вірно визначено валюту монети!");

            int? amount = InputConversion.ConvertToAmount(tb_Amount.Text);
            if(amount == null && tb_Amount.Text.Length != 0)
                throw new ArgumentException("Не вірно визначено кількість виготовлених монет!");

            string? notes = InputConversion.ConvertString(tb_Notes.Text);
            string[] metals = tb_Metals.Text.Split(',', StringSplitOptions.RemoveEmptyEntries);


            //Create new fields
            Country? coin_country = UserData.Data.Countries.Find(
                x => x.Name.ToLower() == country.ToLower()
                );
            if (coin_country == null)
            {
                coin_country = new(country);
                UserData.Data.Countries.Add(coin_country);
            }

            Currency? coin_currency = UserData.Data.Currencies.Find(
                x => x.Name.ToLower() == currency.ToLower()
                );
            if (coin_currency == null)
            {
                coin_currency = new(currency);
                UserData.Data.Currencies.Add(coin_currency);
            }
            List<Metal> coin_metals = new();
            foreach (string metal in metals)
            {
                Metal? coin_metal = UserData.Data.Metals.Find(
                x => x.Name.ToLower().Trim() == metal.ToLower().Trim()
                );

                if (coin_metal == null)
                {
                    coin_metal = new(metal.Trim());
                    UserData.Data.Metals.Add(coin_metal);
                }
                coin_metals.Add(coin_metal);
            }

            //Apply editing
            CoinToEdit.YearOfIssue = year.Value;
            CoinToEdit.Country = coin_country;
            CoinToEdit.CoinValue = nominal.Value;
            CoinToEdit.CoinCurrency = coin_currency;
            CoinToEdit.MetalContent = coin_metals;
            CoinToEdit.AmountIssued = amount;
            CoinToEdit.Notes = notes ?? "";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                ApplyEditing();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (create_new)
                UserData.Data.Coins.Add(CoinToEdit);

            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            LoadCoinData();
        }

        private void FormEditCoin_Load(object sender, EventArgs e)
        {
            LoadCountrySuggestions();
            LoadCurrencySuggestions();
            LoadMetalsSuggestions();
            LoadCoinData();
        }
    }
}
