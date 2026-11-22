using System;
using System.Collections.Generic;
using System.Text;

namespace DemoMuhasebeProgram
{
    public class Hammadde
    {
        public string name;
        public int kod;
        public string anaKatagori;
        public string altKatagori = "bos";
        public Hammadde(string txtName, string txtKatagori)
        {
            name = txtName;
            anaKatagori = txtKatagori;
        }
        public int degiskenSayisi = 4;
    }
    public class HammaddeList
    {
        public List<Hammadde> hammaddeliste = new List<Hammadde>();
        public int HammaddeListSize()
        {
            return hammaddeliste.Count;
        }
        private bool inToNumber(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
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
                        break;
                    default:
                        return false;
                }
            }
            return true;
        }
        public bool trueHammaddeInput(Hammadde hammadde)
        {
            bool dogruMu = true;
            if (hammadde.name == "" || hammadde.anaKatagori == "")
            {
                MessageBox.Show("Hammadde adı ve kategori boş bırakılamaz.");
                dogruMu = false;
            }
            else if (inToNumber(hammadde.name))
            {
                MessageBox.Show("Hammadde adı sayı içermemelidir.");
                dogruMu = false;
            }
            else if (hammadde.anaKatagori.Length < 3)
            {
                MessageBox.Show("Hammadde kategorisi en az 3 karakterden oluşmalıdır.");
                dogruMu = false;
            }
            for (int i = 0; i < hammaddeliste.Count; i++)
            {
                if (hammaddeliste[i].name == hammadde.name)
                {
                    MessageBox.Show("Bu hammadde zaten mevcut.");
                    dogruMu = false;
                }
            }
            return dogruMu;
        }
        public void hammaddeAdd(Hammadde hammadde)
        {
            hammadde.kod = hammaddeliste.Count;
            hammaddeliste.Add(hammadde);
        }
        public string GetHammaddeDegisken(int index,int x)
        {
            if (x == 0)
            { return hammaddeliste[index].kod.ToString(); }
            else if (x == 1)
            { return hammaddeliste[index].name; }
            else if (x == 2)
            { return hammaddeliste[index].anaKatagori; }
            else if (x == 3)
            { return hammaddeliste[index].altKatagori; }
            return  "";
        }
    }
}
