using ClosedXML.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static DemoMuhasebeProgram.Fatura;
using static DemoMuhasebeProgram.Personel_Islemleri;

namespace DemoMuhasebeProgram
{
    public partial class FaturaIsleme : UserControl
    {
        private CariList CariListe;
        private HammaddeList HammaddeList;
        private Fatura newfatura;
        private Form1 mainForm;
        private LoadingForm loadingForm;
        private FaturaListe faturaListe;
        enum Mod
        {
            bos, yeniSatir, satiriDuzenle
        }
        void ModAyari(Mod mod)
        {
            if (mod == Mod.bos)
            {
                txtMiktar.Enabled = false;
                txtBirimFiyat.Enabled = false;
                txtKoliIciAdet.Enabled = false;
                txtIskontoOrani.Enabled = false;
                cmbKdvOrani.Enabled = false;
                cmbUrunAdi.Enabled = false;
                btnEkle.Enabled = false;
                txtMiktar.Text = "";
                txtBirimFiyat.Text = "";
                txtKoliIciAdet.Text = "";
                txtIskontoOrani.Text = "";
                cmbKdvOrani.Text = "";
                cmbKdvOrani.SelectedIndex = -1;
                cmbUrunAdi.SelectedIndex = -1;
                cmbFaturaUrunNo.Enabled = false;
                cmbFaturaUrunNo.SelectedIndex = -1;
                cmbFaturaUrunNo.Items.Clear();
                btnEkle.Text = "Ekle";
                btnEditMod.Enabled = true;
                btnEklemeMod.Enabled = true;
            }
            else if (mod == Mod.yeniSatir)
            {
                txtMiktar.Enabled = true;
                txtBirimFiyat.Enabled = true;
                txtKoliIciAdet.Enabled = true;
                txtIskontoOrani.Enabled = true;
                cmbKdvOrani.Enabled = true;
                cmbUrunAdi.Enabled = true;
                btnEkle.Enabled = true;
                txtMiktar.Text = "";
                txtBirimFiyat.Text = "";
                txtKoliIciAdet.Text = "";
                txtIskontoOrani.Text = "";
                cmbKdvOrani.Text = "";
                cmbKdvOrani.SelectedIndex = -1;
                cmbUrunAdi.SelectedIndex = -1;
                cmbFaturaUrunNo.Enabled = false;
                cmbFaturaUrunNo.SelectedIndex = -1;
                cmbFaturaUrunNo.Items.Clear();
                btnEkle.Text = "Ekle";
                btnEditMod.Enabled = true;
                btnEklemeMod.Enabled = false;
            }
            else if (mod == Mod.satiriDuzenle)
            {
                txtMiktar.Enabled = true;
                txtBirimFiyat.Enabled = true;
                txtKoliIciAdet.Enabled = true;
                txtIskontoOrani.Enabled = true;
                cmbKdvOrani.Enabled = true;
                cmbUrunAdi.Enabled = true;
                btnEkle.Enabled = true;
                txtMiktar.Text = "";
                txtBirimFiyat.Text = "";
                txtKoliIciAdet.Text = "";
                txtIskontoOrani.Text = "";
                cmbKdvOrani.Text = "";
                cmbKdvOrani.SelectedIndex = -1;
                cmbUrunAdi.SelectedIndex = -1;
                for (int i = 0; i < newfatura.faturaSatiris.Count; i++)
                {
                    cmbFaturaUrunNo.Items.Add(newfatura.faturaSatiris[i].faturaSatiriId);
                }
                cmbFaturaUrunNo.Enabled = true;
                cmbFaturaUrunNo.SelectedIndex = -1;
                btnEkle.Text = "Güncelle";
                btnEditMod.Enabled = false;
                btnEklemeMod.Enabled = true;
            }
        }
        public FaturaIsleme(CariList cList, HammaddeList hList, Form1 form1, FaturaListe lFatura)
        {
            InitializeComponent();
            CariListe = cList;
            HammaddeList = hList;
            mainForm = form1;
            Fatura fatura = new Fatura();
            newfatura = fatura;
            faturaListe = lFatura;
            if (cmbFirmaUnvani.Items.Count != 0)
            {
                cmbFirmaUnvani.Items.Clear();
            }
            for (int i = 0; i < CariListe.cariList.Count; i++)
            {
                cmbFirmaUnvani.Items.Add(CariListe.cariList[i].GetName());
            }
            if (cmbUrunAdi.Items.Count != 0)
            {
                cmbUrunAdi.Items.Clear();
            }
            for (int i = 0; i < HammaddeList.hammaddeliste.Count; i++)
            {
                cmbUrunAdi.Items.Add(HammaddeList.hammaddeliste[i].name);
            }
            ModAyari(Mod.bos);
        }
        private void btnEklemeMod_Click(object sender, EventArgs e)
        {
            ModAyari(Mod.yeniSatir);
        }
        decimal StringToFloat(string txt)
        {
            decimal.TryParse(txt, NumberStyles.Number, new CultureInfo("tr-TR"), out decimal donus);
            return donus;
        }
        private void lableAyar()
        {

            label11.Text = newfatura.toplamTutar + " TL";
            label12.Text = newfatura.ToplamKdvTutar + " TL";
            label13.Text = newfatura.toplamIskontoTutar + " TL";
            label14.Text = newfatura.ToplamHamTurar + " TL";
        }
        private void faturaSaritiEkle(Fatura fatura,FaturaSatiri faturaSatiri, string name, string faturaSatiriId, string koliIciAdet, string miktar, string birimFiyat, string iskontoOrani, string kdvOrani)
        {
            faturaSatiri.urunName = name;
            faturaSatiri.koliIciAdet = StringToFloat(koliIciAdet);
            faturaSatiri.miktar = StringToFloat(miktar);
            faturaSatiri.birimFiyat = StringToFloat(birimFiyat);
            faturaSatiri.hamTutar = faturaSatiri.miktar * faturaSatiri.birimFiyat;
            faturaSatiri.iskontoOrani = StringToFloat(iskontoOrani);
            faturaSatiri.iskontoTutari = faturaSatiri.hamTutar * (faturaSatiri.iskontoOrani / 100);
            faturaSatiri.iskontoDahilTutar = faturaSatiri.hamTutar - faturaSatiri.iskontoTutari;
            faturaSatiri.kdvOrani = StringToFloat(kdvOrani);
            faturaSatiri.kdvTutari = faturaSatiri.iskontoDahilTutar * (faturaSatiri.kdvOrani / 100);
            faturaSatiri.kdvDahilTutar = faturaSatiri.iskontoDahilTutar + faturaSatiri.kdvTutari;
            fatura.FaturaSatiriEkle(faturaSatiri);
            dataGridView1.Rows.Add(faturaSatiri.faturaSatiriId, faturaSatiri.urunName, faturaSatiri.koliIciAdet, faturaSatiri.miktar
                , faturaSatiri.birimFiyat, faturaSatiri.hamTutar, faturaSatiri.iskontoOrani, faturaSatiri.iskontoTutari
                , faturaSatiri.iskontoDahilTutar, faturaSatiri.kdvOrani, faturaSatiri.kdvTutari, faturaSatiri.kdvDahilTutar);
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (btnEkle.Text == "Ekle")
            {
                FaturaSatiri faturaSatiri = new FaturaSatiri();
                faturaSaritiEkle(newfatura,faturaSatiri, cmbUrunAdi.Text, txtFaturaNo.Text, txtKoliIciAdet.Text,
                    txtMiktar.Text, txtBirimFiyat.Text, txtIskontoOrani.Text, cmbKdvOrani.Text);
                ModAyari(Mod.bos);
            }
            else if (btnEkle.Text == "Güncelle")
            {
                for (int i = 0; i < newfatura.faturaSatiris.Count; i++)
                {
                    if (newfatura.faturaSatiris[i].faturaSatiriId.ToString() == cmbFaturaUrunNo.Text)
                    {
                        newfatura.FaturaSatiriDuzenle(newfatura.faturaSatiris[i], cmbUrunAdi.Text, StringToFloat(txtKoliIciAdet.Text)
                            , StringToFloat(txtMiktar.Text), StringToFloat(txtBirimFiyat.Text), StringToFloat(txtIskontoOrani.Text)
                            , StringToFloat(cmbKdvOrani.Text));
                        dataGridView1.Rows[i].SetValues(newfatura.faturaSatiris[i].faturaSatiriId, newfatura.faturaSatiris[i].urunName
                            , newfatura.faturaSatiris[i].koliIciAdet, newfatura.faturaSatiris[i].miktar
                            , newfatura.faturaSatiris[i].birimFiyat, newfatura.faturaSatiris[i].hamTutar
                            , newfatura.faturaSatiris[i].iskontoOrani, newfatura.faturaSatiris[i].iskontoTutari
                            , newfatura.faturaSatiris[i].iskontoDahilTutar, newfatura.faturaSatiris[i].kdvOrani
                            , newfatura.faturaSatiris[i].kdvTutari, newfatura.faturaSatiris[i].kdvDahilTutar);
                    }
                }
                ModAyari(Mod.bos);
            }
            lableAyar();
        }
        private void ExcelldenVeriAlmaFunctions()
        {
            OpenFileDialog dosyaSec = new OpenFileDialog();
            dosyaSec.Filter = "Excel Dosyası (*.xlsx)|*.xlsx";
            if (dosyaSec.ShowDialog() == DialogResult.OK)
            {
                string dosyaYolu = dosyaSec.FileName;
                using (XLWorkbook excelDosyasi = new XLWorkbook(dosyaYolu))
                {
                    int newFaturaSatiriSayisi = 0;
                    IXLWorksheet sayfa = excelDosyasi.Worksheet(1);
                    bool calis = true;
                    int satir = 3;
                    cmbFirmaUnvani.Text = sayfa.Cell(1, 2).GetString();
                    txtFaturaNo.Text = sayfa.Cell(1, 5).GetString();
                    dateTimePicker1.Value = sayfa.Cell(1, 8).GetDateTime();
                    while (calis)
                    {
                        string hucreVeri = sayfa.Cell(satir, 1).GetString();
                        if (hucreVeri != "")
                        {
                            newFaturaSatiriSayisi++;
                            satir++;
                        }
                        else
                            calis = false;
                    }
                    for (int i = 0; i < newFaturaSatiriSayisi; i++)
                    {
                        string faturaUrunNo = "";
                        string urunName = "";
                        string koliIciAdet = "";
                        string miktar = "";
                        string birimFiyat = "";
                        string hamTutar = "";
                        string iskontoOrani = "";
                        string iskontoTutari = "";
                        string iskontoDahilTutar = "";
                        string kdvOrani = "";
                        string kdvTutari = "";
                        string kdvDahilTutar = "";
                        faturaUrunNo = sayfa.Cell(i + 3, 1).GetString();
                        urunName = sayfa.Cell(i + 3, 2).GetString();
                        koliIciAdet = sayfa.Cell(i + 3, 3).GetString();
                        miktar = sayfa.Cell(i + 3, 4).GetString();
                        birimFiyat = sayfa.Cell(i + 3, 5).GetString();
                        hamTutar = sayfa.Cell(i + 3, 6).GetString();
                        iskontoOrani = sayfa.Cell(i + 3, 7).GetString();
                        iskontoTutari = sayfa.Cell(i + 3, 8).GetString();
                        iskontoDahilTutar = sayfa.Cell(i + 3, 9).GetString();
                        kdvOrani = sayfa.Cell(i + 3, 10).GetString();
                        kdvTutari = sayfa.Cell(i + 3, 11).GetString();
                        kdvDahilTutar = sayfa.Cell(i + 3, 12).GetString();
                        FaturaSatiri faturaSatiri = new FaturaSatiri();
                        faturaSaritiEkle(newfatura,faturaSatiri, urunName, faturaUrunNo, koliIciAdet, miktar, birimFiyat, iskontoOrani, kdvOrani);
                    }
                    newfatura.faturaNo = txtFaturaNo.Text;
                    newfatura.CariUnven = cmbFirmaUnvani.Text;
                    newfatura.tarih = DateOnly.FromDateTime(dateTimePicker1.Value);
                }
            }
            lableAyar();
        }
        public bool ExcellVeriAktarmaButtonFunction()
        {
            string CariUnvan = cmbFirmaUnvani.Text;
            string faturaNo = txtFaturaNo.Text;
            string stdSon = ".xlsx";
            string tarih = "";
            string FileName = "";
            char ayirac = '-';
            newfatura.CariUnven = CariUnvan;
            newfatura.faturaNo = faturaNo;
            newfatura.tarih = DateOnly.FromDateTime(dateTimePicker1.Value);
            tarih = newfatura.tarih.ToString();
            SaveFileDialog dosyaKaydet = new SaveFileDialog();
            FileName = CariUnvan + ayirac + faturaNo + ayirac + tarih + ayirac + stdSon;
            dosyaKaydet.Filter = "Excel Dosyası (*.xlsx)|*.xlsx";
            dosyaKaydet.FileName = FileName;
            if (dosyaKaydet.ShowDialog() != DialogResult.OK)
                return false;
            using (XLWorkbook excelDosyasi = new XLWorkbook())
            {
                int satır = 1;
                IXLWorksheet sayfa = excelDosyasi.Worksheets.Add("FaturaSatirleri");
                sayfa.Cell(satır, 1).Value = "Unvan: ";
                sayfa.Cell(satır, 2).Value = CariUnvan;
                sayfa.Cell(satır, 4).Value = "Fatura No: ";
                sayfa.Cell(satır, 5).Value = faturaNo;
                sayfa.Cell(satır, 7).Value = "Tarih: ";
                sayfa.Cell(satır, 8).Value = newfatura.tarih.ToDateTime(TimeOnly.MinValue);
                satır++;
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    sayfa.Cell(satır, i + 1).Value = dataGridView1.Columns[i].HeaderText;
                }
                satır++;
                for (int i = 0; i < newfatura.faturaSatiris.Count; i++)
                {
                    for (int i1 = 0; i1 < newfatura.faturaSatiris[0].degiskenSayisi; i1++)
                    {
                        sayfa.Cell(satır, i1 + 1).Value = newfatura.GetFaturaSatiriDegisken(i, i1);
                    }
                    satır++;
                }
                satır++;
                sayfa.Cell(satır, dataGridView1.ColumnCount - 1).Value = "Ham Toplam:";
                sayfa.Cell(satır, dataGridView1.ColumnCount).Value = label14.Text;
                satır++;
                sayfa.Cell(satır, dataGridView1.ColumnCount - 1).Value = "İskonto Toplam:";
                sayfa.Cell(satır, dataGridView1.ColumnCount).Value = label13.Text;
                satır++;
                sayfa.Cell(satır, dataGridView1.ColumnCount - 1).Value = "Kdv Toplam:";
                sayfa.Cell(satır, dataGridView1.ColumnCount).Value = label12.Text;
                satır++;
                sayfa.Cell(satır, dataGridView1.ColumnCount - 1).Value = "Toplam Fatura Tutar:";
                sayfa.Cell(satır, dataGridView1.ColumnCount).Value = label11.Text;
                excelDosyasi.SaveAs(dosyaKaydet.FileName);
            }
            return true;
        }
        private void btnOutTheExcell_Click(object sender, EventArgs e)
        {
            ExcelldenVeriAlmaFunctions();
        }
        private void FaturayiKaydet(Fatura fatura)
        {
            ModAyari(Mod.bos);
            for (int i = 0; i < CariListe.cariList.Count; i++)
            {
                if (fatura.CariUnven == CariListe.cariList[i].GetName())
                {
                    CariListe.cariList[i].MalAlım(fatura.toplamTutar);
                    break;
                }
            }
            dataGridView1.Rows.Clear();
            faturaListe.FaturaListesineEkle(fatura);
            Fatura yenifatura = new Fatura();
            fatura = yenifatura;
            lableAyar();
        }
        private void InToExcell_Click(object sender, EventArgs e)
        {
            if (cmbFirmaUnvani.Text == "")
            {
                MessageBox.Show("Fatura Kaydı İçin Firma Ünvenı Semelisiniz.");
            }
            else if (txtFaturaNo.Text == "")
            {
                MessageBox.Show("Fatura Kaydı Yapmak İçin Fatura No Kısmını Doldurmalısınız.");
            }
            else if (cmbFirmaUnvani.Text != "" && txtFaturaNo.Text != "")
            {
                if (ExcellVeriAktarmaButtonFunction())
                    FaturayiKaydet(newfatura);
            }
            else
            {
                MessageBox.Show("Beklenmeyen Bir Hata Oluştu Fatura Kaydı Alınamadı Lütfen Bilgileri Kontrol Edip Tekrar Deneyiniz.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditMod_Click(object sender, EventArgs e)
        {
            ModAyari(Mod.satiriDuzenle);
        }

        private void cmbFaturaUrunNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFaturaUrunNo.SelectedIndex != -1)
            {
                int sItems = cmbFaturaUrunNo.SelectedIndex;
                for (int i = 0; i < newfatura.faturaSatiris.Count; i++)
                {
                    if (sItems == newfatura.faturaSatiris[i].faturaSatiriId)
                    {
                        cmbUrunAdi.Text = newfatura.faturaSatiris[i].urunName;
                        txtKoliIciAdet.Text = newfatura.faturaSatiris[i].koliIciAdet.ToString();
                        txtMiktar.Text = newfatura.faturaSatiris[i].miktar.ToString();
                        txtBirimFiyat.Text = newfatura.faturaSatiris[i].birimFiyat.ToString();
                        cmbKdvOrani.Text = newfatura.faturaSatiris[i].kdvOrani.ToString();
                        txtIskontoOrani.Text = newfatura.faturaSatiris[i].iskontoOrani.ToString();
                    }
                }
            }
        }
        private void ExcelldenTopluVeriAlmaFunctions()
        {
            FaturaListe eklenecekFaturalar = new FaturaListe();
            OpenFileDialog dosyaSec = new OpenFileDialog();
            dosyaSec.Filter = "Excel Dosyası (*.xlsx)|*.xlsx";
            if (dosyaSec.ShowDialog() == DialogResult.OK)
            {
                string dosyaYolu = dosyaSec.FileName;
                using (XLWorkbook excelDosyasi = new XLWorkbook(dosyaYolu))
                {
                    int newFaturaSatiriSayisi = 0;
                    IXLWorksheet sayfa = excelDosyasi.Worksheet(1);
                    bool calis = true;
                    int satir = 2;
                    while (calis)
                    {
                        string hucreVeri = sayfa.Cell(satir, 1).GetString();
                        if (hucreVeri != "")
                        {
                            newFaturaSatiriSayisi++;
                            satir++;
                        }
                        else
                            calis = false;
                    }
                    for (int i = 0; i < newFaturaSatiriSayisi; i++)
                    {
                        string cariUnvan = "";
                        string urunName = "";
                        string koliIciAdet = "";
                        string miktar = "";
                        string birimFiyat = "";
                        string iskontoOrani = "";
                        string kdvOrani = "";
                        string faturaNo = "";
                        DateTime stringtarih;
                        DateOnly tarih = DateOnly.MinValue;
                        faturaNo = sayfa.Cell(i + 2, 1).GetString();
                        cariUnvan = sayfa.Cell(i + 2, 3).GetString();
                        stringtarih = DateTime.Parse(sayfa.Cell(i + 2, 2).GetString());
                        tarih = DateOnly.FromDateTime(stringtarih);
                        urunName = sayfa.Cell(i + 2, 5).GetString();
                        koliIciAdet = sayfa.Cell(i + 2, 6).GetString();
                        miktar = sayfa.Cell(i + 2, 7).GetString();
                        birimFiyat = sayfa.Cell(i + 2, 8).GetString();
                        iskontoOrani = sayfa.Cell(i + 2, 10).GetString();
                        kdvOrani = sayfa.Cell(i + 2, 12).GetString();
                        FaturaSatiri faturaSatiri = new FaturaSatiri();
                        faturaSatiri.urunName = urunName;
                        faturaSatiri.koliIciAdet = StringToFloat(koliIciAdet);
                        faturaSatiri.miktar = StringToFloat(miktar);
                        faturaSatiri.birimFiyat = StringToFloat(birimFiyat);
                        faturaSatiri.hamTutar = faturaSatiri.miktar * faturaSatiri.birimFiyat;
                        faturaSatiri.iskontoOrani = StringToFloat(iskontoOrani);
                        faturaSatiri.iskontoTutari = faturaSatiri.hamTutar * (faturaSatiri.iskontoOrani / 100);
                        faturaSatiri.iskontoDahilTutar = faturaSatiri.hamTutar - faturaSatiri.iskontoTutari;
                        faturaSatiri.kdvOrani = StringToFloat(kdvOrani);
                        faturaSatiri.kdvTutari = faturaSatiri.iskontoDahilTutar * (faturaSatiri.kdvOrani / 100);
                        faturaSatiri.kdvDahilTutar = faturaSatiri.iskontoDahilTutar + faturaSatiri.kdvTutari;
                        bool faturaNoBulundi = false;
                        int index = 0;
                        for (int i1 = 0; i1 < eklenecekFaturalar.faturaList.Count; i1++)
                        {
                            if (eklenecekFaturalar.faturaList[i1].faturaNo == faturaNo && eklenecekFaturalar.faturaList[i1].tarih == tarih && eklenecekFaturalar.faturaList[i1].CariUnven == cariUnvan)
                            { faturaNoBulundi = true;index = i1; }
                        }
                        if (faturaNoBulundi)
                        {
                            eklenecekFaturalar.faturaList[index].FaturaSatiriEkle(faturaSatiri);   
                        }
                        else
                        {
                            Fatura yeniFatura = new Fatura();
                            yeniFatura.faturaNo = faturaNo;
                            yeniFatura.CariUnven = cariUnvan;
                            yeniFatura.tarih = tarih;
                            yeniFatura.FaturaSatiriEkle(faturaSatiri);
                            eklenecekFaturalar.faturaList.Add(yeniFatura);
                        }
                    }
                }
                for (int i = 0; i < eklenecekFaturalar.faturaList.Count; i++)
                {
                    FaturayiKaydet(eklenecekFaturalar.faturaList[i]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExcelldenTopluVeriAlmaFunctions();
        }
    }
}
