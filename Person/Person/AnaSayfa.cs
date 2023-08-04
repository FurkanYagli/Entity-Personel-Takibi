using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Person
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void BtnPersoneller_Click(object sender, EventArgs e)
        {
            Personeller fr = new Personeller();
            fr.Show();
            this.Hide();
        }

        private void BtnKullanicilar_Click(object sender, EventArgs e)
        {
            Kullanicilar fr = new Kullanicilar();
            fr.Show();
            this.Hide();
        }

        private void BtnSistemAyarları_Click(object sender, EventArgs e)
        {
            SistemAyarları fr = new SistemAyarları();
            fr.Show();
            this.Hide();
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            if (Global.yetki == 1)
            {
                BtnKullanicilar.Enabled = false;
                BtnSistemAyarları.Enabled = false;
            }
        }
    }
}
