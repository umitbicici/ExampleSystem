using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using DevExpress.XtraEditors;

namespace ExampleSystem
{
    public partial class ogrenciSinav1 : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=FERVOR;Initial Catalog=db.exampleSystem;Integrated Security=True");
        string dogruCevap, soruMetni, sinavZamani;
        int cevap = 0, veri = 0, progressBarSayac = 100, soruSayac = 1, dogruSayisi = 0, yanlisSayisi = 0, bosSayisi = 0, kayitSayisi = 0, sinavNot = 0;
        public ogrenciSinav1()
        {
            InitializeComponent();
        }

        private void btnBosBirak_Click(object sender, EventArgs e)
        {
            bosSayisi++;
            cevap = -1;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE tblSoru SET Cevap= '" + cevap + "' WHERE Metin='" + soruMetni + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veri++;
            sorulariGetir();
        }

        public void sinavKaydet()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into tblSinav(sinavAdi,sinavZaman,dogruSayisi,yanlisSayisi,bosSayisi,sinavNot) values (@sinavAdi,@sinavZaman,@dogruSayisi,@yanlisSayisi,@bosSayisi,@sinavNot)", baglanti);
            komut.Parameters.Add("@sinavAdi", "1.Sınav");
            komut.Parameters.Add("@sinavZaman", sinavZamani);
            komut.Parameters.Add("@dogruSayisi", dogruSayisi);
            komut.Parameters.Add("@yanlisSayisi", yanlisSayisi);
            komut.Parameters.Add("@bosSayisi", bosSayisi);
            sinavNot = dogruSayisi * 10;
            komut.Parameters.Add("@sinavNot", sinavNot);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
            sinavKaydet();
        }

        public void sorulariGetir()
        {
            lblSoru.Text = Convert.ToString(soruSayac);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from tblSoru", baglanti);
            SqlCommand cmd = new SqlCommand("select count(*) from tblSoru", baglanti);
            kayitSayisi = Convert.ToInt32(cmd.ExecuteScalar());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (veri >= kayitSayisi)
            {
                progressBarSayac = 0;
                baglanti.Close();
                sinavKaydet();
                XtraMessageBox.Show("Sınavınız Başarı ile Tamamlandı, Anasayfaya Yönlendiriliyorsunuz...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                ogrenciSonuc ogrSonuc = new ogrenciSonuc();
                ogrSonuc.Show();

            }
            else
            {
                lblSoruMetin.Text = dt.Rows[veri][1].ToString();
                soruMetni = dt.Rows[veri][1].ToString();
                btnCvp1.Text = dt.Rows[veri][2].ToString();
                btnCvp2.Text = dt.Rows[veri][3].ToString();
                btnCvp3.Text = dt.Rows[veri][4].ToString();
                btnCvp4.Text = dt.Rows[veri][5].ToString();
                dogruCevap = dt.Rows[veri][6].ToString();
                pictureBox1.ImageLocation = dt.Rows[veri][9].ToString();
                baglanti.Close();
            }
        }
        private void ogrenciIslem_Load(object sender, EventArgs e)
        {
            sinavZamani= Convert.ToString(DateTime.Now.ToLongDateString()); //Bugünün tarihi atılıyor
            progressBarControl1.ShowProgressInTaskBar = true; //Görev çubuğunda kalan süreyi gösterir
            progressBarControl1.Properties.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid;
            progressBarControl1.Properties.EndColor = System.Drawing.Color.DarkOrange;
            progressBarControl1.Properties.StartColor = System.Drawing.Color.DarkSlateGray;
            progressBarControl1.Properties.ShowTitle = true;
            progressBarControl1.Properties.LookAndFeel.SetStyle(DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat, false, false);
            progressBarControl1.EditValue = 100;
            timer1.Start();
            sorulariGetir();
        }

        private void btnCvp1_Click(object sender, EventArgs e)
        {
            soruSayac++;
            if (btnCvp1.Text == dogruCevap)
            {
                dogruSayisi++;
                cevap = 1;
            }
            else
            {
                yanlisSayisi++;
                cevap = 0;
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE tblSoru SET Cevap= '" + cevap + "' WHERE Metin='" + soruMetni + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veri++;
            sorulariGetir();
        }

        private void btnCvp2_Click(object sender, EventArgs e)
        {
            soruSayac++;
            if (btnCvp2.Text == dogruCevap)
            {
                dogruSayisi++;
                cevap = 1;
            }
            else
            {
                yanlisSayisi++;
                cevap = 0;
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE tblSoru SET Cevap= '" + cevap + "' WHERE Metin='" + soruMetni + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veri++;
            sorulariGetir();
        }

        private void btnCvp3_Click(object sender, EventArgs e)
        {
            soruSayac++;
            if (btnCvp3.Text == dogruCevap)
            {
                dogruSayisi++;
                cevap = 1;
            }
            else
            {
                yanlisSayisi++;
                cevap = 0;
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE tblSoru SET Cevap= '" + cevap + "' WHERE Metin='" + soruMetni + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veri++;
            sorulariGetir();
        }

        private void btnCvp4_Click(object sender, EventArgs e)
        {
            soruSayac++;
            if (btnCvp4.Text == dogruCevap)
            {
                dogruSayisi++;
                cevap = 1;
            }
            else
            {
                yanlisSayisi++;
                cevap = 0;
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE tblSoru SET Cevap= '" + cevap + "' WHERE Metin='" + soruMetni + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veri++;
            sorulariGetir();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBarSayac--;
            progressBarControl1.EditValue = progressBarSayac;
            if (progressBarSayac == 0)
            {
                XtraMessageBox.Show("Süreniz Dolmuştur! Anasayfaya Yönlendiriliyorsunuz...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sinavKaydet();
                this.Hide();
                ogrenciSonuc ogrSonuc = new ogrenciSonuc();
                ogrSonuc.Show();
            }
        }
    }
}
