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
    public partial class KodGiris : Form
    {
        public KodGiris()
        {
            InitializeComponent();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxKod.Text == Global.login)
            {

                int Id = Global.userId;
                using (PersonContext context = new PersonContext())
                {
                    User kullanici = context.Users.Find(Id);
                    AnaSayfa fr = new AnaSayfa();
                    fr.Show();
                    this.Hide();
                    var Islem = new Log()
                    {
                        KullaniciId = Id,
                        Ad = kullanici.Ad,
                        Aktif = true,
                        Tarih = DateTime.Now
                    };
                }
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız Lütfen Tekrar Deneyin veya Yeni Kod İsteyin");
            }
        }

        private void BtnYeniKod_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string GirisKodu = rnd.Next(100000, 999999).ToString();
            int Id = Global.userId;
            Global.login = GirisKodu;
            using (PersonContext context = new PersonContext())
            {
                User kullanici = context.Users.Find(Id);
                var girisHareketleri = new EntryMobility
                {
                    KullaniciId = Id,
                    Ad = kullanici.Ad,
                    Aktif = true,
                    Kod = GirisKodu,
                    Tarih = DateTime.Now

                };
                context.EntryMobilities.Add(girisHareketleri);
                context.SaveChanges();
                maskedTextBoxKod.Text = Global.login;

            }

        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void KodGiris_Load(object sender, EventArgs e)
        {
            maskedTextBoxKod.Text = Global.login;
        }
    }
}
