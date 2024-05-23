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
    public partial class ogrenciGoruntule : Form
    {
        public ogrenciGoruntule()
        {
            InitializeComponent();
        }
        public TextBox textBoxOgrenciNo
        {
            get { return txtOgrNo; }
            set { txtOgrNo = value; }
        }
        public TextBox textBoxOgrenciAdi
        {
            get { return txtOgrAd; }
            set { txtOgrAd = value; }
        }
        public TextBox textBoxOgrenciSoyad
        {
            get { return txtOgrSoyad; }
            set { txtOgrSoyad = value; }
        }
        public TextBox textBoxOgrenciMezuniyet
        {
            get { return txtMezuniyetTarihi; }
            set { txtMezuniyetTarihi = value; }
        }
        public TextBox textBoxOgrenciCepTel
        {
            get { return txtCepTel; }
            set { txtCepTel = value; }
        }
        public TextBox textBoxOgrenciEPosta
        {
            get { return txtEPosta; }
            set { txtEPosta = value; }
        }
        public TextBox textBoxOgrenciEvTel
        {
            get { return txtEvTel; }
            set { txtEvTel = value; }
        }
        public TextBox textBoxOgrenciEvUlke
        {
            get { return txtEvUlke; }
            set { txtEvUlke = value; }
        }
        public TextBox textBoxOgrenciEvSehir
        {
            get { return txtEvSehir; }
            set { txtEvSehir = value; }
        }
        public TextBox textBoxOgrenciEvAdres
        {
            get { return txtEvAdres; }
            set { txtEvAdres = value; }
        }
        public DataGridView DataEgitimBilgi
        {
            get { return dgEgitimBilgileri; }
            set { dgEgitimBilgileri = value; }
        }
        public DataGridView DataIsBilgi
        {
            get { return dgIsBilgileri; }
            set { dgIsBilgileri = value; }
        }

        private void btnKayitGuncelle_Click(object sender, EventArgs e)
        {

        }
    }
}

