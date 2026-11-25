using ClosedXML.Excel;
using DemoMuhasebeProgram.Classes;
using DocumentFormat.OpenXml.Drawing.Charts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DemoMuhasebeProgram.UserControls
{
    public partial class ReceteListele : UserControl
    {
        private ReceteList receteList;
        private HammaddeList hammaddeList;
        private ReceteList filitreReceteList;
        void dvgDoldur()
        {
            ReceteList fReceteList = new ReceteList();
            filitreReceteList = fReceteList;
            cmbUrunName.Items.Clear();
            dataGridView1.Rows.Clear();
            cmbHammaddeAdı.Items.Clear();
            cmbUrunName.SelectedIndex = -1;
            cmbHammaddeAdı.SelectedIndex = -1;
            cmbUrunName.Text = "";
            cmbHammaddeAdı.Text = "";
            for (int i = 0; i < receteList.receteList.Count; i++)
            {
                Recete recete = new Recete();
                recete.receteId = receteList.receteList[i].receteId;
                recete.SatisUrunNamse = receteList.receteList[i].SatisUrunNamse;
                filitreReceteList.receteList.Add(recete);
                for (int j = 0; j < receteList.receteList[i].satirList.Count; j++)
                {
                    ReceteSatiri receteSatiri = new ReceteSatiri();
                    receteSatiri.birim = receteList.receteList[i].satirList[j].birim;
                    receteSatiri.hammaddeAd = receteList.receteList[i].satirList[j].hammaddeAd;
                    receteSatiri.miktar = receteList.receteList[i].satirList[j].miktar;
                    receteSatiri.satirId = receteList.receteList[i].satirList[j].satirId;
                    dataGridView1.Rows.Add(receteList.receteList[i].SatisUrunNamse, receteList.receteList[i].satirList[j].hammaddeAd, receteList.receteList[i].satirList[j].miktar, receteList.receteList[i].satirList[j].birim);
                    filitreReceteList.receteList[i].satirList.Add(receteSatiri);
                }
                cmbUrunName.Items.Add(receteList.receteList[i].SatisUrunNamse);
            }
            for (int i = 0; i < hammaddeList.HammaddeListSize(); i++)
                cmbHammaddeAdı.Items.Add(hammaddeList.hammaddeliste[i].name);
        }
        void dvgDoldur(string txt)
        {
            ReceteList fReceteList = new ReceteList();
            filitreReceteList = fReceteList;
            dataGridView1.Rows.Clear();
            for (int i = 0; i < receteList.receteList.Count; i++)
            {
                if (receteList.receteList[i].SatisUrunNamse == txt)
                {
                    Recete recete = new Recete();
                    recete.receteId = receteList.receteList[i].receteId;
                    recete.SatisUrunNamse = receteList.receteList[i].SatisUrunNamse;
                    for (int j = 0; j < receteList.receteList[i].satirList.Count; j++)
                    {
                        ReceteSatiri receteSatiri = new ReceteSatiri();
                        receteSatiri.birim = receteList.receteList[i].satirList[j].birim;
                        receteSatiri.hammaddeAd = receteList.receteList[i].satirList[j].hammaddeAd;
                        receteSatiri.miktar = receteList.receteList[i].satirList[j].miktar;
                        receteSatiri.satirId = receteList.receteList[i].satirList[j].satirId;
                        dataGridView1.Rows.Add(receteList.receteList[i].SatisUrunNamse, receteList.receteList[i].satirList[j].hammaddeAd, receteList.receteList[i].satirList[j].miktar, receteList.receteList[i].satirList[j].birim);
                        recete.satirList.Add(receteSatiri);
                    }
                    filitreReceteList.receteList.Add(recete);
                }
            }
        }
        void dvgDoldur(string txt, int x)
        {
            ReceteList fReceteList = new ReceteList();
            filitreReceteList = fReceteList;
            dataGridView1.Rows.Clear();
            for (int i = 0; i < receteList.receteList.Count; i++)
            {
                bool eslesenHammaddeVar = false;
                Recete recete = new Recete();
                recete.receteId = receteList.receteList[i].receteId;
                recete.SatisUrunNamse = receteList.receteList[i].SatisUrunNamse;
                for (int j = 0; j < receteList.receteList[i].satirList.Count; j++)
                {
                    if (receteList.receteList[i].satirList[j].hammaddeAd == txt)
                    {
                        eslesenHammaddeVar = true;
                        ReceteSatiri receteSatiri = new ReceteSatiri();
                        receteSatiri.birim = receteList.receteList[i].satirList[j].birim;
                        receteSatiri.hammaddeAd = receteList.receteList[i].satirList[j].hammaddeAd;
                        receteSatiri.miktar = receteList.receteList[i].satirList[j].miktar;
                        receteSatiri.satirId = receteList.receteList[i].satirList[j].satirId;
                        dataGridView1.Rows.Add(receteList.receteList[i].SatisUrunNamse, receteList.receteList[i].satirList[j].hammaddeAd, receteList.receteList[i].satirList[j].miktar, receteList.receteList[i].satirList[j].birim);
                        recete.satirList.Add(receteSatiri);
                    }
                }
                if(eslesenHammaddeVar)
                    filitreReceteList.receteList.Add(recete);
            }
        }
        public ReceteListele(ReceteList lRecete, HammaddeList lHammadde)
        {
            InitializeComponent();
            receteList = lRecete;
            hammaddeList = lHammadde;
            dvgDoldur();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbUrunName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUrunName.SelectedIndex != -1)
                dvgDoldur(cmbUrunName.Text);
            else
                cmbHammaddeAdı.Enabled = true;
        }
        private void cmbUrunName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (cmbUrunName.Text == "")
                    dvgDoldur();
                else
                    dvgDoldur(cmbUrunName.Text);
                e.Handled = true;
            }
        }
        private void cmbHammaddeAdı_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHammaddeAdı.SelectedIndex != -1)
                dvgDoldur(cmbHammaddeAdı.Text, 0);
            else
                cmbHammaddeAdı.Enabled = true;
        }
        private void cmbHammaddeAdı_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (cmbHammaddeAdı.Text == "")
                    dvgDoldur();
                else
                    dvgDoldur(cmbHammaddeAdı.Text, 0);
                e.Handled = true;
            }
        }
        private bool ExcelldenTopluVeriAktarmaFunctions()
        {
            string stdBas = "Recete";
            string urunAdi = cmbUrunName.Text;
            string stdSon = ".xlsx";
            SaveFileDialog dosyaKaydet = new SaveFileDialog();
            string FileName = stdBas + stdSon;
            dosyaKaydet.Filter = "Excel Dosyası (*.xlsx)|*.xlsx";
            dosyaKaydet.FileName = FileName;
            if (dosyaKaydet.ShowDialog() != DialogResult.OK) 
                return false;
            using (XLWorkbook excelDosyasi = new XLWorkbook())
            {
                int satır = 1;
                IXLWorksheet sayfa = excelDosyasi.Worksheets.Add("Recete");
                for (int i = 0; i < dataGridView1.ColumnCount; i++) sayfa.Cell(satır, i + 1).Value = dataGridView1.Columns[i].HeaderText;
                satır++;
                for (int i = 0; i < filitreReceteList.receteList.Count; i++)
                {
                    for (int j = 0; j < filitreReceteList.receteList[i].satirList.Count; j++)
                    {
                        sayfa.Cell(satır, 1).Value = filitreReceteList.receteList[i].SatisUrunNamse;
                        sayfa.Cell(satır, 2).Value = filitreReceteList.receteList[i].satirList[j].hammaddeAd;
                        sayfa.Cell(satır, 3).Value = filitreReceteList.receteList[i].satirList[j].miktar;
                        sayfa.Cell(satır, 4).Value = filitreReceteList.receteList[i].satirList[j].birim;
                        satır++;
                    }
                }
                excelDosyasi.SaveAs(dosyaKaydet.FileName);
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (ExcelldenTopluVeriAktarmaFunctions())
            { 
            
            }
        }
    }
}
