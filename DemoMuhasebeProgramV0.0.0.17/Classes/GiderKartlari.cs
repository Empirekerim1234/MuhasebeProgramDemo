using System;
using System.Collections.Generic;
using System.Text;

namespace DemoMuhasebeProgram.Classes
{
    public class GiderKatagori
    {
        public int Id = 0;
        public string name = "";
    }
    public class GiderKatagorileriListe {
        public List<GiderKatagori> liste = new List<GiderKatagori>();
        public void giderKatagoriListesineEkle(GiderKatagori katagori)
        {
            katagori.Id = liste.Count;
            liste.Add(katagori);
        }
    }
    public class GiderKartlari
    {
        public int Id = -1;
        public string Name = "";
        public string Katagori = "";
    }
    public class GiderKarlariListe { 
        public List<GiderKartlari> liste = new List<GiderKartlari>();
        public void giderKartleriListesineEkle(GiderKartlari gider)
        {
            gider.Id = liste.Count;
            liste.Add(gider);
        }
    }
}
