using ClosedXML.Excel;
using DemoMuhasebeProgram.Classes;
using DocumentFormat.OpenXml.Office.CustomUI;
using Microsoft.VisualBasic;

namespace DemoMuhasebeProgram.UserControls
{
    public partial class ReceteTanimla : UserControl
    {
        private Recete recete;
        private SatisUrunListe satisUrunListe;
        private ReceteList receteList;
        private ReceteExcell excell;
        enum Mod {bos, yeni, seçimyok, seçimvar}
        private void ModAyar(Mod mod)
        {
            switch (mod)
            {
                case Mod.bos:
                    cmbSelected.Enabled = false;
                    cmbUrunName.Enabled = false;
                    cmbHammaddeName.Enabled = false;
                    cmbBirim.Enabled = false;
                    txtMiktar.Enabled = false;
                    cmbSelected.SelectedIndex = -1;
                    cmbBirim.SelectedIndex = -1;
                    cmbUrunName.SelectedIndex = -1;
                    cmbHammaddeName.SelectedIndex = -1;
                    cmbBirim.Text = "";
                    cmbSelected.Text = "";
                    cmbHammaddeName.Text = "";
                    txtMiktar.Text = "";
                    btnOk.Enabled = false;
                    btnOk.Text = "";
                    break;
                case Mod.yeni:
                    cmbSelected.Enabled = false;
                    cmbUrunName.Enabled = true;
                    cmbHammaddeName.Enabled = true;
                    cmbBirim.Enabled = true;
                    txtMiktar.Enabled = true;
                    cmbSelected.SelectedIndex = -1;
                    cmbBirim.SelectedIndex = -1;
                    cmbHammaddeName.SelectedIndex = -1;
                    cmbBirim.Text = "";
                    cmbSelected.Text = "";
                    cmbHammaddeName.Text = "";
                    txtMiktar.Text = "";
                    btnOk.Enabled = true;
                    btnOk.Text = "Ekle";
                    break;
                case Mod.seçimyok:
                    cmbSelected.Enabled = true;
                    cmbUrunName.Enabled = false;
                    cmbHammaddeName.Enabled = false;
                    cmbBirim.Enabled = false;
                    txtMiktar.Enabled = false;
                    cmbSelected.SelectedIndex = -1;
                    cmbBirim.SelectedIndex = -1;
                    cmbHammaddeName.SelectedIndex = -1;
                    cmbBirim.Text = "";
                    cmbSelected.Text = "";
                    cmbHammaddeName.Text = "";
                    txtMiktar.Text = "";
                    btnOk.Enabled = false;
                    btnOk.Text = "Güncelle";
                    break;
                case Mod.seçimvar:
                    cmbSelected.Enabled = true;
                    cmbUrunName.Enabled = true;
                    cmbHammaddeName.Enabled = true;
                    cmbBirim.Enabled = true;
                    txtMiktar.Enabled = true;
                    if (int.TryParse(cmbSelected.Text, out int i))
                    {cmbHammaddeName.Text = recete.satirList[i].hammaddeAd; txtMiktar.Text = recete.satirList[i].miktar.ToString();cmbBirim.Text = recete.satirList[i].birim;}
                    btnOk.Enabled = true;
                    btnOk.Text = "Güncelle";
                    break;
                default:
                    break;
            }
        }
        private void cmbDoldur()
        { for (int i = 0; i < satisUrunListe.satisUruns.Count; i++) cmbUrunName.Items.Add(satisUrunListe.satisUruns[i].ad); }
        public ReceteTanimla(SatisUrunListe lSatis, ReceteList lRecete)
        {
            InitializeComponent();
            Recete newRecete = new Recete();
            ReceteExcell newexcell = new ReceteExcell();
            excell = newexcell;
            recete = newRecete; receteList = lRecete; satisUrunListe = lSatis;
            ModAyar(Mod.bos);
            cmbDoldur();
            for (int i = 0; i < receteList.receteList.Count; i++) cmbSelectedRecete.Items.Add(receteList.receteList[i].SatisUrunNamse);
        }
        private void btnNew_Click(object sender, EventArgs e)
        { ModAyar(Mod.yeni); }
        private void btnEdit_Click(object sender, EventArgs e)
        { ModAyar(Mod.seçimyok); }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (btnOk.Text == "Ekle")
            {
                ReceteSatiri newReceteSatiri = new ReceteSatiri();
                newReceteSatiri.hammaddeAd = cmbHammaddeName.Text;
                if (decimal.TryParse(txtMiktar.Text, out decimal mik)) newReceteSatiri.miktar = mik;
                newReceteSatiri.birim = cmbBirim.Text;
                newReceteSatiri.satirId = recete.satirList.Count;
                recete.satirList.Add(newReceteSatiri);
                dataGridView1.Rows.Add(newReceteSatiri.satirId, newReceteSatiri.hammaddeAd, newReceteSatiri.miktar, newReceteSatiri.birim);
                cmbSelected.Items.Add(newReceteSatiri.satirId);
            }
            else if (btnOk.Text == "Güncelle")
            {
                for (int i = 0; i < recete.satirList.Count; i++)
                {
                    if (cmbSelected.Text == recete.satirList[i].satirId.ToString())
                    {
                        recete.satirList[i].hammaddeAd = cmbHammaddeName.Text;
                        if (decimal.TryParse(txtMiktar.Text, out decimal mik)) recete.satirList[i].miktar = mik;
                        recete.satirList[i].birim = cmbBirim.Text;
                        dataGridView1.Rows[i].SetValues(recete.satirList[i].satirId, recete.satirList[i].hammaddeAd, recete.satirList[i].miktar, recete.satirList[i].birim);
                    }
                }
            }
        }
        private void ReceteKaydet(Recete inRecete)
        {
            int index = -1;
            bool Sonuc = false;
            dataGridView1.Rows.Clear();
            for (int i = 0; i < receteList.receteList.Count; i++)
            {
                if (cmbUrunName.Text == receteList.receteList[i].SatisUrunNamse)
                {
                    index = i;
                    DialogResult sonuc = MessageBox.Show("Seçili Ürünün Zaten Reçetesi Var Kaydedilirse Eski Reçete Yerine Yazılıcak!\nHayıra Basarsanız İşlemler Temizlenicek Sayfa Sıfırlanıcak", "Onaylıyormusunuz?", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                    if (sonuc == DialogResult.Yes) Sonuc = true;
                    break;
                }
            }
            if (index != -1) {if (Sonuc) receteList.receteList[index] = recete;}
            else receteList.receteList.Add(inRecete);
            Recete yeniRecete = new Recete();
            recete = yeniRecete;
        }
        private void InToExcell_Click(object sender, EventArgs e)
        {
            if (cmbUrunName.Text == "")
                MessageBox.Show("Fatura Kaydı İçin Firma Ünvenı Semelisiniz.");
            else 
            {
                if (excell.ExvelleReceteVeriAktar(cmbUrunName,dataGridView1,recete,cmbSelected)) 
                    ReceteKaydet(recete);
            }
        }

        private void btnOutTheExcell_Click(object sender, EventArgs e)
        { excell.ExcelldenReceteVeriAlmaFunctions(cmbUrunName,recete,dataGridView1,cmbSelected);}
        private void cmbSelected_SelectedIndexChanged(object sender, EventArgs e)
        { if (cmbSelected.SelectedIndex != -1) ModAyar(Mod.seçimvar); }
        private void ExcelldenTopluVeriAlmaFunctions()
        {
            ReceteList eklemeBasariliOlursaKabulEdilecekListe = new ReceteList();
            for (int i = 0; i < receteList.receteList.Count; i++)
            {
                Recete yenirecete = new Recete();
                yenirecete.SatisUrunNamse = receteList.receteList[i].SatisUrunNamse;
                eklemeBasariliOlursaKabulEdilecekListe.receteList.Add(yenirecete);
                for (int j = 0; j < receteList.receteList[i].satirList.Count; j++)
                    eklemeBasariliOlursaKabulEdilecekListe.receteList[i].satirList.Add(receteList.receteList[i].satirList[j]);
            }
            OpenFileDialog dosyaSec = new OpenFileDialog();
            dosyaSec.Filter = "Excel Dosyası (*.xlsx)|*.xlsx";
            if (dosyaSec.ShowDialog() == DialogResult.OK)
            {
                string dosyaYolu = dosyaSec.FileName;
                using (XLWorkbook excelDosyasi = new XLWorkbook(dosyaYolu))
                {
                    int newReceteSatiriSayisi = 0;
                    IXLWorksheet sayfa = excelDosyasi.Worksheet(1);
                    bool calis = true;
                    int satir = 3;
                    while (calis)
                    {
                        string hucreVeri = sayfa.Cell(satir, 1).GetString();
                        if (hucreVeri != "") { newReceteSatiriSayisi++; satir++; }
                        else calis = false;
                    }
                    satir = 3;
                    bool hatalıEslesme = false;
                    for (int i = 0; i < newReceteSatiriSayisi; i++)
                    {
                        int ReceteId = -1;
                        ReceteSatiri receteSatiri = new ReceteSatiri();
                        for (int j = 0; j < eklemeBasariliOlursaKabulEdilecekListe.receteList.Count; j++)
                        {
                            if (sayfa.Cell(satir + i, 2).GetString() == eklemeBasariliOlursaKabulEdilecekListe.receteList[j].SatisUrunNamse)
                            {ReceteId = j;break;}
                        }
                        if (ReceteId != -1)
                        {
                            if (decimal.TryParse(sayfa.Cell(i + satir, 4).GetString(), out decimal mik))
                            {
                                receteSatiri.miktar = mik;
                                receteSatiri.hammaddeAd = sayfa.Cell(i + satir, 3).GetString();
                                receteSatiri.birim = "Kg";
                                receteSatiri.satirId = eklemeBasariliOlursaKabulEdilecekListe.receteList[ReceteId].satirList.Count;
                                eklemeBasariliOlursaKabulEdilecekListe.receteList[ReceteId].satirList.Add(receteSatiri);
                            }
                            else { MessageBox.Show("Reçete Satırı Eklenemedi: " + i); hatalıEslesme = true; break; }
                        }
                        else
                        {
                            if (decimal.TryParse(sayfa.Cell(i + satir, 4).GetString(), out decimal mik))
                            {
                                receteSatiri.miktar = mik;
                                Recete newRecete = new Recete();
                                newRecete.SatisUrunNamse = sayfa.Cell(satir + i, 2).GetString();
                                receteSatiri.hammaddeAd = sayfa.Cell(i + satir, 3).GetString();
                                receteSatiri.birim = "Kg";
                                receteSatiri.satirId = newRecete.satirList.Count;
                                newRecete.satirList.Add(receteSatiri);
                                eklemeBasariliOlursaKabulEdilecekListe.receteList.Add(newRecete);
                            }
                            else
                            {MessageBox.Show("Reçete Satırı Eklenemedi: " + i);hatalıEslesme = true;break;}
                        }
                    }
                    if (!hatalıEslesme)
                    {receteList.receteList = eklemeBasariliOlursaKabulEdilecekListe.receteList;MessageBox.Show("Excellden veri aktarımı başarılı bir şekilde aktarıldı");}
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {ExcelldenTopluVeriAlmaFunctions();}
        private void cmbSelectedRecete_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelectedRecete.SelectedIndex != -1)
            {
                dataGridView1.Rows.Clear();
                for (int i = 0; i < receteList.receteList.Count; i++)
                {
                    if (receteList.receteList[i].SatisUrunNamse == cmbSelectedRecete.Text)
                    {
                        cmbSelected.Items.Clear();
                        Recete copyRecete = new Recete();
                        copyRecete.receteId = receteList.receteList[i].receteId;
                        copyRecete.SatisUrunNamse = receteList.receteList[i].SatisUrunNamse;
                        cmbUrunName.Text = copyRecete.SatisUrunNamse;
                        for (int j = 0; j < receteList.receteList[i].satirList.Count; j++)
                        {
                            ReceteSatiri receteSatiri = new ReceteSatiri();
                            receteSatiri.hammaddeAd = receteList.receteList[i].satirList[j].hammaddeAd;
                            receteSatiri.birim = receteList.receteList[i].satirList[j].birim;
                            receteSatiri.miktar = receteList.receteList[i].satirList[j].miktar;
                            receteSatiri.satirId = receteList.receteList[i].satirList[j].satirId;
                            copyRecete.satirList.Add( receteSatiri );
                            cmbSelected.Items.Add(receteList.receteList[i].satirList[j].satirId);
                            dataGridView1.Rows.Add(receteList.receteList[i].satirList[j].satirId, receteList.receteList[i].satirList[j].hammaddeAd,
                                                         receteList.receteList[i].satirList[j].miktar, receteList.receteList[i].satirList[j].birim);
                        }
                        recete = copyRecete;
                        break;
                    }
                }
            }
        }
    }
}