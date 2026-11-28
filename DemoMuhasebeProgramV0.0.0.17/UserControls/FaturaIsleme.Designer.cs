namespace DemoMuhasebeProgram
{
    partial class FaturaIsleme
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            Urun_No = new DataGridViewTextBoxColumn();
            Fatura_Kalem = new DataGridViewTextBoxColumn();
            Koli_Ici_Adet = new DataGridViewTextBoxColumn();
            Miktar = new DataGridViewTextBoxColumn();
            Birim_Fiyar = new DataGridViewTextBoxColumn();
            Ham_Fiyat = new DataGridViewTextBoxColumn();
            Iskonto_Orani = new DataGridViewTextBoxColumn();
            Iskonto_Tutar = new DataGridViewTextBoxColumn();
            Iskonto_Dahil_Tutar = new DataGridViewTextBoxColumn();
            KdvOrani = new DataGridViewTextBoxColumn();
            KdvTutar = new DataGridViewTextBoxColumn();
            Kdv_Dahil_Tutar = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            button1 = new Button();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            panel3 = new Panel();
            label18 = new Label();
            dateTimePicker1 = new DateTimePicker();
            cmbFaturaUrunNo = new ComboBox();
            label17 = new Label();
            InToExcell = new Button();
            btnOutTheExcell = new Button();
            txtIskontoOrani = new TextBox();
            label16 = new Label();
            txtFaturaNo = new TextBox();
            label15 = new Label();
            cmbFirmaUnvani = new ComboBox();
            txtBirimFiyat = new TextBox();
            txtKoliIciAdet = new TextBox();
            cmbKdvOrani = new ComboBox();
            btnEkle = new Button();
            panel4 = new Panel();
            btnEditMod = new Button();
            btnEklemeMod = new Button();
            txtMiktar = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbUrunAdi = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1389, 670);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Urun_No, Fatura_Kalem, Koli_Ici_Adet, Miktar, Birim_Fiyar, Ham_Fiyat, Iskonto_Orani, Iskonto_Tutar, Iskonto_Dahil_Tutar, KdvOrani, KdvTutar, Kdv_Dahil_Tutar });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1120, 545);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Urun_No
            // 
            Urun_No.HeaderText = "Fatura Ürün No";
            Urun_No.MinimumWidth = 6;
            Urun_No.Name = "Urun_No";
            // 
            // Fatura_Kalem
            // 
            Fatura_Kalem.HeaderText = "Fatura Ürün";
            Fatura_Kalem.MinimumWidth = 6;
            Fatura_Kalem.Name = "Fatura_Kalem";
            Fatura_Kalem.Resizable = DataGridViewTriState.True;
            // 
            // Koli_Ici_Adet
            // 
            Koli_Ici_Adet.HeaderText = "Koli İçi Adet";
            Koli_Ici_Adet.MinimumWidth = 6;
            Koli_Ici_Adet.Name = "Koli_Ici_Adet";
            // 
            // Miktar
            // 
            Miktar.HeaderText = "Miktar";
            Miktar.MinimumWidth = 6;
            Miktar.Name = "Miktar";
            // 
            // Birim_Fiyar
            // 
            Birim_Fiyar.HeaderText = "Birim Fiyat";
            Birim_Fiyar.MinimumWidth = 6;
            Birim_Fiyar.Name = "Birim_Fiyar";
            // 
            // Ham_Fiyat
            // 
            Ham_Fiyat.HeaderText = "Ham Tutar";
            Ham_Fiyat.MinimumWidth = 6;
            Ham_Fiyat.Name = "Ham_Fiyat";
            // 
            // Iskonto_Orani
            // 
            Iskonto_Orani.HeaderText = "İskonto Oranı";
            Iskonto_Orani.MinimumWidth = 6;
            Iskonto_Orani.Name = "Iskonto_Orani";
            Iskonto_Orani.Resizable = DataGridViewTriState.True;
            // 
            // Iskonto_Tutar
            // 
            Iskonto_Tutar.HeaderText = "İskonto Tutar";
            Iskonto_Tutar.MinimumWidth = 6;
            Iskonto_Tutar.Name = "Iskonto_Tutar";
            // 
            // Iskonto_Dahil_Tutar
            // 
            Iskonto_Dahil_Tutar.HeaderText = "İskonto Dahil Tutar";
            Iskonto_Dahil_Tutar.MinimumWidth = 6;
            Iskonto_Dahil_Tutar.Name = "Iskonto_Dahil_Tutar";
            // 
            // KdvOrani
            // 
            KdvOrani.HeaderText = "Kdv Oranı";
            KdvOrani.MinimumWidth = 6;
            KdvOrani.Name = "KdvOrani";
            KdvOrani.Resizable = DataGridViewTriState.True;
            // 
            // KdvTutar
            // 
            KdvTutar.HeaderText = "Kdv Tutar";
            KdvTutar.MinimumWidth = 6;
            KdvTutar.Name = "KdvTutar";
            // 
            // Kdv_Dahil_Tutar
            // 
            Kdv_Dahil_Tutar.HeaderText = "Kdv Dahil Tutar";
            Kdv_Dahil_Tutar.MinimumWidth = 6;
            Kdv_Dahil_Tutar.Name = "Kdv_Dahil_Tutar";
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 545);
            panel2.Name = "panel2";
            panel2.Size = new Size(1120, 125);
            panel2.TabIndex = 0;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Right;
            button1.Location = new Point(999, 0);
            button1.Name = "button1";
            button1.Size = new Size(121, 125);
            button1.TabIndex = 8;
            button1.Text = "Excellden Toplu Fatura Al";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(338, 3);
            label11.Name = "label11";
            label11.Size = new Size(36, 20);
            label11.TabIndex = 7;
            label11.Text = "0 TL";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(338, 23);
            label12.Name = "label12";
            label12.Size = new Size(36, 20);
            label12.TabIndex = 6;
            label12.Text = "0 TL";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(123, 23);
            label13.Name = "label13";
            label13.Size = new Size(36, 20);
            label13.TabIndex = 5;
            label13.Text = "0 TL";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(123, 0);
            label14.Name = "label14";
            label14.Size = new Size(36, 20);
            label14.TabIndex = 4;
            label14.Text = "0 TL";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(242, 3);
            label10.Name = "label10";
            label10.Size = new Size(90, 20);
            label10.TabIndex = 3;
            label10.Text = "Fatura Tutar:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(257, 23);
            label9.Name = "label9";
            label9.Size = new Size(75, 20);
            label9.TabIndex = 2;
            label9.Text = "Kdv Tutar:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 23);
            label8.Name = "label8";
            label8.Size = new Size(98, 20);
            label8.TabIndex = 1;
            label8.Text = "İskonto Tutar:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 0);
            label7.Name = "label7";
            label7.Size = new Size(82, 20);
            label7.TabIndex = 0;
            label7.Text = "Ham Tutar:";
            // 
            // panel3
            // 
            panel3.Controls.Add(label18);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(cmbFaturaUrunNo);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(InToExcell);
            panel3.Controls.Add(btnOutTheExcell);
            panel3.Controls.Add(txtIskontoOrani);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(txtFaturaNo);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(cmbFirmaUnvani);
            panel3.Controls.Add(txtBirimFiyat);
            panel3.Controls.Add(txtKoliIciAdet);
            panel3.Controls.Add(cmbKdvOrani);
            panel3.Controls.Add(btnEkle);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(txtMiktar);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(cmbUrunAdi);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(1120, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(269, 670);
            panel3.TabIndex = 1;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(66, 167);
            label18.Name = "label18";
            label18.Size = new Size(43, 20);
            label18.TabIndex = 28;
            label18.Text = "Tarih:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(115, 162);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(151, 27);
            dateTimePicker1.TabIndex = 27;
            // 
            // cmbFaturaUrunNo
            // 
            cmbFaturaUrunNo.FormattingEnabled = true;
            cmbFaturaUrunNo.Location = new Point(115, 195);
            cmbFaturaUrunNo.Name = "cmbFaturaUrunNo";
            cmbFaturaUrunNo.Size = new Size(151, 28);
            cmbFaturaUrunNo.TabIndex = 26;
            cmbFaturaUrunNo.SelectedIndexChanged += cmbFaturaUrunNo_SelectedIndexChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(-2, 198);
            label17.Name = "label17";
            label17.Size = new Size(111, 20);
            label17.TabIndex = 25;
            label17.Text = "Fatura Urun No:";
            // 
            // InToExcell
            // 
            InToExcell.Dock = DockStyle.Bottom;
            InToExcell.Location = new Point(0, 612);
            InToExcell.Name = "InToExcell";
            InToExcell.Size = new Size(269, 29);
            InToExcell.TabIndex = 24;
            InToExcell.Text = "Faturayı Kayet";
            InToExcell.UseVisualStyleBackColor = true;
            InToExcell.Click += InToExcell_Click;
            // 
            // btnOutTheExcell
            // 
            btnOutTheExcell.Dock = DockStyle.Bottom;
            btnOutTheExcell.Location = new Point(0, 641);
            btnOutTheExcell.Name = "btnOutTheExcell";
            btnOutTheExcell.Size = new Size(269, 29);
            btnOutTheExcell.TabIndex = 23;
            btnOutTheExcell.Text = "Excellden Veri Al";
            btnOutTheExcell.UseVisualStyleBackColor = true;
            btnOutTheExcell.Click += btnOutTheExcell_Click;
            // 
            // txtIskontoOrani
            // 
            txtIskontoOrani.Location = new Point(115, 399);
            txtIskontoOrani.Name = "txtIskontoOrani";
            txtIskontoOrani.Size = new Size(151, 27);
            txtIskontoOrani.TabIndex = 22;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(33, 132);
            label16.Name = "label16";
            label16.Size = new Size(76, 20);
            label16.TabIndex = 21;
            label16.Text = "Fatura No:";
            // 
            // txtFaturaNo
            // 
            txtFaturaNo.Location = new Point(115, 129);
            txtFaturaNo.Name = "txtFaturaNo";
            txtFaturaNo.Size = new Size(151, 27);
            txtFaturaNo.TabIndex = 20;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(11, 98);
            label15.Name = "label15";
            label15.Size = new Size(98, 20);
            label15.TabIndex = 19;
            label15.Text = "Firma Unvani:";
            // 
            // cmbFirmaUnvani
            // 
            cmbFirmaUnvani.FormattingEnabled = true;
            cmbFirmaUnvani.Location = new Point(115, 95);
            cmbFirmaUnvani.Name = "cmbFirmaUnvani";
            cmbFirmaUnvani.Size = new Size(151, 28);
            cmbFirmaUnvani.TabIndex = 18;
            // 
            // txtBirimFiyat
            // 
            txtBirimFiyat.Location = new Point(115, 329);
            txtBirimFiyat.Name = "txtBirimFiyat";
            txtBirimFiyat.Size = new Size(151, 27);
            txtBirimFiyat.TabIndex = 17;
            // 
            // txtKoliIciAdet
            // 
            txtKoliIciAdet.Location = new Point(115, 263);
            txtKoliIciAdet.Name = "txtKoliIciAdet";
            txtKoliIciAdet.Size = new Size(151, 27);
            txtKoliIciAdet.TabIndex = 16;
            // 
            // cmbKdvOrani
            // 
            cmbKdvOrani.FormattingEnabled = true;
            cmbKdvOrani.Location = new Point(115, 362);
            cmbKdvOrani.Name = "cmbKdvOrani";
            cmbKdvOrani.Size = new Size(151, 28);
            cmbKdvOrani.TabIndex = 14;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(115, 430);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(151, 29);
            btnEkle.TabIndex = 12;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnEditMod);
            panel4.Controls.Add(btnEklemeMod);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(269, 89);
            panel4.TabIndex = 13;
            // 
            // btnEditMod
            // 
            btnEditMod.Location = new Point(0, 44);
            btnEditMod.Name = "btnEditMod";
            btnEditMod.Size = new Size(266, 35);
            btnEditMod.TabIndex = 1;
            btnEditMod.Text = "Düzenleme Yap";
            btnEditMod.UseVisualStyleBackColor = true;
            btnEditMod.Click += btnEditMod_Click;
            // 
            // btnEklemeMod
            // 
            btnEklemeMod.Location = new Point(0, 3);
            btnEklemeMod.Name = "btnEklemeMod";
            btnEklemeMod.Size = new Size(266, 35);
            btnEklemeMod.TabIndex = 0;
            btnEklemeMod.Text = "Ekleme yap";
            btnEklemeMod.UseVisualStyleBackColor = true;
            btnEklemeMod.Click += btnEklemeMod_Click;
            // 
            // txtMiktar
            // 
            txtMiktar.Location = new Point(115, 296);
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(151, 27);
            txtMiktar.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 399);
            label6.Name = "label6";
            label6.Size = new Size(96, 20);
            label6.TabIndex = 9;
            label6.Text = "İskonto Oran:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 365);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 8;
            label5.Text = "Kdv Oran:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 332);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 7;
            label4.Text = "Birim Fiyat:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 299);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 6;
            label3.Text = "Miktar:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 266);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 5;
            label2.Text = "Koli İçi Adet:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 232);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 4;
            label1.Text = "Ürün Adı:";
            // 
            // cmbUrunAdi
            // 
            cmbUrunAdi.FormattingEnabled = true;
            cmbUrunAdi.Location = new Point(115, 229);
            cmbUrunAdi.Name = "cmbUrunAdi";
            cmbUrunAdi.Size = new Size(151, 28);
            cmbUrunAdi.TabIndex = 0;
            // 
            // FaturaIsleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "FaturaIsleme";
            Size = new Size(1389, 670);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel3;
        private Panel panel2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtBirimFiyat;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox cmbUrunAdi;
        private TextBox textBox3;
        private TextBox txtMiktar;
        private Button btnEkle;
        private Panel panel4;
        private Button button2;
        private Button btnEklemeMod;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private ComboBox cmbKdvOrani;
        private Button btnEditMod;
        private TextBox txtKoliIciAdet;
        private Label label15;
        private ComboBox cmbFirmaUnvani;
        private Label label16;
        private TextBox txtFaturaNo;
        private DataGridViewTextBoxColumn Urun_No;
        private DataGridViewTextBoxColumn Fatura_Kalem;
        private DataGridViewTextBoxColumn Koli_Ici_Adet;
        private DataGridViewTextBoxColumn Miktar;
        private DataGridViewTextBoxColumn Birim_Fiyar;
        private DataGridViewTextBoxColumn Ham_Fiyat;
        private DataGridViewTextBoxColumn Iskonto_Orani;
        private DataGridViewTextBoxColumn Iskonto_Tutar;
        private DataGridViewTextBoxColumn Iskonto_Dahil_Tutar;
        private DataGridViewTextBoxColumn KdvOrani;
        private DataGridViewTextBoxColumn KdvTutar;
        private DataGridViewTextBoxColumn Kdv_Dahil_Tutar;
        private TextBox txtIskontoOrani;
        private Button btnOutTheExcell;
        private Button InToExcell;
        private Label label17;
        private ComboBox cmbFaturaUrunNo;
        private Label label18;
        private DateTimePicker dateTimePicker1;
        private Button button1;
    }
}
