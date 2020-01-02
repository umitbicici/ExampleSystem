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
using DevExpress.XtraEditors;

namespace ExampleSystem
{
    public partial class ogretmenIslem : Form
    {
        public ogretmenIslem()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=FERVOR;Initial Catalog=db.exampleSystem;Integrated Security=True");
        private void sorular()
        {
            DataSet dataset = new DataSet();
            SqlDataAdapter adtr = new SqlDataAdapter("Select * from tblSoru",baglanti);
            adtr.Fill(dataset, "soru");
            dataGridView1.DataSource = dataset.Tables["soru"];
            baglanti.Close();
        }
        private void frmOgretmen_Load(object sender, EventArgs e)
        {
            sorular();
        }
        private void btnYenile_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            ((DataTable)dataGridView1.DataSource).Rows.Clear();
            sorular();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            richEditMetin.Visible = false;
            pictureBox1.Visible = true;
            if (richEditMetin.Text=="" || txtA.Text=="" || txtB.Text == "" || txtC.Text == "" || txtD.Text == "" || comboBoxKategori.SelectedIndex=='0' ||comboBoxCevap.SelectedIndex=='0')
            {
                XtraMessageBox.Show("Lütfen Alanları Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Insert into tblSoru(Metin,secenekA,secenekB,secenekC,secenekD,dogruCevap,Kategori,Resim) values (@Metin,@secenekA,@secenekB,@secenekC,@secenekD,@dogruCevap,@Kategori,@Resim)", baglanti);
                komut.Parameters.Add("@Metin", richEditMetin.Text);
                komut.Parameters.Add("@secenekA", txtA.Text);
                komut.Parameters.Add("@secenekB", txtB.Text);
                komut.Parameters.Add("@secenekC", txtC.Text);
                komut.Parameters.Add("@secenekD", txtD.Text);
                komut.Parameters.Add("@dogruCevap", comboBoxCevap.SelectedItem);
                komut.Parameters.Add("@Kategori", comboBoxKategori.SelectedItem);
                komut.Parameters.Add("@Resim", txtResim.Text);
                komut.ExecuteNonQuery();
                XtraMessageBox.Show("Soru Eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                richEditMetin.Text = "";
                txtA.Text = "";
                txtB.Text = "";
                txtC.Text = "";
                txtD.Text = "";
                comboBoxCevap.SelectedIndex = '0';
                comboBoxKategori.SelectedIndex = '0';
                ((DataTable)dataGridView1.DataSource).Rows.Clear();
                sorular();
                baglanti.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete from tblSoru where ID='" + dataGridView1.SelectedRows[i].Cells["ID"].Value.ToString() + "'", baglanti);
                komut.ExecuteNonQuery();
                XtraMessageBox.Show("Soru Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ((DataTable)dataGridView1.DataSource).Rows.Clear();
                sorular();
                baglanti.Close();
            }
        }
        private void btnSecenekEkle_Click(object sender, EventArgs e)
        {
            comboBoxCevap.Properties.Items.Clear();
            if (txtA.Text == "" || txtB.Text == "" || txtC.Text == "" || txtD.Text == "")
            {
                XtraMessageBox.Show("Lütfen Alanları Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                comboBoxCevap.Properties.Items.Add(txtA.Text);
                comboBoxCevap.Properties.Items.Add(txtB.Text);
                comboBoxCevap.Properties.Items.Add(txtC.Text);
                comboBoxCevap.Properties.Items.Add(txtD.Text);
                XtraMessageBox.Show("Seçenekler Eklendi. Lütfen Doğru Cevabı Seçiniz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void txtAra_Click(object sender, EventArgs e)
        {
            txtAra.Text = "";
        }

        private void txtAra_EditValueChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from tblSoru where Kategori like '%" + txtAra.Text + "%'", baglanti);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(komut);
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            dataGridView1.DataSource = dataset.Tables[0];
            baglanti.Close();
        }

        private void btnResim_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            xtraOpenFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = xtraOpenFileDialog1.FileName;
            txtResim.Text = xtraOpenFileDialog1.FileName;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            pictureBox1.ImageLocation = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {
            richEditMetin.Visible = true;
        }
    }
}
