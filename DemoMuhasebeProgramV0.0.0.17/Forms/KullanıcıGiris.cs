using DemoMuhasebeProgram.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DemoMuhasebeProgram
{
    public partial class KullanıcıGiris : Form
    {
        private Kullanicilar kullaniciList;
        private Kullanici girisYapanKullanici;
        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MAXIMIZE = 0xF030; // Tam ekran yapma komutu
            const int SC_MINIMIZE = 0xF020; // Simge durumuna küçültme komutu
            const int WM_NCLBUTTONDBLCLK = 0x00A3; // Başlık çubuğuna çift tıklama

            // Başlık çubuğuna çift tıklamayı engelle
            if (m.Msg == WM_NCLBUTTONDBLCLK)
            {
                return;
            }

            // Sistem menüsünden veya butonlardan gelen büyütme/küçültme komutlarını engelle
            if (m.Msg == WM_SYSCOMMAND)
            {
                int command = m.WParam.ToInt32() & 0xFFF0;
                if (command == SC_MAXIMIZE || command == SC_MINIMIZE)
                {
                    return;
                }
            }

            base.WndProc(ref m);
        }
        public KullanıcıGiris()
        {
            InitializeComponent();
            this.CenterToScreen();
            panel2.Location = new Point((this.ClientSize.Width - panel2.Width) / 2,
                            (this.ClientSize.Height - panel2.Height) / 2);
            panel2.Size = new Size(this.Size.Width / 5, this.Size.Height / 5);
            this.MaximizeBox = false; // Büyütme butonunu pasif yapar ve çift tıklamayı önler
            this.MinimizeBox = false; // Küçültme butonunu pasif yapar
            Kullanicilar kullanicilar = new Kullanicilar();
            Kullanici kullanici = new Kullanici();
            kullaniciList = kullanicilar;
            girisYapanKullanici = kullanici;
        }
        private void GirisYap()
        {
            Form1 mainForm = new Form1(girisYapanKullanici, this);
            mainForm.Show();
            mainForm.Enabled = true;
            mainForm.Focus();
            this.Enabled = false;
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = "";
            for (int i = 0; i < kullaniciList.kullanicilar.Count; i++)
            {
                if (textBox2.Text == kullaniciList.kullanicilar[i].ad)
                {
                    kullaniciAdi = textBox2.Text;
                    if (textBox1.Text == kullaniciList.kullanicilar[i].sifre)
                    {
                        girisYapanKullanici = kullaniciList.kullanicilar[i];
                        break;
                    }
                }
            }
            if (girisYapanKullanici.ad != "")
                GirisYap();
            else if (kullaniciAdi == "")
                MessageBox.Show("Kullanıcı Bulunamadı Kullanıcı Adını Yanlış Yada Yok");
            else if (kullaniciAdi != "")
                MessageBox.Show("Kullanici Adi Ve Şifre Uyuşmadı Lütfen Tekrar Deniyiniz");
            else
                MessageBox.Show("sistem hatası tekrar deneyin");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool kullaniciEklemeYap = true;
            if (textBox2.Text == "")
            { MessageBox.Show("Kullanıcı Bos Olamaz"); kullaniciEklemeYap = false; }
            else if (textBox1.Text == "")
            { MessageBox.Show("Şifre Boş Olamaz"); kullaniciEklemeYap = false; }
            for (int i = 0; i < kullaniciList.kullanicilar.Count; i++)
            {
                if (kullaniciList.kullanicilar[i].ad == textBox2.Text)
                { MessageBox.Show("Bu Kullanıcı Adı Zaten Mevcut"); kullaniciEklemeYap = false; }
            }
            if (kullaniciEklemeYap)
            {
                girisYapanKullanici.ad = textBox2.Text;
                girisYapanKullanici.sifre = textBox1.Text;
                kullaniciList.kullanicilarAdd(girisYapanKullanici);
            }
        }
        private void Kapat()
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kapat();
        }

        private void KullanıcıGiris_SizeChanged(object sender, EventArgs e)
        {
            panel2.Location = new Point((this.ClientSize.Width - panel2.Width) / 2,
                            (this.ClientSize.Height - panel2.Height) / 2);
            panel2.Size = new Size(this.Size.Width / 5, this.Size.Height / 5);
        }
    }
}
