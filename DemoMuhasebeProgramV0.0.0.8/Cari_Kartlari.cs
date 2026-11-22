using ClosedXML.Excel;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static DemoMuhasebeProgram.CariClass;
using static DemoMuhasebeProgram.Fatura;

namespace DemoMuhasebeProgram
{
    public partial class Cari_Kartlari : UserControl
    {
        private CariList liste;
        private FaturaListe faturaListe;
        void TextBoxTextSet(TextBox textBox, string txt)
        {
            textBox.Text = txt;
        }
        void TextBoxEnebledSet(TextBox textBox, bool aktif)
        {
            textBox.Enabled = aktif;
        }
        enum Mod
        {
            emptyMod, newMod, editModNotSelected, editModSelected
        }
        public bool CariKartChracterControl(string txt)
        {
            bool donus = true;
            for (int i = 0; i < txt.Length; i++)
            {
                switch (txt[i])
                {
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                    case '0':
                        donus = false;
                        break;
                }
            }
            return donus;
        }
        public bool CariKartNameControl(string name)
        {
            if (name.Length >= 3 && CariKartChracterControl(name))
            {
                return true;
            }
            return false;
        }
        public bool CariKartVergiNoControl(string vergiNo)
        {
            if (vergiNo.Length == 10 && !CariKartChracterControl(vergiNo))
            {
                return true;
            }
            return false;
        }
        public bool CariKartTelNoControl(string telNo)
        {
            if (telNo.Length == 10 && !CariKartChracterControl(telNo))
            {
                return true;
            }
            return false;
        }

