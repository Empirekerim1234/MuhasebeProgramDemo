using System;
using System.Collections.Generic;
using System.Text;

namespace DemoMuhasebeProgram.Classes
{
    public class ReceteSatiri
    {
        public int satirId;
        public string hammaddeAd;
        public decimal miktar;
        public string birim;
    }
    public class Recete
    { 
        public List<ReceteSatiri> satirList = new List<ReceteSatiri>();
        public int receteId;
        public string SatisUrunNamse;
    }
    public class ReceteList
    {
        public List<Recete> receteList = new List<Recete>();
    }
}
