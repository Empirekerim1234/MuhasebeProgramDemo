
using DemoMuhasebeProgram.Classes;
using DemoMuhasebeProgram.UserControls;
using DocumentFormat.OpenXml.Vml.Spreadsheet;
using static DemoMuhasebeProgram.Classes.Fatura;

namespace DemoMuhasebeProgram
{
    public partial class Form1 : Form
    {
        public Form1 form1
        {
            get { return this; }
        }
        enum SekmeTur
        {
            Bos, PersonelIslemleri, CariKartlari, HammaddeKartlari, FaturaIsleme, Faturalar, SatisKartlari, ReceteTanimla, ReceteListele
        }
        private TabPage? yeniSekme;
        public CariList cariList = new CariList();
        public HammaddeList hammaddeList = new HammaddeList();
        public FaturaListe faturaList = new FaturaListe();
        public Kullanicilar kullanicilar = new Kullanicilar();
        public Kullanici kullanici = new Kullanici();
        public KullanıcıGiris girisForm;
        public SatisUrunListe satisUrunListe = new SatisUrunListe();
        public ReceteList receteList = new ReceteList();
        public Form1(Kullanici girisYapanKullanici, KullanıcıGiris girisForm)
        {
            InitializeComponent();
            kullanici = girisYapanKullanici;
            this.girisForm = girisForm;
            label1.Text = "Kullanıcı Adı: " + girisYapanKullanici.ad;
        }
        private UserControl SekmeNesnesiOlustur(SekmeTur sekmeTur)
        {
            UserControl userControl = new UserControl();
            switch (sekmeTur)
            {
                case SekmeTur.PersonelIslemleri:
                    Personel_Islemleri personelForm = new Personel_Islemleri();
                    userControl = personelForm;
                    break;
                case SekmeTur.CariKartlari:
                    Cari_Kartlari cariKartlari = new Cari_Kartlari(cariList, faturaList);
                    userControl = cariKartlari;
                    break;
                case SekmeTur.HammaddeKartlari:
                    HammaddeKartlari hammaddeKartlari = new HammaddeKartlari(hammaddeList, this);
                    userControl = hammaddeKartlari;
                    break;
                case SekmeTur.FaturaIsleme:
                    FaturaIsleme faturaIsleme = new FaturaIsleme(cariList, hammaddeList, this, faturaList);
                    userControl = faturaIsleme;
                    break;
                case SekmeTur.Faturalar:
                    FaturaRapor faturalar = new FaturaRapor(faturaList, cariList);
                    userControl = faturalar;
                    break;
                case SekmeTur.SatisKartlari:
                    SatisKartlari satisKartlari = new SatisKartlari(satisUrunListe);
                    userControl = satisKartlari;
                    break;
                case SekmeTur.ReceteTanimla:
                    ReceteTanimla receteTanimla = new ReceteTanimla(satisUrunListe, receteList);
                    userControl = receteTanimla;
                    break;
                case SekmeTur.ReceteListele:
                    ReceteListele receteListele = new ReceteListele(receteList, hammaddeList);
                    userControl = receteListele;
                    break;
            }
            return userControl;
        }
        private void SekmeAc(Button button, SekmeTur sekmeTur)
        {
            string buttonText;
            buttonText = button.Text;
            int index = -1;
            bool sekmeZatenVarMi = false;

            for (int i = 0; i < tabControl1.TabPages.Count; i++)
            {
                if (tabControl1.TabPages[i].Text == buttonText)
                {
                    sekmeZatenVarMi = true;
                    index = i;
                    break;
                }
            }
            if (!sekmeZatenVarMi)
            {
                TabPage yeniSekme = new TabPage(buttonText);

                // Formu TabPage içerisinde çalıştır

                UserControl userControl = SekmeNesnesiOlustur(sekmeTur);
                userControl.Dock = DockStyle.Fill;

                // Formu sekmeye ekle
                yeniSekme.Controls.Add(userControl);

                tabControl1.TabPages.Add(yeniSekme);
                tabControl1.SelectedTab = yeniSekme;

                // Formu göster
                userControl.Show();
            }
            else
            {
                tabControl1.SelectedIndex = index;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SekmeAc(button1, SekmeTur.PersonelIslemleri);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SekmeAc(button2, SekmeTur.CariKartlari);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            girisForm.Close();
        }
        private void FaturaIsleme_Click(object sender, EventArgs e)
        {
            SekmeAc(btnFaturaIsleme, SekmeTur.FaturaIsleme);
        }
        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
        }
        private void btnHammaddeKart_Click(object sender, EventArgs e)
        {
            SekmeAc(btnHammaddeKart, SekmeTur.HammaddeKartlari);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (panel5.Visible == false)
                panel5.Visible = true;
            else if (panel5.Visible == true)
                panel5.Visible = false;
        }
        private void btnYenile_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex != -1)
            {
                Button button = new Button();
                SekmeTur sekmeTur = SekmeTur.Bos;
                TabPage eskiSekme = tabControl1.SelectedTab;
                if (eskiSekme.Controls[0] is Personel_Islemleri)
                {
                    sekmeTur = SekmeTur.PersonelIslemleri;
                    button = button1;
                }
                else if (eskiSekme.Controls[0] is Cari_Kartlari)
                {
                    sekmeTur = SekmeTur.CariKartlari;
                    button = button2;
                }
                else if (eskiSekme.Controls[0] is HammaddeKartlari)
                {
                    sekmeTur = SekmeTur.HammaddeKartlari;
                    button = btnHammaddeKart;
                }
                else if (eskiSekme.Controls[0] is FaturaIsleme)
                {
                    sekmeTur = SekmeTur.FaturaIsleme;
                    button = btnFaturaIsleme;
                }
                else if (eskiSekme.Controls[0] is FaturaRapor)
                {
                    sekmeTur = SekmeTur.Faturalar;
                    button = button7;
                }
                else if (eskiSekme.Controls[0] is SatisKartlari)
                {
                    sekmeTur = SekmeTur.SatisKartlari;
                    button = btnSatisKartlari;
                }
                else if (eskiSekme.Controls[0] is ReceteTanimla)
                {
                    sekmeTur = SekmeTur.ReceteTanimla;
                    button = btnReceteTanimla;
                }
                else if (eskiSekme.Controls[0] is ReceteListele)
                {
                    sekmeTur = SekmeTur.ReceteListele;
                    button = btnReceteListele;
                }
                tabControl1.SelectedTab.Dispose();
                SekmeAc(button, sekmeTur);
            }
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex != -1)
                tabControl1.SelectedTab.Dispose();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (panel7.Visible == false)
                panel7.Visible = true;
            else if (panel7.Visible == true)
                panel7.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (panel8.Visible == false)
                panel8.Visible = true;
            else if (panel8.Visible == true)
                panel8.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (panel9.Visible == false)
                panel9.Visible = true;
            else if (panel9.Visible == true)
                panel9.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SekmeAc(button7, SekmeTur.Faturalar);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == false)
                panel2.Visible = true;
            else if (panel2.Visible == true)
                panel2.Visible = false;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            girisForm.Show();
            girisForm.Enabled = true;
            girisForm.Focus();
            this.Enabled = false;
            this.Hide();
        }

        private void btnSatisKartlari_Click(object sender, EventArgs e)
        {
            SekmeAc(btnSatisKartlari, SekmeTur.SatisKartlari);
        }

        private void btnReceteTanimla_Click(object sender, EventArgs e)
        {
            SekmeAc(btnReceteTanimla, SekmeTur.ReceteTanimla);
        }
        private void btnReceteListele_Click(object sender, EventArgs e)
        {
            SekmeAc(btnReceteListele, SekmeTur.ReceteListele);
        }
    }
}
