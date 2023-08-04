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
    public partial class Kullanicilar : Form
    {
        public Kullanicilar()
        {
            InitializeComponent();
        }
        int Id;
        int Yetki;
        bool Aktif;
        void KolonDuzenle()
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns["Id"].DisplayIndex = 0;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Ad"].DisplayIndex = 1;
            dataGridView1.Columns["Soyad"].DisplayIndex = 2;
            dataGridView1.Columns["TC"].DisplayIndex = 3;
            dataGridView1.Columns["Tel"].DisplayIndex = 4;
            dataGridView1.Columns["YetkiId"].DisplayIndex = 5;
            dataGridView1.Columns["Aktif"].DisplayIndex = 6;
            if (Global.yetki == 2)
            {
                BtnAktifEt.Enabled = false;
                radioButtonSuperAdmin.Enabled = false;
            }
            else if (Global.yetki == 3)
            {

            }
            else
            {
                MessageBox.Show("Hatalı Yetki Düzeyi");
                Application.Exit();
            }
            {

            }
        }
        private void BtnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAnaSayfa_Click(object sender, EventArgs e)
        {
            AnaSayfa fr = new AnaSayfa();
            fr.Show();
            this.Hide();
        }
        PersonContext db = new PersonContext();
        private void Kullanicilar_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = db.Users.ToList();
            KolonDuzenle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = int.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
            TxtAd.Text = dataGridView1.CurrentRow.Cells["Ad"].Value.ToString();
            TxtSoyad.Text = dataGridView1.CurrentRow.Cells["Soyad"].Value.ToString();
            maskedTextBoxTc.Text = dataGridView1.CurrentRow.Cells["TC"].Value.ToString();
            maskedTextBoxTel.Text = dataGridView1.CurrentRow.Cells["Tel"].Value.ToString();
            Aktif = Convert.ToBoolean(dataGridView1.CurrentRow.Cells["Aktif"].Value.ToString());
            Yetki = int.Parse(dataGridView1.CurrentRow.Cells["YetkiId"].Value.ToString());
            if (Yetki == 1)
            {
                radioButtonYetkisiz.Checked = true;
            }
            else if (Yetki == 2)
            {
                radioButtonAdmin.Checked = true;
            }
            else if (Yetki == 3)
            {
                radioButtonSuperAdmin.Checked = true;
            }
            else
            {
                radioButtonYetkisiz.Checked = true;
            }
            {

            }
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {

                string Tel = maskedTextBoxTel.Text;
                string digitsOnly = new string(Tel.Where(char.IsDigit).ToArray());
                using (PersonContext context = new PersonContext())
                {
                    if (Yetki == 1 || Yetki == 2 || Yetki == 3)
                    {
                        maskedTextBoxTel.Text.Trim();
                        maskedTextBoxTc.Text.Trim();
                        TxtAd.Text.Trim();
                        TxtSoyad.Text.Trim();
                        int uzunlukTC = maskedTextBoxTc.Text.Length;
                        int uzunlukTel = digitsOnly.Length;
                        int uzunlukAd = TxtAd.Text.Length;
                        int uzunlukSoyad = TxtSoyad.Text.Length;
                        if (uzunlukAd > 1 && uzunlukSoyad > 1 && uzunlukTC == 11 && uzunlukTel == 11)
                        {
                            var sorguTel = from x in context.Users
                                           where x.Tel == digitsOnly
                                           select x;

                            var sorgu = from x in context.Users
                                        where x.TC == maskedTextBoxTc.Text
                                        select x;
                            if (sorgu.Any() || sorguTel.Any())
                            {
                                if (sorgu.Any())
                                {
                                    MessageBox.Show("Bu Kullanıcı Zaten Mevcut", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else if (sorguTel.Any())
                                {
                                    MessageBox.Show("Bu Telefon Numarası Başka Bir Kullanıcı Tarafından Kullanılıyor", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else //sorgu || sorguTel
                            {
                                var kullanici = new User
                                {
                                    Ad = TxtAd.Text,
                                    Soyad = TxtSoyad.Text,
                                    TC = maskedTextBoxTc.Text,
                                    Tel = digitsOnly,
                                    YetkiId = Yetki,
                                    Aktif = true
                                };
                                db.Users.Add(kullanici);
                                dataGridView1.Update();
                                KolonDuzenle();
                                db.SaveChanges();
                                KolonDuzenle();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Bilgiler Boş Bırakılamaz");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Yetki Türünü Seçiniz");
                    }
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Yetki = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Yetki = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Yetki = 3;
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            maskedTextBoxTel.Text.Trim();
            maskedTextBoxTc.Text.Trim();
            TxtAd.Text.Trim();
            TxtSoyad.Text.Trim();
            string Tel = maskedTextBoxTel.Text;
            string digitsOnly = new string(Tel.Where(char.IsDigit).ToArray());
            int uzunlukTC = maskedTextBoxTc.Text.Length;
            int uzunlukTel = digitsOnly.Length;
            int uzunlukAd = TxtAd.Text.Length;
            int uzunlukSoyad = TxtSoyad.Text.Length;
            if (uzunlukAd > 1 && uzunlukSoyad > 1 && uzunlukTC == 11 && uzunlukTel == 11)
            {
                int YetkiTuru = int.Parse(dataGridView1.CurrentRow.Cells["YetkiId"].Value.ToString());
                try
                {

                    using (PersonContext context = new PersonContext())
                    {
                        var sorguTel = from x in context.Users
                                       where x.Id != Id && x.Tel == digitsOnly
                                       select x;

                        var sorgu = from x in context.Users
                                    where x.Id != Id && x.TC == maskedTextBoxTc.Text
                                    select x;
                        if (sorgu.Any() || sorguTel.Any())
                        {
                            if (sorgu.Any())
                            {
                                MessageBox.Show("Bu Kullanıcı Zaten Mevcut", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else if (sorguTel.Any())
                            {
                                MessageBox.Show("Bu Telefon Numarası Başka Bir Kullanıcı Tarafından Kullanılıyor", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else// sorgu || sorguTel
                        {
                            if (Global.yetki == 3)
                            {
                                if (YetkiTuru == 3)
                                {
                                    if (Id < Global.userId)
                                    {
                                        User kullanici = db.Users.Find(Id);
                                        kullanici.Ad = TxtAd.Text;
                                        kullanici.Soyad = TxtSoyad.Text;
                                        kullanici.TC = maskedTextBoxTc.Text;
                                        kullanici.Tel = digitsOnly;
                                        kullanici.Aktif = Aktif;
                                        kullanici.YetkiId = Yetki;
                                        dataGridView1.Update();
                                        db.SaveChanges();
                                        KolonDuzenle();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Bu Kullanıcının Bilgilerini Değiştiremezsiniz");
                                    }
                                }
                                else if (YetkiTuru == 2 || YetkiTuru == 1)
                                {
                                    Yetki = 2;
                                    User kullanici = db.Users.Find(Id);
                                    kullanici.Ad = TxtAd.Text;
                                    kullanici.Soyad = TxtSoyad.Text;
                                    kullanici.TC = maskedTextBoxTc.Text;
                                    kullanici.Tel = digitsOnly;
                                    kullanici.Aktif = Aktif;
                                    kullanici.YetkiId = Yetki;
                                    dataGridView1.Update();
                                    db.SaveChanges();
                                    KolonDuzenle();
                                }
                                else
                                {
                                    MessageBox.Show("Bir Hata Oluştu");
                                    KolonDuzenle();
                                }
                            }
                            else if (Global.yetki == 2)
                            {
                                if (YetkiTuru == 3)
                                {
                                    MessageBox.Show("Bu Kullanıcının Bilgilerini Güncelleyemezsiniz");
                                }
                                else if (YetkiTuru == 2)
                                {
                                    if (YetkiTuru == 2 && Yetki == 1)
                                    {
                                        MessageBox.Show("Yetki Türünüz Bu Kullanıcının Yetkisini Düşürmeye Yetmiyor");
                                    }
                                    else if (YetkiTuru == 2 && Yetki == 3)
                                    {
                                        MessageBox.Show("Yetki Türünüz Bu Kullanıcının Yetkisini Yükseltmeye Yetmiyor");
                                    }
                                    else if (YetkiTuru == 2 && Yetki == 2)
                                    {
                                        User kullanici = db.Users.Find(Id);
                                        kullanici.Ad = TxtAd.Text;
                                        kullanici.Soyad = TxtSoyad.Text;
                                        kullanici.TC = maskedTextBoxTc.Text;
                                        kullanici.Tel = digitsOnly;
                                        kullanici.Aktif = Aktif;
                                        kullanici.YetkiId = Yetki;
                                        dataGridView1.Update();
                                        db.SaveChanges();
                                        KolonDuzenle();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Bir Hata Oluştu Lütfen Güncelleyeceğiniz Kişinin Yetki Türünü Kontrol Ediniz");
                                    }


                                }
                                else if (YetkiTuru == 1)
                                {
                                    User kullanici = db.Users.Find(Id);
                                    kullanici.Ad = TxtAd.Text;
                                    kullanici.Soyad = TxtSoyad.Text;
                                    kullanici.TC = maskedTextBoxTc.Text;
                                    kullanici.Tel = digitsOnly;
                                    kullanici.Aktif = Aktif;
                                    kullanici.YetkiId = Yetki;
                                    dataGridView1.Update();
                                    db.SaveChanges();
                                    KolonDuzenle();
                                }
                                else
                                {
                                    MessageBox.Show("Bir Hata Oluştu");
                                    KolonDuzenle();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Bir Hata Oluştu");
                                KolonDuzenle();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Bilgileri Tekrar Kontrol Ediniz");
            }
            

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int YetkiTuru = int.Parse(dataGridView1.CurrentRow.Cells["YetkiId"].Value.ToString());
            if (Global.userId == Id)
            {
                MessageBox.Show("Kendinizi Silemezsiniz");
            }
            else
            {


                if (Global.yetki == 3)
                {
                    if (YetkiTuru == 3)
                    {
                        if (Id < Global.userId)
                        {
                            User kullanici = db.Users.Find(Id);
                            kullanici.Aktif = false;
                            dataGridView1.Update();
                            dataGridView1.Update();
                            db.SaveChanges();
                            KolonDuzenle();
                        }
                        else
                        {
                            MessageBox.Show("Bu Kullanıcıyı Silemezsiniz");
                        }
                    }
                    else if (YetkiTuru == 2 || YetkiTuru == 1)
                    {
                        User kullanici = db.Users.Find(Id);
                        kullanici.Aktif = false;
                        dataGridView1.Update();
                        dataGridView1.Update();
                        db.SaveChanges();
                        KolonDuzenle();
                    }
                    else
                    {
                        MessageBox.Show("Bir Hata Oluştu");
                        KolonDuzenle();
                    }
                }
                else if (Global.yetki == 2)
                {
                    if (YetkiTuru == 3)
                    {
                        MessageBox.Show("Bu Kullanıcıyı Silemezsiniz");
                    }
                    else if (YetkiTuru == 2)
                    {

                        User kullanici = db.Users.Find(Id);
                        kullanici.Aktif = false;
                        dataGridView1.Update();
                        dataGridView1.Update();
                        db.SaveChanges();
                        KolonDuzenle();
                    }
                    else if (YetkiTuru == 1)
                    {
                        User kullanici = db.Users.Find(Id);
                        kullanici.Aktif = false;
                        dataGridView1.Update();
                        dataGridView1.Update();
                        db.SaveChanges();
                        KolonDuzenle();
                    }
                    else
                    {
                        MessageBox.Show("Bir Hata Oluştu");
                        KolonDuzenle();
                    }
                }
                else
                {
                    MessageBox.Show("Bir Hata Oluştu");
                    KolonDuzenle();
                }
            }

        }

        private void BtnAktifEt_Click(object sender, EventArgs e)
        {
            User kullanici = db.Users.Find(Id);
            kullanici.Aktif = true;
            dataGridView1.Update();
            db.SaveChanges();
            KolonDuzenle();
        }
    }
}