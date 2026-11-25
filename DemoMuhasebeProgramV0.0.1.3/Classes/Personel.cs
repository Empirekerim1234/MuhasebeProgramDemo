using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoMuhasebeProgram.Classes
{
    public class Personel
    {
        public int kod;
        public string name;
        public string lastName;
        public string tcNo;
        public string telNo;
        public bool durum;

    }
    public class PersonelListe
    {
        public List<Personel> personels = new List<Personel>();
        public void personelKaydet(Personel personel, string name, string lastName, string tcNo, string telNo, bool personelDurum)
        {
            personel.kod = personels.Count;
            personel.name = name;
            personel.lastName = lastName;
            personel.tcNo = tcNo;
            personel.telNo = telNo;
            personel.durum = personelDurum;
            personels.Add(personel);
        }
    }
}