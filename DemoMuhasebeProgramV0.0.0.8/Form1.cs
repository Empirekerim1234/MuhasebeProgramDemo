
using static DemoMuhasebeProgram.Fatura;

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
            Bos, PersonelIslemleri, CariKartlari, HammaddeKartlari, FaturaIsleme,Faturalar
        }
        private TabPage? yeniSekme;
        public CariList cariList = new CariList();
        public HammaddeList hammaddeList = new HammaddeList();
        public FaturaListe faturaList = new FaturaListe();
        public Form1()
        {
            InitializeComponent();
        }
        private void SekmeAc(Button button, UserControl userControl)
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

                // Fatura İşlemleri formunu oluştur
                //HammaddeKartlari faturaForm = new HammaddeKartlari(hammaddeList, form1);

                // Formu TabPage içerisinde çalıştır

                userControl.Dock = DockStyle.Fill;

                yeniSekme.Controls.Add(userControl);

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
        private void acilaceakSekmeTuruneGoreSecim(Button buton, SekmeTur sekmeTur)
        {
            if (sekmeTur == SekmeTur.PersonelIslemleri)
            {
                Personel_Islemleri personelForm = new Personel_Islemleri();
                SekmeAc(buton, personelForm);
            }
            else if (sekmeTur == SekmeTur.CariKartlari)
            {
                Cari_Kartlari cariKartlari = new Cari_Kartlari(cariList,faturaList);
                SekmeAc(buton, cariKartlari);
            }
            else if (sekmeTur == SekmeTur.HammaddeKartlari)
            {
                HammaddeKartlari hammaddeKartlari = new HammaddeKartlari(hammaddeList, this);
                SekmeAc(buton, hammaddeKartlari);
            }
            else if (sekmeTur == SekmeTur.FaturaIsleme)
            {
                FaturaIsleme faturaIsleme = new FaturaIsleme(cariList, hammaddeList, this, faturaList);
                SekmeAc(buton, faturaIsleme);
            }
            else if (sekmeTur == SekmeTur.Faturalar)
            {
                FaturaRapor faturalar = new FaturaRapor(faturaList, cariList);
                SekmeAc(buton, faturalar);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            acilaceakSekmeTuruneGoreSecim(button1, SekmeTur.PersonelIslemleri);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            acilaceakSekmeTuruneGoreSecim(button2, SekmeTur.CariKartlari);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FaturaIsleme_Click(object sender, EventArgs e)
        {
            acilaceakSekmeTuruneGoreSecim(btnFaturaIsleme, SekmeTur.FaturaIsleme);
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnHammaddeKart_Click(object sender, EventArgs e)
        {
            acilaceakSekmeTuruneGoreSecim(btnHammaddeKart, SekmeTur.HammaddeKartlari);
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
                SekmeTur sekmeTur = SekmeTur.Bos;
                TabPage eskiSekme = tabControl1.SelectedTab;
                if (eskiSekme.Controls[0] is Personel_Islemleri)
                {
                    sekmeTur = SekmeTur.PersonelIslemleri;
                }
                else if (eskiSekme.Controls[0] is Cari_Kartlari)
                {
                    sekmeTur = SekmeTur.CariKartlari;
                }
                else if (eskiSekme.Controls[0] is HammaddeKartlari)
                {
                    sekmeTur = SekmeTur.HammaddeKartlari;
                }
                else if (eskiSekme.Controls[0] is FaturaIsleme)
                {
                    sekmeTur = SekmeTur.FaturaIsleme;
                }
                else if(eskiSekme.Controls[0] is FaturaRapor)
                {
                    sekmeTur = SekmeTur.Faturalar;
                }
                tabControl1.SelectedTab.Dispose();
                if (sekmeTur == SekmeTur.PersonelIslemleri)
                {
                    acilaceakSekmeTuruneGoreSecim(button1, sekmeTur);
                }
                else if (sekmeTur == SekmeTur.CariKartlari)
                {
                    acilaceakSekmeTuruneGoreSecim(button2, sekmeTur); ;
                }
                else if (sekmeTur == SekmeTur.HammaddeKartlari)
                {
                    acilaceakSekmeTuruneGoreSecim(btnHammaddeKart, sekmeTur);
                }
                else if (sekmeTur == SekmeTur.FaturaIsleme)
                {
                    acilaceakSekmeTuruneGoreSecim(btnFaturaIsleme, sekmeTur);
                }
                else if (sekmeTur == SekmeTur.Faturalar)
                {
                    acilaceakSekmeTuruneGoreSecim(button7, sekmeTur);
                }
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
            acilaceakSekmeTuruneGoreSecim(button7, SekmeTur.Faturalar);
        }
    }
}