        public bool CariKartControl(string name, string vergiNo, string telNo)
        {
            bool dogruGiris = true;
            if (!CariKartNameControl(name))
            {
                MessageBox.Show("Cari Kart Adı 3 karakterden az olamaz ve rakam içeremez.");
                dogruGiris = false;
            }
            else if (!CariKartVergiNoControl(vergiNo))
            {
                MessageBox.Show("Vergi Numarası 10 haneli olmalı ve rakam içermelidir.");
                dogruGiris = false;
            }
            else if (!CariKartTelNoControl(telNo))
            {
                MessageBox.Show("Telefon Numarası 11 haneli olmalı ve rakam içermelidir.");
                dogruGiris = false;
            }
            else if (!SameNameControl(name))
            {
                MessageBox.Show("Aynı isimde bir cari kart zaten mevcut.");
                dogruGiris = false;
            }
            else
            {
                dogruGiris = true;
            }
            return dogruGiris;
        }
        void ModSettings(Mod mod)
        {
            if (mod == Mod.emptyMod)
            {
                cmbSelectCari.SelectedIndex = -1;
                cmbSelectCari.Enabled = false;
                TextBoxTextSet(txtName, "");
                TextBoxTextSet(txtTelNo, "");
                TextBoxTextSet(txtVergiNo, "");
                TextBoxEnebledSet(txtName, false);
                TextBoxEnebledSet(txtTelNo, false);
                TextBoxEnebledSet(txtVergiNo, false);
                button2.Text = "";
                button2.Enabled = false;
                button2.Visible = false;
            }
            else if (mod == Mod.newMod)
            {
                cmbSelectCari.SelectedIndex = -1;
                cmbSelectCari.Enabled = false;
                TextBoxTextSet(txtName, "");
                TextBoxTextSet(txtTelNo, "");
                TextBoxTextSet(txtVergiNo, "");
                TextBoxEnebledSet(txtName, true);
                TextBoxEnebledSet(txtTelNo, true);
                TextBoxEnebledSet(txtVergiNo, true);
                button2.Text = "Ekle";
                button2.Enabled = true;
                button2.Visible = true;
            }
            else if (mod == Mod.editModNotSelected)
            {
                cmbSelectCari.SelectedIndex = -1;
                cmbSelectCari.Enabled = true;
                TextBoxTextSet(txtName, "");
                TextBoxTextSet(txtTelNo, "");
                TextBoxTextSet(txtVergiNo, "");
                TextBoxEnebledSet(txtName, false);
                TextBoxEnebledSet(txtTelNo, false);
                TextBoxEnebledSet(txtVergiNo, false);
                button2.Text = "Güncelle";
                button2.Enabled = false;
                button2.Visible = true;
            }
            else if (mod == Mod.editModSelected)
            {
                string SorchName = cmbSelectCari.Items[cmbSelectCari.SelectedIndex].ToString();
                for (int i = 0; i < liste.CariListCount(); i++)
                {
                    if (liste.cariList[i].GetName() == SorchName)
                    {
                        TextBoxTextSet(txtName, liste.cariList[i].GetName());
                        TextBoxTextSet(txtTelNo, liste.cariList[i].GetIletisimNo());
                        TextBoxTextSet(txtVergiNo, liste.cariList[i].GetVergiNo());
                        break;
                    }
                }
                cmbSelectCari.Enabled = true;
                TextBoxEnebledSet(txtName, true);
                TextBoxEnebledSet(txtTelNo, true);
                TextBoxEnebledSet(txtVergiNo, true);
                button2.Text = "Güncelle";
                button2.Enabled = true;
                button2.Visible = true;
            }
        }
        private void dvgDoldur()
        {
            for (int i = 0; i < liste.cariList.Count; i++)
            {
                dataGridView1.Rows[i].Cells[1].Value = liste.cariList[i].GetCariKod();
                dataGridView1.Rows[i].Cells[2].Value = liste.cariList[i].GetName();
                dataGridView1.Rows[i].Cells[3].Value = liste.cariList[i].GetIletisimNo();
                dataGridView1.Rows[i].Cells[4].Value = liste.cariList[i].GetVergiNo();
                dataGridView1.Rows[i].Cells[5].Value = liste.cariList[i].GetTopAlinanMal();
                dataGridView1.Rows[i].Cells[6].Value = liste.cariList[i].GetTopOdenenTutar();
            }
                    }
        public Cari_Kartlari(CariList cariList, FaturaListe fLiset)
        {
            InitializeComponent();
            ModSettings(Mod.emptyMod);
            liste = cariList;
            dvgDoldur();
        }
        public bool SameNameControl(string name)
        {
            for (int i = 0; i < liste.CariListCount(); i++)
            {
                if (liste.cariList[i].GetName() == name && i != cmbSelectCari.SelectedIndex)
                {
                    return false;
                }
            }
            return true;
        }
        private void NewCari_Click(object sender, EventArgs e)
        {
            ModSettings(Mod.newMod);
        }
        private void EditCari_Click(object sender, EventArgs e)
        {
            ModSettings(Mod.editModNotSelected);
        }
        private void DataGridViewColerReset()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
            }
        }
        private void cmbSelectCari_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelectCari.SelectedIndex != -1)
            {
                ModSettings(Mod.editModSelected);
                string SorchName = cmbSelectCari.Items[cmbSelectCari.SelectedIndex].ToString();
                int index = -1;
                for (int i = 0; i < liste.CariListCount(); i++)
                {
                    if (liste.cariList[i].GetName() == SorchName)
                    {
                        index = i;
                    }
                }
                if (index != -1)
                {
                    txtName.Text = liste.cariList[index].GetName();
                    txtTelNo.Text = liste.cariList[index].GetIletisimNo();
                    txtVergiNo.Text = liste.cariList[index].GetVergiNo();
                    DataGridViewColerReset();
                    dataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
        }
        private void CariKartEkle(string name, string vergiNo, string iletisimNo)
        {
            if (CariKartControl(name, vergiNo, iletisimNo))
            {
                CariClass newCariKart = new CariClass();
                newCariKart.SetName(name);
                newCariKart.SetVergiNo(vergiNo);
                newCariKart.SetIletisimNo(iletisimNo);
                liste.AddCariList(newCariKart);
                dataGridView1.Rows.Add(liste.CariListCount(), name, iletisimNo, vergiNo, 0, 0, 0);
                cmbSelectCari.Items.Add(name);
            }
        }
        private void CariKartEdit(string name, string vergiNo, string iletisimNo)
        {
            string SorchName = cmbSelectCari.Items[cmbSelectCari.SelectedIndex].ToString();
            int index = -1;
            if (CariKartControl(name, vergiNo, iletisimNo))
            {
                for (int i = 0; i < liste.CariListCount(); i++)
                {
                    if (liste.cariList[i].GetName() == SorchName)
                    {
                        index = i;
                    }
                }
                if (index != -1)
                {
                    liste.cariList[index].SetName(name);
                    liste.cariList[index].SetIletisimNo(iletisimNo);
                    liste.cariList[index].SetVergiNo(vergiNo);
                    dataGridView1.Rows[index].Cells[1].Value = name;
                    dataGridView1.Rows[index].Cells[2].Value = iletisimNo;
                    dataGridView1.Rows[index].Cells[3].Value = vergiNo;
                    cmbSelectCari.Items[index] = name;
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Ekle")
            {
                CariKartEkle(txtName.Text, txtVergiNo.Text, txtTelNo.Text);
                dataGridView1.ClearSelection();
            }
            else if (button2.Text == "Güncelle")
            {
                CariKartEdit(txtName.Text, txtVergiNo.Text, txtTelNo.Text);
                dataGridView1.ClearSelection();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaSec = new OpenFileDialog();
            dosyaSec.Filter = "Excel Dosyası (*.xlsx)|*.xlsx";
            if (dosyaSec.ShowDialog() == DialogResult.OK)
            {
                string dosyaYolu = dosyaSec.FileName;
                using (XLWorkbook excelDosyasi = new XLWorkbook(dosyaYolu))
                {
                    int newCariKartSayisi = 0;
                    IXLWorksheet sayfa = excelDosyasi.Worksheet(1);
                    bool calis = true;
                    int satir = 2;
                    while (calis)
                    {
                        string hucreVeri = sayfa.Cell(satir, 1).GetString();
                        if (hucreVeri != "")
                        {
                            newCariKartSayisi++;
                            satir++;
                        }
                        else
                            calis = false;
                    }
                    for (int i = 0; i < newCariKartSayisi; i++)
                    {
                        string name;
                        string vergiNo;
                        string iletisimNo;
                        //bool durum;
                        name = sayfa.Cell(i + 2, 1).GetString();
                        iletisimNo = sayfa.Cell(i + 2, 3).GetString();
                        vergiNo = sayfa.Cell(i + 2, 2).GetString();
                        CariClass cari = new CariClass();
                        liste.AddCariList(cari);
                        liste.cariList[liste.CariListCount() - 1].SetName(name);
                        liste.cariList[liste.CariListCount() - 1].SetIletisimNo(iletisimNo);
                        liste.cariList[liste.CariListCount() - 1].SetVergiNo(vergiNo);
                        dataGridView1.Rows.Add(liste.CariListCount(), cari.GetName(),cari.GetIletisimNo(), cari.GetVergiNo());
                        cmbSelectCari.Items.Add(cari.GetName());
                    }
                }
            }
        }

        private void InToExcell_Click(object sender, EventArgs e)
        {
            SaveFileDialog dosyaKaydet = new SaveFileDialog();
            dosyaKaydet.Filter = "Excel Dosyası (*.xlsx)|*.xlsx";
            dosyaKaydet.FileName = "Cari_Kartlar.xlsx";
            if (dosyaKaydet.ShowDialog() != DialogResult.OK)
                return;
            using (XLWorkbook excelDosyasi = new XLWorkbook())
            {
                int satır = 2;

                IXLWorksheet sayfa = excelDosyasi.Worksheets.Add("Cari_Kartlar");
                sayfa.Cell(1, 1).Value = "Unvan";
                sayfa.Cell(1, 2).Value = "Iletisim No";
                sayfa.Cell(1, 3).Value = "Vergi No";
                sayfa.Cell(1,4).Value = "Toplam Alınan Mal";
                sayfa.Cell(1, 5).Value = "Toplam Ödenen Tutar";
                sayfa.Cell(1, 6).Value = "Toplam Borç";
                for (int i = 0; i < liste.CariListCount(); i++)
                {
                    CariClass cari = liste.cariList[i];
                    sayfa.Cell(satır + i, 1).Value = cari.GetName();
                    sayfa.Cell(satır + i, 2).Value = cari.GetIletisimNo();
                    sayfa.Cell(satır + i, 3).Value = cari.GetVergiNo();
                    sayfa.Cell(satır + i, 4).Value = cari.GetTopAlinanMal();
                    sayfa.Cell(satır + i, 5).Value = cari.GetTopOdenenTutar();
                    sayfa.Cell(satır + i, 6).Value = cari.GetTopBorc();
                }
                excelDosyasi.SaveAs(dosyaKaydet.FileName);
            }
        }
    }
}