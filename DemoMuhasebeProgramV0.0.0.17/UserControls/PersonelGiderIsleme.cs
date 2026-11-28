using ClosedXML.Excel;
using DemoMuhasebeProgram.Classes;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Vml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DemoMuhasebeProgram.UserControls
{
    public partial class PersonelGiderIsleme : UserControl
    {
        PersonelListe personelListe;
        PersonelGiderSatirii PGsatiri;
        TarihBazlıPersonelGider TarihBPG;
        PersonelGiderListesi pgList;
        enum Mod
        {
            bos, yeni, secimYok, secimVar
        }
        private void ModAyar(Mod mod)
        {
            switch (mod)
            {
                case Mod.bos:
                    cmbName.Enabled = false;
                    cmbName.SelectedIndex = -1;
                    cmbName.Text = "";
                    cmbSelected.Enabled = false;
                    cmbSelected.SelectedIndex = -1;
                    cmbSelected.Text = "";
                    cmbTur.Enabled = false;
                    cmbTur.SelectedIndex = -1;
                    cmbTur.Text = "";
                    btnOk.Enabled = false;
                    btnOk.Text = "";
                    panel4.Visible = false;
                    break;
                case Mod.yeni:
                    cmbName.Enabled = true;
                    cmbName.SelectedIndex = -1;
                    cmbName.Text = "";
                    cmbSelected.Enabled = false;
                    cmbSelected.SelectedIndex = -1;
                    cmbSelected.Text = "";
                    cmbTur.Enabled = true;
                    cmbTur.SelectedIndex = -1;
                    cmbTur.Text = "";
                    btnOk.Enabled = true;
                    btnOk.Text = "Ekle";
                    panel4.Visible = true;
                    break;
                case Mod.secimYok:
                    cmbName.Enabled = false;
                    cmbName.SelectedIndex = -1;
                    cmbName.Text = "";
                    cmbSelected.Enabled = true;
                    cmbSelected.SelectedIndex = -1;
                    cmbSelected.Text = "";
                    cmbTur.Enabled = false;
                    cmbTur.SelectedIndex = -1;
                    cmbTur.Text = "";
                    btnOk.Enabled = false;
                    btnOk.Text = "Güncelle";
                    panel4.Visible = true;
                    break;
                case Mod.secimVar:
                    var satiri = TarihBPG.satirs.Find(kart => kart.id.ToString() == cmbSelected.Text);
                    if (satiri != null)
                    {
                        PGsatiri = satiri;
                        cmbName.Enabled = true;
                        cmbSelected.Enabled = true;
                        cmbTur.Enabled = true;
                        btnOk.Enabled = true;
                        btnOk.Text = "Güncelle";
                        panel4.Visible = true;
                        cmbName.Text = PGsatiri.PersonelName;
                        cmbTur.Text = PGsatiri.Tur;
                        txtTutar.Text = PGsatiri.fiyat.ToString();
                    }
                    else
                    { MessageBox.Show("Bir Hata Oluştu"); }
                    break;
                default:
                    break;
            }
        }
        private void Doldur()
        {
            dataGridView1.Rows.Clear();
            cmbSelected.Items.Clear();
            foreach (var kart in TarihBPG.satirs)
            {
                dataGridView1.Rows.Add(kart.id, kart.PersonelName, kart.Tur, kart.fiyat);
                cmbSelected.Items.Add(kart.id);
            }
        }
        public PersonelGiderIsleme(PersonelListe lPersonel, PersonelGiderListesi lpGider)
        {
            InitializeComponent();
            personelListe = lPersonel;
            pgList = lpGider;
            ModAyar(Mod.bos);
            var tpGider = pgList.liste.Find(kart => kart.tarih.Date == dtpTarih.Value.Date);
            if (tpGider != null)
                TarihBPG = tpGider;
            else
                TarihBPG = new TarihBazlıPersonelGider();
            foreach (var kart in personelListe.personels)
                cmbName.Items.Add(kart.name);
            Doldur();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ModAyar(Mod.yeni);
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            ModAyar(Mod.secimYok);
        }
        private void cmbSelected_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModAyar(Mod.secimVar);
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (btnOk.Text == "Ekle")
            {
                PersonelGiderSatirii yeniSatir = new PersonelGiderSatirii();
                yeniSatir.PersonelName = cmbName.Text;
                yeniSatir.Tur = cmbTur.Text;
                if (decimal.TryParse(txtTutar.Text, out decimal t))
                    yeniSatir.fiyat = t;
                TarihBPG.SatirEkle(yeniSatir);
                dataGridView1.Rows.Add(yeniSatir.id, yeniSatir.PersonelName, yeniSatir.Tur, yeniSatir.fiyat);
                cmbSelected.Items.Add(yeniSatir.id);
            }
            else if (btnOk.Text == "Güncelle")
            {
                var editSatir = TarihBPG.satirs.Find(kart => cmbSelected.Text.ToString() == kart.id.ToString());
                if (editSatir != null)
                {
                    editSatir.PersonelName = cmbName.Text;
                    editSatir.Tur = cmbTur.Text;
                    if (decimal.TryParse(txtTutar.Text, out decimal t))
                        editSatir.fiyat = t;
                    dataGridView1.Rows[editSatir.id].SetValues(editSatir.id, editSatir.PersonelName, editSatir.Tur, editSatir.fiyat);
                }
            }
        }
        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            var tarihBazlıPersonel = pgList.liste.Find(kart => kart.tarih.Date == dtpTarih.Value.Date);
            if (tarihBazlıPersonel != null)
            {
                TarihBPG = tarihBazlıPersonel;
            }
            else
            {
                TarihBPG = new TarihBazlıPersonelGider();
            }
            Doldur();
        }
        public bool ExvelleVeriAktar()
        {
            string stdBas = "PersonelGideri";
            DateTime tarih = dtpTarih.Value.Date;
            string stringtarih = tarih.ToString("dd-MMMM-yyyy");
            string stdSon = ".xlsx";
            SaveFileDialog dosyaKaydet = new SaveFileDialog();
            string FileName = stdBas + "-" + stringtarih + "-" + stdSon;
            dosyaKaydet.Filter = "Excel Dosyası (*.xlsx)|*.xlsx";
            dosyaKaydet.FileName = FileName;
            if (dosyaKaydet.ShowDialog() != DialogResult.OK) return false;
            TarihBPG.tarih = tarih;
            using (XLWorkbook excelDosyasi = new XLWorkbook())
            {
                int satır = 1;
                IXLWorksheet sayfa = excelDosyasi.Worksheets.Add("Recete");
                sayfa.Cell(satır, 1).Value = "Tarih: ";
                sayfa.Cell(satır, 2).Value = stringtarih;
                satır++;
                for (int i = 0; i < dataGridView1.ColumnCount; i++) sayfa.Cell(satır, i + 1).Value = dataGridView1.Columns[i].HeaderText;
                satır++;
                foreach (var kart in TarihBPG.satirs)
                {
                    sayfa.Cell(satır, 1).Value = kart.id;
                    sayfa.Cell(satır, 2).Value = kart.PersonelName;
                    sayfa.Cell(satır, 3).Value = kart.Tur;
                    sayfa.Cell(satır, 4).Value = kart.fiyat;
                    satır++;
                }
                excelDosyasi.SaveAs(dosyaKaydet.FileName);
                pgList.PersonelGiderListesineEkle(TarihBPG);
                ModAyar(Mod.bos);
            }
            return true;
        }
        public void ExcelldenVeriAlmaFunctions()
        {
            OpenFileDialog dosyaSec = new OpenFileDialog();
            dosyaSec.Filter = "Excel Dosyası (*.xlsx)|*.xlsx";
            if (dosyaSec.ShowDialog() == DialogResult.OK)
            {
                string dosyaYolu = dosyaSec.FileName;
                using (XLWorkbook excelDosyasi = new XLWorkbook(dosyaYolu))
                {
                    int newPersonelGiderSatiri = 0;
                    IXLWorksheet sayfa = excelDosyasi.Worksheet(1);
                    bool calis = true;
                    int satir = 3;
                    while (calis)
                    {
                        string hucreVeri = sayfa.Cell(satir, 1).GetString();
                        if (hucreVeri != "") { newPersonelGiderSatiri++; satir++; }
                        else calis = false;
                    }
                    satir = 3;
                    for (int i = 0; i < newPersonelGiderSatiri; i++)
                    {
                        PersonelGiderSatirii Psatir = new PersonelGiderSatirii();
                        Psatir.PersonelName = sayfa.Cell(i + satir, 2).GetString();
                        Psatir.Tur = sayfa.Cell(i + satir, 3).GetString();
                        if(decimal.TryParse(sayfa.Cell(i + satir, 4).GetString(),out decimal t))
                            Psatir.fiyat = t;
                        TarihBPG.SatirEkle(Psatir);
                        dataGridView1.Rows.Add(Psatir.id,Psatir.PersonelName,Psatir.Tur,Psatir.fiyat);
                        cmbSelected.Items.Add(Psatir.id);
                    }
                }
            }
        }
    }
}
