using DemoMuhasebeProgram.Classes;
using DemoMuhasebeProgram.YardımcıClass;
using DocumentFormat.OpenXml.Office2013.Excel;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DemoMuhasebeProgram.UserControls
{
    public partial class GelirKartlariTanimla : UserControl
    {
        FormOlusturucu formOlusturucu;
        GelirKartleriLiset gKartiListe;
        GelirKartiKatagoriListesi kListe;
        enum Mod
        {
            bos, yeni, secimYok, secimVar
        }
        private void ModAyar(Mod mod)
        {
            switch (mod)
            {
                case Mod.bos:
                    cmbSelect.Enabled = false;
                    cmbSelect.SelectedIndex = -1;
                    cmbSelect.Text = "";
                    panel4.Visible = false;
                    cmbTur.Enabled = false;
                    cmbTur.SelectedIndex = -1;
                    cmbTur.Text = "";
                    txtName.Enabled = false;
                    txtName.Text = "";
                    btnOk.Enabled = false;
                    btnOk.Text = "";
                    break;
                case Mod.yeni:
                    cmbSelect.Enabled = false;
                    cmbSelect.SelectedIndex = -1;
                    cmbSelect.Text = "";
                    panel4.Visible = false;
                    cmbTur.Enabled = true;
                    cmbTur.SelectedIndex = -1;
                    cmbTur.Text = "";
                    txtName.Enabled = true;
                    txtName.Text = "";
                    btnOk.Enabled = true;
                    btnOk.Text = "Ekle";
                    break;
                case Mod.secimYok:
                    cmbSelect.Enabled = true;
                    cmbSelect.SelectedIndex = -1;
                    cmbSelect.Text = "";
                    panel4.Visible = true;
                    cmbTur.Enabled = false;
                    cmbTur.SelectedIndex = -1;
                    cmbTur.Text = "";
                    txtName.Enabled = false;
                    txtName.Text = "";
                    btnOk.Enabled = false;
                    btnOk.Text = "Güncelle";
                    break;
                case Mod.secimVar:
                    cmbSelect.Enabled = false;
                    panel4.Visible = true;
                    cmbTur.Enabled = true;
                    txtName.Enabled = true;
                    btnOk.Enabled = true;
                    btnOk.Text = "Güncelle";
                    var kart = gKartiListe.liste.Find(kart=> kart.id.ToString() == cmbSelect.Text);
                    if (kart != null)
                    {
                        cmbTur.Text = kart.katagori;
                        txtName.Text = kart.name;
                    }
                    break;
            }
        }
        public GelirKartlariTanimla(GelirKartleriLiset glKart,GelirKartiKatagoriListesi gkKatagoriListe)
        {
            InitializeComponent();
            kListe = gkKatagoriListe;
            gKartiListe = glKart;
            formOlusturucu = new FormOlusturucu();
            foreach (var katagori in kListe.liste)
                cmbTur.Items.Add(katagori.name);
            foreach (var kart in gKartiListe.liste)
            {
                dataGridView1.Rows.Add(kart.id, kart.name, kart.katagori);
                cmbSelect.Items.Add(kart.id);
            }
            ModAyar(Mod.bos);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Form form = formOlusturucu.YeniFormAc("Katagori Tanımal", 318, 247, false, FormWindowState.Normal, FormStartPosition.CenterScreen);
            form.Show();
            Panel mainPanel = formOlusturucu.PanelOlustur(form,"mainPanel", DockStyle.Fill,false);
            form.Controls.Add(mainPanel);

            //Panel altPanel = formOlusturucu.PanelOlustur(mainPanel,0,80,"altPanel", DockStyle.Bottom);
            //mainPanel.Controls.Add(altPanel);
            //int ustPanelYuk = mainPanel.ClientSize.Height - altPanel.ClientSize.Height;
            //Panel ustPanel = formOlusturucu.PanelOlustur(mainPanel,0,ustPanelYuk,"ustPanel", DockStyle.Top);

            int stdBtnGen = 80, stdBtnYuk = 40;
            DockStyle stdBtnDock = DockStyle.None;
            Button btnKaydet = formOlusturucu.ButtonOlustur(mainPanel, "btnKaydet", "Kaydet", stdBtnGen, stdBtnYuk, stdBtnDock);
            Button btnIptal = formOlusturucu.ButtonOlustur(mainPanel, "btnIptal", "İptal", stdBtnGen, stdBtnYuk, stdBtnDock);

            //mainPanel.Controls.Add(ustPanel);

            int stdTxtGen = 150, stdTxtYuk = 30;
            DockStyle stdTxtDockStyle = DockStyle.None;
            TextBox txtKatagori = formOlusturucu.txtOlustur(mainPanel, "txtKatagori", stdTxtGen, stdTxtYuk, stdTxtDockStyle);
            Label lbKatagori = formOlusturucu.LableOlusturucu("lbKatagori", "Katagori Ad:");
            mainPanel.Controls.Add(lbKatagori);

            //int stdBtnSpace = 6;
            //int stdBtnLocX = (mainPanel.ClientSize.Width - (btnKaydet.Size.Width + btnIptal.Size.Width + stdBtnSpace)) / 2;
            //btnKaydet.Location = new Point(stdBtnLocX, 20);
            //stdBtnLocX += btnKaydet.Size.Width + stdBtnSpace;
            //btnIptal.Location = new Point(stdBtnLocX, 20);
            //int stdTxtLbX = (mainPanel.ClientSize.Width - (txtKatagori.Size.Width + lbKatagori.Size.Width)) / 2;
            //lbKatagori.Location = new Point(stdTxtLbX, 20);
            //stdTxtLbX += lbKatagori.Size.Width;
            //txtKatagori.Location = new Point(stdTxtLbX, 20);
            int kullandigimAlanX = formOlusturucu.ButonlarlaKullandigimGenislik(btnKaydet,btnIptal , 6);
            int locationX = mainPanel.ClientSize.Width;
            int locationY = mainPanel.ClientSize.Height;
            locationY -= (txtKatagori.Size.Height + btnKaydet.Size.Height);
            locationY = locationY / 2;
            locationX -= txtKatagori.Size.Width + lbKatagori.Size.Width;
            locationX = locationX / 2;
            lbKatagori.Location = new Point(locationX, locationY);
            locationX += lbKatagori.Size.Width;
            txtKatagori.Location = new Point(locationX, locationY);
            int space = 50;
            locationY += txtKatagori.Size.Height + space;
            locationX = mainPanel.ClientSize.Width;
            locationX -= (btnIptal.Size.Width + btnKaydet.Size.Width);
            locationX = locationX / 2;
            btnKaydet.Location = new Point(locationX, locationY);
            locationX += btnKaydet.Size.Width;
            btnIptal.Location = new Point(locationX, locationY);

            form.FormClosed += (s, e) => { this.Enabled = true; };
            btnKaydet.Click += (s, e) =>
            {
                DialogResult sonuc = MessageBox.Show("Kaydetmek İstediğinize Eminmisiniz", "Onay?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sonuc == DialogResult.Yes && txtKatagori.Text != "")
                {
                    GelirKartlariKatagori yenikatagori = new GelirKartlariKatagori();
                    yenikatagori.name = txtKatagori.Text;
                    kListe.ListeyeEkle(yenikatagori);
                    cmbTur.Items.Add(txtKatagori.Text);
                    form.Close();
                }
                else if (txtKatagori.Text == "")
                    MessageBox.Show("Katagori Adı Girmelisiniz.");
            };
            btnIptal.Click += (s, e) =>
            {
                DialogResult sonuc = MessageBox.Show("İptal Etmek İstediğinize Eminmisiniz", "Onay?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sonuc == DialogResult.Yes)
                {
                    form.Close();
                }
            };
        }
        private void cmbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbSelect.SelectedIndex != -1)
                ModAyar(Mod.secimVar);
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (btnOk.Text == "Ekle")
            {
                GelirKartlari yKart = new GelirKartlari();
                yKart.name = txtName.Text;
                yKart.katagori = cmbTur.Text;
                gKartiListe.ListeyeEkle(yKart);
                dataGridView1.Rows.Add(yKart.id,yKart.name,yKart.katagori);
                cmbSelect.Items.Add(yKart.id);
            }
            else if (btnOk.Text == "Güncelle")
            {
                var kart = gKartiListe.liste.Find(kart => kart.id.ToString() == cmbSelect.Text);
                if (kart != null)
                {
                    kart.katagori = cmbTur.Text;
                    kart.name = txtName.Text;
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[0].Value.ToString() == kart.id.ToString())
                            dataGridView1.Rows[i].SetValues(kart.id,kart.name,kart.katagori);
                    }
                }
                else
                    MessageBox.Show("Bir Hata Oluştu!");
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            ModAyar(Mod.yeni);
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            ModAyar(Mod.secimYok);
        }
    }
}
