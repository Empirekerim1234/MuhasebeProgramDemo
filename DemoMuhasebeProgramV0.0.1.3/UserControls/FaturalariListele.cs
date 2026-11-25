using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static DemoMuhasebeProgram.Classes.Fatura;

namespace DemoMuhasebeProgram
{
    public partial class FaturalariListele : UserControl
    {
        private FaturaListe faturalar;
        public FaturalariListele(FaturaListe faturaList)
        {
            InitializeComponent();
            faturalar = faturaList;
            //for()
        }
    }
}
