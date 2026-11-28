using System;
using System.Collections.Generic;
using System.Text;

namespace DemoMuhasebeProgram.Classes
{
    public class PersonelGiderSatirii
    {
        public int id = -1;
        public string PersonelName = "";
        public string Tur = "";
        public decimal fiyat = 0;
    }
    public class TarihBazlıPersonelGider
    { 
        public List<PersonelGiderSatirii> satirs = new List<PersonelGiderSatirii>();
        public DateTime tarih = DateTime.Today;
        public int id = -1;
        public void SatirEkle(PersonelGiderSatirii satir)
        {
            satir.id = satirs.Count;
            satirs.Add(satir);
        }
    }
    public class PersonelGiderListesi
    {
        public List<TarihBazlıPersonelGider> liste = new List<TarihBazlıPersonelGider>();
        public void PersonelGiderListesineEkle(TarihBazlıPersonelGider tarihBazlıPersonel)
        {
            tarihBazlıPersonel.id = liste.Count;
            liste.Add(tarihBazlıPersonel);
        }
    }
}
