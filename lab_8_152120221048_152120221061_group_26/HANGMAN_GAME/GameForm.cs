using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace HANGMAN_GAME
{
    public partial class GameForm : Form
    {
        private string kategori;
        private string zorluk;
        private string secilenKelime;
        private Label[] labels;
        private List<string> yanlisHarfler = new List<string>();
        private int puan = 100;
        private int time = 20;
        private string resimTuru;
        private Timer timer = new Timer();
        private Random rnd = new Random();

        public GameForm(string secilenKategori, string secilenZorluk, int secilenSure, string secilenResimTuru)
        {
            InitializeComponent();
            kategori = secilenKategori.ToLower();
            zorluk = secilenZorluk.ToLower();

            time = secilenSure;

            resimTuru = secilenResimTuru;
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            labels = new Label[] { label1, label2, label3, label4, label5, label6, label7, label8 };
            foreach (var lbl in labels)
            {
                lbl.Text = "_";
                lbl.Visible = false;
            }

            secilenKelime = KelimeGetir(kategori, zorluk);

            if (secilenKelime == "bos" || secilenKelime.Length > labels.Length)
            {
                MessageBox.Show("Seçilen kategori/zorluk için uygun kelime yok! ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            for (int i = 0; i < secilenKelime.Length; i++)
            {
                labels[i].Visible = true;
            }

            label11.Text = secilenKelime.Length.ToString();
            label15.Text = puan.ToString();
            label18.Text = "Category : " + kategori.ToString();
            label20.Text = "Difficulty Level : " + zorluk.ToString();



            string resimAd = puan.ToString() + ".png";
            //string path = Path.Combine(Application.StartupPath, "hangman_resimler", "100.jpg");
            string path = Path.Combine(Application.StartupPath, "hangman_resimler", resimTuru, resimAd);
            ResmiGuncelle();








            if (File.Exists(path))
                pictureBoxAdam.Image = Image.FromFile(path);

            label17.Text = time + " s";  // Süreyi gösteriyoruz

            timer.Interval = 1000;
            timer.Tick += timer1_Tick;
            timer.Start();
        }

        private void Guessbutton_Click(object sender, EventArgs e)
        {
            string harf = GuesstextBox.Text.ToLower();

            if (string.IsNullOrWhiteSpace(harf) || harf.Length != 1 || !char.IsLetter(harf[0]))
            {
                MessageBox.Show("Lütfen geçerli bir harf girin!");
                return;
            }

            bool bulundu = false;
            for (int i = 0; i < secilenKelime.Length; i++)
            {
                if (secilenKelime[i].ToString() == harf)
                {
                    labels[i].Text = harf.ToUpper();
                    bulundu = true;
                }
            }

            if (!bulundu)
            {
                if (!yanlisHarfler.Contains(harf))
                {
                    yanlisHarfler.Add(harf);
                    label12.Text += harf + ", ";
                }

                puan -= 10;
                label15.Text = puan.ToString();
                ResmiGuncelle();

                if (puan <= 0)
                {
                    timer.Stop();
                    MessageBox.Show($"Puan kalmadı!\nKelime: {secilenKelime.ToUpper()}", "OYUN BİTTİ");
                    Guessbutton.Enabled = false;
                    GuesstextBox.Enabled = false;
                    
                    this.BackColor = Color.Red;
                    
                }
            }

            GuesstextBox.Clear();
            GuesstextBox.Focus();

            string mevcut = string.Join("", labels.Where(l => l.Visible).Select(l => l.Text.ToLower()));
            if (mevcut == secilenKelime)
            {
                timer.Stop();
                MessageBox.Show("Tebrikler! Kelimeyi buldun: " + secilenKelime.ToUpper(), "Kazandın");
                Guessbutton.Enabled = false;
                GuesstextBox.Enabled = false;
                this.BackColor = Color.Green;
                
            }
        }

        private void ResmiGuncelle()
        {
            string resimAd = puan.ToString() + ".png"; 

            //string yol = Path.Combine(Application.StartupPath, "hangman_resimler",  puan.ToString() + ".jpg");
            string yol = Path.Combine(Application.StartupPath, "hangman_resimler", resimTuru, resimAd);



            if (File.Exists(yol))
                pictureBoxAdam.Image = Image.FromFile(yol);
            else
            {
                // Eğer dosya yoksa, son resmi gösterelim (örneğin, 10.jpg)
                string yolSonResim = Path.Combine(Application.StartupPath, "hangman_resimler", resimTuru, "100.png");
                if (File.Exists(yolSonResim))
                {
                    pictureBoxAdam.Image = Image.FromFile(yolSonResim);
                }
                else
                {
                    MessageBox.Show("Resim dosyası bulunamadı: " +resimTuru+"_"+ resimAd);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            label17.Text = time + " s";

            if (time == 0)
            {
                timer.Stop();
                MessageBox.Show("Süre doldu! Kelime: " + secilenKelime.ToUpper(), "ZAMAN BİTTİ");
                Guessbutton.Enabled = false;
                GuesstextBox.Enabled = false;
                this.BackColor = Color.Red;
            }
        }

        private void Finishbutton_Click(object sender, EventArgs e)
        {
            timer.Stop();
            this.Close();
        }

        private string KelimeGetir(string kategori, string zorluk)
        {
            List<string> secenek = new List<string>();

            // Kategoriye ve zorluk seviyesine göre kelimeleri seçiyoruz
            switch (kategori)
            {
                case "tarih":
                    if (zorluk == "kolay") secenek = new List<string> { "asya", "kudus", "osman", "fatih", "ankara" };
                    else if (zorluk == "orta") secenek = new List<string> { "talas", "ankara", "fatih", "turk", "selcuk" };
                    else secenek = new List<string> { "malazgirt", "canakkale", "alparslan", "ataturk", "osmanli" };
                    break;

                case "cografya":
                    if (zorluk == "kolay") secenek = new List<string> { "dag", "deniz", "orman", "gok", "nehr" };
                    else if (zorluk == "orta") secenek = new List<string> { "ekvator", "kita", "vadi", "deniz", "ada" };
                    else secenek = new List<string> { "yercekimi", "mercator", "kuresel", "global", "kutup" };
                    break;

                case "matematik":
                    if (zorluk == "kolay") secenek = new List<string> { "kok", "asal", "toplama", "carpma", "cikarma" };
                    else if (zorluk == "orta") secenek = new List<string> { "ucgen", "matris", "dortgen", "logaritma", "sayılar" };
                    else secenek = new List<string> { "integral", "logaritma", "fonksiyon", "limit", "differansiyel" };
                    break;

                case "genel":
                    if (zorluk == "kolay") secenek = new List<string> { "elma", "masa", "kalem", "kitap", "telefon" };
                    else if (zorluk == "orta") secenek = new List<string> { "defter", "kitaplik", "monitor", "telefon", "bilgisayar" };
                    else secenek = new List<string> { "objektif", "naftalin", "kitaplik", "kamera", "klavye" };
                    break;

                case "karma":
                    if (zorluk == "kolay") secenek = new List<string> { "dag", "masa", "kok", "su", "balik" };
                    else if (zorluk == "orta") secenek = new List<string> { "kitaplik", "matris", "ekran", "kurs", "program" };
                    else secenek = new List<string> { "logaritm", "mercator", "canakale", "rasyonel", "pi" };
                    break;
                    /*
                default: // karma
                    
                    if (zorluk == "kolay") secenek = new List<string> { "dag", "masa", "kok", "su", "balik" };
                    else if (zorluk == "orta") secenek = new List<string> { "kitaplik", "matris", "ekran", "kurs", "program" };
                    else secenek = new List<string> { "logaritma", "mercator", "canakkale", "rasyonel", "pi" };
                    break;
                    */
            }

            // Listeyi karıştırıp rastgele bir kelime seçiyoruz
            return secenek.Count > 0 ? secenek[rnd.Next(secenek.Count)] : "bos";
        }





        private void Cluebutton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> ipuclar = new Dictionary<string, string>()
            {
                // tarih
                { "asya", "Türklerin ilk yaşadığı kıta." },
                { "kudus", "Üç büyük dinin kutsal şehri." },
                { "osman", "Osmanlı Devleti'nin kurucusu." },
                { "fatih", "İstanbul'u fetheden Osmanlı padişahı." },
                { "ankara", "Türkiye'nin başkenti." },
                { "talas", "Türklerin İslamiyet'i kabul ettiği savaş." },
                { "turk", "Orta Asya kökenli millet." },
                { "selcuk", "Büyük Selçuklu Devleti'nin kurucusu." },
                { "malazgirt", "1071'de Anadolu'nun kapılarını açan zafer." },
                { "canakkale", "1915'te destan yazılan cephe." },
                { "alparslan", "Malazgirt zaferinin komutanı." },
                { "ataturk", "Türkiye Cumhuriyeti'nin kurucusu." },
                { "osmanli", "600 yıl hüküm süren Türk devleti." },

                // cografya
                { "dag", "Yüksek yer şekli, zirvesi vardır." },
                { "deniz", "Tuzlu su kütlesi." },
                { "orman", "Ağaçlarla kaplı doğal alan." },
                { "gok", "Yukarıdaki boşluk, gökyüzü." },
                { "nehr", "Akarsu, büyük su yolu." },
                { "ekvator", "Dünyanın ortasından geçen hayali çizgi." },
                { "kita", "Asya, Avrupa gibi büyük kara parçaları." },
                { "vadi", "İki dağ arasında yer alan çukur alan." },
                { "ada", "Etrafı suyla çevrili kara parçası." },
                { "yercekimi", "Cisimleri yere çeken kuvvet." },
                { "mercator", "Dünya haritasını düzlemde gösteren sistem." },
                { "kuresel", "Dünyayı ilgilendiren, yuvarlak yapıda olan." },
                { "global", "Dünya çapında, evrensel." },
                { "kutup", "Dünyanın en kuzey ve en güney uçları." },

                // matematik
                { "kok", "Bir sayının kare veya küp kökü." },
                { "asal", "Sadece 1 ve kendisine bölünen sayı." },
                { "toplama", "İki sayıyı bir araya getirme işlemi." },
                { "carpma", "Tekrarlı toplama işlemi." },
                { "cikarma", "Eksiltme işlemi." },
                { "ucgen", "Üç kenarlı geometrik şekil." },
                { "matris", "Sayıların tablo gibi dizildiği yapı." },
                { "dortgen", "Dört kenarlı şekil." },
                { "logaritma", "Üstel fonksiyonun ters işlemi." },
                { "sayılar", "Matematiğin temel varlıkları." },
                { "integral", "Alan hesaplamada kullanılan matematiksel ifade." },
                { "fonksiyon", "Bir girdiye karşılık bir çıktı tanımlayan yapı." },
                { "limit", "Bir fonksiyonun yaklaşmakta olduğu değer." },
                { "differansiyel", "Türevle ilgili matematiksel kavram." },
                { "rasyonel", "Pay ve paydayla ifade edilebilen sayı." },
                { "pi", "Çemberin çevresinin çapına oranı." },

                // genel
                { "elma", "Kırmızı veya yeşil renkte meyve." },
                { "masa", "Üzerine yazı yazılır, yemek yenir." },
                { "kalem", "Yazı yazmak için kullanılan araç." },
                { "kitap", "Okumak için sayfalardan oluşan nesne." },
                { "telefon", "Uzakta biriyle konuşmak için kullanılan cihaz." },
                { "defter", "Yazı yazmak için kullanılan kağıt grubu." },
                { "kitaplik", "Kitapları saklamak için kullanılan mobilya." },
                { "monitor", "Bilgisayarda görüntü sunan cihaz." },
                { "bilgisayar", "Veri işleyebilen elektronik cihaz." },
                { "objektif", "Fotoğraf makinesinin merceği." },
                { "naftalin", "Koku giderici beyaz madde." },
                { "kamera", "Görüntü kaydeden cihaz." },
                { "klavye", "Bilgisayara veri girmek için kullanılan tuş takımı." },
                { "ekran", "Görüntü sunulan dijital yüzey." },

                // karma
                { "su", "Hayatın kaynağı olan sıvı." },
                { "balik", "Suda yaşayan canlı." },
                { "kurs", "Belirli konuda verilen eğitim." },
                { "program", "Bilgisayarda çalışan komutlar bütünü." },
                { "logaritm", "Logaritma işleminin kısaltması." },
                { "canakale", "Canakkale'nin kısaltılmış hali." },
            };

            if (ipuclar.ContainsKey(secilenKelime))
                label13.Text = ipuclar[secilenKelime];
            else
                label13.Text = "Bu kelime için ipucu tanımlanmadı.";
        }

    }
}
