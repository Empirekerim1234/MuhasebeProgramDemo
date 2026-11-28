using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace DemoMuhasebeProgram.Classes
{
    public class GelirKartlari
    {
        public int id = -1;
        public string name = "";
        public string katagori = "";
    }
    public class GelirKartlariKatagori
    {
        public int id = -1;
        public string name = "";
    }
    public class GelirKartiKatagoriListesi
    {
        public List<GelirKartlariKatagori> liste = new List<GelirKartlariKatagori>();
        public void ListeyeEkle(GelirKartlariKatagori katagori)
        {
            katagori.id = liste.Count;
            liste.Add(katagori);
        }
    }
    public class GelirKartleriLiset
    {
        public List<GelirKartlari> liste = new List<GelirKartlari>();
        public void ListeyeEkle(GelirKartlari kart)
        {
            kart.id = liste.Count;
            liste.Add(kart);
        }
    }
}
