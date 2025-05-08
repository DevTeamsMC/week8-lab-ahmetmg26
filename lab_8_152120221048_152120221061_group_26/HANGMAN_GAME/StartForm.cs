using System;
using System.Drawing;
using System.Windows.Forms;

namespace HANGMAN_GAME
{
    public partial class StartForm : Form
    {
        private string secilenKategori = "karma";
        private string secilenZorluk = "kolay";
        private string secilenResimTuru = "adam_as";
        int secilenSure = 10;

        public StartForm()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent; // isteğe bağlı görsel efekt
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            // Giriş ekranı yüklendiğinde yapılacak işler (örn. arkaplan resmi vs.)

        }

        private bool ayarYapildi = false;
        private void btnSettnigs_Click(object sender, EventArgs e)
        {
            optionsForm settingsForm = new optionsForm();
            if (settingsForm.ShowDialog() == DialogResult.OK)
            {
                secilenKategori = settingsForm.SecilenKategori;
                secilenZorluk = settingsForm.SecilenZorluk;

                secilenSure = settingsForm.SecilenSure;

                secilenResimTuru = settingsForm.SecilenResimTuru;

                ayarYapildi = true;

                MessageBox.Show($"Kategori: {secilenKategori}\nZorluk: {secilenZorluk}\nSüre: {secilenSure} saniye\nResim Türü: {secilenResimTuru}", "Seçimler Onaylandı");
            }
        
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if (!ayarYapildi)
            {
                string mesaj = $"Varsayılan ayarlarla başlamak ister misiniz?\n\n" +
                               $"Kategori: {secilenKategori}\n" +
                               $"Zorluk: {secilenZorluk}\n" +
                               $"Süre: {secilenSure} saniye\n" +
                               $"Resim Türü: {secilenResimTuru}\n\n" +
                               $"!! Hayır'a tıklarsanız ayarlar sayfasına yönlendirileceksiniz !!";

                DialogResult sonuc = MessageBox.Show(mesaj, "Varsayılan Ayarlar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (sonuc == DialogResult.No)
                {
                    btnSettnigs_Click(null, null);
                    return;
                }
            }

            // Oyunu başlat
            GameForm gameForm = new GameForm(secilenKategori, secilenZorluk, secilenSure, secilenResimTuru);
            gameForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Oyundan çıkmak istediğinizden emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }
    }
}
