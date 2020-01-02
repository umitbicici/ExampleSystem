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
    public partial class adminPanel : Form
    {
        public adminPanel()
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
        private void ogrenciCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOgretmen_Click(object sender, EventArgs e)
        {
            chartControl1.Visible = false;
            dataGridView1.Visible = true;
            DataSet dataset = new DataSet();
            SqlDataAdapter adtr = new SqlDataAdapter("Select name AS Ad,surname AS Soyad from tblOgretmen", baglanti);
            adtr.Fill(dataset, "ogretmen");
            dataGridView1.DataSource = dataset.Tables["ogretmen"];
            baglanti.Close();
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            chartControl1.Visible = false;
            dataGridView1.Visible = true;
            DataSet dataset = new DataSet();
            SqlDataAdapter adtr = new SqlDataAdapter("Select name AS Ad,surname AS Soyad from tblOgrenci", baglanti);
            adtr.Fill(dataset, "ogrenci");
            dataGridView1.DataSource = dataset.Tables["ogrenci"];
            baglanti.Close();
        }

        private void btnGenelBasari_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            chart.Animate();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from tblSinav", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count <= 0)
            {
                XtraMessageBox.Show("Sistemde Sınav Bulunmamaktadır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sinav1Tarih = dt.Rows[veri][2].ToString();
                sinav1DogruSayisi = dt.Rows[veri][3].ToString();
                sinav1YanlisSayisi = dt.Rows[veri][4].ToString();
                sinav1BosSayisi = dt.Rows[veri][5].ToString();
                chartControl1.Series["Doğru"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(sinav1Tarih, sinav1DogruSayisi));
                chartControl1.Series["Yanlış"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(sinav1Tarih, sinav1YanlisSayisi));
                chartControl1.Series["Boş"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(sinav1Tarih, sinav1BosSayisi));
                chartControl1.Visible = true;
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
                chartControl1.Series["Doğru"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(sinav2Tarih, sinav2DogruSayisi));
                chartControl1.Series["Yanlış"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(sinav2Tarih, sinav2YanlisSayisi));
                chartControl1.Series["Boş"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(sinav2Tarih, sinav2BosSayisi));
                chartControl1.Visible = true;
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
                chartControl1.Series["Doğru"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(sinav3Tarih, sinav3DogruSayisi));
                chartControl1.Series["Yanlış"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(sinav3Tarih, sinav3YanlisSayisi));
                chartControl1.Series["Boş"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(sinav3Tarih, sinav3BosSayisi));
                chartControl1.Visible = true;
            }
            baglanti.Close();
            veri = 0;
        }
    }
}
