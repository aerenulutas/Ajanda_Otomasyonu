
namespace GorselProje
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label19 = new System.Windows.Forms.Label();
            this.arastirmasecenekleri = new System.Windows.Forms.ComboBox();
            this.Ekle = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.bassaati = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.yüklükitaplar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aktsecenekleri = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bitissaati = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.not = new System.Windows.Forms.TextBox();
            this.sil = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ajandalistesi = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.girisEkranınaDon = new System.Windows.Forms.Button();
            this.Listele = new System.Windows.Forms.Button();
            this.kullanıcıAdi = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Kütüphane = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.idno = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ajandalistesi)).BeginInit();
            this.SuspendLayout();
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.OldLace;
            this.label19.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(10, 19);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(289, 29);
            this.label19.TabIndex = 163;
            this.label19.Text = "Araştırma Seçenekleri:";
            // 
            // arastirmasecenekleri
            // 
            this.arastirmasecenekleri.BackColor = System.Drawing.Color.OldLace;
            this.arastirmasecenekleri.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arastirmasecenekleri.FormattingEnabled = true;
            this.arastirmasecenekleri.Items.AddRange(new object[] {
            "Kitap Okuma",
            "Çalışma",
            "Yazı Yazma",
            "Sosyal Medyada Gezme",
            "Araştırma"});
            this.arastirmasecenekleri.Location = new System.Drawing.Point(350, 16);
            this.arastirmasecenekleri.Name = "arastirmasecenekleri";
            this.arastirmasecenekleri.Size = new System.Drawing.Size(191, 32);
            this.arastirmasecenekleri.TabIndex = 162;
            // 
            // Ekle
            // 
            this.Ekle.BackColor = System.Drawing.Color.OldLace;
            this.Ekle.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ekle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ekle.Location = new System.Drawing.Point(1373, 173);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(116, 64);
            this.Ekle.TabIndex = 158;
            this.Ekle.Text = "Ekle";
            this.Ekle.UseVisualStyleBackColor = false;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.OldLace;
            this.label14.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(604, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(191, 27);
            this.label14.TabIndex = 156;
            this.label14.Text = "Başlangıç Tarihi";
            // 
            // bassaati
            // 
            this.bassaati.BackColor = System.Drawing.Color.OldLace;
            this.bassaati.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bassaati.Location = new System.Drawing.Point(934, 43);
            this.bassaati.MaxLength = 13;
            this.bassaati.Multiline = true;
            this.bassaati.Name = "bassaati";
            this.bassaati.Size = new System.Drawing.Size(84, 32);
            this.bassaati.TabIndex = 155;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.OldLace;
            this.label13.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(829, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 27);
            this.label13.TabIndex = 154;
            this.label13.Text = "||";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.OldLace;
            this.label12.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(325, 24);
            this.label12.TabIndex = 152;
            this.label12.Text = "Programımızda Yüklü Kitaplar:";
            // 
            // yüklükitaplar
            // 
            this.yüklükitaplar.BackColor = System.Drawing.Color.OldLace;
            this.yüklükitaplar.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yüklükitaplar.FormattingEnabled = true;
            this.yüklükitaplar.ItemHeight = 16;
            this.yüklükitaplar.Items.AddRange(new object[] {
            "Abdullah Çelik (Bedri Rahmi Eyüboğlu)",
            "Mahfi Eğilmez (Küresel Finans Krizi)",
            "Adelheid Meutes Bossert (Gündelik Yaşamda Zen(Kadın))",
            "A.P.Martinich (Thomas Hobbes)",
            "Ibni-Sina (Hayati ve Eserleri Hakkinda Çalismalar)",
            "Burak Büyükdemir (Kümesteki Kartal Neden Uçamaz)",
            "Canan Karatay (Karatay Diyeti)",
            "Canan Karatay (Karatay Diyeti\'yle Yaşam Boyu Sağlık)",
            "Sibel Özbudun (Kızılderililer, İndianer, Vardık, Varız, Hep Varolacağız)",
            "Canan Karatay (Karatay Mutfağı)",
            "Jared Diamond (Tüfek, Mikrop ve Çelik)",
            "Charles Dickens (İki Şehrin Hikâyesi)",
            "Jean-Claude Carriere, Umberto Eco (Kitaplardan Kurtulabileceğinizi Sanmayın)",
            "Charles Dickens (Oliver Twist)",
            "Charlotte Brontë (Jane Eyre)",
            "Richard Feynman (Fizik Yasaları Üzerine)",
            "Turgut Cansever (İslam\'da Şehir ve Mimari)",
            "Victor Hugo (Sefiller)"});
            this.yüklükitaplar.Location = new System.Drawing.Point(350, 61);
            this.yüklükitaplar.Name = "yüklükitaplar";
            this.yüklükitaplar.Size = new System.Drawing.Size(249, 24);
            this.yüklükitaplar.TabIndex = 164;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OldLace;
            this.label1.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(906, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 27);
            this.label1.TabIndex = 166;
            this.label1.Text = "Başlangıç Saati";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.OldLace;
            this.label2.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 29);
            this.label2.TabIndex = 167;
            this.label2.Text = "Aktivite Seçenekleri:";
            // 
            // aktsecenekleri
            // 
            this.aktsecenekleri.BackColor = System.Drawing.Color.OldLace;
            this.aktsecenekleri.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aktsecenekleri.FormattingEnabled = true;
            this.aktsecenekleri.Items.AddRange(new object[] {
            "Kitap Okuma ",
            "Dergi Okuma",
            "Sesli Konuşma",
            "Yüzme",
            "Koşma",
            "Müzik Dinleme",
            "Dinlenme",
            "Toplantı",
            "Halı Saha Maçı",
            "Cafede Oturma",
            "Özel Ders",
            "Kamp",
            "Resim Çizme",
            "Spor"});
            this.aktsecenekleri.Location = new System.Drawing.Point(350, 102);
            this.aktsecenekleri.Name = "aktsecenekleri";
            this.aktsecenekleri.Size = new System.Drawing.Size(191, 32);
            this.aktsecenekleri.TabIndex = 168;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.OldLace;
            this.label3.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(918, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 27);
            this.label3.TabIndex = 173;
            this.label3.Text = "Bitiş Saati";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.OldLace;
            this.label4.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(604, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 27);
            this.label4.TabIndex = 171;
            this.label4.Text = "Bitiş Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.OldLace;
            this.label5.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(829, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 27);
            this.label5.TabIndex = 169;
            this.label5.Text = "||";
            // 
            // bitissaati
            // 
            this.bitissaati.BackColor = System.Drawing.Color.OldLace;
            this.bitissaati.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bitissaati.Location = new System.Drawing.Point(934, 112);
            this.bitissaati.MaxLength = 13;
            this.bitissaati.Multiline = true;
            this.bitissaati.Name = "bitissaati";
            this.bitissaati.Size = new System.Drawing.Size(84, 32);
            this.bitissaati.TabIndex = 174;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.OldLace;
            this.label6.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1167, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 29);
            this.label6.TabIndex = 175;
            this.label6.Text = "Not:";
            // 
            // not
            // 
            this.not.BackColor = System.Drawing.Color.OldLace;
            this.not.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.not.Location = new System.Drawing.Point(1236, 12);
            this.not.MaxLength = 50;
            this.not.Multiline = true;
            this.not.Name = "not";
            this.not.Size = new System.Drawing.Size(253, 135);
            this.not.TabIndex = 176;
            // 
            // sil
            // 
            this.sil.BackColor = System.Drawing.Color.OldLace;
            this.sil.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sil.Location = new System.Drawing.Point(1373, 243);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(116, 64);
            this.sil.TabIndex = 177;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = false;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.OldLace;
            this.label16.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(1035, 43);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 14);
            this.label16.TabIndex = 178;
            this.label16.Text = "* Örn: 18:45 , 09:45";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.OldLace;
            this.label7.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(1035, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 14);
            this.label7.TabIndex = 179;
            this.label7.Text = "* Örn: 18:45 , 09:45";
            // 
            // ajandalistesi
            // 
            this.ajandalistesi.AllowUserToAddRows = false;
            this.ajandalistesi.AllowUserToDeleteRows = false;
            this.ajandalistesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ajandalistesi.BackgroundColor = System.Drawing.Color.OldLace;
            this.ajandalistesi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ajandalistesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ajandalistesi.GridColor = System.Drawing.Color.OldLace;
            this.ajandalistesi.Location = new System.Drawing.Point(12, 173);
            this.ajandalistesi.Name = "ajandalistesi";
            this.ajandalistesi.ReadOnly = true;
            this.ajandalistesi.Size = new System.Drawing.Size(1353, 640);
            this.ajandalistesi.TabIndex = 180;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(605, 49);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 181;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(605, 121);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker2.TabIndex = 182;
            // 
            // girisEkranınaDon
            // 
            this.girisEkranınaDon.BackColor = System.Drawing.Color.OldLace;
            this.girisEkranınaDon.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.girisEkranınaDon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.girisEkranınaDon.Location = new System.Drawing.Point(1373, 749);
            this.girisEkranınaDon.Name = "girisEkranınaDon";
            this.girisEkranınaDon.Size = new System.Drawing.Size(116, 64);
            this.girisEkranınaDon.TabIndex = 183;
            this.girisEkranınaDon.Text = "Giriş Ekranına Dön";
            this.girisEkranınaDon.UseVisualStyleBackColor = false;
            this.girisEkranınaDon.Click += new System.EventHandler(this.girisEkranınaDon_Click);
            // 
            // Listele
            // 
            this.Listele.BackColor = System.Drawing.Color.OldLace;
            this.Listele.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Listele.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Listele.Location = new System.Drawing.Point(1373, 370);
            this.Listele.Name = "Listele";
            this.Listele.Size = new System.Drawing.Size(116, 64);
            this.Listele.TabIndex = 184;
            this.Listele.Text = "Listele";
            this.Listele.UseVisualStyleBackColor = false;
            this.Listele.Click += new System.EventHandler(this.Listele_Click);
            // 
            // kullanıcıAdi
            // 
            this.kullanıcıAdi.AutoSize = true;
            this.kullanıcıAdi.BackColor = System.Drawing.Color.OldLace;
            this.kullanıcıAdi.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullanıcıAdi.Location = new System.Drawing.Point(137, 142);
            this.kullanıcıAdi.Name = "kullanıcıAdi";
            this.kullanıcıAdi.Size = new System.Drawing.Size(0, 29);
            this.kullanıcıAdi.TabIndex = 185;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.OldLace;
            this.label8.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 23);
            this.label8.TabIndex = 186;
            this.label8.Text = "Hoşgeldin..";
            // 
            // Kütüphane
            // 
            this.Kütüphane.BackColor = System.Drawing.Color.OldLace;
            this.Kütüphane.BackgroundImage = global::GorselProje.Properties.Resources.BlogPost23_evinde_kucuk_bir_kutuphane_olusturmanin_3_yolu;
            this.Kütüphane.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Kütüphane.Font = new System.Drawing.Font("Rockwell", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kütüphane.ForeColor = System.Drawing.Color.Red;
            this.Kütüphane.Location = new System.Drawing.Point(1373, 449);
            this.Kütüphane.Name = "Kütüphane";
            this.Kütüphane.Size = new System.Drawing.Size(116, 279);
            this.Kütüphane.TabIndex = 187;
            this.Kütüphane.Text = "Kütüphane İçin";
            this.Kütüphane.UseVisualStyleBackColor = false;
            this.Kütüphane.Click += new System.EventHandler(this.Kütüphane_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.OldLace;
            this.label9.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(1035, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 15);
            this.label9.TabIndex = 188;
            this.label9.Text = "Günlük Saat Toplamı=";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.OldLace;
            this.label10.Location = new System.Drawing.Point(1456, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 189;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.OldLace;
            this.label11.ForeColor = System.Drawing.Color.OldLace;
            this.label11.Location = new System.Drawing.Point(1243, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 190;
            this.label11.Text = "label11";
            // 
            // idno
            // 
            this.idno.BackColor = System.Drawing.Color.OldLace;
            this.idno.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idno.Location = new System.Drawing.Point(1414, 328);
            this.idno.Name = "idno";
            this.idno.Size = new System.Drawing.Size(42, 36);
            this.idno.TabIndex = 191;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.OldLace;
            this.label15.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(1360, 310);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(138, 14);
            this.label15.TabIndex = 192;
            this.label15.Text = "Silmek İçin ID Yazınız";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GorselProje.Properties.Resources.resim5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1499, 832);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.idno);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Kütüphane);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.kullanıcıAdi);
            this.Controls.Add(this.Listele);
            this.Controls.Add(this.girisEkranınaDon);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ajandalistesi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.not);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bitissaati);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.aktsecenekleri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yüklükitaplar);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.arastirmasecenekleri);
            this.Controls.Add(this.Ekle);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.bassaati);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Name = "Form2";
            this.Text = "Ajanda Programı";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ajandalistesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox arastirmasecenekleri;
        private System.Windows.Forms.Button Ekle;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox bassaati;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox yüklükitaplar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox aktsecenekleri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bitissaati;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox not;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView ajandalistesi;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button girisEkranınaDon;
        private System.Windows.Forms.Button Listele;
        private System.Windows.Forms.Label kullanıcıAdi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Kütüphane;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox idno;
        private System.Windows.Forms.Label label15;
    }
}