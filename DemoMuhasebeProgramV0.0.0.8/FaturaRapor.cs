using DemoMuhasebeProgram;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.Serialization;
using System.Text;
using System.Windows.Forms;
using static DemoMuhasebeProgram.Fatura;

namespace DemoMuhasebeProgram
{
    public partial class FaturaRapor : UserControl
    {
        private FaturaListe filitrelenenFaturalar = new FaturaListe();
        private FaturaListe tamFaturaListe;
        private CariList cariListe;
        bool UnvanaGoreFilitre(Fatura fatura, bool filitreAktif)
        {
            if (!filitreAktif)
                return true;
            else if (fatura.CariUnven == cmbUnvan.Text)
                return true;
            return false;
        }
        bool FaturaNoYaGoreFilitre(Fatura fatura, bool filitreAktif)
        {
            if (!filitreAktif)
                return true;
            else if (fatura.faturaNo == cmbFaturaNo.Text)
                return true;
            return false;
        }
        bool vergiNoYaGoreFilitrele(Fatura fatura, bool filitreAktif, string text)
        {
            if (!filitreAktif)
                return true;
            else if (fatura.CariUnven == text)
                return true;
            return false;
        }
        bool minTutaraGoreFilitrele(Fatura fatura, bool filitreAktrif, decimal tutar)
        {
            if (!filitreAktrif)
                return true;
            else if (fatura.toplamTutar >= tutar)
                return true;
            return false;
        }
        bool maxTutaraGoreFilitrele(Fatura fatura, bool filitreAktrif, decimal tutar)
        {
            if (!filitreAktrif)
                return true;
            else if (fatura.toplamTutar <= tutar)
                return true;
            return false;
        }
        bool tariheGoreFilitrele(Fatura fatura, bool filitreAktif)
        {
            if (!filitreAktif)
                return true;
            else if (fatura.tarih <= DateOnly.FromDateTime(dtpBitis.Value.Date) && fatura.tarih >= DateOnly.FromDateTime(dtpBaslangic.Value.Date))
                return true;
            return false;
        }
        void cmbFaturaNoDoldur()
        {
            cmbFaturaNo.Items.Clear();
            cmbFaturaNo.SelectedIndex = -1;
            for (int i = 0; i < filitrelenenFaturalar.faturaList.Count; i++)
            {
                cmbFaturaNo.Items.Add(filitrelenenFaturalar.faturaList[i].faturaNo);
            }
        }
        private void filitrele()
        {
            bool unvanVar = false;
            bool faturaNoVar = false;
            bool vergiNoVar = false;
            bool minTutarVar = false;
            bool maxTutarVar = false;
            bool tarihVar = false;
            decimal minTutar = 0;
            decimal maxTutar = 0;
            string vergiNo_yaGoreUnvan = "";
            if (cmbUnvan.SelectedIndex != -1 || cmbUnvan.Text != "")
                unvanVar = true;
            if (cmbFaturaNo.SelectedIndex != -1 || cmbFaturaNo.Text != "")
                faturaNoVar = true;
            if (cmbVergiNo.SelectedIndex != -1 || cmbVergiNo.Text != "")
                vergiNoVar = true;
            if (txtMinTutar.Text != "")
            {
                minTutar = Convert.ToDecimal(txtMinTutar.Text);
                if (minTutar != 0)
                    minTutarVar = true;
            }
            if (txtMaxTutar.Text != "")
            {
                maxTutar = Convert.ToDecimal(txtMaxTutar.Text);
                if (maxTutar != 0)
                    maxTutarVar = true;
            }
            if (dtpBaslangic.Value.Date != DateTime.Today || dtpBitis.Value.Date != DateTime.Today.AddDays(1))
                tarihVar = true;
            filitrelenenFaturalar.faturaList.Clear();
            if (vergiNoVar)
            {
                for (int i = 0; i < cariListe.cariList.Count; i++)
                {
                    if (cariListe.cariList[i].GetVergiNo() == cmbVergiNo.Text)
                    {
                        vergiNo_yaGoreUnvan = cariListe.cariList[i].GetName();
                        break;
                    }
                }
            }
            for (int i = 0; i < tamFaturaListe.faturaList.Count; i++)
            {
                bool unvanUygun, FaturaNoUygun, vergiNoUygun, minTutarUygun, maxTutarUygun, tarihUygun;
                unvanUygun = UnvanaGoreFilitre(tamFaturaListe.faturaList[i], unvanVar);
                FaturaNoUygun = FaturaNoYaGoreFilitre(tamFaturaListe.faturaList[i], faturaNoVar);
                vergiNoUygun = vergiNoYaGoreFilitrele(tamFaturaListe.faturaList[i], vergiNoVar, vergiNo_yaGoreUnvan);
                minTutarUygun = minTutaraGoreFilitrele(tamFaturaListe.faturaList[i], minTutarVar, minTutar);
                maxTutarUygun = maxTutaraGoreFilitrele(tamFaturaListe.faturaList[i], maxTutarVar, maxTutar);
                tarihUygun = tariheGoreFilitrele(tamFaturaListe.faturaList[i], tarihVar);
                if (unvanUygun && FaturaNoUygun && vergiNoUygun && minTutarUygun && maxTutarUygun && tarihUygun)
                    filitrelenenFaturalar.faturaList.Add(tamFaturaListe.faturaList[i]);
            }
            if (unvanVar || faturaNoVar || vergiNoVar || minTutarVar || maxTutarVar || tarihVar)
                dtvDoldur(filitrelenenFaturalar);
            else
                dtvDoldur(tamFaturaListe);
        }
        private void cmbDoldur(FaturaListe faturaListe)
        {
            cmbFaturaNo.Items.Clear();
            cmbUnvan.Items.Clear();
            cmbVergiNo.Items.Clear();
            for (int i = 0; i < faturaListe.faturaList.Count; i++)
            {
                cmbFaturaNo.Items.Add(faturaListe.faturaList[i].faturaNo);
            }
            for (int i = 0; i < cariListe.cariList.Count; i++)
            {
                cmbUnvan.Items.Add(cariListe.cariList[i].GetName());
                cmbVergiNo.Items.Add(cariListe.cariList[i].GetVergiNo());
            }
        }
        private void dtvDoldur(FaturaListe faturaListe)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < faturaListe.faturaList.Count; i++)
            {
                dataGridView1.Rows.Add(faturaListe.faturaList[i].faturaNo, faturaListe.faturaList[i].CariUnven, faturaListe.faturaList[i].tarih,
                    faturaListe.faturaList[i].ToplamHamTurar, faturaListe.faturaList[i].toplamIskontoTutar, faturaListe.faturaList[i].ToplamKdvTutar,
                    faturaListe.faturaList[i].toplamTutar);
            }
        }
        public FaturaRapor(FaturaListe lFatura, CariList lCari)
        {
            InitializeComponent();
            tamFaturaListe = lFatura;
            cariListe = lCari;
            dtvDoldur(tamFaturaListe);
            cmbDoldur(tamFaturaListe);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            txtMaxTutar.Text = "";
            txtMinTutar.Text = "";
            cmbFaturaNo.SelectedIndex = -1;
            cmbUnvan.SelectedIndex = -1;
            cmbVergiNo.SelectedIndex = -1;
            cmbGeriyeDonukTarih.SelectedIndex = -1;
            cmbFaturaNo.Text = "";
            cmbUnvan.Text = "";
            cmbVergiNo.Text = "";
            cmbGeriyeDonukTarih.Text = "";
            dtpBaslangic.Value = DateTime.Today;
            dtpBitis.Value = DateTime.Today.AddDays(1);
            dtvDoldur(tamFaturaListe);
            cmbDoldur(tamFaturaListe);
        }
        private void cmbUnvan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUnvan.SelectedIndex == -1)
            {
                cmbFaturaNoDoldur();
                filitrele();
            }
        }
        private void cmbVergiNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVergiNo.SelectedIndex == -1)
                filitrele();
        }
        private void cmbFaturaNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFaturaNo.SelectedIndex != -1)
                filitrele();
        }
        private void cmbFaturaNo_TextUpdate(object sender, EventArgs e)
        {
            if (cmbFaturaNo.Text != "")
                filitrele();
        }
        private void dtpBaslangic_ValueChanged(object sender, EventArgs e)
        {
            if (dtpBaslangic.Value != DateTime.Today)
                filitrele();
        }
        private void dtpBitis_ValueChanged(object sender, EventArgs e)
        {
            if (dtpBitis.Value != DateTime.Today.AddDays(1))
                filitrele();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}