namespace DemoMuhasebeProgram.UserControls
{
    partial class ReceteListele
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
            UrunName = new DataGridViewTextBoxColumn();
            HammaddeName = new DataGridViewTextBoxColumn();
            Miktar = new DataGridViewTextBoxColumn();
            Birim = new DataGridViewTextBoxColumn();
            Maliyet = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            label2 = new Label();
            cmbHammaddeAdı = new ComboBox();
            label1 = new Label();
            cmbUrunName = new ComboBox();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1134, 513);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { UrunName, HammaddeName, Miktar, Birim, Maliyet });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(835, 513);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // UrunName
            // 
            UrunName.HeaderText = "Ürün Adı";
            UrunName.MinimumWidth = 6;
            UrunName.Name = "UrunName";
            UrunName.ReadOnly = true;
            UrunName.Width = 125;
            // 
            // HammaddeName
            // 
            HammaddeName.HeaderText = "Hammadde Adı";
            HammaddeName.MinimumWidth = 6;
            HammaddeName.Name = "HammaddeName";
            HammaddeName.ReadOnly = true;
            HammaddeName.Width = 125;
            // 
            // Miktar
            // 
            Miktar.HeaderText = "Miktar";
            Miktar.MinimumWidth = 6;
            Miktar.Name = "Miktar";
            Miktar.ReadOnly = true;
            Miktar.Width = 125;
            // 
            // Birim
            // 
            Birim.HeaderText = "Birim";
            Birim.MinimumWidth = 6;
            Birim.Name = "Birim";
            Birim.ReadOnly = true;
            Birim.Width = 125;
            // 
            // Maliyet
            // 
            Maliyet.HeaderText = "Maliyet";
            Maliyet.MinimumWidth = 6;
            Maliyet.Name = "Maliyet";
            Maliyet.ReadOnly = true;
            Maliyet.Width = 125;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(cmbHammaddeAdı);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(cmbUrunName);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(835, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(299, 513);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 40);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 4;
            label2.Text = "Hammadde Adı:";
            // 
            // cmbHammaddeAdı
            // 
            cmbHammaddeAdı.FormattingEnabled = true;
            cmbHammaddeAdı.Location = new Point(145, 37);
            cmbHammaddeAdı.Name = "cmbHammaddeAdı";
            cmbHammaddeAdı.Size = new Size(151, 28);
            cmbHammaddeAdı.TabIndex = 3;
            cmbHammaddeAdı.SelectedIndexChanged += cmbHammaddeAdı_SelectedIndexChanged;
            cmbHammaddeAdı.KeyPress += cmbHammaddeAdı_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 6);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 2;
            label1.Text = "Ürün Adı:";
            // 
            // cmbUrunName
            // 
            cmbUrunName.FormattingEnabled = true;
            cmbUrunName.Location = new Point(145, 3);
            cmbUrunName.Name = "cmbUrunName";
            cmbUrunName.Size = new Size(151, 28);
            cmbUrunName.TabIndex = 1;
            cmbUrunName.SelectedIndexChanged += cmbUrunName_SelectedIndexChanged;
            cmbUrunName.KeyPress += cmbUrunName_KeyPress;
            // 
            // button1
            // 
            button1.Location = new Point(145, 71);
            button1.Name = "button1";
            button1.Size = new Size(151, 29);
            button1.TabIndex = 5;
            button1.Text = "Excelle Veri Aktar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ReceteListele
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "ReceteListele";
            Size = new Size(1134, 513);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private DataGridViewTextBoxColumn UrunName;
        private DataGridViewTextBoxColumn HammaddeName;
        private DataGridViewTextBoxColumn Miktar;
        private DataGridViewTextBoxColumn Birim;
        private DataGridViewTextBoxColumn Maliyet;
        private ComboBox cmbUrunName;
        private Label label2;
        private ComboBox cmbHammaddeAdı;
        private Label label1;
        private Button button1;
    }
}
