using DocumentFormat.OpenXml.Office.PowerPoint.Y2021.M06.Main;
using DocumentFormat.OpenXml.Office2013.Excel;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoMuhasebeProgram.YardımcıClass
{
    public class FormOlusturucu
    {
        public Panel PanelOlustur(string Name, DockStyle dock, bool sizeMod)
        {
            Panel panel = new Panel();
            panel.Dock = dock;
            panel.Name = Name;
            panel.AutoSize = sizeMod;
            return panel;
        }
        public Panel PanelOlustur(Panel mainPanel,int gen,int yuk,string Name, DockStyle dock)
        {
            Panel panel = new Panel();
            panel.Dock = dock;
            panel.Name = Name;
            panel.Size = new Size(gen,yuk);
            mainPanel.Controls.Add(panel);
            return panel;
        }
        public Panel PanelOlustur(Form form, string Name, DockStyle dock,bool autoSize)
        {
            Panel panel = new Panel();
            panel.Dock = dock;
            panel.Name = Name;
            panel.AutoSize = autoSize;
            form.Controls.Add(panel);
            return panel;
        }
        public int ButonlarlaKullandigimGenislik(Button x,Button y,int space)
        {
            int sonuc = x.Size.Width + y.Size.Width + space;
            //MessageBox.Show("Genislik:" + sonuc);
            return sonuc;
        }
        public int SatirdeKullandigimYukseklik(TextBox t,Button b,int space)
        {
            int sonuc = b.Size.Height + t.Size.Height + space;
            //MessageBox.Show("Yukseklik:" + sonuc);
            return sonuc;
        }
        public Button ButtonOlustur(Panel panel , string Name, string Txt, int gen, int yuk, DockStyle dock)
        {
            Button btn = new Button();
            btn.Name = Name;
            btn.Text = Txt;
            btn.Size = new Size(gen, yuk);
            btn.Dock = dock;
            panel.Controls.Add(btn);
            return btn;
        }
        public TextBox txtOlustur(Panel panel, string name, int gen, int yuk, DockStyle dock)
        {
            TextBox txtBox = new TextBox();
            txtBox.Name = name;
            txtBox.Size = new Size(gen, yuk);
            panel.Controls.Add(txtBox);
            txtBox.Dock = dock;
            return txtBox;
        }
        public ComboBox cmbOlusturucu(Panel panel, string name, int gen, int yuk, DockStyle dock, ComboBoxStyle dropStyle)
        {
            ComboBox cmbBox = new ComboBox();
            cmbBox.Name = name;
            cmbBox.Size = new Size(gen, yuk);
            panel.Controls.Add(cmbBox);
            cmbBox.Dock = dock;
            cmbBox.DropDownStyle = dropStyle;
            return cmbBox;
        }
        public Label LableOlusturucu(string name,string txt)
        {
            Label lb = new Label();
            lb.Name = name;
            lb.Text = txt;
            return lb;
        }
        public DateTimePicker dtpOlusturucu(Panel panel,string name,int gen,int yuk, DateTimePickerFormat format, string Format)
        {
            DateTimePicker dtp = new DateTimePicker();
            dtp.Name = name;
            dtp.Size = new Size(gen, yuk);
            panel.Controls.Add(dtp);
            dtp.Format = format;
            dtp.CustomFormat = Format;
            return dtp;
        }
        public Form YeniFormAc(string formTxt, int formGen, int formYuk, bool sizeChance, FormWindowState windowState, FormStartPosition formStartPosition)
        {
            Form form = new Form();
            form.Text = formTxt;
            form.Size = new Size(formGen, formYuk);
            form.MaximumSize = new Size(formGen, formYuk);
            form.MinimumSize = new Size(formGen, formYuk);
            form.MaximizeBox = sizeChance;
            form.MinimizeBox = sizeChance;
            form.WindowState = windowState;
            form.StartPosition = formStartPosition;
            return form;
        }
    }
}
