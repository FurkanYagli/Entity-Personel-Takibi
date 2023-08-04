using Person.Context;
using Person.Entities;
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
    public partial class SistemAyarları : Form
    {
        public SistemAyarları()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        
        private void dataGridViewMeslek_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        PersonContext db = new PersonContext();
        void KolonDuzenle()
        {
            dataGridViewSehir.Columns["Id"].DisplayIndex = 0;
            dataGridViewSehir.Columns["Ad"].DisplayIndex = 1;
            dataGridViewSehir.Columns["Ad"].HeaderText = "Şehir";
            dataGridViewSehir.Columns["Aktif"].DisplayIndex = 2;
            dataGridViewMeslek.Columns["Id"].DisplayIndex = 0;
            dataGridViewMeslek.Columns["Ad"].DisplayIndex = 1;
            dataGridViewMeslek.Columns["Ad"].HeaderText = "Meslek";
            dataGridViewMeslek.Columns["Aktif"].DisplayIndex = 2;
        }
        private void SistemAyarlari_Load(object sender, EventArgs e)
        {
            dataGridViewMeslek.DataSource = db.Jobs.ToList();
            dataGridViewSehir.DataSource = db.Cities.ToList();
            KolonDuzenle();
        }

        private void BtnSehirEkle_Click(object sender, EventArgs e)
        {
            var sehir = new City
            {
                Ad = TxtSehir.Text,
                Aktif = true
            };
            db.Cities.Add(sehir);
            dataGridViewSehir.Update();
            db.SaveChanges();
            KolonDuzenle();
        }

        int Id;
        int MeslekId;
        bool Aktif;
        private void dataGridViewSehir_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = int.Parse(dataGridViewSehir.CurrentRow.Cells["Id"].Value.ToString());
            TxtSehir.Text = dataGridViewSehir.CurrentRow.Cells["Ad"].Value.ToString();
            Aktif = Convert.ToBoolean(dataGridViewSehir.CurrentRow.Cells["Aktif"].Value.ToString());
        }

        private void BtnMeslekSil_Click(object sender, EventArgs e)
        {
            Job meslek = db.Jobs.Find(Id);
            meslek.Aktif = false;
            dataGridViewMeslek.Update();
            KolonDuzenle();
            db.SaveChanges();
        }

        private void BtnMeslekEkle_Click(object sender, EventArgs e)
        {
            var meslek = new Job
            {
                Ad = TxtMeslek.Text,
                Aktif = true
            };
            db.Jobs.Add(meslek);
            dataGridViewMeslek.Update();
            db.SaveChanges();
            KolonDuzenle();
        }

        private void BtnMeslekGuncelle_Click(object sender, EventArgs e)
        {
            Job meslek = db.Jobs.Find(Id);
            meslek.Ad = TxtMeslek.Text;
            meslek.Aktif = Aktif;
            db.SaveChanges();
            dataGridViewMeslek.Update();
            KolonDuzenle();
            db.SaveChanges();
        }

        private void BtnSehirGuncelle_Click(object sender, EventArgs e)
        {
            City sehir = db.Cities.Find(Id);
            sehir.Ad = TxtSehir.Text;
            sehir.Aktif = Aktif;
            dataGridViewSehir.Update();
            KolonDuzenle();
            db.SaveChanges();
        }

        private void BtnSehirSil_Click(object sender, EventArgs e)
        {
            City sehir = db.Cities.Find(Id);
            sehir.Aktif = false;
            dataGridViewSehir.Update();
            KolonDuzenle();
            db.SaveChanges();
        }

        private void dataGridViewMeslek_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = int.Parse(dataGridViewMeslek.CurrentRow.Cells["Id"].Value.ToString());
            TxtMeslek.Text = dataGridViewMeslek.CurrentRow.Cells["Ad"].Value.ToString();
            Aktif = Convert.ToBoolean(dataGridViewMeslek.CurrentRow.Cells["Aktif"].Value.ToString());
        }

        private void BtnAnaSayfa_Click(object sender, EventArgs e)
        {
            AnaSayfa fr = new AnaSayfa();
            fr.Show();
            this.Hide();
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}