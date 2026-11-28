using System;
using System.Collections.Generic;
using System.Text;

namespace DemoMuhasebeProgram.Classes
{
    public class SatisUrun
    {
        public int Id = 0;
        public string ad = "";
        public decimal fiyat = 0;
        public string katagori = "";
    }
    public class SatisUrunListe
    {
        public List<SatisUrun> satisUruns = new List<SatisUrun>();
    }
}
