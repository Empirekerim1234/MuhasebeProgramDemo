using ClosedXML.Excel;
using DocumentFormat.OpenXml.Drawing.Charts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoMuhasebeProgram.Classes
{
    public class Excell
    {

    }
    public class ReceteExcell
    {
        public bool ExvelleReceteVeriAktar(ComboBox cmbUrunName, DataGridView dataGridView1, Recete recete, ComboBox cmbSelected)
        {
            string stdBas = "Recete";
            string urunAdi = cmbUrunName.Text;
            string stdSon = ".xlsx";
            SaveFileDialog dosyaKaydet = new SaveFileDialog();
            string FileName = stdBas + "-" + urunAdi + stdSon;
            dosyaKaydet.Filter = "Excel Dosyası (*.xlsx)|*.xlsx";
            dosyaKaydet.FileName = FileName;
            if (dosyaKaydet.ShowDialog() != DialogResult.OK) return false;
            using (XLWorkbook excelDosyasi = new XLWorkbook())
            {
                int satır = 1;
                IXLWorksheet sayfa = excelDosyasi.Worksheets.Add("Recete");
                sayfa.Cell(satır, 1).Value = "Ürün Adı: ";
                sayfa.Cell(satır, 2).Value = urunAdi;
                satır++;
                for (int i = 0; i < dataGridView1.ColumnCount; i++) sayfa.Cell(satır, i + 1).Value = dataGridView1.Columns[i].HeaderText;
                satır++;
                for (int i = 0; i < recete.satirList.Count; i++)
                {
                    sayfa.Cell(satır + i, 1).Value = recete.satirList[i].satirId;
                    sayfa.Cell(satır + i, 2).Value = recete.satirList[i].hammaddeAd;
                    sayfa.Cell(satır + i, 3).Value = recete.satirList[i].miktar;
                    sayfa.Cell(satır + i, 4).Value = recete.satirList[i].birim;
                }
                excelDosyasi.SaveAs(dosyaKaydet.FileName);
                recete.SatisUrunNamse = urunAdi;
                cmbSelected.Items.Clear();
            }
            return true;
        }
        public void ExcelldenReceteVeriAlmaFunctions(ComboBox cmbUrunName, Recete recete, DataGridView dataGridView1, ComboBox cmbSelected)
        {
            OpenFileDialog dosyaSec = new OpenFileDialog();
            dosyaSec.Filter = "Excel Dosyası (*.xlsx)|*.xlsx";
            if (dosyaSec.ShowDialog() == DialogResult.OK)
            {
                string dosyaYolu = dosyaSec.FileName;
                using (XLWorkbook excelDosyasi = new XLWorkbook(dosyaYolu))
                {
                    int newReceteSayisi = 0;
                    IXLWorksheet sayfa = excelDosyasi.Worksheet(1);
                    bool calis = true;
                    int satir = 3;
                    cmbUrunName.Text = sayfa.Cell(1, 2).GetString();
                    while (calis)
                    {
                        string hucreVeri = sayfa.Cell(satir, 1).GetString();
                        if (hucreVeri != "") { newReceteSayisi++; satir++; }
                        else calis = false;
                    }
                    satir = 3;
                    for (int i = 0; i < newReceteSayisi; i++)
                    {
                        ReceteSatiri receteSatiri = new ReceteSatiri();
                        receteSatiri.hammaddeAd = sayfa.Cell(i + satir, 2).GetString();
                        if (decimal.TryParse(sayfa.Cell(i + satir, 3).GetString(), out decimal mik))
                            receteSatiri.miktar = mik;
                        receteSatiri.birim = sayfa.Cell(i + satir, 4).GetString();
                        receteSatiri.satirId = recete.satirList.Count;
                        recete.satirList.Add(receteSatiri);
                        dataGridView1.Rows.Add(receteSatiri.satirId, receteSatiri.hammaddeAd, receteSatiri.miktar, receteSatiri.birim);
                        cmbSelected.Items.Add(receteSatiri.satirId);
                    }
                    recete.SatisUrunNamse = cmbUrunName.Text;
                }
            }
        }
    }
}
