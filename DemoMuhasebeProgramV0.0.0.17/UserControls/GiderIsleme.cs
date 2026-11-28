using ClosedXML.Excel;
using DemoMuhasebeProgram.Classes;
using DemoMuhasebeProgram.YardımcıClass;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DemoMuhasebeProgram.UserControls
{
    public partial class GiderIsleme : UserControl
    {
        FormOlusturucu formOlusturucu;
        GiderKarlariListe giderKarlari;
        TarihselGiderListesi tarihselGiderListe = new TarihselGiderListesi();
        giderListesi giderListesi;
        enum Mod
        {
            bos, yeni, secimYok, secimVar
        }
        void ModAyar(Mod mod)
        {
            switch (mod)
            {
                case Mod.bos:
                    cmbName.Enabled = false;
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    cmbName.SelectedIndex = -1;
                    textBox1.Text = "";
                    textBox2.Text = "";
                    cmbName.Text = "";
                    btnOk.Enabled = false;
                    btnOk.Text = "";
                    panel5.Visible = false;
                    break;
                case Mod.yeni:
                    cmbName.Enabled = true;
                    textBox1.Enabled = true;
                    textBox2.Enabled = true;
                    textBox1.Text = "";
                    textBox2.Text = "";
                    cmbName.Text = "";
                    btnOk.Enabled = true;
                    btnOk.Text = "Ekle";
                    panel5.Visible = false;
                    break;
                case Mod.secimYok:
                    cmbName.Enabled = true;
                    textBox1.Enabled = true;
                    textBox2.Enabled = true;
                    textBox1.Text = "";
                    textBox2.Text = "";
                    cmbName.Text = "";
                    btnOk.Enabled = true;
                    btnOk.Text = "Güncelle";
                    panel5.Visible = true;
                    break;
                case Mod.secimVar:
                    cmbName.Enabled = true;
                    textBox1.Enabled = true;
                    textBox2.Enabled = true;
                    btnOk.Enabled = true;
                    btnOk.Text = "Güncelle";
                    panel5.Visible = true;
                    break;
            }
        }
        void dgvAbdCmbDoldur()
        {
            dataGridView1.Rows.Clear();
            cmbSelect.Items.Clear();
            int index = giderListesi.liste.FindIndex(liste => liste.tarih.Date == dtpTarih.Value.Date);
            if (index == -1)
            {
                TarihselGiderListesi tarihselGiderListesi = new TarihselGiderListesi();
                tarihselGiderListe = tarihselGiderListesi;
            }
            else
            {
                tarihselGiderListe = giderListesi.liste[index];
                foreach (var kart in tarihselGiderListe.satirs)
                {
                    dataGridView1.Rows.Add(kart.id, kart.name, kart.katagori, kart.tutar, kart.aciklama);
                    cmbSelect.Items.Add(kart.id);
                }
            }
        }
        public GiderIsleme(GiderKarlariListe gListe, giderListesi giderL)
        {
            InitializeComponent();
            FormOlusturucu fOlustur = new FormOlusturucu();
            formOlusturucu = fOlustur;
            giderKarlari = gListe;
            giderListesi = giderL;
            foreach (var kart in giderKarlari.liste) cmbName.Items.Add(kart.Name);
            dgvAbdCmbDoldur();
            ModAyar(Mod.bos);
        }
        private void btnNewGiris_Click(object sender, EventArgs e)
        {
            ModAyar(Mod.yeni);
        }
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            ModAyar(Mod.secimYok);
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (btnOk.Text == "Ekle")
            {
                GiderSatiri satir = new GiderSatiri();
                bool eklemeBasarili = true;

                if (decimal.TryParse(textBox1.Text, out decimal t))
                    satir.tutar = t;
                else
                    eklemeBasarili = false;
                satir.name = cmbName.Text;
                satir.aciklama = textBox2.Text;
                var giderKarti = giderKarlari.liste.Find(kart => kart.Name == satir.name);
                if (giderKarti != null)
                    satir.katagori = giderKarti.Katagori;
                if (satir.katagori == "" || satir.name == "")
                    eklemeBasarili = false;
                if (eklemeBasarili)
                {
                    tarihselGiderListe.tarihselGiderListesineEkele(satir);
                    dataGridView1.Rows.Add(satir.id, satir.name, satir.katagori, satir.tutar, satir.aciklama);
                    cmbSelect.Items.Add(satir.id);
                }
                else
                    MessageBox.Show("ad veya id veya katagori boş olamaz");
            }
            else if (btnOk.Text == "Güncelle")
            {
                GiderSatiri satir = new GiderSatiri();
                int satirIndex = tarihselGiderListe.satirs.FindIndex(giderSatiri => giderSatiri.id.ToString() == cmbSelect.Text.ToString());
                if (satirIndex == -1)
                    return;
                satir.name = cmbName.Text;
                var giderKarti = giderKarlari.liste.Find(kart => kart.Name == satir.name);
                if (giderKarti != null)
                    satir.katagori = giderKarti.Katagori;
                if (decimal.TryParse(textBox1.Text, out decimal t))
                    satir.tutar = t;
                satir.aciklama = textBox2.Text;
                satir.id = tarihselGiderListe.satirs[satirIndex].id;
                if (satir.name != "" && satir.katagori != "" && satir.tutar != -1 && satir.id != -1)
                {
                    tarihselGiderListe.satirs[satirIndex] = satir;
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        string j = dataGridView1.Rows[i].Cells[0].Value.ToString();
                        if (j == satir.id.ToString())
                            dataGridView1.Rows[i].SetValues(satir.id, satir.name, satir.katagori, satir.tutar, satir.aciklama);
                    }
                }
            }
        }
        private void cmbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelect.SelectedIndex != -1)
            {
                ModAyar(Mod.secimVar);
                var satir = tarihselGiderListe.satirs.Find(satir => satir.id.ToString() == cmbSelect.Text);
                if (satir != null)
                {
                    cmbSelect.Enabled = false;
                    cmbName.Text = satir.name;
                    textBox1.Text = satir.tutar.ToString();
                    textBox2.Text = satir.aciklama;
                }
            }
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
                    int newGiderSatiri = 0;
                    IXLWorksheet sayfa = excelDosyasi.Worksheet(1);
                    bool calis = true;
                    int satir = 3;
                    while (calis)
                    {
                        string hucreVeri = sayfa.Cell(satir, 2).GetString();
                        if (hucreVeri != "") { newGiderSatiri++; satir++; }
                        else calis = false;
                    }
                    satir = 3;
                    for (int i = 0; i < newGiderSatiri; i++)
                    {
                        GiderSatiri giderSatiri = new GiderSatiri();
                        giderSatiri.name = sayfa.Cell(i + satir, 2).GetString();
                        if (decimal.TryParse(sayfa.Cell(i + satir, 4).GetString(), out decimal t))
                            giderSatiri.tutar = t;
                        giderSatiri.aciklama = sayfa.Cell(i + satir, 5).GetString();

                        var giderKarti = giderKarlari.liste.Find(kart => kart.Name == giderSatiri.name);
                        if (giderKarti != null)
                            giderSatiri.katagori = giderKarti.Katagori;

                        tarihselGiderListe.tarihselGiderListesineEkele(giderSatiri);
                        dataGridView1.Rows.Add(giderSatiri.id, giderSatiri.name, giderSatiri.katagori, giderSatiri.tutar, giderSatiri.aciklama);
                        cmbSelect.Items.Add(giderSatiri.id);
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ExcelldenVeriAlmaFunctions();
        }
        public bool ExvelleVeriAktar()
        {
            string stdBas = "Giderler";
            string stringtarih = tarihselGiderListe.tarih.ToString();
            string stdSon = ".xlsx";
            SaveFileDialog dosyaKaydet = new SaveFileDialog();
            string FileName = stdBas + "-" + stringtarih + stdSon;
            dosyaKaydet.Filter = "Excel Dosyası (*.xlsx)|*.xlsx";
            dosyaKaydet.FileName = FileName;
            if (dosyaKaydet.ShowDialog() != DialogResult.OK) return false;
            using (XLWorkbook excelDosyasi = new XLWorkbook())
            {
                int satır = 1;
                IXLWorksheet sayfa = excelDosyasi.Worksheets.Add("Giderler");
                sayfa.Cell(satır, 1).Value = "Tarih:";
                sayfa.Cell(satır, 2).Value = tarihselGiderListe.tarih.ToString();
                satır++;
                for (int i = 0; i < dataGridView1.ColumnCount; i++) sayfa.Cell(satır, i + 1).Value = dataGridView1.Columns[i].HeaderText;
                foreach (var kart in tarihselGiderListe.satirs)
                {
                    satır++;
                    sayfa.Cell(satır, 1).Value = kart.id;
                    sayfa.Cell(satır, 2).Value = kart.name;
                    sayfa.Cell(satır, 3).Value = kart.katagori;
                    sayfa.Cell(satır, 4).Value = kart.tutar;
                    sayfa.Cell(satır, 5).Value = kart.aciklama;
                }
                excelDosyasi.SaveAs(dosyaKaydet.FileName);
            }
            return true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (ExvelleVeriAktar())
            {
                tarihselGiderListe.tarih = dtpTarih.Value;
                int index = giderListesi.liste.FindIndex(gider => gider.tarih.Date == dtpTarih.Value.Date);
                if (index == -1)
                    giderListesi.GiderListesineEkle(tarihselGiderListe);
                else
                    giderListesi.liste[index] = tarihselGiderListe;
            }
        }
        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            dgvAbdCmbDoldur();
        }
    }
}
