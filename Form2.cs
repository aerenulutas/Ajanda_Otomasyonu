using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace GorselProje
{
    public partial class Form2 : Form


    {
     
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-BM7722A\SQLEXPRESS;Initial Catalog=AjandaKayit;Integrated Security=True");
        public void ajandayigoster(string ajandalar)
        {

            SqlDataAdapter da = new SqlDataAdapter(ajandalar,baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            ajandalistesi.DataSource = ds.Tables[0];

        }
       
        private void Ekle_Click(object sender, EventArgs e)
        {
            int farksaat = 0;
            bool boolean = false;

            if (dateTimePicker1.Value.ToString("dd.MM.yyyy") != dateTimePicker2.Value.ToString("dd.MM.yyyy"))
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into " + kullanıcıAdi.Text + "(ArastirmaSecenegim,SectigimKitap,AktiviteSeceneğim,BaslangıçTarihi,BaslangiçSaati,BitisTarihi,BitisSaati,Notalma,GunlukSaat) values (@Arastirma,@Sectigim,@Aktivite,@BaslangıçTa,@BaslangiçSa,@BitisTa,@BitisSa,@Notal,@Gunluk)", baglanti);
                komut.Parameters.AddWithValue("@Arastirma", arastirmasecenekleri.Text);
                komut.Parameters.AddWithValue("@Sectigim", yüklükitaplar.Text);
                komut.Parameters.AddWithValue("@Aktivite", aktsecenekleri.Text);
                komut.Parameters.AddWithValue("@BaslangıçTa", dateTimePicker1.Value.ToString("dd.MM.yyyy"));
                komut.Parameters.AddWithValue("@BaslangiçSa", bassaati.Text);
                komut.Parameters.AddWithValue("@BitisTa", dateTimePicker2.Value.ToString("dd.MM.yyyy"));
                komut.Parameters.AddWithValue("@BitisSa", bitissaati.Text);
                komut.Parameters.AddWithValue("@Notal", not.Text);
                komut.Parameters.AddWithValue("@Gunluk", farksaat.ToString());
                komut.ExecuteNonQuery();
                ajandayigoster("select * from " + kullanıcıAdi.Text + "");
                baglanti.Close();
                boolean = true;

            }
            else if (dateTimePicker1.Value.ToString("dd.MM.yyyy") == dateTimePicker2.Value.ToString("dd.MM.yyyy"))
            {
                string baslangıcsaati = bassaati.Text;
                string bitissaatii = bitissaati.Text;
                TimeSpan basbitFarki = DateTime.Parse(bitissaatii).Subtract(DateTime.Parse(baslangıcsaati));
                string calismaSuresi = basbitFarki.ToString();
                string saatfark = calismaSuresi.Replace("-", "");
                string yenisaatfark = saatfark.Substring(0, 2);
                farksaat = Convert.ToInt32(yenisaatfark);
                
            }

            if (boolean!=true)         
            {
                if (farksaat >= 10)
                {
                    MessageBox.Show("Saat farkı 10 dan büyük olamaz");
                }
                else if (label9.Text == "Günlük Saat Toplamı=10" || label9.Text == "Günlük Saat Toplamı=11" || label9.Text == "Günlük Saat Toplamı=12" || label9.Text == "Günlük Saat Toplamı=13" || label9.Text == "Günlük Saat Toplamı=14" || label9.Text == "Günlük Saat Toplamı=15"
                    || label9.Text == "Günlük Saat Toplamı=16" || label9.Text == "Günlük Saat Toplamı=17" || label9.Text == "Günlük Saat Toplamı=18" || label9.Text == "Günlük Saat Toplamı=19" || label9.Text == "Günlük Saat Toplamı=20" || label9.Text == "Günlük Saat Toplamı=21" 
                    || label9.Text == "Günlük Saat Toplamı=22" || label9.Text == "Günlük Saat Toplamı=23" || label9.Text == "Günlük Saat Toplamı=24") 
                {
                    MessageBox.Show("Günlük Aktivte Süresi 10 Saati Geçemez");
                }
                else
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("insert into " + kullanıcıAdi.Text + "(ArastirmaSecenegim,SectigimKitap,AktiviteSeceneğim,BaslangıçTarihi,BaslangiçSaati,BitisTarihi,BitisSaati,Notalma,GunlukSaat) values (@Arastirma,@Sectigim,@Aktivite,@BaslangıçTa,@BaslangiçSa,@BitisTa,@BitisSa,@Notal,@Gunluk)", baglanti);
                    komut.Parameters.AddWithValue("@Arastirma", arastirmasecenekleri.Text);
                    komut.Parameters.AddWithValue("@Sectigim", yüklükitaplar.Text);
                    komut.Parameters.AddWithValue("@Aktivite", aktsecenekleri.Text);
                    komut.Parameters.AddWithValue("@BaslangıçTa", dateTimePicker1.Value.ToString("dd.MM.yyyy"));
                    komut.Parameters.AddWithValue("@BaslangiçSa", bassaati.Text);
                    komut.Parameters.AddWithValue("@BitisTa", dateTimePicker2.Value.ToString("dd.MM.yyyy"));
                    komut.Parameters.AddWithValue("@BitisSa", bitissaati.Text);
                    komut.Parameters.AddWithValue("@Notal", not.Text);
                    komut.Parameters.AddWithValue("@Gunluk", farksaat.ToString());
                    komut.ExecuteNonQuery();
                    ajandayigoster("select * from " + kullanıcıAdi.Text + "");
                    baglanti.Close();
                    double toplam = 0;
                    for (int i = 0; i < ajandalistesi.Rows.Count; i++)
                    {
                        toplam += Convert.ToDouble(ajandalistesi.Rows[i].Cells[9].Value);
                    }
                    label9.Text = "Günlük Saat Toplamı=" + toplam;
                }

            }

            string saat;
            saat = Convert.ToString(bassaati.Text);
            label11.Text = "" + saat;
          
        }
 
        private void girisEkranınaDon_Click(object sender, EventArgs e)
        {
            Form1 fr2 = new Form1();
            fr2.Show();
            Hide();
        }

        private void Listele_Click(object sender, EventArgs e)
        {
            ajandayigoster("select * from " + kullanıcıAdi.Text + "");
        }
              
        private void Form2_Load(object sender, EventArgs e)
        {
            kullanıcıAdi.Text = Form1.kullaniciBilgisi;
              
        }

        private void Kütüphane_Click(object sender, EventArgs e)
        {
             
         Process.Start("https://drive.google.com/drive/folders/1oAx-JaobK5oGWFbRpv4qXa4TGLd0t87I?usp=share_link");
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label10.Text = string.Format("{0:hh:mm}", DateTime.Now);
            if (label10.Text == label11.Text)
            {
                timer1.Interval = 60000;
                var fromAddress = new MailAddress("ajandamailgonderme@gmail.com");
                var toAddress = new MailAddress("abdullaherenulutas@gmail.com");
                const string fromPassword = "ucqxcncmkbnsyioe";
                const string subject = "AjandaAlarım";
                const string body = "Aktivite Başlangıç Saatiniz Gelmiştir.İyi Günler Dilerim.... ";
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = true,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })

                {

                    smtp.Send(message);

                }

            }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM " + kullanıcıAdi.Text + " WHERE id=@id " , baglanti);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(idno.Text));            
            komut.ExecuteNonQuery();
            ajandayigoster("select * from " + kullanıcıAdi.Text + "");
            baglanti.Close();

            

        }
    }
}
