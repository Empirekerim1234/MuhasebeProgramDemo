using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoMuhasebeProgram
{
    public class FaturaSatiri
    {
        public int faturaSatiriId = 0;
        public string urunName = "";
        public decimal koliIciAdet;
        public decimal miktar;
        public decimal birimFiyat;
        public decimal hamTutar;
        public decimal iskontoOrani;
        public decimal iskontoTutari;
        public decimal iskontoDahilTutar;
         public decimal kdvOrani;
         public decimal kdvTutari;
         public decimal kdvDahilTutar;
         public int degiskenSayisi = 12;
    }
    public class Fatura
    {
        public string faturaNo;
        public string CariUnven;
        public decimal toplamTutar = 0;
        public decimal toplamIskontoTutar = 0;
        public decimal ToplamKdvTutar = 0;
        public decimal ToplamHamTurar = 0;
        public DateOnly tarih;
        public List<FaturaSatiri> faturaSatiris = new List<FaturaSatiri>();
        public void FaturaHesaplamaliari()
        {
            toplamTutar = 0;
            toplamIskontoTutar = 0;
            ToplamKdvTutar = 0;
            ToplamHamTurar = 0;
            for (int i = 0; i < faturaSatiris.Count;i++)
            {
                ToplamHamTurar += faturaSatiris[i].hamTutar;
                toplamIskontoTutar += faturaSatiris[i].iskontoTutari;
                ToplamKdvTutar += faturaSatiris[i].kdvTutari;
                toplamTutar += faturaSatiris[i].kdvDahilTutar;
            }
        }
        public void FaturaSatiriEkle(FaturaSatiri faturaSatiri)
        {
            faturaSatiri.faturaSatiriId = faturaSatiris.Count;
            faturaSatiris.Add(faturaSatiri);
            FaturaHesaplamaliari();
        }
        public void FaturaSatiriDuzenle(FaturaSatiri faturaSatiri,string urunName, decimal koliIciAdet,decimal miktar,
            decimal birimFiyat, decimal iskontoOrani,decimal kdvOrani)
        {
            faturaSatiri.urunName = urunName;
            faturaSatiri.koliIciAdet = koliIciAdet;
            faturaSatiri.miktar = miktar;
            faturaSatiri.birimFiyat = birimFiyat;
            faturaSatiri.hamTutar = faturaSatiri.miktar * faturaSatiri.birimFiyat;
            faturaSatiri.iskontoOrani = iskontoOrani;
            faturaSatiri.iskontoTutari = faturaSatiri.hamTutar * (faturaSatiri.iskontoOrani / 100);
            faturaSatiri.iskontoDahilTutar = faturaSatiri.hamTutar - faturaSatiri.iskontoTutari;
            faturaSatiri.kdvOrani = kdvOrani;
            faturaSatiri.kdvTutari = faturaSatiri.iskontoDahilTutar * (faturaSatiri.kdvOrani / 100);
            faturaSatiri.kdvDahilTutar = faturaSatiri.iskontoDahilTutar + faturaSatiri.kdvTutari;
            FaturaHesaplamaliari();
        }
        public string GetFaturaSatiriDegisken(int index, int x)
        { 
            string deger = "";
            switch (x)
            {
                case 0:
                    deger = faturaSatiris[index].faturaSatiriId.ToString();
                    break;
                case 1:
                    deger = faturaSatiris[index].urunName;
                    break;
                case 2:
                    deger = faturaSatiris[index].koliIciAdet.ToString();
                    break;
                case 3:
                    deger = faturaSatiris[index].miktar.ToString();
                    break;
                case 4:
                    deger = faturaSatiris[index].birimFiyat.ToString();
                    break;
                case 5:
                    deger = faturaSatiris[index].hamTutar.ToString();
                    break;
                case 6:
                    deger = faturaSatiris[index].iskontoOrani.ToString();
                    break;
                case 7:
                    deger = faturaSatiris[index].iskontoTutari.ToString();
                    break;
                case 8:
                    deger = faturaSatiris[index].iskontoDahilTutar.ToString();
                    break;
                case 9:
                    deger = faturaSatiris[index].kdvOrani.ToString();
                    break;
                case 10:
                    deger = faturaSatiris[index].kdvTutari.ToString();
                    break;
                case 11:
                    deger = faturaSatiris[index].kdvDahilTutar.ToString();
                    break;
                default:
                    break;
            }
            return deger;
        }
        public class FaturaListe
        {
            public List<Fatura> faturaList = new List<Fatura>();
            public void FaturaListesineEkle(Fatura fatura)
            {
                faturaList.Add(fatura);
            }
        }
    }
}
