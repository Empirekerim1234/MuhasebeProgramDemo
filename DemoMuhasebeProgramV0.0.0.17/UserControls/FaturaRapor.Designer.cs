namespace DemoMuhasebeProgram
{
    partial class FaturaRapor
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            Fatura_No = new DataGridViewTextBoxColumn();
            Unvan = new DataGridViewTextBoxColumn();
            Tarih = new DataGridViewTextBoxColumn();
            ToplamHamTutar = new DataGridViewTextBoxColumn();
            ToplamIskontoTutar = new DataGridViewTextBoxColumn();
            ToplamKdvTutar = new DataGridViewTextBoxColumn();
            ToplamFaturaTutar = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            cmbGeriyeDonukTarih = new ComboBox();
            txtMaxTutar = new TextBox();
            txtMinTutar = new TextBox();
            label7 = new Label();
            label6 = new Label();
            cmbVergiNo = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dtpBitis = new DateTimePicker();
            dtpBaslangic = new DateTimePicker();
            cmbUnvan = new ComboBox();
            cmbFaturaNo = new ComboBox();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1458, 691);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Fatura_No, Unvan, Tarih, ToplamHamTutar, ToplamIskontoTutar, ToplamKdvTutar, ToplamFaturaTutar });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 125);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1458, 441);
            dataGridView1.TabIndex = 2;
            // 
            // Fatura_No
            // 
            Fatura_No.HeaderText = "No";
            Fatura_No.MinimumWidth = 6;
            Fatura_No.Name = "Fatura_No";
            Fatura_No.Width = 125;
            // 
            // Unvan
            // 
            Unvan.HeaderText = "Ünvan";
            Unvan.MinimumWidth = 6;
            Unvan.Name = "Unvan";
            Unvan.Width = 125;
            // 
            // Tarih
            // 
            Tarih.HeaderText = "Tarih";
            Tarih.MinimumWidth = 6;
            Tarih.Name = "Tarih";
            Tarih.Width = 125;
            // 
            // ToplamHamTutar
            // 
            ToplamHamTutar.HeaderText = "Ham Tutar";
            ToplamHamTutar.MinimumWidth = 6;
            ToplamHamTutar.Name = "ToplamHamTutar";
            ToplamHamTutar.Width = 125;
            // 
            // ToplamIskontoTutar
            // 
            ToplamIskontoTutar.HeaderText = "İskonto Tutar";
            ToplamIskontoTutar.MinimumWidth = 6;
            ToplamIskontoTutar.Name = "ToplamIskontoTutar";
            ToplamIskontoTutar.Width = 125;
            // 
            // ToplamKdvTutar
            // 
            ToplamKdvTutar.HeaderText = "Kdv Tutar";
            ToplamKdvTutar.MinimumWidth = 6;
            ToplamKdvTutar.Name = "ToplamKdvTutar";
            ToplamKdvTutar.Width = 125;
            // 
            // ToplamFaturaTutar
            // 
            ToplamFaturaTutar.HeaderText = "Toplam Fatura Tutar";
            ToplamFaturaTutar.MinimumWidth = 6;
            ToplamFaturaTutar.Name = "ToplamFaturaTutar";
            ToplamFaturaTutar.Width = 125;
            // 
            // panel3
            // 
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 566);
            panel3.Name = "panel3";
            panel3.Size = new Size(1458, 125);
            panel3.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(606, 52);
            label13.Name = "label13";
            label13.Size = new Size(104, 20);
            label13.TabIndex = 4;
            label13.Text = "Genel Toplam:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(349, 93);
            label12.Name = "label12";
            label12.Size = new Size(91, 20);
            label12.TabIndex = 3;
            label12.Text = "Kdv Toplam:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(49, 93);
            label11.Name = "label11";
            label11.Size = new Size(114, 20);
            label11.TabIndex = 2;
            label11.Text = "İskonto Toplam:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(349, 12);
            label10.Name = "label10";
            label10.Size = new Size(98, 20);
            label10.TabIndex = 1;
            label10.Text = "Ham Toplam:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(49, 12);
            label9.Name = "label9";
            label9.Size = new Size(93, 20);
            label9.TabIndex = 0;
            label9.Text = "Fatura Sayısı:";
            // 
            // panel2
            // 
            panel2.Controls.Add(label8);
            panel2.Controls.Add(cmbGeriyeDonukTarih);
            panel2.Controls.Add(txtMaxTutar);
            panel2.Controls.Add(txtMinTutar);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(cmbVergiNo);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dtpBitis);
            panel2.Controls.Add(dtpBaslangic);
            panel2.Controls.Add(cmbUnvan);
            panel2.Controls.Add(cmbFaturaNo);
            panel2.Controls.Add(button2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1458, 125);
            panel2.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(349, 75);
            label8.Name = "label8";
            label8.Size = new Size(105, 20);
            label8.TabIndex = 17;
            label8.Text = "Geriye Dönük :";
            // 
            // cmbGeriyeDonukTarih
            // 
            cmbGeriyeDonukTarih.FormattingEnabled = true;
            cmbGeriyeDonukTarih.Location = new Point(460, 72);
            cmbGeriyeDonukTarih.Name = "cmbGeriyeDonukTarih";
            cmbGeriyeDonukTarih.Size = new Size(151, 28);
            cmbGeriyeDonukTarih.TabIndex = 16;
            // 
            // txtMaxTutar
            // 
            txtMaxTutar.Location = new Point(935, 35);
            txtMaxTutar.Name = "txtMaxTutar";
            txtMaxTutar.Size = new Size(125, 27);
            txtMaxTutar.TabIndex = 15;
            // 
            // txtMinTutar
            // 
            txtMinTutar.Location = new Point(935, 4);
            txtMinTutar.Name = "txtMinTutar";
            txtMinTutar.Size = new Size(125, 27);
            txtMinTutar.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(767, 38);
            label7.Name = "label7";
            label7.Size = new Size(162, 20);
            label7.TabIndex = 13;
            label7.Text = "En Yüksek Fatura Tutarı:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(771, 7);
            label6.Name = "label6";
            label6.Size = new Size(158, 20);
            label6.TabIndex = 12;
            label6.Text = "En Düşük Fatura Tutarı:";
            // 
            // cmbVergiNo
            // 
            cmbVergiNo.FormattingEnabled = true;
            cmbVergiNo.Location = new Point(108, 72);
            cmbVergiNo.Name = "cmbVergiNo";
            cmbVergiNo.Size = new Size(151, 28);
            cmbVergiNo.TabIndex = 11;
            cmbVergiNo.SelectedIndexChanged += cmbVergiNo_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 75);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 10;
            label5.Text = "Vergi No:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 7);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 9;
            label4.Text = "Ünvan:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 41);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 8;
            label3.Text = "Fatura No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(378, 42);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 7;
            label2.Text = "Bitiş Tarihi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(343, 7);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 6;
            label1.Text = "Başlangıç Tarihi";
            // 
            // dtpBitis
            // 
            dtpBitis.Location = new Point(460, 39);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(250, 27);
            dtpBitis.TabIndex = 5;
            dtpBitis.ValueChanged += dtpBitis_ValueChanged;
            // 
            // dtpBaslangic
            // 
            dtpBaslangic.Location = new Point(460, 4);
            dtpBaslangic.Name = "dtpBaslangic";
            dtpBaslangic.Size = new Size(250, 27);
            dtpBaslangic.TabIndex = 4;
            dtpBaslangic.Value = new DateTime(2026, 11, 20, 6, 6, 31, 0);
            dtpBaslangic.ValueChanged += dtpBaslangic_ValueChanged;
            // 
            // cmbUnvan
            // 
            cmbUnvan.FormattingEnabled = true;
            cmbUnvan.Location = new Point(108, 4);
            cmbUnvan.Name = "cmbUnvan";
            cmbUnvan.Size = new Size(151, 28);
            cmbUnvan.TabIndex = 3;
            cmbUnvan.SelectedIndexChanged += cmbUnvan_SelectedIndexChanged;
            // 
            // cmbFaturaNo
            // 
            cmbFaturaNo.FormattingEnabled = true;
            cmbFaturaNo.Location = new Point(108, 38);
            cmbFaturaNo.Name = "cmbFaturaNo";
            cmbFaturaNo.Size = new Size(151, 28);
            cmbFaturaNo.TabIndex = 2;
            cmbFaturaNo.SelectedIndexChanged += cmbFaturaNo_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(1361, 0);
            button2.Name = "button2";
            button2.Size = new Size(94, 125);
            button2.TabIndex = 1;
            button2.Text = "Temizle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FaturaRapor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "FaturaRapor";
            Size = new Size(1458, 691);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel3;
        private Panel panel2;
        private Button button2;
        private DataGridViewTextBoxColumn Fatura_No;
        private DataGridViewTextBoxColumn Unvan;
        private DataGridViewTextBoxColumn Tarih;
        private DataGridViewTextBoxColumn ToplamHamTutar;
        private DataGridViewTextBoxColumn ToplamIskontoTutar;
        private DataGridViewTextBoxColumn ToplamKdvTutar;
        private DataGridViewTextBoxColumn ToplamFaturaTutar;
        private ComboBox cmbFaturaNo;
        private DateTimePicker dtpBitis;
        private DateTimePicker dtpBaslangic;
        private ComboBox cmbUnvan;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbVergiNo;
        private Label label5;
        private Label label4;
        private TextBox txtMaxTutar;
        private TextBox txtMinTutar;
        private Label label7;
        private Label label6;
        private ComboBox cmbGeriyeDonukTarih;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label13;
        private Label label12;
        private Label label11;
    }
}
