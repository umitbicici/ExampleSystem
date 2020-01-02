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
    public partial class ogretmenGiris : Form
    {
        public ogretmenGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=FERVOR;Initial Catalog=db.exampleSystem;Integrated Security=True");

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "Select * from tblOgretmen where username=@username AND password=@password";
                SqlParameter prm1 = new SqlParameter("username", txtUsername.Text.Trim());
                SqlParameter prm2 = new SqlParameter("password", txtPassword.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    XtraMessageBox.Show("Giriş Yapıldı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ogretmenIslem frmOgretmen = new ogretmenIslem();
                    frmOgretmen.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {

                XtraMessageBox.Show("Kullanıcı Adı veya Şifre Uyuşmuyor!","Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void windowsUIButtonPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}
