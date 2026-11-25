namespace DemoMuhasebeProgram
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            tabControl1 = new TabControl();
            panel2 = new Panel();
            panel4 = new Panel();
            button11 = new Button();
            panel9 = new Panel();
            button8 = new Button();
            button9 = new Button();
            panel8 = new Panel();
            button7 = new Button();
            button6 = new Button();
            panel7 = new Panel();
            btnFaturaIsleme = new Button();
            button5 = new Button();
            panel5 = new Panel();
            btnReceteTanimla = new Button();
            btnSatisKartlari = new Button();
            btnHammaddeKart = new Button();
            button2 = new Button();
            button1 = new Button();
            button4 = new Button();
            button3 = new Button();
            panel3 = new Panel();
            label1 = new Label();
            button10 = new Button();
            panel6 = new Panel();
            btnKapat = new Button();
            btnYenile = new Button();
            btnReceteListele = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tabControl1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1194, 656);
            panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(250, 57);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(944, 599);
            tabControl1.TabIndex = 2;
            tabControl1.MouseClick += tabControl1_MouseClick;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 57);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 599);
            panel2.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(button11);
            panel4.Controls.Add(panel9);
            panel4.Controls.Add(button9);
            panel4.Controls.Add(panel8);
            panel4.Controls.Add(button6);
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(button5);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(button4);
            panel4.Controls.Add(button3);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(10);
            panel4.Size = new Size(250, 599);
            panel4.TabIndex = 1;
            // 
            // button11
            // 
            button11.Dock = DockStyle.Bottom;
            button11.Location = new Point(10, 525);
            button11.Name = "button11";
            button11.Size = new Size(230, 29);
            button11.TabIndex = 11;
            button11.Text = "Kullanıcı Değiştir";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // panel9
            // 
            panel9.AutoSize = true;
            panel9.Controls.Add(button8);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(10, 478);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(5);
            panel9.Size = new Size(230, 40);
            panel9.TabIndex = 10;
            panel9.Visible = false;
            // 
            // button8
            // 
            button8.Dock = DockStyle.Top;
            button8.Location = new Point(5, 5);
            button8.Name = "button8";
            button8.Size = new Size(220, 30);
            button8.TabIndex = 3;
            button8.Text = "Ayarlar";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Dock = DockStyle.Top;
            button9.Location = new Point(10, 443);
            button9.Name = "button9";
            button9.Size = new Size(230, 35);
            button9.TabIndex = 9;
            button9.Text = "Ayarlar Ve Yönetim Modülü";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // panel8
            // 
            panel8.AutoSize = true;
            panel8.Controls.Add(button7);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(10, 403);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(5);
            panel8.Size = new Size(230, 40);
            panel8.TabIndex = 8;
            panel8.Visible = false;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Top;
            button7.Location = new Point(5, 5);
            button7.Name = "button7";
            button7.Size = new Size(220, 30);
            button7.TabIndex = 3;
            button7.Text = "Faturalar";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Top;
            button6.Location = new Point(10, 368);
            button6.Name = "button6";
            button6.Size = new Size(230, 35);
            button6.TabIndex = 7;
            button6.Text = "Raporlama Modülü";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnReceteListele);
            panel7.Controls.Add(btnFaturaIsleme);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(10, 276);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(5);
            panel7.Size = new Size(230, 92);
            panel7.TabIndex = 5;
            panel7.Visible = false;
            // 
            // btnFaturaIsleme
            // 
            btnFaturaIsleme.Dock = DockStyle.Top;
            btnFaturaIsleme.Location = new Point(5, 5);
            btnFaturaIsleme.Name = "btnFaturaIsleme";
            btnFaturaIsleme.Size = new Size(220, 30);
            btnFaturaIsleme.TabIndex = 3;
            btnFaturaIsleme.Text = "Fatura İşleme";
            btnFaturaIsleme.UseVisualStyleBackColor = true;
            btnFaturaIsleme.Click += FaturaIsleme_Click;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Top;
            button5.Location = new Point(10, 241);
            button5.Name = "button5";
            button5.Size = new Size(230, 35);
            button5.TabIndex = 6;
            button5.Text = "İşleme Modülü";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnReceteTanimla);
            panel5.Controls.Add(btnSatisKartlari);
            panel5.Controls.Add(btnHammaddeKart);
            panel5.Controls.Add(button2);
            panel5.Controls.Add(button1);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(10, 45);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(5);
            panel5.Size = new Size(230, 196);
            panel5.TabIndex = 4;
            panel5.Visible = false;
            // 
            // btnReceteTanimla
            // 
            btnReceteTanimla.Dock = DockStyle.Top;
            btnReceteTanimla.Location = new Point(5, 124);
            btnReceteTanimla.Name = "btnReceteTanimla";
            btnReceteTanimla.Size = new Size(220, 29);
            btnReceteTanimla.TabIndex = 5;
            btnReceteTanimla.Text = "ReçeteTanımlama";
            btnReceteTanimla.UseVisualStyleBackColor = true;
            btnReceteTanimla.Click += btnReceteTanimla_Click;
            // 
            // btnSatisKartlari
            // 
            btnSatisKartlari.Dock = DockStyle.Top;
            btnSatisKartlari.Location = new Point(5, 95);
            btnSatisKartlari.Name = "btnSatisKartlari";
            btnSatisKartlari.Size = new Size(220, 29);
            btnSatisKartlari.TabIndex = 5;
            btnSatisKartlari.Text = "Satıştaki Urun kartları";
            btnSatisKartlari.UseVisualStyleBackColor = true;
            btnSatisKartlari.Click += btnSatisKartlari_Click;
            // 
            // btnHammaddeKart
            // 
            btnHammaddeKart.Dock = DockStyle.Top;
            btnHammaddeKart.Location = new Point(5, 65);
            btnHammaddeKart.Name = "btnHammaddeKart";
            btnHammaddeKart.Size = new Size(220, 30);
            btnHammaddeKart.TabIndex = 4;
            btnHammaddeKart.Text = "Hammadde Kartları";
            btnHammaddeKart.UseVisualStyleBackColor = true;
            btnHammaddeKart.Click += btnHammaddeKart_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.Location = new Point(5, 35);
            button2.Name = "button2";
            button2.Size = new Size(220, 30);
            button2.TabIndex = 1;
            button2.Text = "Cari Kartları";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.Location = new Point(5, 5);
            button1.Name = "button1";
            button1.Size = new Size(220, 30);
            button1.TabIndex = 0;
            button1.Text = "personel işlemlari";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.Location = new Point(10, 10);
            button4.Name = "button4";
            button4.Size = new Size(230, 35);
            button4.TabIndex = 4;
            button4.Text = "Kart Tanımlama Modülü";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Bottom;
            button3.Location = new Point(10, 554);
            button3.Name = "button3";
            button3.Size = new Size(230, 35);
            button3.TabIndex = 2;
            button3.Text = "Çıkış";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveBorder;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(button10);
            panel3.Controls.Add(panel6);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1194, 57);
            panel3.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 9);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 4;
            label1.Text = "Kullanıcı Adı:";
            // 
            // button10
            // 
            button10.Location = new Point(12, 12);
            button10.Name = "button10";
            button10.Size = new Size(43, 29);
            button10.TabIndex = 3;
            button10.Text = "| | |";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnKapat);
            panel6.Controls.Add(btnYenile);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(1041, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(153, 57);
            panel6.TabIndex = 2;
            // 
            // btnKapat
            // 
            btnKapat.Dock = DockStyle.Bottom;
            btnKapat.Location = new Point(0, 28);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(153, 29);
            btnKapat.TabIndex = 0;
            btnKapat.Text = "Açık Sekmeyi Kapat";
            btnKapat.UseVisualStyleBackColor = true;
            btnKapat.Click += btnKapat_Click;
            // 
            // btnYenile
            // 
            btnYenile.Dock = DockStyle.Top;
            btnYenile.Location = new Point(0, 0);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(153, 29);
            btnYenile.TabIndex = 1;
            btnYenile.Text = "Açık Sekmeyi Yenile";
            btnYenile.UseVisualStyleBackColor = true;
            btnYenile.Click += btnYenile_Click;
            // 
            // btnReceteListele
            // 
            btnReceteListele.Dock = DockStyle.Top;
            btnReceteListele.Location = new Point(5, 35);
            btnReceteListele.Name = "btnReceteListele";
            btnReceteListele.Size = new Size(220, 29);
            btnReceteListele.TabIndex = 4;
            btnReceteListele.Text = "Reçete Listesi";
            btnReceteListele.UseVisualStyleBackColor = true;
            btnReceteListele.Click += btnReceteListele_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 656);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel9.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private TabControl tabControl1;
        private Button button1;
        private Panel panel4;
        private Button button2;
        private Button button3;
        private Button btnFaturaIsleme;
        private Button btnHammaddeKart;
        private Panel panel5;
        private Button button4;
        private Button btnYenile;
        private Button btnKapat;
        private Panel panel6;
        private Panel panel9;
        private Button button8;
        private Button button9;
        private Panel panel8;
        private Button button7;
        private Button button6;
        private Panel panel7;
        private Button button5;
        private Button button10;
        private Button button11;
        private Label label1;
        private Button btnSatisKartlari;
        private Button btnReceteTanimla;
        private Button btnReceteListele;
    }
}
