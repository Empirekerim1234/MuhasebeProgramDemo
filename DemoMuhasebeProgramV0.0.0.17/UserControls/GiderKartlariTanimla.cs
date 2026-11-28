using ClosedXML.Excel;
using DemoMuhasebeProgram.Classes;
using DemoMuhasebeProgram.YardımcıClass;
using DocumentFormat.OpenXml.Office.CustomUI;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Vml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DemoMuhasebeProgram.UserControls
{
    public partial class GiderKartlariTanimla : UserControl
    {
        GiderKatagorileriListe katagoriListe;
        GiderKarlariListe giderKartiListe;
        private FormOlusturucu former;
        private void dtvDoldur()
        {
            if (giderKartiListe.liste.Count > 0)
            {
                dataGridView1.Rows.Clear();
                for (int i = 0; i < giderKartiListe.liste.Count; i++)
                    dataGridView1.Rows.Add(giderKartiListe.liste[i].Id, giderKartiListe.liste[i].Name, giderKartiListe.liste[i].Katagori);

            }
        }
        public GiderKartlariTanimla(GiderKatagorileriListe lKatagori, GiderKarlariListe lGider)
        {
            InitializeComponent();
            FormOlusturucu formOlusturucu = new FormOlusturucu();
            former = formOlusturucu;
            katagoriListe = lKatagori;
            giderKartiListe = lGider;
            dtvDoldur();
        }
        private void YeniKatagoriOlusturma()
        {
            //-----------------------------------------------------------
            string formTxt = "Yeni Katagori";
            int formGen = 400;
            int formYuk = 300;
            bool formSizeChanced = false;
            FormWindowState formWindowState = FormWindowState.Normal;
            FormStartPosition formStartPosition = FormStartPosition.CenterScreen;
            //-----------------------------------------------------------
            string mainPanelName = "mainPanel";
            DockStyle mainPanelDock = DockStyle.Fill;
            bool mainPanelAutoSize = false;
            //-----------------------------------------------------------
            string altPanelName = "altPanel";
            DockStyle altPanelDock = DockStyle.Bottom;
            bool altPanelAutoSize = true;
            //-----------------------------------------------------------
            string ustPanelName = "ustPanel";
            DockStyle ustPanelDock = DockStyle.Fill;
            bool ustPanelAutoSize = false;
            //-----------------------------------------------------------
            string btnKaydetName = "btnKaydet";
            string btnKaydetTxt = "Kaydet";
            int btnKaydetGen = 90;
            int btnKaydetYuk = 40;
            DockStyle btnKaydetDock = DockStyle.Top;
            //-----------------------------------------------------------
            string btnIptalName = "btnIptal";
            string btnIptalTxt = "İptal";
            int btnIptalGen = 90;
            int btnIptalYuk = 40;
            DockStyle btnIptalDock = DockStyle.Bottom;
            //-----------------------------------------------------------
            string txtKatagoriNameName = "";
            int txtGen = 125;
            int txtYuk = 70;
            DockStyle txtDock = DockStyle.None;
            //-----------------------------------------------------------
            string katagoriAdiLbName = "lbKatagoriAdi";
            string katagoriAdiLbTxt = "KatagoriAdi:";
            //-----------------------------------------------------------
            Form form = former.YeniFormAc(formTxt, formGen, formYuk, formSizeChanced, formWindowState, formStartPosition);
            Panel mainPanel = former.PanelOlustur(mainPanelName, mainPanelDock, mainPanelAutoSize);
            Panel altPanel = former.PanelOlustur(altPanelName, altPanelDock, altPanelAutoSize);
            Panel ustPanel = former.PanelOlustur(ustPanelName, ustPanelDock, ustPanelAutoSize);
            System.Windows.Forms.Button btnKaydet = former.ButtonOlustur(altPanel, btnKaydetName, btnKaydetTxt, btnKaydetGen, btnKaydetYuk, btnKaydetDock);
            System.Windows.Forms.Button btnIptal = former.ButtonOlustur(altPanel, btnIptalName, btnIptalTxt, btnIptalGen, btnIptalYuk, btnIptalDock);
            TextBox txtKatagoriName = former.txtOlustur(ustPanel, txtKatagoriNameName, txtGen, txtYuk, txtDock);
            Label katagoriAdLb = former.LableOlusturucu(katagoriAdiLbName, katagoriAdiLbTxt);

            form.Controls.Add(mainPanel);
            mainPanel.Controls.Add(altPanel);
            mainPanel.Controls.Add(ustPanel);
            ustPanel.Controls.Add(katagoriAdLb);

            txtKatagoriName.Location = new Point((ustPanel.ClientSize.Width - txtKatagoriName.Width) / 2, ustPanel.Location.Y);
            katagoriAdLb.Location = new Point(txtKatagoriName.Location.X - katagoriAdLb.Size.Width, (txtKatagoriName.Size.Height - katagoriAdLb.Size.Height) / 2);

            btnKaydet.Click += (s, e) =>
            {
                if (txtKatagoriName.Text != "")
                {
                    DialogResult sonuc = MessageBox.Show("Kaydetmek Istedigine Eminmisin.", "Kaydedilsin mi?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (sonuc == DialogResult.Yes)
                    {
                        GiderKatagori katagori = new GiderKatagori();
                        katagori.name = txtKatagoriName.Text;
                        katagoriListe.giderKatagoriListesineEkle(katagori);
                        this.Enabled = true;
                        form.Close();
                    }
                }
                else
                    MessageBox.Show("Katagori Adı Boş Olamaz.");
            };

            btnIptal.Click += (s, e) =>
            {
                DialogResult sonuc = MessageBox.Show("İptaletmek Istedigine Eminmisin.", "İptal mi?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sonuc == DialogResult.Yes)
                {
                    this.Enabled = true;
                    form.Close();
                }
            };

            form.FormClosed += (s, e) => { this.Enabled = true; };

            form.Show();
            this.Enabled = false;
        }
        private void btnNewKatagori_Click(object sender, EventArgs e)
        {
            YeniKatagoriOlusturma();
        }
        private void YeniGiderTanimla()
        {
            //-----------------------------------------------------------
            string formTxt = "Yeni Gider";
            int formGen = 400;
            int formYuk = 300;
            bool formSizeChanced = false;
            FormWindowState formWindowState = FormWindowState.Normal;
            FormStartPosition formStartPosition = FormStartPosition.CenterScreen;
            //-----------------------------------------------------------
            string mainPanelName = "mainPanel";
            DockStyle mainPanelDock = DockStyle.Fill;
            bool mainPanelAutoSize = false;
            //-----------------------------------------------------------
            string altPanelName = "altPanel";
            DockStyle altPanelDock = DockStyle.Bottom;
            bool altPanelAutoSize = true;
            //-----------------------------------------------------------
            string ustPanelName = "ustPanel";
            DockStyle ustPanelDock = DockStyle.Fill;
            bool ustPanelAutoSize = false;
            //-----------------------------------------------------------
            string btnKaydetName = "btnKaydet";
            string btnKaydetTxt = "Kaydet";
            int btnKaydetGen = 90;
            int btnKaydetYuk = 40;
            DockStyle btnKaydetDock = DockStyle.Top;
            //-----------------------------------------------------------
            string btnIptalName = "btnIptal";
            string btnIptalTxt = "İptal";
            int btnIptalGen = 90;
            int btnIptalYuk = 40;
            DockStyle btnIptalDock = DockStyle.Bottom;
            //-----------------------------------------------------------
            string cmbKatagoriSelectName = "txtKatagoriName";
            int cmbKatagoriSelectGen = 125;
            int cmbKatagoriSelectYuk = 70;
            DockStyle cmbKatagoriSelectDock = DockStyle.None;
            ComboBoxStyle comboBoxStyle = ComboBoxStyle.DropDownList;
            //-----------------------------------------------------------
            string txtGiderNameName = "txtGiderName";
            int txtGiderGen = 125;
            int txtGiderYuk = 70;
            DockStyle txtGiderDock = DockStyle.None;
            //-----------------------------------------------------------
            string katagoriAdiLbName = "lbKatagoriAdi";
            string katagoriAdiLbTxt = "KatagoriAdi:";
            //-----------------------------------------------------------
            string giderAdiLbName = "lbGiderAdi";
            string giderAdiLbTxt = "GiderAdi:";
            //-----------------------------------------------------------
            Form form = former.YeniFormAc(formTxt, formGen, formYuk, formSizeChanced, formWindowState, formStartPosition);
            Panel mainPanel = former.PanelOlustur(mainPanelName, mainPanelDock, mainPanelAutoSize);
            Panel altPanel = former.PanelOlustur(altPanelName, altPanelDock, altPanelAutoSize);
            Panel ustPanel = former.PanelOlustur(ustPanelName, ustPanelDock, ustPanelAutoSize);
            System.Windows.Forms.Button btnKaydet = former.ButtonOlustur(altPanel, btnKaydetName, btnKaydetTxt, btnKaydetGen, btnKaydetYuk, btnKaydetDock);
            System.Windows.Forms.Button btnIptal = former.ButtonOlustur(altPanel, btnIptalName, btnIptalTxt, btnIptalGen, btnIptalYuk, btnIptalDock);
            System.Windows.Forms.ComboBox cmbKatagoriSelect = former.cmbOlusturucu(ustPanel, cmbKatagoriSelectName, cmbKatagoriSelectGen, cmbKatagoriSelectYuk, cmbKatagoriSelectDock, comboBoxStyle);
            TextBox txtGiderName = former.txtOlustur(ustPanel, txtGiderNameName, txtGiderGen, txtGiderYuk, txtGiderDock); ;
            Label katagoriAdLb = former.LableOlusturucu(katagoriAdiLbName, katagoriAdiLbTxt);
            Label giderAdiLb = former.LableOlusturucu(giderAdiLbName, giderAdiLbTxt);

            form.Controls.Add(mainPanel);
            mainPanel.Controls.Add(altPanel);
            mainPanel.Controls.Add(ustPanel);
            ustPanel.Controls.Add(katagoriAdLb);
            ustPanel.Controls.Add(giderAdiLb);
            for (int i = 0; i < katagoriListe.liste.Count; i++) cmbKatagoriSelect.Items.Add(katagoriListe.liste[i].name);

            btnKaydet.Click += (s, e) =>
            {
                if (txtGiderName.Text != "" && cmbKatagoriSelect.SelectedIndex != -1)
                {
                    DialogResult sonuc = MessageBox.Show("Kaydetmek Istedigine Eminmisin.", "Kaydedilsin mi?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (sonuc == DialogResult.Yes)
                    {
                        GiderKartlari giderKarti = new GiderKartlari();
                        giderKarti.Name = txtGiderName.Text;
                        giderKarti.Katagori = cmbKatagoriSelect.Text;
                        giderKartiListe.giderKartleriListesineEkle(giderKarti);
                        dtvDoldur();
                        this.Enabled = true;
                        form.Close();
                    }
                }
                else
                    MessageBox.Show("Katagori Adı Boş Olamaz.");
            };

            btnIptal.Click += (s, e) =>
            {
                DialogResult sonuc = MessageBox.Show("İptaletmek Istedigine Eminmisin.", "İptal mi?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sonuc == DialogResult.Yes)
                {
                    this.Enabled = true;
                    form.Close();
                }
            };

            form.FormClosed += (s, e) => { this.Enabled = true; };

            form.Show();
            this.Enabled = false;
            txtGiderName.Location = new Point((ustPanel.ClientSize.Width - txtGiderName.Width) / 2, ustPanel.Location.Y);
            giderAdiLb.Location = new Point(txtGiderName.Left - giderAdiLb.Width, txtGiderName.Top + (txtGiderName.Height - giderAdiLb.Height) / 2);
            cmbKatagoriSelect.Location = new Point(txtGiderName.Left, txtGiderName.Bottom + 5);
            katagoriAdLb.Location = new Point(cmbKatagoriSelect.Left - katagoriAdLb.Width, cmbKatagoriSelect.Top + (cmbKatagoriSelect.Height - katagoriAdLb.Height) / 2);
        }
        private void btnGiderTanimla_Click(object sender, EventArgs e)
        {
            YeniGiderTanimla();
        }
        public bool ExvelleVeriAktar()
        {
            string stdBas = "GiderKartlari";
            string stdSon = ".xlsx";
            SaveFileDialog dosyaKaydet = new SaveFileDialog();
            string FileName = stdBas + stdSon;
            dosyaKaydet.Filter = "Excel Dosyası (*.xlsx)|*.xlsx";
            dosyaKaydet.FileName = FileName;
            if (dosyaKaydet.ShowDialog() != DialogResult.OK) return false;
            using (XLWorkbook excelDosyasi = new XLWorkbook())
            {
                int satır = 1;
                IXLWorksheet sayfa = excelDosyasi.Worksheets.Add(stdBas);
                for (int i = 0; i < dataGridView1.ColumnCount; i++) sayfa.Cell(satır, i + 1).Value = dataGridView1.Columns[i].HeaderText;
                satır++;
                for (int i = 0; i < giderKartiListe.liste.Count; i++)
                {
                    sayfa.Cell(satır + i, 1).Value = giderKartiListe.liste[i].Id;
                    sayfa.Cell(satır + i, 2).Value = giderKartiListe.liste[i].Name;
                    sayfa.Cell(satır + i, 3).Value = giderKartiListe.liste[i].Katagori;
                }
                excelDosyasi.SaveAs(dosyaKaydet.FileName);
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExvelleVeriAktar();
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
                    int newGiderKartiSayisi = 0;
                    IXLWorksheet sayfa = excelDosyasi.Worksheet(1);
                    bool calis = true;
                    int satir = 2;
                    while (calis)
                    {
                        string hucreVeri = sayfa.Cell(satir, 1).GetString();
                        if (hucreVeri != "") { newGiderKartiSayisi++; satir++; }
                        else calis = false;
                    }
                    satir = 2;
                    for (int i = 0; i < newGiderKartiSayisi; i++)
                    {
                        GiderKartlari giderKartlari = new GiderKartlari();
                        giderKartlari.Name = sayfa.Cell(i + satir, 2).GetString();
                        giderKartlari.Katagori = sayfa.Cell(i + satir, 3).GetString();
                        giderKartiListe.giderKartleriListesineEkle(giderKartlari);
                        dataGridView1.Rows.Add(giderKartlari.Id,giderKartlari.Name,giderKartlari.Katagori);
                    }
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ExcelldenVeriAlmaFunctions();
        }
    }
}