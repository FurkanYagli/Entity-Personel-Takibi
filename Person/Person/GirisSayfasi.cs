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
    public partial class GirisSayfasi : Form
    {
        public GirisSayfasi()
        {
            InitializeComponent();
        }

        DateTime tarih = DateTime.Now;
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            string Tel = maskedTextBoxTel.Text;
            string digitsOnly = new string(Tel.Where(char.IsDigit).ToArray());
            using (PersonContext context = new PersonContext())
            {
                User user = context.Users.Where(x => x.Tel == digitsOnly && x.TC == maskedTextBoxTC.Text).SingleOrDefault() as User;

                // var sorgu = from x in context.Users where x.TC == maskedTextBoxTC.Text && x.Tel == digitsOnly select x;
                if (user != null)
                {
                    int Id = user.Id;
                    Global.userId = Id;
                    User kullanici = context.Users.Find(Id);
                    Global.yetki = kullanici.YetkiId;
                    if (kullanici.Aktif == true)
                    {
                        Global.yetki = kullanici.YetkiId;
                        Random rnd = new Random();
                        string GirisKod = rnd.Next(100000, 999999).ToString();
                        Global.login = GirisKod;
                        var girisHareketleri = new EntryMobility
                        {
                            KullaniciId = Id,
                            Ad = kullanici.Ad,
                            Aktif = true,
                            Kod = GirisKod,
                            Tarih = tarih

                        };
                        context.EntryMobilities.Add(girisHareketleri);
                        context.SaveChanges();
                        KodGiris fr = new KodGiris();
                        fr.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Giriş Başarısız Hesabınız Silinmiş");
                    }
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Bilgileri Lütfen Bilgilerinizi Kontrol Ediniz");
                }
            }
        }

        private void GirisSayfasi_Load(object sender, EventArgs e)
        {
            maskedTextBoxTC.Text = "12345678901";
            maskedTextBoxTel.Text = "12345678901";
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
