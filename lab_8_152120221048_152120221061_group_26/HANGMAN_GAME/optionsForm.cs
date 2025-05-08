using System;
using System.Windows.Forms;

namespace HANGMAN_GAME
{
    public partial class optionsForm : Form
    {
        public string SecilenKategori { get; private set; } = "karma";
        public string SecilenZorluk { get; private set; } = "kolay";
        public int SecilenSure { get; private set; } = 20;
        public string SecilenResimTuru { get; private set; } = "adam_as";  

        public optionsForm()
        {
            InitializeComponent();
        }

        private void optionsForm_Load(object sender, EventArgs e)
        {
            // Kategori combobox’ına seçenekler ekleniyor
            kategoriComboBox.Items.Add("tarih");
            kategoriComboBox.Items.Add("cografya");
            kategoriComboBox.Items.Add("matematik");
            kategoriComboBox.Items.Add("genel");
            kategoriComboBox.Items.Add("karma");

            kategoriComboBox.SelectedIndex = 4; 
            kolayBtn.Checked = true;            

            numericUpDownSure.Minimum = 10;   
            numericUpDownSure.Maximum = 60;   
            numericUpDownSure.Value = 20;

            comboBoxResimTuru.Items.Add("adam_as");
            comboBoxResimTuru.Items.Add("cop_adam_as");
            comboBoxResimTuru.Items.Add("cicek_yapraklarini_kopar");
            comboBoxResimTuru.Items.Add("balon_patlat");
            comboBoxResimTuru.SelectedIndex = 0; // Varsayılan: "adam as"
        }

        private void onaylaBtn_Click(object sender, EventArgs e)
        {
            SecilenSure = (int)numericUpDownSure.Value;

            if (kategoriComboBox.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir kategori seçin.");
                return;
            }

            SecilenKategori = kategoriComboBox.SelectedItem.ToString().ToLower();

            if (kolayBtn.Checked)
                SecilenZorluk = "kolay";
            else if (ortaBtn.Checked)
                SecilenZorluk = "orta";
            else if (zorBtn.Checked)
                SecilenZorluk = "zor";
            else
                SecilenZorluk = "kolay"; // fallback

            SecilenResimTuru = comboBoxResimTuru.SelectedItem.ToString();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
