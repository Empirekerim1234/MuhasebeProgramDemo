using ClosedXML.Excel;
using DemoMuhasebeProgram.Classes;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security;
using System.Text;
using System.Windows.Forms;
using static DemoMuhasebeProgram.Personel_Islemleri;
using static System.Net.Mime.MediaTypeNames;
namespace DemoMuhasebeProgram
{
    public partial class Personel_Islemleri : UserControl
    {
        PersonelListe personelList;
        public enum Mod
        {
            New, Edit_Is_Not_Selected, Edit_Is_Selected, Empty
        }
        Mod modum = new Mod();
        public enum girisHataKodu
        {
            Dogru, AdYanlis, SoyadYanlis, TcYanlis, TelYanlis, AynıIsimVeSoyisimdeKayitVar
        }

        private void SetMod()
        {
            if (modum == Mod.New)
            {
                txtName.Enabled = true;
                txtLastName.Enabled = true;
                txtTC.Enabled = true;
                txtTelNo.Enabled = true;
                checkBox1.Enabled = true;
                comboBox1.Enabled = false;
                button1.Enabled = true;
                button1.Text = "Ekle";
                button1.Visible = true;
                comboBox1.Text = "";
                txtName.Text = "";
                txtLastName.Text = "";
                txtTC.Text = "";
                txtTelNo.Text = "";
            }
            else if (modum == Mod.Edit_Is_Not_Selected)
            {
                txtName.Enabled = false;
                txtLastName.Enabled = false;
                txtTC.Enabled = false;
                txtTelNo.Enabled = false;
                checkBox1.Enabled = false;
                comboBox1.Enabled = true;
                button1.Enabled = false;
                button1.Text = "Güncelle";
                button1.Visible = true;
                txtName.Text = "";
                txtLastName.Text = "";
                txtTC.Text = "";
                txtTelNo.Text = "";
            }
            else if (modum == Mod.Edit_Is_Selected)
            {
                txtName.Enabled = true;
                txtLastName.Enabled = true;
                txtTC.Enabled = true;
                txtTelNo.Enabled = true;
                checkBox1.Enabled = true;
                comboBox1.Enabled = true;
                button1.Enabled = true;
                button1.Text = "Güncelle";
                button1.Visible = true;
            }
            else if (modum == Mod.Empty)
            {
                txtName.Enabled = false;
                txtLastName.Enabled = false;
                txtTC.Enabled = false;
                txtTelNo.Enabled = false;
                checkBox1.Enabled = false;
                comboBox1.Enabled = false;
                button1.Enabled = false;
                button1.Text = " ";
                button1.Visible = false;
            }
        }
        void comboAndGiridLoad(PersonelListe personelList)
        {
            if (dataGridView1.Rows.Count != 0)
                dataGridView1.Rows.Clear();
            if (comboBox1.Items.Count != 0)
                comboBox1.Items.Clear();
            foreach (var kart in personelList.personels)
            {
                dataGridView1.Rows.Add(kart.name, kart.lastName, kart.tcNo, kart.telNo, kart.durum);
                comboBox1.Items.Add(kart.name + " " + kart.lastName);
            }
        }
        public Personel_Islemleri(PersonelListe lPersonel)
        {
            InitializeComponent();
            personelList = lPersonel;
            modum = Mod.Empty;
            comboAndGiridLoad(personelList);
            SetMod();
        }
        private bool InOnlyNumbre(string txt)
        {
            bool isOnlyNumber = true;
            for (int i = 0; i < txt.Length; i++)
            {
                switch (txt[i])
                {
                    case '0':
                        break;
                    case '1':
                        break;
                    case '2':
                        break;
                    case '3':
                        break;
                    case '4':
                        break;
                    case '5':
                        break;
                    case '6':
                        break;
                    case '7':
                        break;
                    case '8':
                        break;
                    case '9':
                        break;
                    default:
                        isOnlyNumber = false;
                        break;
                }
            }
            return isOnlyNumber;
        }
        bool inToTheNumber(string txt)
        {
            bool inToTheNumber = false;
            for (int i = 0; i < txt.Length; i++)
            {
                switch (txt[i])
                {
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        inToTheNumber = true;
                        break;
                    default:
                        break;
                }
            }
            return inToTheNumber;
        }
        girisHataKodu PersonelKayitOnayi(PersonelListe personelList, string name, string lastName, string tcNo, string telNo)
        {
            if (txtName.Text.Length >= 2 && !inToTheNumber(txtName.Text))
            {
                name = txtName.Text;
            }
            else
            {
                return girisHataKodu.AdYanlis;
            }
            if (txtLastName.Text.Length >= 2 && !inToTheNumber(txtLastName.Text))
            {
                lastName = txtLastName.Text;
            }
            else
            {
                return girisHataKodu.SoyadYanlis;
            }
            if (InOnlyNumbre(txtTC.Text) && txtTC.Text.Length == 11)
            {
                tcNo = txtTC.Text;
            }
            else
            {
                return girisHataKodu.TcYanlis;
            }
            if (InOnlyNumbre(txtTelNo.Text) && txtTelNo.Text.Length == 10)
            {
                telNo = txtTelNo.Text;
            }
            else
            {
                return girisHataKodu.TelYanlis;
            }
            if (personelList.personels.Count != 0)
            {
                for (int i = 0; i < personelList.personels.Count; i++)
                {
                    if (name == personelList.personels[i].name && lastName == personelList.personels[i].lastName)
                    {
                        return girisHataKodu.AynıIsimVeSoyisimdeKayitVar;
                    }
                }
            }
            return girisHataKodu.Dogru;
        }
        private void ComboAndGridGuncelle(Personel personel, int index)
        {
            comboBox1.Items[index] = personel.name + " " + personel.lastName;
            dataGridView1.Rows[index].Cells[1].Value = personel.name;
            dataGridView1.Rows[index].Cells[2].Value = personel.lastName;
            dataGridView1.Rows[index].Cells[3].Value = personel.tcNo;
            dataGridView1.Rows[index].Cells[4].Value = personel.telNo;
            dataGridView1.Rows[index].Cells[5].Value = personel.durum;
        }
        girisHataKodu PersonelGuncellemeOnayi(PersonelListe personelList, string name, string lastName, string tcNo, string telNo, int index)
        {
            if (txtName.Text.Length >= 2 && !inToTheNumber(txtName.Text))
            {
                name = txtName.Text;
            }
            else
            {
                return girisHataKodu.AdYanlis;
            }
            if (txtLastName.Text.Length >= 2 && !inToTheNumber(txtLastName.Text))
            {
                lastName = txtLastName.Text;
            }
            else
            {
                return girisHataKodu.SoyadYanlis;
            }
            if (InOnlyNumbre(txtTC.Text) && txtTC.Text.Length == 11)
            {
                tcNo = txtTC.Text;
            }
            else
            {
                return girisHataKodu.TcYanlis;
            }
            if (InOnlyNumbre(txtTelNo.Text) && txtTelNo.Text.Length == 10)
            {
                telNo = txtTelNo.Text;
            }
            else
            {
                return girisHataKodu.TelYanlis;
            }
            if (personelList.personels.Count != 0)
            {
                for (int i = 0; i < personelList.personels.Count; i++)
                {
                    if (name == personelList.personels[i].name && lastName == personelList.personels[i].lastName && personelList.personels[i] != personelList.personels[index])
                    {
                        return girisHataKodu.AynıIsimVeSoyisimdeKayitVar;
                    }
                }
            }
            return girisHataKodu.Dogru;
        }
        bool HataKoduKontrol(girisHataKodu hataKodu)
        {
            if (hataKodu == girisHataKodu.Dogru)
            {
                return true;
            }
            else if (hataKodu == girisHataKodu.AdYanlis)
            {
                MessageBox.Show("Personel Adı En Az 2 Karakterden Oluşmalıdır. Ve Sadece Harf İçermelidir.");
            }
            else if (hataKodu == girisHataKodu.SoyadYanlis)
            {
                MessageBox.Show("Personel Soyadı En Az 2 Karakterden Oluşmalıdır. Ve Sadece Harf İçermelidir.");
            }
            else if (hataKodu == girisHataKodu.TcYanlis)
            {
                MessageBox.Show("Tc Numarası Sadece Rakam İçermeli Ve 11 Haneli Olmalıdır.");
            }
            else if (hataKodu == girisHataKodu.TelYanlis)
            {
                MessageBox.Show("Telefon Numarası Sadece Rakam İçermeli Ve 10 Haneli Olmalıdır.\n" + "Örnek:5551234567 şekinde giriniz!");
            }
            else if (hataKodu == girisHataKodu.AynıIsimVeSoyisimdeKayitVar)
            {
                MessageBox.Show("Aynı Isim Soyisim De Personel Zaten Var Farklı Bir Kayıt İşlemi Yapınız");
            }
            return false;
        }
        void PersonelKayitModu(PersonelListe personelList)
        {
            string name = txtName.Text;
            string lastName = txtLastName.Text;
            string tc = txtTC.Text;
            string tel = txtTelNo.Text;
            bool durum = checkBox1.Checked;
            if (HataKoduKontrol(PersonelKayitOnayi(personelList, name, lastName, tc, tel)))
            {
                Personel personel = new Personel();
                personelList.personelKaydet(personel, name, lastName, tc, tel, durum);
                dataGridView1.Rows.Add(personel.kod, personel.name, personel.lastName, personel.tcNo, personel.telNo, personel.durum);
                comboBox1.Items.Add(personel.name + " " + personel.lastName);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string name = "", lastName = "", telNo = "", tcNo = "";
            bool durum = checkBox1.Checked;
            if (modum == Mod.New)
            {
                PersonelKayitModu(personelList);
            }
            else if (modum == Mod.Edit_Is_Selected)
            {
                int index = Convert.ToInt32(txtPersonelKod.Text);
                if (HataKoduKontrol(PersonelGuncellemeOnayi(personelList, name, lastName, tcNo, telNo, index)))
                {
                    personelList.personels[index].name = txtName.Text;
                    personelList.personels[index].lastName = txtLastName.Text;
                    personelList.personels[index].tcNo = txtTC.Text;
                    personelList.personels[index].telNo = txtTelNo.Text;
                    personelList.personels[index].durum = checkBox1.Checked;
                    ComboAndGridGuncelle(personelList.personels[index], index);
                }
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            modum = Mod.New;
            SetMod();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            modum = Mod.Edit_Is_Not_Selected;
            SetMod();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            modum = Mod.Edit_Is_Selected;
            SetMod();
            txtName.Text = personelList.personels[index].name;
            txtLastName.Text = personelList.personels[index].lastName;
            txtTC.Text = personelList.personels[index].tcNo;
            txtTelNo.Text = personelList.personels[index].telNo;
            txtPersonelKod.Text = personelList.personels[index].kod.ToString();
            checkBox1.Checked = personelList.personels[index].durum;
        }
        private void InToExcell_Click(object sender, EventArgs e)
        {
            SaveFileDialog dosyaKaydet = new SaveFileDialog();
            dosyaKaydet.Filter = "Excel Dosyası (*.xlsx)|*.xlsx";
            dosyaKaydet.FileName = "Personeller.xlsx";
            if (dosyaKaydet.ShowDialog() != DialogResult.OK)
                return;
            using (XLWorkbook excelDosyasi = new XLWorkbook())
            {
                int satır = 2;

                IXLWorksheet sayfa = excelDosyasi.Worksheets.Add("Personeller");
                sayfa.Cell(1, 1).Value = "Ad";
                sayfa.Cell(1, 2).Value = "Soyad";
                sayfa.Cell(1, 3).Value = "TC";
                sayfa.Cell(1, 4).Value = "Telefon";
                sayfa.Cell(1, 5).Value = "Durum";
                for (int i = 0; i < personelList.personels.Count; i++)
                {
                    sayfa.Cell(satır + i, 1).Value = personelList.personels[i].name;
                    sayfa.Cell(satır + i, 2).Value = personelList.personels[i].lastName;
                    sayfa.Cell(satır + i, 3).Value = personelList.personels[i].tcNo;
                    sayfa.Cell(satır + i, 4).Value = personelList.personels[i].telNo;
                    if (personelList.personels[i].durum == true)
                        sayfa.Cell(satır + i, 5).Value = "aktif";
                    else
                        sayfa.Cell(satır + i, 5).Value = "pasif";
                }
                excelDosyasi.SaveAs(dosyaKaydet.FileName);
            }
        }
        private void OutToExcell_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaSec = new OpenFileDialog();
            dosyaSec.Filter = "Excel Dosyası (*.xlsx)|*.xlsx";
            if (dosyaSec.ShowDialog() == DialogResult.OK)
            {
                string dosyaYolu = dosyaSec.FileName;
                using (XLWorkbook excelDosyasi = new XLWorkbook(dosyaYolu))
                {
                    int newPersonelSayisi = 0;
                    IXLWorksheet sayfa = excelDosyasi.Worksheet(1);
                    bool calis = true;
                    int satir = 2;
                    while (calis)
                    {
                        string hucreVeri = sayfa.Cell(satir, 1).GetString();
                        if (hucreVeri != "")
                        {
                            newPersonelSayisi++;
                            satir++;
                        }
                        else
                            calis = false;
                    }
                    for (int i = 0; i < newPersonelSayisi; i++)
                    {
                        string name;
                        string lastName;
                        string tc;
                        string tel;
                        bool durum;
                        name = sayfa.Cell(i + 2, 1).GetString();
                        lastName = sayfa.Cell(i + 2, 2).GetString();
                        tc = sayfa.Cell(i + 2, 3).GetString();
                        tel = sayfa.Cell(i + 2, 4).GetString();
                        if (sayfa.Cell(i + 2, 5).GetString() == "pasif")
                            durum = false;
                        else
                            durum = true;
                        Personel personel = new Personel();
                        personelList.personelKaydet(personel, name, lastName, tc, tel, durum);
                        dataGridView1.Rows.Add(personel.kod, personel.name, personel.lastName, personel.tcNo, personel.telNo, personel.durum);
                        comboBox1.Items.Add(personel.name + " " + personel.lastName);
                    }
                }
            }
        }
    }
}