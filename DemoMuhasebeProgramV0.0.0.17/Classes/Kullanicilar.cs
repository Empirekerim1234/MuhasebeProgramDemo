using System;
using System.Collections.Generic;
using System.Text;

namespace DemoMuhasebeProgram.Classes
{
    public class Kullanici {
        public string ad = "";
        public string sifre = "";
        public int id;
    }
    public class Kullanicilar
    {
        public List<Kullanici> kullanicilar = new List<Kullanici>();
        public void kullanicilarAdd(Kullanici kullanici)
        {
            kullanici.id = kullanicilar.Count;
            kullanicilar.Add(kullanici);
        }
    }
}
