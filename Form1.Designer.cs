
namespace GorselProje
{
    partial class Form1
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
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.kullanicitipi = new System.Windows.Forms.ComboBox();
            this.guncelle = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.kabulediyorum = new System.Windows.Forms.RadioButton();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.personelGirisi = new System.Windows.Forms.Button();
            this.arasGirisi = new System.Windows.Forms.Button();
            this.kayitol = new System.Windows.Forms.Button();
            this.ogrGirisi = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.uyeeposta = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.uyeonayla = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.uyesifre = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.uyekullaniciadi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.perssifre = new System.Windows.Forms.TextBox();
            this.ogrsifre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ogrkullaniciadi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.perskullaniciadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.arakullaniciadi = new System.Windows.Forms.TextBox();
            this.arasifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.OldLace;
            this.label20.Font = new System.Drawing.Font("Rockwell", 15.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(28, 369);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(153, 25);
            this.label20.TabIndex = 149;
            this.label20.Text = "Kullanıcı Adı:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.OldLace;
            this.label19.Font = new System.Drawing.Font("Rockwell", 15.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(25, 409);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(159, 25);
            this.label19.TabIndex = 148;
            this.label19.Text = "Kullanıcı Tipi:";
            // 
            // kullanicitipi
            // 
            this.kullanicitipi.BackColor = System.Drawing.Color.OldLace;
            this.kullanicitipi.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullanicitipi.FormattingEnabled = true;
            this.kullanicitipi.Items.AddRange(new object[] {
            "Öğrenci",
            "Personel",
            "Araştırmacı"});
            this.kullanicitipi.Location = new System.Drawing.Point(195, 404);
            this.kullanicitipi.Name = "kullanicitipi";
            this.kullanicitipi.Size = new System.Drawing.Size(191, 34);
            this.kullanicitipi.TabIndex = 147;
            // 
            // guncelle
            // 
            this.guncelle.BackColor = System.Drawing.Color.OldLace;
            this.guncelle.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guncelle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guncelle.Location = new System.Drawing.Point(1392, 735);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(116, 64);
            this.guncelle.TabIndex = 146;
            this.guncelle.Text = "Güncelle";
            this.guncelle.UseVisualStyleBackColor = false;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.Red;
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(331, 587);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(222, 56);
            this.linkLabel1.TabIndex = 145;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Kişisel Verilerimin İşlenmesine İlişkin\r\nAydınlatma Metni’ni okudum. \r\nÜyelik Söz" +
    "leşmesi’ni okudum \r\nve kabul ediyorum.";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // kabulediyorum
            // 
            this.kabulediyorum.AutoSize = true;
            this.kabulediyorum.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kabulediyorum.ForeColor = System.Drawing.Color.Red;
            this.kabulediyorum.Location = new System.Drawing.Point(334, 646);
            this.kabulediyorum.Name = "kabulediyorum";
            this.kabulediyorum.Size = new System.Drawing.Size(114, 18);
            this.kabulediyorum.TabIndex = 144;
            this.kabulediyorum.TabStop = true;
            this.kabulediyorum.Text = "Kabul ediyorum";
            this.kabulediyorum.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.OldLace;
            this.label18.Font = new System.Drawing.Font("Adobe Gothic Std B", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(19, 658);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(144, 30);
            this.label18.TabIndex = 143;
            this.label18.Text = "ÖNEMLİ !!!!!";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.OldLace;
            this.label16.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(20, 702);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(633, 24);
            this.label16.TabIndex = 142;
            this.label16.Text = "*  Kullanıcı adınız en az 10 en fazla 14 karakterden oluşmalıdır\r\n";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.OldLace;
            this.label17.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(20, 769);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(805, 24);
            this.label17.TabIndex = 141;
            this.label17.Text = "*  E-posta Adresiniz en az 6 en fazla 30 karakterden oluşmalıdır.Tekrak deneyin.";
            // 
            // personelGirisi
            // 
            this.personelGirisi.BackColor = System.Drawing.Color.OldLace;
            this.personelGirisi.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personelGirisi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.personelGirisi.Location = new System.Drawing.Point(723, 165);
            this.personelGirisi.Name = "personelGirisi";
            this.personelGirisi.Size = new System.Drawing.Size(116, 64);
            this.personelGirisi.TabIndex = 140;
            this.personelGirisi.Text = "Giriş";
            this.personelGirisi.UseVisualStyleBackColor = false;
            this.personelGirisi.Click += new System.EventHandler(this.personelGirisi_Click);
            // 
            // arasGirisi
            // 
            this.arasGirisi.BackColor = System.Drawing.Color.OldLace;
            this.arasGirisi.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arasGirisi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.arasGirisi.Location = new System.Drawing.Point(1270, 165);
            this.arasGirisi.Name = "arasGirisi";
            this.arasGirisi.Size = new System.Drawing.Size(116, 64);
            this.arasGirisi.TabIndex = 139;
            this.arasGirisi.Text = "Giriş";
            this.arasGirisi.UseVisualStyleBackColor = false;
            this.arasGirisi.Click += new System.EventHandler(this.arasGirisi_Click);
            // 
            // kayitol
            // 
            this.kayitol.BackColor = System.Drawing.Color.OldLace;
            this.kayitol.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kayitol.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.kayitol.Location = new System.Drawing.Point(195, 587);
            this.kayitol.Name = "kayitol";
            this.kayitol.Size = new System.Drawing.Size(116, 64);
            this.kayitol.TabIndex = 138;
            this.kayitol.Text = "Kayıt Ol";
            this.kayitol.UseVisualStyleBackColor = false;
            this.kayitol.Click += new System.EventHandler(this.kayitol_Click);
            // 
            // ogrGirisi
            // 
            this.ogrGirisi.BackColor = System.Drawing.Color.OldLace;
            this.ogrGirisi.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ogrGirisi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ogrGirisi.Location = new System.Drawing.Point(195, 165);
            this.ogrGirisi.Name = "ogrGirisi";
            this.ogrGirisi.Size = new System.Drawing.Size(116, 64);
            this.ogrGirisi.TabIndex = 137;
            this.ogrGirisi.Text = "Giriş";
            this.ogrGirisi.UseVisualStyleBackColor = false;
            this.ogrGirisi.Click += new System.EventHandler(this.ogrGirisi_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.OldLace;
            this.label15.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(20, 735);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(548, 24);
            this.label15.TabIndex = 136;
            this.label15.Text = "*  Sifreniz en az 10 en fazla 13 karakterden oluşmalıdır";
            // 
            // uyeeposta
            // 
            this.uyeeposta.BackColor = System.Drawing.Color.OldLace;
            this.uyeeposta.Font = new System.Drawing.Font("Rockwell Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyeeposta.Location = new System.Drawing.Point(195, 528);
            this.uyeeposta.MaxLength = 30;
            this.uyeeposta.Multiline = true;
            this.uyeeposta.Name = "uyeeposta";
            this.uyeeposta.Size = new System.Drawing.Size(367, 29);
            this.uyeeposta.TabIndex = 135;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.OldLace;
            this.label14.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(80, 528);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 27);
            this.label14.TabIndex = 134;
            this.label14.Text = "E-posta:";
            // 
            // uyeonayla
            // 
            this.uyeonayla.BackColor = System.Drawing.Color.OldLace;
            this.uyeonayla.Font = new System.Drawing.Font("Rockwell Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uyeonayla.Location = new System.Drawing.Point(195, 490);
            this.uyeonayla.MaxLength = 13;
            this.uyeonayla.Multiline = true;
            this.uyeonayla.Name = "uyeonayla";
            this.uyeonayla.PasswordChar = '*';
            this.uyeonayla.Size = new System.Drawing.Size(191, 29);
            this.uyeonayla.TabIndex = 133;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.OldLace;
            this.label13.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(80, 490);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 27);
            this.label13.TabIndex = 132;
            this.label13.Text = "Onayla:";
            // 
            // uyesifre
            // 
            this.uyesifre.BackColor = System.Drawing.Color.OldLace;
            this.uyesifre.Font = new System.Drawing.Font("Rockwell Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uyesifre.Location = new System.Drawing.Point(195, 448);
            this.uyesifre.MaxLength = 13;
            this.uyesifre.Multiline = true;
            this.uyesifre.Name = "uyesifre";
            this.uyesifre.PasswordChar = '*';
            this.uyesifre.Size = new System.Drawing.Size(191, 29);
            this.uyesifre.TabIndex = 131;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.OldLace;
            this.label12.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(106, 448);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 27);
            this.label12.TabIndex = 130;
            this.label12.Text = "Şifre:";
            // 
            // uyekullaniciadi
            // 
            this.uyekullaniciadi.BackColor = System.Drawing.Color.OldLace;
            this.uyekullaniciadi.Font = new System.Drawing.Font("Rockwell Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyekullaniciadi.Location = new System.Drawing.Point(195, 369);
            this.uyekullaniciadi.MaxLength = 14;
            this.uyekullaniciadi.Multiline = true;
            this.uyekullaniciadi.Name = "uyekullaniciadi";
            this.uyekullaniciadi.Size = new System.Drawing.Size(191, 29);
            this.uyekullaniciadi.TabIndex = 129;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.OldLace;
            this.label10.Font = new System.Drawing.Font("Rockwell", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(328, 50);
            this.label10.TabIndex = 128;
            this.label10.Text = "Üye Olmak İçin";
            // 
            // perssifre
            // 
            this.perssifre.BackColor = System.Drawing.Color.OldLace;
            this.perssifre.Font = new System.Drawing.Font("Rockwell Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perssifre.Location = new System.Drawing.Point(723, 109);
            this.perssifre.Multiline = true;
            this.perssifre.Name = "perssifre";
            this.perssifre.PasswordChar = '*';
            this.perssifre.Size = new System.Drawing.Size(191, 29);
            this.perssifre.TabIndex = 127;
            // 
            // ogrsifre
            // 
            this.ogrsifre.BackColor = System.Drawing.Color.OldLace;
            this.ogrsifre.Font = new System.Drawing.Font("Rockwell Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ogrsifre.Location = new System.Drawing.Point(195, 109);
            this.ogrsifre.Multiline = true;
            this.ogrsifre.Name = "ogrsifre";
            this.ogrsifre.PasswordChar = '*';
            this.ogrsifre.Size = new System.Drawing.Size(191, 29);
            this.ogrsifre.TabIndex = 126;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.OldLace;
            this.label9.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(106, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 27);
            this.label9.TabIndex = 125;
            this.label9.Text = "Şifre:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.OldLace;
            this.label8.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 27);
            this.label8.TabIndex = 124;
            this.label8.Text = "Kullanıcı Adı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.OldLace;
            this.label7.Font = new System.Drawing.Font("Rockwell", 29F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(296, 48);
            this.label7.TabIndex = 123;
            this.label7.Text = "Öğrenci Girişi";
            // 
            // ogrkullaniciadi
            // 
            this.ogrkullaniciadi.BackColor = System.Drawing.Color.OldLace;
            this.ogrkullaniciadi.Font = new System.Drawing.Font("Rockwell Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrkullaniciadi.Location = new System.Drawing.Point(195, 73);
            this.ogrkullaniciadi.Multiline = true;
            this.ogrkullaniciadi.Name = "ogrkullaniciadi";
            this.ogrkullaniciadi.Size = new System.Drawing.Size(191, 29);
            this.ogrkullaniciadi.TabIndex = 122;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.OldLace;
            this.label6.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(635, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 27);
            this.label6.TabIndex = 121;
            this.label6.Text = "Şifre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.OldLace;
            this.label5.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(548, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 27);
            this.label5.TabIndex = 120;
            this.label5.Text = "Kullanıcı Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.OldLace;
            this.label4.Font = new System.Drawing.Font("Rockwell", 29F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(574, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(307, 48);
            this.label4.TabIndex = 119;
            this.label4.Text = "Personel Girişi";
            // 
            // perskullaniciadi
            // 
            this.perskullaniciadi.BackColor = System.Drawing.Color.OldLace;
            this.perskullaniciadi.Font = new System.Drawing.Font("Rockwell Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.perskullaniciadi.Location = new System.Drawing.Point(723, 71);
            this.perskullaniciadi.Multiline = true;
            this.perskullaniciadi.Name = "perskullaniciadi";
            this.perskullaniciadi.Size = new System.Drawing.Size(191, 29);
            this.perskullaniciadi.TabIndex = 118;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.OldLace;
            this.label3.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1181, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 27);
            this.label3.TabIndex = 117;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.OldLace;
            this.label2.Font = new System.Drawing.Font("Rockwell", 29F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1091, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(370, 48);
            this.label2.TabIndex = 116;
            this.label2.Text = "Araştırmacı Girişi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OldLace;
            this.label1.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1094, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 27);
            this.label1.TabIndex = 115;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // arakullaniciadi
            // 
            this.arakullaniciadi.BackColor = System.Drawing.Color.OldLace;
            this.arakullaniciadi.Font = new System.Drawing.Font("Rockwell Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.arakullaniciadi.Location = new System.Drawing.Point(1270, 73);
            this.arakullaniciadi.Multiline = true;
            this.arakullaniciadi.Name = "arakullaniciadi";
            this.arakullaniciadi.Size = new System.Drawing.Size(191, 29);
            this.arakullaniciadi.TabIndex = 114;
            // 
            // arasifre
            // 
            this.arasifre.BackColor = System.Drawing.Color.OldLace;
            this.arasifre.Font = new System.Drawing.Font("Rockwell Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arasifre.Location = new System.Drawing.Point(1270, 115);
            this.arasifre.Multiline = true;
            this.arasifre.Name = "arasifre";
            this.arasifre.PasswordChar = '*';
            this.arasifre.Size = new System.Drawing.Size(191, 29);
            this.arasifre.TabIndex = 113;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GorselProje.Properties.Resources.resim5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1526, 813);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.kullanicitipi);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.kabulediyorum);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.personelGirisi);
            this.Controls.Add(this.arasGirisi);
            this.Controls.Add(this.kayitol);
            this.Controls.Add(this.ogrGirisi);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.uyeeposta);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.uyeonayla);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.uyesifre);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.uyekullaniciadi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.perssifre);
            this.Controls.Add(this.ogrsifre);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ogrkullaniciadi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.perskullaniciadi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.arakullaniciadi);
            this.Controls.Add(this.arasifre);
            this.Name = "Form1";
            this.Text = "Ajanda Programı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox kullanicitipi;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.RadioButton kabulediyorum;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button personelGirisi;
        private System.Windows.Forms.Button arasGirisi;
        private System.Windows.Forms.Button kayitol;
        private System.Windows.Forms.Button ogrGirisi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox uyeeposta;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox uyeonayla;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox uyesifre;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox uyekullaniciadi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox perssifre;
        private System.Windows.Forms.TextBox ogrsifre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ogrkullaniciadi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox perskullaniciadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox arakullaniciadi;
        private System.Windows.Forms.TextBox arasifre;
    }
}

