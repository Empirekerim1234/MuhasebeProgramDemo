using ClosedXML.Excel;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DemoMuhasebeProgram
{
    public partial class HammaddeKartlari : UserControl
    {
        private HammaddeList hammaddeList;
        private Form1 mainForm;
        enum Mod
        {
            Bos, YeniKayıt, DüzenleSecimYok, DüzenleSecimVar
        }
        void ModAyarları(Mod mod)
        {
            if (mod == Mod.Bos)
            {
                cmbSelect.SelectedIndex = -1;
                cmbSelect.Enabled = false;
                cmbAnaKatagori.Enabled = false;
                cmbAltKatagori.Enabled = false;
                txtHammaddeName.Enabled = false;
                button3.Enabled = false;
                button3.Text = "";
            }
            else if (mod == Mod.YeniKayıt)
            {
                cmbSelect.SelectedIndex = -1;
                cmbSelect.Enabled = false;
                cmbAnaKatagori.Enabled = true;
                cmbAltKatagori.Enabled = true;
                txtHammaddeName.Enabled = true;
                button3.Enabled = true;
                button3.Text = "Ekle";
            }
            else if (mod == Mod.DüzenleSecimYok)
            {
                cmbSelect.SelectedIndex = -1;
                cmbSelect.Enabled = true;
                cmbAnaKatagori.Enabled = false;
                cmbAltKatagori.Enabled = false;
                txtHammaddeName.Enabled = false;
                button3.Enabled = false;
                button3.Text = "Güncelle";
            }
            else if (mod == Mod.DüzenleSecimVar)
            {
                cmbSelect.Enabled = true;
                cmbAnaKatagori.Enabled = true;
                cmbAltKatagori.Enabled = true;
                txtHammaddeName.Enabled = true;
                button3.Enabled = true;
                button3.Text = "Güncelle";
            }
        }
        public HammaddeKartlari(HammaddeList hammaddeLer, Form1 form1)
        {
            InitializeComponent();
            ModAyarları(Mod.Bos);
            hammaddeList = hammaddeLer;
            mainForm = form1;
        }
        void AddToDataGrid(Hammadde hammadde)
        {
            int kod = hammadde.kod;
            string name = hammadde.name;
            string katagori = hammadde.anaKatagori;
            dataGridView1.Rows.Add(kod, name, katagori);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Ekle")
            {
                Hammadde hammadde = new Hammadde(txtHammaddeName.Text, cmbAnaKatagori.Text);
                if (hammaddeList.trueHammaddeInput(hammadde))
                {
                    hammaddeList.hammaddeAdd(hammadde);
                    AddToDataGrid(hammadde);
                    cmbSelect.Items.Add(hammadde.name);
                }
            }
            else if (button3.Text == "Güncelle")
            {
                string selectName = cmbSelect.Items[cmbSelect.SelectedIndex].ToString();
                int index = -1;
                for (int i = 0; i < hammaddeList.HammaddeListSize(); i++)
                {
                    if (hammaddeList.hammaddeliste[i].name == cmbSelect.Items[cmbSelect.SelectedIndex])
                    {
                        index = i;
                        break;
                    }
                }
                if (index != -1)
                {
                    hammaddeList.hammaddeliste[index].name = txtHammaddeName.Text;
                    hammaddeList.hammaddeliste[index].anaKatagori = cmbAnaKatagori.Text;
                    dataGridView1.Rows[index].Cells[1].Value = hammaddeList.hammaddeliste[index].name;
                    dataGridView1.Rows[index].Cells[2].Value = hammaddeList.hammaddeliste[index].anaKatagori;
                    cmbSelect.Items[cmbSelect.SelectedIndex] = hammaddeList.hammaddeliste[index].name;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModAyarları(Mod.YeniKayıt);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModAyarları(Mod.DüzenleSecimYok);
        }
        private void cmbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelect.SelectedIndex != -1)
            {
                ModAyarları(Mod.DüzenleSecimVar);
                for (int i = 0; i < hammaddeList.HammaddeListSize(); i++)
                {
                    if (hammaddeList.hammaddeliste[i].name == cmbSelect.Items[cmbSelect.SelectedIndex])
                    {
                        txtHammaddeName.Text = hammaddeList.hammaddeliste[i].name;
                        cmbAnaKatagori.Text = hammaddeList.hammaddeliste[i].anaKatagori;
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
                    int newHammaddeSayisi = 0;
                    IXLWorksheet sayfa = excelDosyasi.Worksheet(1);
                    bool calis = true;
                    int satir = 2;
                    while (calis)
                    {
                        string hucreVeri = sayfa.Cell(satir, 1).GetString();
                        if (hucreVeri != "")
                        {
                            newHammaddeSayisi++;
                            satir++;
                        }
                        else
                            calis = false;
                    }
                    for (int i = 0; i < newHammaddeSayisi; i++)
                    {
                        string name;
                        string katagori;
                        string kod;
                        string altKatagori;
                        name = sayfa.Cell(i + 2, 2).GetString();
                        katagori = sayfa.Cell(i + 2, 3).GetString();
                        kod = sayfa.Cell(i + 2, 1).GetString();
                        altKatagori = sayfa.Cell(i+2,4).GetString();
                        Hammadde hammadde = new Hammadde(name, katagori);
                        hammaddeList.hammaddeAdd(hammadde);
                        dataGridView1.Rows.Add(hammadde.kod, hammadde.name, hammadde.anaKatagori);
                        cmbSelect.Items.Add(hammadde.name);
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
            LoadingForm loading = new LoadingForm(mainForm);
            mainForm.Enabled = false;
            try
            {
                loading.Show();
                loading.Focus();
                loading.Enabled = false;
                loading.IsLocadingComplete(100, 1);
                SaveFileDialog dosyaKaydet = new SaveFileDialog();
                dosyaKaydet.Filter = "Excel Dosyası (*.xlsx)|*.xlsx";
                dosyaKaydet.FileName = "HammaddeKartlari.xlsx";
                if (dosyaKaydet.ShowDialog() != DialogResult.OK)
                    return;
                using (XLWorkbook excelDosyasi = new XLWorkbook())
                {
                    int satır = 2;

                    IXLWorksheet sayfa = excelDosyasi.Worksheets.Add("HammaddeKartlari");
                    for (int i = 0; i < dataGridView1.ColumnCount; i++)
                    {
                        sayfa.Cell(1, i + 1).Value = dataGridView1.Columns[i].HeaderText;
                    }
                    loading.IsLocadingComplete(hammaddeList.HammaddeListSize() * 3, 1);
                    for (int i = 0; i < hammaddeList.HammaddeListSize(); i++)
                    {
                        for (int i1 = 0; i1 < hammaddeList.hammaddeliste[0].degiskenSayisi; i1++)
                        {
                            sayfa.Cell(satır + i, i1 + 1).Value = hammaddeList.GetHammaddeDegisken(i, i1);
                        }
                        loading.IsLocadingComplete(hammaddeList.HammaddeListSize() * 3, i * 3);
                    }
                    excelDosyasi.SaveAs(dosyaKaydet.FileName);
                }
            }
            finally
            {
                loading.Close();
                mainForm.Enabled = true;
                mainForm.Focus();
                loading.Dispose();
            }
            
        }
        private void InToExcell_Click(object sender, EventArgs e)
        {
            ExcellVeriAktarmaButtonFunction();
        }
    }
}
