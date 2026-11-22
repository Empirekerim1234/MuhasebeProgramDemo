using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Text;
using System.Windows.Forms;

namespace DemoMuhasebeProgram
{
    public partial class LoadingForm : Form
    {
        private Form1 mainForm;
        public LoadingForm(Form1 form1)
        {
            InitializeComponent();
            this.ControlBox = false;
            mainForm = form1;
            mainForm.Enabled = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            //this.Location = new Point(Cursor.Position.X - this.Width / 2, Cursor.Position.Y - this.Height / 2);
        }
        public void IsLocadingComplete(int yapilacakIslem,int yapilanIslem)
        {
            int tamamlanmaYuzdesi = 1;
                if (yapilanIslem != 0)
                {
                    tamamlanmaYuzdesi = yapilanIslem * 100 / yapilacakIslem;
                    label2.Text = "% " + (tamamlanmaYuzdesi).ToString();
                    progressBar1.Value = tamamlanmaYuzdesi;
                }
                else 
                label2.Text = "% 0";
        }
        private void LoadingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
