using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MezunBilgiSistemi
{
    public partial class Form1 : Form
    {
        MySqlConnection baglanti = new MySqlConnection("Server = localhost;Database = mezunbilgisistemi; user=root");

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtKullaniciSifre.Text;

            string query = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";

            using (MySqlCommand command = new MySqlCommand(query, baglanti))
            {
                command.Parameters.AddWithValue("@username", kullaniciAdi);
                command.Parameters.AddWithValue("@password", sifre);

                try
                {
                    baglanti.Open();

                    int kullaniciSayisi = Convert.ToInt32(command.ExecuteScalar());

                    if (kullaniciSayisi > 0)
                    {
                        MessageBox.Show("Giriş başarılı!");
                        MezunBilgiForm mezunBilgiForm = new MezunBilgiForm();
                        mezunBilgiForm.ShowDialog();
                        this.Close();
                        baglanti.Close();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Bağlantı hatası: " + ex.Message);
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
