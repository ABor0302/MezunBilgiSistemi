using Microsoft.Build.Framework.XamlTypes;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace MezunBilgiSistemi
{
    public partial class MezunBilgiForm : Form
    {
        MySqlConnection baglanti = new MySqlConnection("Server = localhost;Database = mezunbilgisistemi; user=root");

        public MezunBilgiForm()
        {
            InitializeComponent();
        }

        private void MezunBilgiForm_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlDataAdapter adaptor = new MySqlDataAdapter("SELECT * FROM mezunbilgileri ORDER BY ogrenci_no", baglanti);
            DataTable dt = new DataTable();

            dt.Clear();
            adaptor.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == dataGridView1.Columns["ogrenci_no"].Index && e.RowIndex != -1)
            {
                
                int ogrenciNo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ogrenci_no"].Value);

                
                ogrenciGoruntule ogrenciGoruntule = new ogrenciGoruntule();

                
                string ogrenciBilgiSorgu = "SELECT ogrenci_no, ad, soyad, mezuniyet_tarihi, ceptel, eposta, evtel, evulke, evsehir, evadres FROM mezunbilgileri WHERE ogrenci_no = @ogrenciNo";
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand(ogrenciBilgiSorgu, baglanti);
                komut.Parameters.AddWithValue("@ogrenciNo", ogrenciNo);

                MySqlDataReader reader = komut.ExecuteReader();

                if (reader.Read())
                {
                    ogrenciGoruntule.textBoxOgrenciNo.Text = reader["ogrenci_no"].ToString();
                    ogrenciGoruntule.textBoxOgrenciAdi.Text = reader["ad"].ToString();
                    ogrenciGoruntule.textBoxOgrenciSoyad.Text = reader["soyad"].ToString();
                    ogrenciGoruntule.textBoxOgrenciMezuniyet.Text = reader["mezuniyet_tarihi"].ToString();
                    ogrenciGoruntule.textBoxOgrenciCepTel.Text = reader["ceptel"].ToString();
                    ogrenciGoruntule.textBoxOgrenciEPosta.Text = reader["eposta"].ToString();
                    ogrenciGoruntule.textBoxOgrenciEvTel.Text = reader["evtel"].ToString();
                    ogrenciGoruntule.textBoxOgrenciEvUlke.Text = reader["evulke"].ToString();
                    ogrenciGoruntule.textBoxOgrenciEvSehir.Text = reader["evsehir"].ToString();
                    ogrenciGoruntule.textBoxOgrenciEvAdres.Text = reader["evadres"].ToString();
                }

                reader.Close();
                baglanti.Close();

                
                string ogrenciEgitimBilgiSorgu = "SELECT AkademikEgitim, Baslangic, Bitis, Ulke, Sehir, Universite, Bolum FROM mezunbilgileri WHERE ogrenci_no = @ogrenciNo";
                baglanti.Open();
                MySqlCommand egitimKomut = new MySqlCommand(ogrenciEgitimBilgiSorgu, baglanti);
                egitimKomut.Parameters.AddWithValue("@ogrenciNo", ogrenciNo);

                MySqlDataAdapter egitimAdaptor = new MySqlDataAdapter(egitimKomut);
                DataTable egitimDt = new DataTable();

                egitimAdaptor.Fill(egitimDt);

                ogrenciGoruntule.DataEgitimBilgi.DataSource = egitimDt;

                baglanti.Close();

                
                string ogrenciIsBilgiSorgu = "SELECT IseGirisTarihi, IstenAyrilisTarihi, KamuOzel, Sektor, Unvan, Pozisyon FROM mezunbilgileri WHERE ogrenci_no = @ogrenciNo";
                baglanti.Open();
                MySqlCommand isKomut = new MySqlCommand(ogrenciIsBilgiSorgu, baglanti);
                isKomut.Parameters.AddWithValue("@ogrenciNo", ogrenciNo);

                MySqlDataAdapter isAdaptor = new MySqlDataAdapter(isKomut);
                DataTable isDt = new DataTable();

                isAdaptor.Fill(isDt);
                ogrenciGoruntule.DataIsBilgi.DataSource = isDt;

                baglanti.Close();
                
                ogrenciGoruntule.Show();
            }
        }
        public void YenileDataGridView()
        {
           
            baglanti.Open();
            MySqlDataAdapter adaptor = new MySqlDataAdapter("SELECT * FROM mezunbilgileri ORDER BY ogrenci_no", baglanti);
            DataTable dt = new DataTable();

            dt.Clear();
            adaptor.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            yeniKayit yenikayit = new yeniKayit();
            yenikayit.Show();
        }

        private void btnDigerRapor_Click(object sender, EventArgs e)
        {
            MezunRapor mezunRapor = new MezunRapor();
            mezunRapor.Show();
        }

        private void btnKayitSil_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Bu kaydı silmek istediğinizden emin misiniz ?", "Uyarı !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (cevap == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                   
                    int ogrenciNo = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ogrenci_no"].Value);

                    
                    baglanti.Open();
                    MySqlCommand komut = new MySqlCommand();
                    komut.Connection = baglanti;
                    komut.CommandText = "DELETE FROM mezunbilgileri WHERE ogrenci_no=@pOgrenciNo";
                    komut.Parameters.AddWithValue("@pOgrenciNo", ogrenciNo);
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Kayıt silindi.");
                    
                    MezunBilgiForm_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Lütfen silmek için bir kayıt seçin.");
                }
            }
        }

    }
}
