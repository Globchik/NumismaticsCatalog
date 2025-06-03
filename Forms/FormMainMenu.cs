using NumismaticsCatalog.Forms;
using System;
using System.Windows.Forms;
using NumismaticsCatalog.ApplicationData;

namespace NumismaticsCatalog
{
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void ShowForm(Form form)
        {
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        public void SaveDataDialog()
        {
            SaveFileDialog file_dialog = new();
            file_dialog.AddExtension = true;
            file_dialog.FileName = "numismatics_data";
            file_dialog.DefaultExt = "json";
            file_dialog.Filter = "JSON (*.json)|*.json";

            DialogResult dr = file_dialog.ShowDialog();
            if (dr != DialogResult.OK)
                return;

            string path = file_dialog.FileName;
            try
            {
                UserData.SaveData(path);
            }
            catch (Exception)
            {
                MessageBox.Show("Помилка!", "Не вдалося експортувати дані.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadDataDialog()
        {
            DialogResult dr = MessageBox.Show("Усі поточні дані буде втрачено.",
                "Увага!", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Exclamation);

            if (dr != DialogResult.OK)
                return;

            UserData.SaveData();

            OpenFileDialog file_dialog = new();
            file_dialog.Filter = "JSON (*.json)|*.json";
            dr = file_dialog.ShowDialog();

            if (dr != DialogResult.OK)
                return;

            string path = file_dialog.FileName;
            try
            {
                UserData.LoadSavedData(path);
                MessageBox.Show("Дані успішно завантажено.", "Успіх!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Не вдалося завантажити дані.", "Помилка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserData.LoadSavedData();
            }
        }

        private void EraseDataDialog()
        {
            DialogResult dr = MessageBox.Show("Усі поточні дані буде втрачено.",
                "Увага!", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Exclamation);

            if (dr != DialogResult.OK)
                return;

            UserData.Data = new();
        }

        private void btn_MyCollection_Click(object sender, EventArgs e)
        {
            var coin_form = new FormCoinsView(
                FormCoinsView.FormCoinsViewType.PersonalCollection
                );
            ShowForm(coin_form);
        }

        private void btn_Collectioners_Click(object sender, EventArgs e)
        {
            var collectioners_form = new FormCollectorsView();
            ShowForm(collectioners_form);
        }

        private void btn_Coins_Click(object sender, EventArgs e)
        {
            var coin_form = new FormCoinsView(
                FormCoinsView.FormCoinsViewType.ViewAll
                );
            ShowForm(coin_form);
        }

        private void btn_ExportData_Click(object sender, EventArgs e)
        {
            SaveDataDialog();
        }

        private void btn_ImportData_Click(object sender, EventArgs e)
        {
            LoadDataDialog();
        }

        private void btn_ResetData_Click(object sender, EventArgs e)
        {
            EraseDataDialog();
        }
        private void btn_Other_Click(object sender, EventArgs e)
        {
            ShowForm(new FormEditAdditionalTables());
        }

        private void FormMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            UserData.SaveData();
        }


    }
}
