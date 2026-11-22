namespace DemoMuhasebeProgram
{
    partial class HammaddeKartlari
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
            HammaddeKod = new DataGridViewTextBoxColumn();
            Hammadde_Name = new DataGridViewTextBoxColumn();
            AnaKatagori = new DataGridViewTextBoxColumn();
            Alt_katagori = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            InToExcell = new Button();
            btnOutTheExcell = new Button();
            panel4 = new Panel();
            button3 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbAltKatagori = new ComboBox();
            cmbAnaKatagori = new ComboBox();
            txtHammaddeName = new TextBox();
            cmbSelect = new ComboBox();
            panel3 = new Panel();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1463, 700);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { HammaddeKod, Hammadde_Name, AnaKatagori, Alt_katagori });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1161, 700);
            dataGridView1.TabIndex = 1;
            // 
            // HammaddeKod
            // 
            HammaddeKod.HeaderText = "H.Kod";
            HammaddeKod.MinimumWidth = 6;
            HammaddeKod.Name = "HammaddeKod";
            HammaddeKod.Width = 125;
            // 
            // Hammadde_Name
            // 
            Hammadde_Name.HeaderText = "Hammadde Adı";
            Hammadde_Name.MinimumWidth = 6;
            Hammadde_Name.Name = "Hammadde_Name";
            Hammadde_Name.Width = 125;
            // 
            // AnaKatagori
            // 
            AnaKatagori.HeaderText = "Ana Katagori";
            AnaKatagori.MinimumWidth = 6;
            AnaKatagori.Name = "AnaKatagori";
            AnaKatagori.Width = 125;
            // 
            // Alt_katagori
            // 
            Alt_katagori.HeaderText = "Alt_Katagori";
            Alt_katagori.MinimumWidth = 6;
            Alt_katagori.Name = "Alt_katagori";
            Alt_katagori.Width = 125;
            // 
            // panel2
            // 
            panel2.Controls.Add(InToExcell);
            panel2.Controls.Add(btnOutTheExcell);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1161, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(302, 700);
            panel2.TabIndex = 0;
            // 
            // InToExcell
            // 
            InToExcell.Dock = DockStyle.Bottom;
            InToExcell.Location = new Point(0, 642);
            InToExcell.Name = "InToExcell";
            InToExcell.Size = new Size(302, 29);
            InToExcell.TabIndex = 3;
            InToExcell.Text = "Excelle Veri Aktar";
            InToExcell.UseVisualStyleBackColor = true;
            InToExcell.Click += InToExcell_Click;
            // 
            // btnOutTheExcell
            // 
            btnOutTheExcell.Dock = DockStyle.Bottom;
            btnOutTheExcell.Location = new Point(0, 671);
            btnOutTheExcell.Name = "btnOutTheExcell";
            btnOutTheExcell.Size = new Size(302, 29);
            btnOutTheExcell.TabIndex = 2;
            btnOutTheExcell.Text = "Excellden veri Al";
            btnOutTheExcell.UseVisualStyleBackColor = true;
            btnOutTheExcell.Click += btnOutTheExcell_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(button3);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(cmbAltKatagori);
            panel4.Controls.Add(cmbAnaKatagori);
            panel4.Controls.Add(txtHammaddeName);
            panel4.Controls.Add(cmbSelect);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 60);
            panel4.Name = "panel4";
            panel4.Size = new Size(302, 182);
            panel4.TabIndex = 1;
            // 
            // button3
            // 
            button3.Location = new Point(148, 141);
            button3.Name = "button3";
            button3.Size = new Size(151, 29);
            button3.TabIndex = 8;
            button3.Text = "Ekle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 110);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 7;
            label4.Text = "Alt Katagori:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 76);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 6;
            label3.Text = "Ana Katagori:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 43);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 5;
            label2.Text = "Hammadde Adı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 9);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 4;
            label1.Text = "Seçilen Hammadde:";
            // 
            // cmbAltKatagori
            // 
            cmbAltKatagori.FormattingEnabled = true;
            cmbAltKatagori.Location = new Point(148, 107);
            cmbAltKatagori.Name = "cmbAltKatagori";
            cmbAltKatagori.Size = new Size(151, 28);
            cmbAltKatagori.TabIndex = 3;
            // 
            // cmbAnaKatagori
            // 
            cmbAnaKatagori.FormattingEnabled = true;
            cmbAnaKatagori.Items.AddRange(new object[] { "Hammadde", "Yan Ürün" });
            cmbAnaKatagori.Location = new Point(148, 73);
            cmbAnaKatagori.Name = "cmbAnaKatagori";
            cmbAnaKatagori.Size = new Size(151, 28);
            cmbAnaKatagori.TabIndex = 2;
            // 
            // txtHammaddeName
            // 
            txtHammaddeName.Location = new Point(148, 40);
            txtHammaddeName.Name = "txtHammaddeName";
            txtHammaddeName.Size = new Size(151, 27);
            txtHammaddeName.TabIndex = 1;
            // 
            // cmbSelect
            // 
            cmbSelect.FormattingEnabled = true;
            cmbSelect.Location = new Point(148, 6);
            cmbSelect.Name = "cmbSelect";
            cmbSelect.Size = new Size(151, 28);
            cmbSelect.TabIndex = 0;
            cmbSelect.SelectedIndexChanged += cmbSelect_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(302, 60);
            panel3.TabIndex = 0;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Dock = DockStyle.Top;
            button2.Location = new Point(0, 30);
            button2.Name = "button2";
            button2.Size = new Size(302, 30);
            button2.TabIndex = 1;
            button2.Text = "Düzenle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Dock = DockStyle.Top;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(302, 30);
            button1.TabIndex = 0;
            button1.Text = "Yeni Kayıt";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // HammaddeKartlari
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "HammaddeKartlari";
            Size = new Size(1463, 700);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Panel panel3;
        private DataGridViewTextBoxColumn HammaddeKod;
        private DataGridViewTextBoxColumn Hammadde_Name;
        private DataGridViewTextBoxColumn AnaKatagori;
        private DataGridViewTextBoxColumn Alt_katagori;
        private Button button2;
        private Button button1;
        private Panel panel4;
        private Button button3;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbAltKatagori;
        private ComboBox cmbAnaKatagori;
        private TextBox txtHammaddeName;
        private ComboBox cmbSelect;
        private Button btnOutTheExcell;
        private Button InToExcell;
    }
}
