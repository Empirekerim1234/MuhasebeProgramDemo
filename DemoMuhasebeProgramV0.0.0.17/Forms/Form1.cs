
using DemoMuhasebeProgram.Classes;
using DemoMuhasebeProgram.UserControls;
using DocumentFormat.OpenXml.Vml.Spreadsheet;
using static DemoMuhasebeProgram.Classes.Fatura;

namespace DemoMuhasebeProgram
{
    public partial class Form1 : Form
    {
        public Form1 form1 { get { return this; } }
        enum SekmeTur
        {
            Bos, PersonelIslemleri, CariKartlari, HammaddeKartlari, FaturaIsleme, Faturalar, SatisKartlari, ReceteTanimla, ReceteListele, GiderKartiTanimla,
            GiderIsleme, PersonelGiderIsleme,GelirKartlariTanimla
        }
        private TabPage? yeniSekme;
        public PersonelListe personelListe = new PersonelListe();
        public CariList cariList = new CariList();
        public HammaddeList hammaddeList = new HammaddeList();
        public FaturaListe faturaList = new FaturaListe();
        public Kullanicilar kullanicilar = new Kullanicilar();
        public Kullanici kullanici = new Kullanici();
        public KullanıcıGiris girisForm;
        public SatisUrunListe satisUrunListe = new SatisUrunListe();
        public ReceteList receteList = new ReceteList();
        public GiderKatagorileriListe giderKatagoriListe = new GiderKatagorileriListe();
        public GiderKarlariListe giderKartListe = new GiderKarlariListe();
        public giderListesi giderListesi = new giderListesi();
        public PersonelGiderListesi personelGiderListesi = new PersonelGiderListesi();
        public GelirKartiKatagoriListesi gkKartlariListe = new GelirKartiKatagoriListesi();
        public GelirKartleriLiset gelKartlariListe = new GelirKartleriLiset();
        //------------------------------------------------------------------------------------------------------------------------------------------------------------
        public Form1(Kullanici girisYapanKullanici, KullanıcıGiris girisForm)
        {
            InitializeComponent();
            kullanici = girisYapanKullanici;
            this.girisForm = girisForm;
            label1.Text = "Kullanıcı Adı: " + girisYapanKullanici.ad;
        }
        private void PanelShowOrHide(Panel panel)
        {
            if (panel.Visible == false)
                panel.Visible = true;
            else if (panel.Visible == true)
                panel.Visible = false;
        }
        private UserControl SekmeNesnesiOlustur(SekmeTur sekmeTur)
        {
            UserControl uC = new UserControl();
            switch (sekmeTur)
            {
                case SekmeTur.PersonelIslemleri: Personel_Islemleri personelForm = new Personel_Islemleri(personelListe); uC = personelForm; break;
                case SekmeTur.CariKartlari: Cari_Kartlari cariKartlari = new Cari_Kartlari(cariList, faturaList); uC = cariKartlari; break;
                case SekmeTur.HammaddeKartlari: HammaddeKartlari hammaddeKartlari = new HammaddeKartlari(hammaddeList, this); uC = hammaddeKartlari; break;
                case SekmeTur.FaturaIsleme: FaturaIsleme faturaIsleme = new FaturaIsleme(cariList, hammaddeList, this, faturaList); uC = faturaIsleme; break;
                case SekmeTur.Faturalar: FaturaRapor faturalar = new FaturaRapor(faturaList, cariList); uC = faturalar; break;
                case SekmeTur.SatisKartlari: SatisKartlari satisKartlari = new SatisKartlari(satisUrunListe); uC = satisKartlari; break;
                case SekmeTur.ReceteTanimla: ReceteTanimla receteTanimla = new ReceteTanimla(satisUrunListe, receteList); uC = receteTanimla; break;
                case SekmeTur.ReceteListele: ReceteListele receteListele = new ReceteListele(receteList, hammaddeList); uC = receteListele; break;
                case SekmeTur.GiderKartiTanimla: GiderKartlariTanimla gKartiT = new GiderKartlariTanimla(giderKatagoriListe, giderKartListe); uC = gKartiT; break;
                case SekmeTur.GiderIsleme: GiderIsleme giderIsleme = new GiderIsleme(giderKartListe, giderListesi); uC = giderIsleme; break;
                case SekmeTur.PersonelGiderIsleme: PersonelGiderIsleme pGiderI = new PersonelGiderIsleme(personelListe, personelGiderListesi); uC = pGiderI; break;
                case SekmeTur.GelirKartlariTanimla: GelirKartlariTanimla gelirKartlariTanimla = new GelirKartlariTanimla(gelKartlariListe); uC = gelirKartlariTanimla;break; 
            }
            return uC;
        }
        private void SekmeAc(Button button, SekmeTur sekmeTur)
        {
            string buttonText;
            buttonText = button.Text;
            int index = -1;
            bool sekmeZatenVarMi = false;
            for (int i = 0; i < tabControl1.TabPages.Count; i++) { if (tabControl1.TabPages[i].Text == buttonText) { sekmeZatenVarMi = true; index = i; break; } }
            if (!sekmeZatenVarMi)
            {
                TabPage yeniSekme = new TabPage(buttonText);
                UserControl userControl = SekmeNesnesiOlustur(sekmeTur);
                userControl.Dock = DockStyle.Fill;
                yeniSekme.Controls.Add(userControl);
                tabControl1.TabPages.Add(yeniSekme);
                tabControl1.SelectedTab = yeniSekme;
                userControl.Show();
            }
            else tabControl1.SelectedIndex = index;
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void btnYenile_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex != -1)
            {
                Button button = new Button();
                SekmeTur sekmeTur = SekmeTur.Bos;
                TabPage eskiSekme = tabControl1.SelectedTab;
                if (eskiSekme.Controls[0] is Personel_Islemleri) { sekmeTur = SekmeTur.PersonelIslemleri; button = button1; }
                else if (eskiSekme.Controls[0] is Cari_Kartlari) { sekmeTur = SekmeTur.CariKartlari; button = button2; }
                else if (eskiSekme.Controls[0] is HammaddeKartlari) { sekmeTur = SekmeTur.HammaddeKartlari; button = btnHammaddeKart; }
                else if (eskiSekme.Controls[0] is FaturaIsleme) { sekmeTur = SekmeTur.FaturaIsleme; button = btnFaturaIsleme; }
                else if (eskiSekme.Controls[0] is FaturaRapor) { sekmeTur = SekmeTur.Faturalar; button = button7; }
                else if (eskiSekme.Controls[0] is SatisKartlari) { sekmeTur = SekmeTur.SatisKartlari; button = btnSatisKartlari; }
                else if (eskiSekme.Controls[0] is ReceteTanimla) { sekmeTur = SekmeTur.ReceteTanimla; button = btnReceteTanimla; }
                else if (eskiSekme.Controls[0] is ReceteListele) { sekmeTur = SekmeTur.ReceteListele; button = btnReceteListele; }
                else if (eskiSekme.Controls[0] is GiderKartlariTanimla) { sekmeTur = SekmeTur.GiderKartiTanimla; button = btnGiderKartlari; }
                else if (eskiSekme.Controls[0] is GiderIsleme) { sekmeTur = SekmeTur.GiderIsleme; button = btnGiderIsleme; }
                else if (eskiSekme.Controls[0] is PersonelGiderIsleme) { sekmeTur = SekmeTur.PersonelGiderIsleme; button = btnPersonelGiderIsleme; }
                else if (eskiSekme.Controls[0] is GelirKartlari) { sekmeTur = SekmeTur.GelirKartlariTanimla;button = btnGelirKartleriTanimla; }
                tabControl1.SelectedTab.Dispose();
                SekmeAc(button, sekmeTur);
            }
        }
        private void btnKapat_Click(object sender, EventArgs e) { if (tabControl1.SelectedIndex != -1) tabControl1.SelectedTab.Dispose(); }
        //-------------------------------------------------------------------------------------------------------------------------------------------------
        private void button1_Click(object sender, EventArgs e) { SekmeAc(button1, SekmeTur.PersonelIslemleri); }
        private void button2_Click(object sender, EventArgs e) { SekmeAc(button2, SekmeTur.CariKartlari); }
        private void button3_Click(object sender, EventArgs e) { girisForm.Close(); }
        private void FaturaIsleme_Click(object sender, EventArgs e) { SekmeAc(btnFaturaIsleme, SekmeTur.FaturaIsleme); }
        private void tabControl1_MouseClick(object sender, MouseEventArgs e) { }
        private void btnHammaddeKart_Click(object sender, EventArgs e) { SekmeAc(btnHammaddeKart, SekmeTur.HammaddeKartlari); }
        private void button4_Click(object sender, EventArgs e) { PanelShowOrHide(panel5); }
        private void button5_Click(object sender, EventArgs e) { PanelShowOrHide(panel7); }
        private void button6_Click(object sender, EventArgs e) { PanelShowOrHide(panel8); }
        private void button9_Click(object sender, EventArgs e) { PanelShowOrHide(panel9); }
        private void button7_Click(object sender, EventArgs e) { SekmeAc(button7, SekmeTur.Faturalar); }
        private void button10_Click(object sender, EventArgs e) { PanelShowOrHide(panel2); }
        private void button11_Click(object sender, EventArgs e) { girisForm.Show(); girisForm.Enabled = true; girisForm.Focus(); this.Enabled = false; this.Hide(); }
        private void btnSatisKartlari_Click(object sender, EventArgs e) { SekmeAc(btnSatisKartlari, SekmeTur.SatisKartlari); }
        private void btnReceteTanimla_Click(object sender, EventArgs e) { SekmeAc(btnReceteTanimla, SekmeTur.ReceteTanimla); }
        private void btnReceteListele_Click(object sender, EventArgs e) { SekmeAc(btnReceteListele, SekmeTur.ReceteListele); }
        private void btnGiderKartlari_Click(object sender, EventArgs e) { SekmeAc(btnGiderKartlari, SekmeTur.GiderKartiTanimla); }
        private void btnGiderIsleme_Click(object sender, EventArgs e) { SekmeAc(btnGiderIsleme, SekmeTur.GiderIsleme); }
        private void btnPersonelGiderIsleme_Click(object sender, EventArgs e) { SekmeAc(btnPersonelGiderIsleme, SekmeTur.PersonelGiderIsleme); }
        private void btnGelirKartleriTanimla_Click(object sender, EventArgs e) { SekmeAc(btnGelirKartleriTanimla, SekmeTur.GelirKartlariTanimla); }
    }
}
