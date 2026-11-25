using ClosedXML.Excel;
using DemoMuhasebeProgram.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DemoMuhasebeProgram.UserControls
{
    public partial class SatisKartlari : UserControl
    {
        private SatisUrunListe satisUrunListe;
        enum Mod
        {
            bos, yeniKayıt, düzenlemeSecimYok, düzenlemeSecimVar
        }
        private void ModAyar(Mod mod)
        {
            switch (mod)
            {
                case Mod.bos:
                    button3.Enabled = false;
                    button3.Text = "";
                    txtFiyat.Enabled = false;
                    txtFiyat.Text = "";
                    txtName.Enabled = false;
                    txtName.Text = "";
                    cmbKatagori.Enabled = false;
                    cmbKatagori.Text = "";
                    cmbSelected.Enabled = false;
                    cmbSelected.Text = "";
                    cmbKatagori.SelectedIndex = -1;
                    cmbSelected.SelectedIndex = -1;
                    panel4.Hide();
                    break;
                case Mod.yeniKayıt:
                    button3.Enabled = true;
                    button3.Text = "Ekle";
                    txtFiyat.Enabled = true;
                    txtFiyat.Text = "";
                    txtName.Enabled = true;
                    txtName.Text = "";
                    cmbKatagori.Enabled = true;
                    cmbKatagori.Text = "";
                    cmbSelected.Enabled = false;
                    cmbSelected.Text = "";
                    cmbKatagori.SelectedIndex = -1;
                    cmbSelected.SelectedIndex = -1;
                    panel4.Hide();
                    break;
                case Mod.düzenlemeSecimYok:
                    button3.Enabled = false;
                    button3.Text = "Güncelle";
                    txtFiyat.Enabled = false;
                    txtFiyat.Text = "";
                    txtName.Enabled = false;
                    txtName.Text = "";
                    cmbKatagori.Enabled = false;
                    cmbKatagori.Text = "";
                    cmbSelected.Enabled = true;
                    cmbSelected.Text = "";
                    cmbKatagori.SelectedIndex = -1;
                    cmbSelected.SelectedIndex = -1;
                    panel4.Show();
                    break;
                case Mod.düzenlemeSecimVar:
                    button3.Enabled = true;
                    button3.Text = "Güncelle";
                    txtFiyat.Enabled = true;
                    txtName.Enabled = true;
                    cmbKatagori.Enabled = true;
                    cmbSelected.Enabled = true;
                    panel4.Show();
                    break;
                default:
                    break;
            }
        }
        private void dgvVeCmbDoldur()
        {
            dataGridView1.Rows.Clear();
            cmbSelected.Items.Clear();
            for (int i = 0; i < satisUrunListe.satisUruns.Count; i++)
            {
                dataGridView1.Rows.Add(satisUrunListe.satisUruns[i].Id, satisUrunListe.satisUruns[i].ad,
                satisUrunListe.satisUruns[i].katagori, satisUrunListe.satisUruns[i].fiyat);
                cmbSelected.Items.Add(satisUrunListe.satisUruns[i].ad);
            }
        }
        public SatisKartlari(SatisUrunListe LsatisUrun)
        {
            InitializeComponent();
            ModAyar(Mod.bos);
            satisUrunListe = LsatisUrun;
            dgvVeCmbDoldur();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ModAyar(Mod.yeniKayıt);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Ekle")
            {
                SatisUrun urun = new SatisUrun();
                urun.ad = txtName.Text;
                if (decimal.TryParse(txtFiyat.Text, out decimal tutar))
                    urun.fiyat = tutar;
                else
                    MessageBox.Show("Fiyat Sadece Rakamdan Oluşmalı");
                urun.katagori = cmbKatagori.Text;
                if (satisUrunListe.satisUruns.Count == 0)
                    urun.Id = 0;
                else
                    urun.Id = satisUrunListe.satisUruns.Count;
                satisUrunListe.satisUruns.Add(urun);
                dataGridView1.Rows.Add(urun.Id, urun.ad, urun.katagori, urun.fiyat);
                cmbSelected.Items.Add(urun.ad);
            }
            else if (button3.Text == "Güncelle")
            {
                int index = -1;
                for (int i = 0; i < satisUrunListe.satisUruns.Count; i++)
                {
                    if (cmbSelected.Text == satisUrunListe.satisUruns[i].ad)
                        index = i;
                }
                if (index != -1)
                {
                    string ad = "";
                    decimal fiyat = 0;
                    string katagori = "";
                    ad = txtName.Text;
                    if (decimal.TryParse(txtFiyat.Text, out decimal tutar))
                        fiyat = tutar;
                    else
                        MessageBox.Show("Fiyat Sadece Rakamdan Oluşmalı");
                    katagori = cmbKatagori.Text;
                    if (ad != "" && katagori != "" && fiyat != 0)
                    {
                        satisUrunListe.satisUruns[index].ad = ad;
                        satisUrunListe.satisUruns[index].fiyat = fiyat;
                        satisUrunListe.satisUruns[index].katagori = katagori;
                        dataGridView1.Rows[index].Cells[1].Value = ad;
                        dataGridView1.Rows[index].Cells[2].Value = katagori;
                        dataGridView1.Rows[index].Cells[3].Value = txtFiyat.Text;
                    }
                    else
                        MessageBox.Show("Giriş Formatlarında Hata Var");
                }
                else
                    MessageBox.Show("Ürün Bulunamadı");
            }
            ModAyar(Mod.bos);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ModAyar(Mod.düzenlemeSecimYok);
        }
        private void cmbSelected_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelected.SelectedIndex != -1)
            {
                ModAyar(Mod.düzenlemeSecimVar);
                for (int i = 0; i < satisUrunListe.satisUruns.Count; i++)
                {
                    if (cmbSelected.Text == satisUrunListe.satisUruns[i].ad)
                    {
                        txtName.Text = satisUrunListe.satisUruns[i].ad;
                        txtFiyat.Text = satisUrunListe.satisUruns[i].fiyat.ToString();
                        cmbKatagori.Text = satisUrunListe.satisUruns[i].katagori;
                    }
                }
            }
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
                    int newSatisKartiSayisi = 0;
                    IXLWorksheet sayfa = excelDosyasi.Worksheet(1);
                    bool calis = true;
                    int satir = 2;
                    while (calis)
                    {
                        string hucreVeri = sayfa.Cell(satir, 1).GetString();
                        if (hucreVeri != "")
                        {
                            newSatisKartiSayisi++;
                            satir++;
                        }
                        else
                            calis = false;
                    }
                    for (int i = 0; i < newSatisKartiSayisi; i++)
                    {
                        string name;
                        string katagori;
                        string fiyat;
                        name = sayfa.Cell(i + 2, 2).GetString();
                        katagori = sayfa.Cell(i + 2, 3).GetString();
                        fiyat = sayfa.Cell(i + 2, 4).GetString();
                        SatisUrun satisKartlari = new SatisUrun();
                        satisKartlari.Id = satisUrunListe.satisUruns.Count;
                        satisKartlari.ad = name;
                        satisKartlari.katagori = katagori;
                        if (decimal.TryParse(fiyat, out decimal tutar))
                            satisKartlari.fiyat = tutar;
                        satisUrunListe.satisUruns.Add(satisKartlari);
                        dataGridView1.Rows.Add(satisKartlari.Id, satisKartlari.ad, satisKartlari.katagori, satisKartlari.fiyat);
                        cmbSelected.Items.Add(satisKartlari.ad);
                    }
                }
            }
        }
        private void btnOutTheExcell_Click(object sender, EventArgs e)
        {
            ExcelldenVeriAlmaFunctions();
        }
        public void ExcellVeriAktarmaButtonFunction()
        {
            SaveFileDialog dosyaKaydet = new SaveFileDialog();
            dosyaKaydet.Filter = "Excel Dosyası (*.xlsx)|*.xlsx";
            dosyaKaydet.FileName = "SatisKartlari.xlsx";
            if (dosyaKaydet.ShowDialog() != DialogResult.OK)
                return;
            using (XLWorkbook excelDosyasi = new XLWorkbook())
            {
                int satır = 2;

                IXLWorksheet sayfa = excelDosyasi.Worksheets.Add("SatisKartlari");
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    sayfa.Cell(1, i + 1).Value = dataGridView1.Columns[i].HeaderText;
                }
                for (int i = 0; i < satisUrunListe.satisUruns.Count; i++)
                {
                    sayfa.Cell(satır + i,1).Value = satisUrunListe.satisUruns[i].Id;
                    sayfa.Cell(satır + i, 2).Value = satisUrunListe.satisUruns[i].ad;
                    sayfa.Cell(satır + i, 3).Value = satisUrunListe.satisUruns[i].katagori;
                    sayfa.Cell(satır + i, 4).Value = satisUrunListe.satisUruns[i].fiyat.ToString();
                }
                excelDosyasi.SaveAs(dosyaKaydet.FileName);
            }
        }
        private void InToExcell_Click(object sender, EventArgs e)
        {
            ExcellVeriAktarmaButtonFunction();
        }
    }
}
