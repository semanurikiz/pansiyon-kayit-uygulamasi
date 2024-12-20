using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace pansiyonkayıt
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-RGG65VF\\MSSQLSERVER01;Initial Catalog=Lavantapansiyon;Integrated Security=True");

        public SqlConnection Query { get; private set; }

        private void btnOda101_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "101";
        }

        private void btnOda102_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "102";
        }

        private void btnOda103_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "103";
        }

        private void btnOda104_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "104";
        }

        private void btnOda105_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "105";
        }

        private void btnOda106_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "106";
        }

        private void btnOda107_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "107";
        }

        private void btnOda108_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "108";
        }

        private void btnOda109_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "109";
        }

        private void btnBosOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil Renkli Odalar Boştur!");
        }

        private void btnDoluOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Renkli Odalar Doludur!");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

          
            baglanti.Open();
            string query = "INSERT INTO musteri_ekle (adi, soyadi, cinsiyet,telefon,mail,TC,odano,ucret,giristarihi,cikistarihi) VALUES (@adi, @soyadi, @cinsiyet,@telefon,@mail,@TC,@odano,@ucret,@giristarihi,@cikistarihi)";
            SqlCommand komut = new SqlCommand(query, baglanti);
            // Parametreleri ekleme
            komut.Parameters.AddWithValue("@adi", txtAd.Text.Trim());
            komut.Parameters.AddWithValue("@soyadi", txtSoyad.Text.Trim());
            komut.Parameters.AddWithValue("@cinsiyet", cmbCinsiyet.SelectedItem?.ToString() ?? "");
            komut.Parameters.AddWithValue("@telefon", mskTelefon.Text.Trim());
            komut.Parameters.AddWithValue("@mail", txtMail.Text.Trim());
            komut.Parameters.AddWithValue("@TC", txtTcNo.Text.Trim());
            komut.Parameters.AddWithValue("@odano", int.TryParse(txtOdaNo.Text, out int odaNo) ? odaNo : (object)DBNull.Value);
            komut.Parameters.AddWithValue("@ucret", decimal.TryParse(txtUcret.Text, out decimal ucret) ? ucret : (object)DBNull.Value);
            komut.Parameters.AddWithValue("@giristarihi", DateTime.TryParse(dtpGirisTarihi.Text, out DateTime girisTarihi) ? girisTarihi : (object)DBNull.Value);
            komut.Parameters.AddWithValue("@cikistarihi", DateTime.TryParse(dtpCikisTarihi.Text, out DateTime cikisTarihi) ? cikisTarihi : (object)DBNull.Value);

            komut.ExecuteNonQuery();
            baglanti.Close();
            if (string.IsNullOrWhiteSpace(txtAd.Text) ||
                string.IsNullOrWhiteSpace(txtSoyad.Text) ||
                cmbCinsiyet.SelectedItem == null ||
                string.IsNullOrWhiteSpace(mskTelefon.Text) ||
                string.IsNullOrWhiteSpace(txtMail.Text) ||
                string.IsNullOrWhiteSpace(txtTcNo.Text) ||
                string.IsNullOrWhiteSpace(txtOdaNo.Text) ||
                string.IsNullOrWhiteSpace(txtUcret.Text) ||
                string.IsNullOrWhiteSpace(dtpGirisTarihi.Text) ||
                string.IsNullOrWhiteSpace(dtpCikisTarihi.Text))
            {
                MessageBox.Show("Tüm alanların doldurulması zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


        }

        private void dtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            int Ucret;
            DateTime KucukTarih = Convert.ToDateTime(dtpGirisTarihi.Text);
            DateTime BuyukTarih = Convert.ToDateTime(dtpCikisTarihi.Text);

            TimeSpan Sonuc;
            Sonuc = BuyukTarih - KucukTarih;
            label1.Text = Sonuc.TotalDays.ToString();
            Ucret = Convert.ToInt32(label1.Text) * 100;
            txtUcret.Text = Ucret.ToString();
        }
    }
}
