using DemoMuhasebeProgram;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace DemoMuhasebeProgram
{
    public class CariClass
    {
        int cariKod = 0;
        string name = "";
        string iletisimNo = "";
        string vergiNo = "";
        decimal topAlDeger = 0;
        decimal topOdenenDeger = 0;
        decimal topBorc = 0;
        public void SetCariKod(int kod)
        {
            cariKod = kod;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetVergiNo(string vergiNo)
        {
            this.vergiNo = vergiNo;
        }
        public void SetIletisimNo(string iletisimNo)
        {
            this.iletisimNo = iletisimNo;
        }
        public int GetCariKod()
        {
            return cariKod;
        }
        public string GetName()
        {
            return name;
        }
        public string GetVergiNo()
        {
            return vergiNo;
        }
        public string GetIletisimNo()
        {
            return iletisimNo;
        }
        public string GetTopAlinanMal()
        {
            return topAlDeger.ToString();
        }
        public string GetTopOdenenTutar()
        {
            return topOdenenDeger.ToString();
        }
        public string GetTopBorc()
        {
            return topBorc.ToString();
        }
        public void BorcHesapla()
        {
            topBorc = topAlDeger - topOdenenDeger;
        }
        public void MalAlım(decimal miktar)
        { 
            topAlDeger += miktar;
            BorcHesapla();
        }
        public void OdemeYap(decimal miktar)
        {
            topOdenenDeger += miktar;
            BorcHesapla();
        }
    }
    public class CariList
    {
        public List<CariClass> cariList = new List<CariClass>();
        public void AddCariList(CariClass cariKart)
        {
            cariKart.SetCariKod(cariList.Count);
            cariList.Add(cariKart);
        }
        public int CariListCount()
        {
            return cariList.Count;
        }
    }
}
