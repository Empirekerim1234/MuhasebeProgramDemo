using ClosedXML.Excel;
using DemoMuhasebeProgram.Classes;

namespace DemoMuhasebeProgram.UserControls
{
    public partial class ReceteTanimla : UserControl
    {
        private Recete recete;
        private SatisUrunListe satisUrunListe;
        private ReceteList receteList;
        enum Mod
        {
            bos, yeni, seçimyok, seçimvar
        }
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
                    cmbUrunName.SelectedIndex = -1;
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
                    {
                        cmbHammaddeName.Text = recete.satirList[i].hammaddeAd;
                        txtMiktar.Text = recete.satirList[i].miktar.ToString();
                        cmbBirim.Text = recete.satirList[i].birim;
                    }
                    btnOk.Enabled = true;
                    btnOk.Text = "Güncelle";
                    break;
                default:
                    break;
            }
        }
        private void cmbDoldur()
        {
            for (int i = 0; i < satisUrunListe.satisUruns.Count; i++)
                cmbUrunName.Items.Add(satisUrunListe.satisUruns[i].ad);
        }
        public ReceteTanimla(SatisUrunListe lSatis, ReceteList lRecete)
        {
            InitializeComponent();
            Recete newRecete = new Recete();
            recete = newRecete;
            receteList = lRecete;
            satisUrunListe = lSatis;
            ModAyar(Mod.bos);
            cmbDoldur();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            ModAyar(Mod.yeni);
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            ModAyar(Mod.seçimyok);
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (btnOk.Text == "Ekle")
            {
                ReceteSatiri newReceteSatiri = new ReceteSatiri();
                newReceteSatiri.hammaddeAd = cmbHammaddeName.Text;
                if (decimal.TryParse(txtMiktar.Text, out decimal mik))
                    newReceteSatiri.miktar = mik;
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
        public bool ExcellVeriAktarmaButtonFunction()
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
        private void ReceteKaydet(Recete inRecete)
        {
            dataGridView1.Rows.Clear();
            receteList.receteList.Add(inRecete);
            Recete yeniRecete = new Recete();
            recete = yeniRecete;
        }
        private void InToExcell_Click(object sender, EventArgs e)
        {
            if (cmbUrunName.Text == "") MessageBox.Show("Fatura Kaydı İçin Firma Ünvenı Semelisiniz.");
            else
            {
                if (ExcellVeriAktarmaButtonFunction())
                    ReceteKaydet(recete);
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
        private void btnOutTheExcell_Click(object sender, EventArgs e)
        {
            ExcelldenVeriAlmaFunctions();
        }
        private void cmbSelected_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelected.SelectedIndex != -1)
                ModAyar(Mod.seçimvar);
        }
        private void ExcelldenTopluVeriAlmaFunctions()
        {
            ReceteList eklemeBasariliOlursaKabulEdilecekListe = new ReceteList();
            for (int i = 0; i < receteList.receteList.Count; i++)
            {
                Recete yenirecete = new Recete();
                yenirecete.SatisUrunNamse = receteList.receteList[i].SatisUrunNamse;
                eklemeBasariliOlursaKabulEdilecekListe.receteList.Add(yenirecete);
                for (int j = 0; j < receteList.receteList[i].satirList.Count;j++)
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
                            {
                                ReceteId = j;
                                break;
                            } 
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
                            else
                            {
                                MessageBox.Show("Reçete Satırı Eklenemedi: " + i);
                                hatalıEslesme = true;
                                break;
                            }
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
                            {
                                MessageBox.Show("Reçete Satırı Eklenemedi: " + i);
                                hatalıEslesme = true;
                                break;
                            }
                        }
                    }
                    if (!hatalıEslesme)
                    {
                        receteList.receteList = eklemeBasariliOlursaKabulEdilecekListe.receteList;
                        MessageBox.Show("Excellden veri aktarımı başarılı bir şekilde aktarıldı");
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ExcelldenTopluVeriAlmaFunctions();
        }
    }
}