using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace MezunBilgiSistemi
{
    public partial class MezunRapor : Form
    {
        public MezunRapor()
        {
            InitializeComponent();
        }

        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=mezunbilgisistemi;user=root");

        private void btnDoktoraListele_Click(object sender, EventArgs e)
        {
            try
            {
                
                baglanti.Open();

                
                string sql = "SELECT AkademikEgitim, ogrenci_no, ad, soyad FROM mezunbilgileri WHERE AkademikEgitim = 'Doktora'";


                
                MySqlCommand komut = new MySqlCommand(sql, baglanti);

               
                MySqlDataReader okuyucu = komut.ExecuteReader();

                
                Form popupForm = new Form();
                DataGridView dataGridViewPopup = new DataGridView();
                dataGridViewPopup.Dock = DockStyle.Fill;
                popupForm.Controls.Add(dataGridViewPopup);

                DataTable dt = new DataTable();
                dt.Load(okuyucu);
                dataGridViewPopup.DataSource = dt;

                
                popupForm.ShowDialog();

                
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void btnTRDoktoraYapanOgr_Click(object sender, EventArgs e)
        {
            try
            {
                
                baglanti.Open();

                
                string sql = "SELECT AkademikEgitim, ogrenci_no, ad, soyad FROM mezunbilgileri WHERE AkademikEgitim = 'Doktora' AND Ulke='Türkiye'";


                
                MySqlCommand komut = new MySqlCommand(sql, baglanti);

                
                MySqlDataReader okuyucu = komut.ExecuteReader();

                
                Form popupForm = new Form();
                DataGridView dataGridViewPopup = new DataGridView();
                dataGridViewPopup.Dock = DockStyle.Fill;
                popupForm.Controls.Add(dataGridViewPopup);

                
                DataTable dt = new DataTable();
                dt.Load(okuyucu);
                dataGridViewPopup.DataSource = dt;

                
                popupForm.ShowDialog();

                
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void btnYurtDisiDoktoraOgr_Click(object sender, EventArgs e)
        {
            try { 
            baglanti.Open();
            string sql = "SELECT ogrenci_no,ad,soyad FROM mezunbilgileri WHERE AkademikEgitim = 'Doktora' AND Ulke != 'Türkiye'";
            MySqlCommand komut = new MySqlCommand(sql, baglanti);
            MySqlDataReader okuyucu = komut.ExecuteReader();

            Form popupForm = new Form();
            DataGridView dataGridViewPopUp = new DataGridView();
            dataGridViewPopUp.Dock = DockStyle.Fill;
            popupForm.Controls.Add(dataGridViewPopUp);

            DataTable dt = new DataTable();
            dt.Load(okuyucu);
            dataGridViewPopUp.DataSource = dt;

            popupForm.ShowDialog();

            baglanti.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void btnYuksekLisansOgr_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                string sorgu = "SELECT ogrenci_no,ad,soyad FROM mezunbilgileri WHERE AkademikEgitim = 'Yüksek Lisans'";

                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);

                MySqlDataReader okuyucu = komut.ExecuteReader();

                Form popupForm = new Form();
                DataGridView dataGridViewPopUp = new DataGridView();
                dataGridViewPopUp.Dock =DockStyle.Fill;
                popupForm.Controls.Add(dataGridViewPopUp);

                DataTable dt = new DataTable();
                dt.Load(okuyucu);
                dataGridViewPopUp.DataSource = dt;

                popupForm.ShowDialog();
                baglanti.Close();


            }
            catch (Exception ex ) 
            {
                MessageBox.Show("Hata oluştur: " + ex.Message);
            }
        }

        private void btnTRYuksekLisansOgrListele_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                string sorgu = "SELECT ogrenci_no,ad,soyad FROM mezunbilgileri WHERE AkademikEgitim = 'Yüksek Lisans' AND Ulke='Türkiye'";
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                MySqlDataReader okuyucu = komut.ExecuteReader();

                Form popUpForm = new Form();
                DataGridView dataGridViewPopUp = new DataGridView();
                dataGridViewPopUp.Dock =DockStyle.Fill;
                popUpForm.Controls.Add(dataGridViewPopUp);

                DataTable dt = new DataTable();
                dt.Load(okuyucu);
                dataGridViewPopUp.DataSource = dt;

                popUpForm.ShowDialog();

                baglanti.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void btnYurtDisiYuksekOgr_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                string sorgu = "SELECT ogrenci_no,ad,soyad FROM mezunbilgileri WHERE AkademikEgitim = 'Yüksek Lisans' AND Ulke != 'Türkiye'";
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);

                MySqlDataReader okuyucu = komut.ExecuteReader();

                Form popUpForm = new Form();
                DataGridView dataGridViewPopUp = new DataGridView();
                dataGridViewPopUp.Dock = DockStyle.Fill;
                popUpForm.Controls.Add(dataGridViewPopUp);

                DataTable dt = new DataTable();
                dt.Load(okuyucu);
                dataGridViewPopUp.DataSource = dt;

                popUpForm.ShowDialog();
                baglanti.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata oluştur: " + ex.Message);
            }
        }

        private void btnMezuniyetSonrasiUcBesYil_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

               
                string sorgu = "SELECT ogrenci_no,ad,soyad,AkademikEgitim,Baslangic,Bitis,Sehir,Universite,Bolum,Pozisyon FROM mezunbilgileri WHERE TIMESTAMPDIFF(YEAR, Mezuniyet_Tarihi, IseGirisTarihi) BETWEEN 3 AND 5";

                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                MySqlDataReader okuyucu = komut.ExecuteReader();

                Form popUpForm = new Form();
                DataGridView dataGridViewPopUp = new DataGridView();
                dataGridViewPopUp.Dock = DockStyle.Fill;
                popUpForm.Controls.Add(dataGridViewPopUp);

                DataTable dt = new DataTable();
                dt.Load(okuyucu);
                dataGridViewPopUp.DataSource = dt;

                popUpForm.ShowDialog();

                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void btnMezuniyetOnYilYonetici_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                string sql = @"SELECT ogrenci_no,ad,soyad,AkademikEgitim,Baslangic,Bitis,Sehir,Universite,Bolum,Pozisyon
                                FROM mezunbilgileri 
                                WHERE (Pozisyon LIKE '%Yönetici%' OR Pozisyon LIKE '%Müdür%') 
                                AND TIMESTAMPDIFF(YEAR, Bitis, IseGirisTarihi) <= 10";

                MySqlCommand komut = new MySqlCommand(sql, baglanti);
                MySqlDataReader okuyucu = komut.ExecuteReader();

                Form popupForm = new Form();
                DataGridView dataGridViewPopUp = new DataGridView();
                dataGridViewPopUp.Dock = DockStyle.Fill;
                popupForm.Controls.Add(dataGridViewPopUp);

                DataTable dt = new DataTable();
                dt.Load(okuyucu);
                dataGridViewPopUp.DataSource = dt;

                popupForm.ShowDialog();

                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }
    }
}
