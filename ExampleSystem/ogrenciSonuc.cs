using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraCharts;

namespace ExampleSystem
{
    public partial class ogrenciSonuc : Form
    {
        public ogrenciSonuc()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=FERVOR;Initial Catalog=db.exampleSystem;Integrated Security=True");
        ChartControl chart = new ChartControl();

        int veri = 0;

        string sinav1DogruSayisi, sinav1YanlisSayisi, sinav1BosSayisi,
               sinav2DogruSayisi, sinav2YanlisSayisi, sinav2BosSayisi,
               sinav3DogruSayisi, sinav3YanlisSayisi, sinav3BosSayisi,
               sinav1Tarih, sinav2Tarih, sinav3Tarih;

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGrafik1_Click(object sender, EventArgs e)
        {
            chart.Animate();
            label1.Visible = false;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from tblSinav where sinavAdi='1.Sınav'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count <= 0)
            {
                XtraMessageBox.Show("1.Sınav Sonucunuz Bulunmamaktadır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sinav1Tarih = dt.Rows[veri][2].ToString();
                sinav1DogruSayisi = dt.Rows[veri][3].ToString();
                sinav1YanlisSayisi = dt.Rows[veri][4].ToString();
                sinav1BosSayisi = dt.Rows[veri][5].ToString();

                chartControl1.Visible = true;
                chartControl2.Visible = false;
                chartControl3.Visible = false;
                chartControl4.Visible = false;

                chartControl1.Series["Doğru"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(sinav1Tarih, sinav1DogruSayisi));
                chartControl1.Series["Yanlış"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(sinav1Tarih, sinav1YanlisSayisi));
                chartControl1.Series["Boş"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(sinav1Tarih, sinav1BosSayisi));
            }
            baglanti.Close();

        }

        private void btnGrafik2_Click(object sender, EventArgs e)
        {
            chart.Animate();
            label1.Visible = false;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from tblSinav where sinavAdi='2.Sınav'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count <= 0)
            {
                XtraMessageBox.Show("2.Sınav Sonucunuz Bulunmamaktadır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sinav2Tarih = dt.Rows[veri][2].ToString();
                sinav2DogruSayisi = dt.Rows[veri][3].ToString();
                sinav2YanlisSayisi = dt.Rows[veri][4].ToString();
                sinav2BosSayisi = dt.Rows[veri][5].ToString();

                chartControl4.Visible = false;
                chartControl3.Visible = false;
                chartControl2.Visible = true;
                chartControl1.Visible = false;

                chartControl2.Series["Doğru"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(sinav2Tarih, sinav2DogruSayisi));
                chartControl2.Series["Yanlış"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(sinav2Tarih, sinav2YanlisSayisi));
                chartControl2.Series["Boş"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(sinav2Tarih, sinav2BosSayisi));
            }
            baglanti.Close();
        }

        private void btnGrafik3_Click(object sender, EventArgs e)
        {
            chart.Animate();
            label1.Visible = false;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from tblSinav where sinavAdi='3.Sınav'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count <= 0)
            {
                XtraMessageBox.Show("3.Sınav Sonucunuz Bulunmamaktadır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sinav3Tarih = dt.Rows[veri][2].ToString();
                sinav3DogruSayisi = dt.Rows[veri][3].ToString();
                sinav3YanlisSayisi = dt.Rows[veri][4].ToString();
                sinav3BosSayisi = dt.Rows[veri][5].ToString();

                chartControl4.Visible = false;
                chartControl3.Visible = true;
                chartControl2.Visible = false;
                chartControl1.Visible = false;

                chartControl3.Series["Doğru"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(sinav3Tarih, sinav3DogruSayisi));
                chartControl3.Series["Yanlış"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(sinav3Tarih, sinav3YanlisSayisi));
                chartControl3.Series["Boş"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(sinav3Tarih, sinav3BosSayisi));
            }
            baglanti.Close();
        }

