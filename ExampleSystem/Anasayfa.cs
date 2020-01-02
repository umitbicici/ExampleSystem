using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleSystem
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOgretmen_Click(object sender, EventArgs e)
        {
            ogretmenGiris ogretmen = new ogretmenGiris();
            this.Hide();
            ogretmen.Show();
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            ogrenciGiris ogrenci = new ogrenciGiris();
            this.Hide();
            ogrenci.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {

            adminGiris admin = new adminGiris();
            this.Hide();
            admin.Show();
        }
    }
}
