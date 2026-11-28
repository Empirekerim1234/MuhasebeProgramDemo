namespace DemoMuhasebeProgram.UserControls
{
    partial class SatisKartlari
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
            Id = new DataGridViewTextBoxColumn();
            UrunName = new DataGridViewTextBoxColumn();
            AnaKatagori = new DataGridViewTextBoxColumn();
            Fiyat = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            panel6 = new Panel();
            InToExcell = new Button();
            btnOutTheExcell = new Button();
            panel5 = new Panel();
            txtName = new TextBox();
            txtFiyat = new TextBox();
            label1 = new Label();
            cmbKatagori = new ComboBox();
            label2 = new Label();
            button3 = new Button();
            label3 = new Label();
            panel4 = new Panel();
            cmbSelected = new ComboBox();
            label4 = new Label();
            panel3 = new Panel();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1033, 49);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, UrunName, AnaKatagori, Fiyat });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(782, 509);
            dataGridView1.TabIndex = 1;
            // 
            // Id
            // 
            Id.HeaderText = "Kod";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 125;
            // 
            // UrunName
            // 
            UrunName.HeaderText = "Ürün Adı";
            UrunName.MinimumWidth = 6;
            UrunName.Name = "UrunName";
            UrunName.ReadOnly = true;
            UrunName.Width = 125;
            // 
            // AnaKatagori
            // 
            AnaKatagori.HeaderText = "Katagorisi";
            AnaKatagori.MinimumWidth = 6;
            AnaKatagori.Name = "AnaKatagori";
            AnaKatagori.ReadOnly = true;
            AnaKatagori.Width = 125;
            // 
            // Fiyat
            // 
            Fiyat.HeaderText = "Fiyat";
            Fiyat.MinimumWidth = 6;
            Fiyat.Name = "Fiyat";
            Fiyat.ReadOnly = true;
            Fiyat.Width = 125;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(782, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(251, 509);
            panel2.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.Controls.Add(InToExcell);
            panel6.Controls.Add(btnOutTheExcell);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 384);
            panel6.Name = "panel6";
            panel6.Size = new Size(251, 125);
            panel6.TabIndex = 14;
            // 
            // InToExcell
            // 
            InToExcell.Dock = DockStyle.Bottom;
            InToExcell.Location = new Point(0, 67);
            InToExcell.Name = "InToExcell";
            InToExcell.Size = new Size(251, 29);
            InToExcell.TabIndex = 1;
            InToExcell.Text = "Excellden Veri Al";
            InToExcell.UseVisualStyleBackColor = true;
            InToExcell.Click += InToExcell_Click;
            // 
            // btnOutTheExcell
            // 
            btnOutTheExcell.Dock = DockStyle.Bottom;
            btnOutTheExcell.Location = new Point(0, 96);
            btnOutTheExcell.Name = "btnOutTheExcell";
            btnOutTheExcell.Size = new Size(251, 29);
            btnOutTheExcell.TabIndex = 0;
            btnOutTheExcell.Text = "Excele Vari Aktar";
            btnOutTheExcell.UseVisualStyleBackColor = true;
            btnOutTheExcell.Click += btnOutTheExcell_Click;
            // 
            // panel5
            // 
            panel5.AutoSize = true;
            panel5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel5.Controls.Add(txtName);
            panel5.Controls.Add(txtFiyat);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(cmbKatagori);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(button3);
            panel5.Controls.Add(label3);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 92);
            panel5.Name = "panel5";
            panel5.Size = new Size(251, 134);
            panel5.TabIndex = 13;
            // 
            // txtName
            // 
            txtName.Location = new Point(96, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(151, 27);
            txtName.TabIndex = 5;
            txtName.Text = "Çamlıca Pizza";
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(96, 69);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(151, 27);
            txtFiyat.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 6);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 1;
            label1.Text = "Ürüm Adı:";
            // 
            // cmbKatagori
            // 
            cmbKatagori.FormattingEnabled = true;
            cmbKatagori.Items.AddRange(new object[] { "Pizza", "Hamburger", "kumpir" });
            cmbKatagori.Location = new Point(96, 35);
            cmbKatagori.Name = "cmbKatagori";
            cmbKatagori.Size = new Size(151, 28);
            cmbKatagori.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 39);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 2;
            label2.Text = "Katagori:";
            // 
            // button3
            // 
            button3.Location = new Point(96, 102);
            button3.Name = "button3";
            button3.Size = new Size(151, 29);
            button3.TabIndex = 9;
            button3.Text = "Yeni Kayıt";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 72);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 3;
            label3.Text = "Fiyat:";
            // 
            // panel4
            // 
            panel4.AutoSize = true;
            panel4.Controls.Add(cmbSelected);
            panel4.Controls.Add(label4);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 58);
            panel4.Name = "panel4";
            panel4.Size = new Size(251, 34);
            panel4.TabIndex = 12;
            // 
            // cmbSelected
            // 
            cmbSelected.FormattingEnabled = true;
            cmbSelected.Location = new Point(96, 3);
            cmbSelected.Name = "cmbSelected";
            cmbSelected.Size = new Size(151, 28);
            cmbSelected.TabIndex = 8;
            cmbSelected.SelectedIndexChanged += cmbSelected_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 6);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 4;
            label4.Text = "Selçili Ürün:";
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(251, 58);
            panel3.TabIndex = 0;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.Location = new Point(0, 29);
            button2.Name = "button2";
            button2.Size = new Size(251, 29);
            button2.TabIndex = 1;
            button2.Text = "Düzenleme Yap";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(251, 29);
            button1.TabIndex = 0;
            button1.Text = "Yeni Kayıt";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SatisKartlari
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "SatisKartlari";
            Size = new Size(1033, 558);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn UrunName;
        private DataGridViewTextBoxColumn AnaKatagori;
        private DataGridViewTextBoxColumn Fiyat;
        private Panel panel2;
        private Panel panel3;
        private Button button2;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox txtName;
        private Label label4;
        private ComboBox cmbSelected;
        private Button button3;
        private ComboBox cmbKatagori;
        private TextBox txtFiyat;
        private Panel panel5;
        private Panel panel4;
        private Panel panel6;
        private Button btnOutTheExcell;
        private Button InToExcell;
    }
}