        private void btnGenelBasari_Click(object sender, EventArgs e)
        {
            chart.Animate();
            label1.Visible = false;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from tblSinav", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count <= 0)
            {
                XtraMessageBox.Show("En Az Bir Sınavı Tamamlayınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sinav1Tarih = dt.Rows[veri][2].ToString();
                sinav1DogruSayisi = dt.Rows[veri][3].ToString();
                sinav1YanlisSayisi = dt.Rows[veri][4].ToString();
                sinav1BosSayisi = dt.Rows[veri][5].ToString();
                chartControl4.Series["Doğru"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(sinav1Tarih, sinav1DogruSayisi));
                chartControl4.Series["Yanlış"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(sinav1Tarih, sinav1YanlisSayisi));
                chartControl4.Series["Boş"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(sinav1Tarih, sinav1BosSayisi));
                chartControl4.Visible = true;
                veri++;
            }
                if (dt.Rows.Count <= 1)
                {
                    //XtraMessageBox.Show("Önce 2.Sınavı Tamamlayınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    sinav2Tarih = dt.Rows[veri][2].ToString();
                    sinav2DogruSayisi = dt.Rows[veri][3].ToString();
                    sinav2YanlisSayisi = dt.Rows[veri][4].ToString();
                    sinav2BosSayisi = dt.Rows[veri][5].ToString();
                    chartControl4.Series["Doğru"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(sinav2Tarih, sinav2DogruSayisi));
                    chartControl4.Series["Yanlış"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(sinav2Tarih, sinav2YanlisSayisi));
                    chartControl4.Series["Boş"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(sinav2Tarih, sinav2BosSayisi));
                    chartControl4.Visible = true;
                    veri++;
                }

                if (dt.Rows.Count <= 2)
                {
                    //XtraMessageBox.Show("Önce 3.Sınavı Tamamlayınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    sinav3Tarih = dt.Rows[veri][2].ToString();
                    sinav3DogruSayisi = dt.Rows[veri][3].ToString();
                    sinav3YanlisSayisi = dt.Rows[veri][4].ToString();
                    sinav3BosSayisi = dt.Rows[veri][5].ToString();
                    chartControl4.Series["Doğru"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(sinav3Tarih, sinav3DogruSayisi));
                    chartControl4.Series["Yanlış"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(sinav3Tarih, sinav3YanlisSayisi));
                    chartControl4.Series["Boş"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(sinav3Tarih, sinav3BosSayisi));
                    chartControl4.Visible = true;
                }
            baglanti.Close();
            veri = 0;
        }

        private void frmGenelBasari_Load(object sender, EventArgs e)
        {
            chartControl1.Visible = false;
            chartControl2.Visible = false;
            chartControl3.Visible = false;
            chartControl4.Visible = false;

        }

        private void btnSinavaBasla_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from tblSinav", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count <= 0)
            {
                DialogResult dialog = new DialogResult();
                dialog = XtraMessageBox.Show("1.Sınava Başlamak İstiyor Musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    ogrenciSinav1 ogr = new ogrenciSinav1();
                    ogr.Show();
                    this.Hide();
                }
            }
            else if (dt.Rows.Count <= 1)
            {
                DialogResult dialog = new DialogResult();
                dialog = XtraMessageBox.Show("2.Sınava Başlamak İstiyor Musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    ogrenciSinav2 ogr = new ogrenciSinav2();
                    ogr.Show();
                    this.Hide();
                }
            }
            else if (dt.Rows.Count <= 2)
            {
                DialogResult dialog = new DialogResult();
                dialog = XtraMessageBox.Show("3.Sınava Başlamak İstiyor Musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    ogrenciSinav3 ogr = new ogrenciSinav3();
                    ogr.Show();
                    this.Hide();
                }
            }
            else
            {
                XtraMessageBox.Show("Bütün Sınavlarınız Tamamlanmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            baglanti.Close();

        }
    }
}
