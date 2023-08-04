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
    public partial class Personeller : Form
    {
        public Personeller()
        {
            InitializeComponent();
        }
        PersonContext db = new PersonContext();
        void ComboBoxDuzenle()
        {
            var meslekler = (from m in db.Jobs
                             select new
                             {
                                 m.Id,
                                 m.Ad
                             }
                                 ).ToList();
            comboBoxMeslek.ValueMember = "Id";
            comboBoxMeslek.DisplayMember = "Ad";
            comboBoxMeslek.DataSource = meslekler;
            var sehirler = (from s in db.Cities
                            select new
                            {
                                s.Id,
                                s.Ad
                            }
                                 ).ToList();
            comboBoxSehir.ValueMember = "Id";
            comboBoxSehir.DisplayMember = "Ad";
            comboBoxSehir.DataSource = sehirler;
            comboBoxMeslek.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSehir.DropDownStyle = ComboBoxStyle.DropDownList;


        }
        void KolonDuzenle()
        {


            using (var context = new PersonContext())
            {
                dataGridView1.DataSource = context.Persons.ToList();
            }
            dataGridView1.Columns["Id"].DisplayIndex = 0;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Ad"].DisplayIndex = 1;
            dataGridView1.Columns["Soyad"].DisplayIndex = 2;
            dataGridView1.Columns["SehirId"].DisplayIndex = 3;
            dataGridView1.Columns["SehirId"].HeaderText = "Şehir";
            dataGridView1.Columns["MeslekId"].DisplayIndex = 4;
            dataGridView1.Columns["MeslekId"].HeaderText = "Meslek";
            dataGridView1.Columns["Maas"].DisplayIndex = 5;
            dataGridView1.Columns["Maas"].HeaderText = "Maaş";
            dataGridView1.Columns["Aktif"].DisplayIndex = 6;
            dataGridView1.ReadOnly = true;
            if (Global.yetki == 1)
            {
                dataGridView1.Columns["Aktif"].Visible = false;
                BtnAktifEt.Enabled = false;
            }
        }
        private void Personeller_Load(object sender, EventArgs e)
        {
            KolonDuzenle();
            ComboBoxDuzenle();
            comboBoxSehir.SelectedIndex = -1;
            comboBoxSehir.Text = "Seçiniz...";
            comboBoxMeslek.SelectedIndex = -1;
            comboBoxMeslek.Text = "Seçiniz...";

        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int PersonelId;
        int IdSehir;
        int IdMeslek;
        bool Aktif;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            PersonelId = int.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
            TxtAd.Text = dataGridView1.CurrentRow.Cells["Ad"].Value.ToString();
            TxtSoyad.Text = dataGridView1.CurrentRow.Cells["Soyad"].Value.ToString();
            IdSehir = int.Parse(dataGridView1.CurrentRow.Cells["SehirId"].Value.ToString());
            IdMeslek = int.Parse(dataGridView1.CurrentRow.Cells["MeslekId"].Value.ToString());
            TxtMaas.Text = dataGridView1.CurrentRow.Cells["Maas"].Value.ToString();
            Aktif = Convert.ToBoolean(dataGridView1.CurrentRow.Cells["Aktif"].Value.ToString());
            Job meslek = db.Jobs.Find(IdMeslek);
            comboBoxMeslek.Text = meslek.Ad;
            City sehir = db.Cities.Find(IdSehir);
            comboBoxSehir.Text = sehir.Ad;
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                using (PersonContext context = new PersonContext())
                {
                    var sorgu = from x in context.Persons where x.Ad == TxtAd.Text && x.Soyad == TxtSoyad.Text select x;
                    if (sorgu.Any())
                    {
                        DialogResult dialog = MessageBox.Show("Bu Personel Zaten Mevcut Yeniden Eklemek İstediğinize Emin Misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dialog == DialogResult.Yes)
                        {
                            var per = new Persons
                            {
                                Ad = TxtAd.Text,
                                Soyad = TxtSoyad.Text,
                                SehirId = Int32.Parse(comboBoxSehir.SelectedValue.ToString()),
                                MeslekId = (int)comboBoxMeslek.SelectedValue,
                                Maas = int.Parse(TxtMaas.Text),
                                Aktif = true
                            };
                            db.Persons.Add(per);
                            db.SaveChanges();
                            KolonDuzenle();
                            MessageBox.Show("Başarıyla Eklendi");
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        var per = new Persons
                        {
                            Ad = TxtAd.Text,
                            Soyad = TxtSoyad.Text,
                            SehirId = Int32.Parse(comboBoxSehir.SelectedValue.ToString()),
                            MeslekId = (int)comboBoxMeslek.SelectedValue,
                            Maas = int.Parse(TxtMaas.Text),
                            Aktif = true
                        };
                        db.Persons.Add(per);
                        db.SaveChanges();
                        KolonDuzenle();
                        MessageBox.Show("Başarıyla Eklendi");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bir Hata Oluştu");
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                using (PersonContext context = new PersonContext())
                {
                    var sorgu = from x in context.Persons where x.Id != PersonelId && x.Ad == TxtAd.Text && x.Soyad == TxtSoyad.Text select x;
                    if (sorgu.Any())
                    {
                        DialogResult dialog = MessageBox.Show("Bu Personel Zaten Mevcut Yeniden Eklemek İstediğinize Emin Misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dialog == DialogResult.Yes)
                        {
                            Persons per = db.Persons.Find(PersonelId);
                            per.Ad = TxtAd.Text;
                            per.Soyad = TxtSoyad.Text;
                            per.SehirId = Int32.Parse(comboBoxSehir.SelectedValue.ToString());
                            per.MeslekId = (int)comboBoxMeslek.SelectedValue;
                            per.Maas = int.Parse(TxtMaas.Text);
                            per.Aktif = Aktif;
                            db.SaveChanges();
                            dataGridView1.Update();
                            KolonDuzenle();
                            db.SaveChanges();
                            MessageBox.Show("Başarıyla Güncellendi");
                        }
                        else //dialog
                        {

                        }
                    }
                    else //sorgu
                    {
                        Persons per = db.Persons.Find(PersonelId);
                        per.Ad = TxtAd.Text;
                        per.Soyad = TxtSoyad.Text;
                        per.SehirId = Int32.Parse(comboBoxSehir.SelectedValue.ToString());
                        per.MeslekId = (int)comboBoxMeslek.SelectedValue;
                        per.Maas = int.Parse(TxtMaas.Text);
                        per.Aktif = Aktif;
                        db.SaveChanges();
                        dataGridView1.Update();
                        KolonDuzenle();
                        db.SaveChanges();
                        MessageBox.Show("Başarıyla Güncellendi");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bir Hata Oluştu");
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                Persons per = db.Persons.Find(PersonelId);
                per.Aktif = false;
                KolonDuzenle();
                db.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Bir Hata Oluştu");
            }

        }

        private void BtnAnaSayfa_Click(object sender, EventArgs e)
        {
            AnaSayfa fr = new AnaSayfa();
            fr.Show();
            this.Hide();
        }

        private void BtnAktifEt_Click(object sender, EventArgs e)
        {
            try
            {
                Persons per = db.Persons.Find(PersonelId);
                per.Aktif = true;
                KolonDuzenle();
                db.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Bir Hata Oluştu");
            }

        }
    }
}

