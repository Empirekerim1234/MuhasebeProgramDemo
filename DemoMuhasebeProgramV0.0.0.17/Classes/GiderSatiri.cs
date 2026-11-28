using System;
using System.Collections.Generic;
using System.Text;

namespace DemoMuhasebeProgram.Classes
{
    public class GiderSatiri
    {
        public int id = -1;
        public string name = "";
        public string katagori = "";
        public decimal tutar = -1;
        public string aciklama = ".";
    }
    public class TarihselGiderListesi
    {
        public List<GiderSatiri> satirs = new List<GiderSatiri>();
        public DateTime tarih;
        public int id;
        public void tarihselGiderListesineEkele(GiderSatiri giderSatiri)
        {
            giderSatiri.id = satirs.Count;
            satirs.Add(giderSatiri);
        }
    }
    public class giderListesi
    {
        public List<TarihselGiderListesi> liste = new List<TarihselGiderListesi>();
        public void GiderListesineEkle(TarihselGiderListesi tarihselGiderListesi)
        {
            tarihselGiderListesi.id = liste.Count;
            liste.Add(tarihselGiderListesi);
        }
    }
}
