using NumismaticsCatalog.ApplicationData;
using NumismaticsCatalog.InputHandling;
using NumismaticsCatalog.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumismaticsCatalog.Forms
{
    public partial class FormEditCollector : Form
    {

        public Collector CollectorToEdit { get; set; }
        bool create_new;

        public FormEditCollector()
        {
            InitializeComponent();
            CollectorToEdit = new();
            create_new = true;
        }

        public FormEditCollector(Collector collector_to_edit)
        {
            InitializeComponent();
            CollectorToEdit = collector_to_edit;
            create_new = false;
        }

        private void LoadCollectorData()
        {
            tb_Name.Text = CollectorToEdit.Name;
            cb_Country.Text = CollectorToEdit.Country?.Name;
            tb_ContactInfo.Text = CollectorToEdit.ContactInformation;
        }

        private void LoadCountrySuggestions()
        {
            cb_Country.DataSource = UserData.Data.Countries;
            cb_Country.DisplayMember = "Name";
            cb_Country.SelectedIndex = -1;
        }

        public void ApplyEditing()
        {
            //Check all fields
            string? name = InputConversion.ConvertString(tb_Name.Text, false);
            if (name == null)
                throw new ArgumentException("Не вірно визначено ім'я колекціонера!");

            string? country = InputConversion.ConvertString(cb_Country.Text, false);
            if (country == null)
                throw new ArgumentException("Не вірно визначено країну колекціонера!");

            string? contact = InputConversion.ConvertString(tb_ContactInfo.Text, true);


            //Create class fields
            Country? collector_country = UserData.Data.Countries.Find(
                x => x.Name.ToLower() == country.ToLower()
                );
            if (collector_country == null)
            {
                collector_country = new(country);
                UserData.Data.Countries.Add(collector_country);
            }

            //Apply editing
            CollectorToEdit.Name = name;
            CollectorToEdit.Country = collector_country;
            CollectorToEdit.ContactInformation = contact ?? "";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                ApplyEditing();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (create_new)
                UserData.Data.Collectors.Add(CollectorToEdit);

            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            LoadCollectorData();
        }

        private void FormEditCollector_Load(object sender, EventArgs e)
        {
            LoadCountrySuggestions();
            LoadCollectorData();
        }
    }
}
