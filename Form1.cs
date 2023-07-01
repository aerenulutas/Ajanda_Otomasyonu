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

namespace GorselProje
{
    public partial class Form1 : Form
    {
        public static string kullaniciBilgisi = "";
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("server=.\\sqlexpress;database=AjandaKayit;Integrated Security=true");
        SqlConnection con2 = new SqlConnection(@"Data Source=DESKTOP-BM7722A\SQLEXPRESS;Initial Catalog=AjandaKayit;Integrated Security=True");
        SqlConnection con3 = new SqlConnection("server=.\\sqlexpress;database=AjandaKayit;Integrated Security=true");


        private void kayitol_Click(object sender, EventArgs e)
        {
            int karakter = uyekullaniciadi.TextLength;
            int karaktersifre = uyesifre.TextLength;
            int karaktersifre2 = uyeonayla.TextLength;
            int eposta = uyeeposta.TextLength;






            if (uyekullaniciadi.Text == "" || uyesifre.Text == "" || uyeonayla.Text == "" || uyeeposta.Text == "")
            {
                MessageBox.Show("Doldurmanız gereken yereler var");


            }
            else if (karakter <= 9)
            {
                MessageBox.Show("Kullanıcı adınız en az 10 en fazla 14 karakterden oluşmalıdır.Tekrar deneyin.");

            }
            else if (karaktersifre <= 9)
            {
                MessageBox.Show("Şifreniz en az 10 en fazla 13 karakterden oluşmalıdır.Tekrar deneyin.");
            }
            else if (karaktersifre2 != karaktersifre)
            {
                MessageBox.Show("Girdiğiniz şifre eşleşmedi.Tekrak deneyin.");
            }
            else if (eposta <= 5)
            {
                MessageBox.Show("E-posta Adresiniz Hatalaı.En az 6 en fazla 30 karakterli olamlıdır.Tekrak deneyin.");

            }
            else if (kabulediyorum.Checked == false)
            {
                MessageBox.Show("Üyelik sözleşmesini kabul etmeniz lazım.");

            }
            else if (kullanicitipi.Text == "")
            {
                MessageBox.Show("Lütfen Kullanıcı tipini seçiniz.");

            }
            
            else
            {

                SqlCommand cmd = new SqlCommand("insert into AjandaKayit (KullaniciAdi,Sifre,Eposta,KullaniciTipi) values('" + uyekullaniciadi.Text + "','" + uyesifre.Text + "','" + uyeeposta.Text + "','" + kullanicitipi.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();


                con2.Open();
                SqlCommand cmd2 = new SqlCommand("Create Table "+ uyekullaniciadi.Text + "(id int identity(1,1) ,ArastirmaSecenegim nvarchar(20),SectigimKitap nvarchar(70),AktiviteSeceneğim nvarchar(50),BaslangıçTarihi nvarchar(MAX),BaslangiçSaati nvarchar(MAX),BitisTarihi nvarchar(MAX),BitisSaati nvarchar(MAX),Notalma nvarchar(MAX),GunlukSaat nvarchar(MAX))", con2);
                cmd2.ExecuteNonQuery();
                con2.Close();
                MessageBox.Show("Kayıdınız başarıyla gerçekleşmiştir.");

                
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://drive.google.com/file/d/18rWbdyO85wcKMFSFTlRSQgnGER_penue/view?usp=share_link");
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            uyekullaniciadi.Clear();
            uyesifre.Clear();
            uyeonayla.Clear();
            uyeeposta.Clear();
            ogrkullaniciadi.Clear();
            ogrsifre.Clear();
            perskullaniciadi.Clear();
            perssifre.Clear();
            arakullaniciadi.Clear();
            arasifre.Clear();
        }
        bool isThere;
        private void ogrGirisi_Click(object sender, EventArgs e)
        {
            string kullaniciadi = ogrkullaniciadi.Text;
            string sifre = ogrsifre.Text;

            con.Open();
            SqlCommand cmd = new SqlCommand("select * from AjandaKayit where KullaniciTipi = 'Öğrenci' ", con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (kullaniciadi == reader["KullaniciAdi"].ToString().TrimEnd() && sifre == reader["Sifre"].ToString().TrimEnd())
                {
                    isThere = true;
                    break;
                }
                else
                {
                    isThere = false;
                }
            }

            con.Close();

            if (isThere)
            {
                Form2 fr2 = new Form2();
                kullaniciBilgisi = ogrkullaniciadi.Text;
                fr2.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adınız veya Şifreniz eksik veya doğru değil.Tekrar Deneyin.");

            }

            
        }

        private void personelGirisi_Click(object sender, EventArgs e)
        {
            string pkullaniciadi = perskullaniciadi.Text;
            string psifre = perssifre.Text;

            con.Open();
            SqlCommand cmd = new SqlCommand("select * from AjandaKayit where KullaniciTipi = 'Personel'", con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (pkullaniciadi == reader["KullaniciAdi"].ToString().TrimEnd() && psifre == reader["Sifre"].ToString().TrimEnd())
                {
                    isThere = true;
                    break;
                }
                else
                {
                    isThere = false;
                }
            }

            con.Close();

            if (isThere)
            {
                Form2 fr2 = new Form2();
                kullaniciBilgisi = perskullaniciadi.Text;
                fr2.Show();
                Hide();

                
            }
            else
            {
                MessageBox.Show("Kullanıcı Adınız ve Şifreniz eksik veya doğru değil.Tekrar Deneyin.");

            }
        }

        private void arasGirisi_Click(object sender, EventArgs e)
        {
            string akullaniciadi = arakullaniciadi.Text;
            string asifre = arasifre.Text;

            con.Open();
            SqlCommand cmd = new SqlCommand("select * from AjandaKayit where KullaniciTipi = 'Araştırmacı'", con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (akullaniciadi == reader["KullaniciAdi"].ToString().TrimEnd() && asifre == reader["Sifre"].ToString().TrimEnd())
                {
                    isThere = true;
                    break;
                }
                else
                {
                    isThere = false;
                }
            }

            con.Close();

            if (isThere)
            {
                Form2 fr2 = new Form2();
                kullaniciBilgisi = arakullaniciadi.Text;
                fr2.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adınız ve Şifreniz eksik veya doğru değil.Tekrar Deneyin.");

            }
        }

 
    }
    
}
