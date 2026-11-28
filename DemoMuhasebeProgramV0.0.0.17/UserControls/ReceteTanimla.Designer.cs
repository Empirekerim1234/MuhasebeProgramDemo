namespace DemoMuhasebeProgram.UserControls
{
    partial class ReceteTanimla
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
            No = new DataGridViewTextBoxColumn();
            HammaddeAdi = new DataGridViewTextBoxColumn();
            Miktar = new DataGridViewTextBoxColumn();
            Birim = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            panel6 = new Panel();
            button1 = new Button();
            InToExcell = new Button();
            btnOutTheExcell = new Button();
            panel5 = new Panel();
            txtMiktar = new TextBox();
            btnOk = new Button();
            cmbUrunName = new ComboBox();
            label5 = new Label();
            cmbHammaddeName = new ComboBox();
            cmbBirim = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel4 = new Panel();
            cmbSelected = new ComboBox();
            label1 = new Label();
            panel3 = new Panel();
            btnEdit = new Button();
            btnNew = new Button();
            cmbSelectedRecete = new ComboBox();
            label6 = new Label();
            panel1.SuspendLayout();
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
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1177, 516);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { No, HammaddeAdi, Miktar, Birim });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(896, 516);
            dataGridView1.TabIndex = 1;
            // 
            // No
            // 
            No.HeaderText = "No";
            No.MinimumWidth = 6;
            No.Name = "No";
            No.Width = 125;
            // 
            // HammaddeAdi
            // 
            HammaddeAdi.HeaderText = "Hammadde Adı";
            HammaddeAdi.MinimumWidth = 6;
            HammaddeAdi.Name = "HammaddeAdi";
            HammaddeAdi.Width = 125;
            // 
            // Miktar
            // 
            Miktar.HeaderText = "Miktar";
            Miktar.MinimumWidth = 6;
            Miktar.Name = "Miktar";
            Miktar.Width = 125;
            // 
            // Birim
            // 
            Birim.HeaderText = "Birim";
            Birim.MinimumWidth = 6;
            Birim.Name = "Birim";
            Birim.Width = 125;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(896, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(281, 516);
            panel2.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(button1);
            panel6.Controls.Add(InToExcell);
            panel6.Controls.Add(btnOutTheExcell);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 419);
            panel6.Name = "panel6";
            panel6.Size = new Size(281, 97);
            panel6.TabIndex = 3;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Bottom;
            button1.Location = new Point(0, 10);
            button1.Name = "button1";
            button1.Size = new Size(281, 29);
            button1.TabIndex = 2;
            button1.Text = "Excellden Toplu Reçete Al";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // InToExcell
            // 
            InToExcell.Dock = DockStyle.Bottom;
            InToExcell.Location = new Point(0, 39);
            InToExcell.Name = "InToExcell";
            InToExcell.Size = new Size(281, 29);
            InToExcell.TabIndex = 0;
            InToExcell.Text = "Kaydet";
            InToExcell.UseVisualStyleBackColor = true;
            InToExcell.Click += InToExcell_Click;
            // 
            // btnOutTheExcell
            // 
            btnOutTheExcell.Dock = DockStyle.Bottom;
            btnOutTheExcell.Location = new Point(0, 68);
            btnOutTheExcell.Name = "btnOutTheExcell";
            btnOutTheExcell.Size = new Size(281, 29);
            btnOutTheExcell.TabIndex = 1;
            btnOutTheExcell.Text = "Excellden Veri Al";
            btnOutTheExcell.UseVisualStyleBackColor = true;
            btnOutTheExcell.Click += btnOutTheExcell_Click;
            // 
            // panel5
            // 
            panel5.AutoSize = true;
            panel5.Controls.Add(txtMiktar);
            panel5.Controls.Add(btnOk);
            panel5.Controls.Add(cmbUrunName);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(cmbHammaddeName);
            panel5.Controls.Add(cmbBirim);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label2);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 177);
            panel5.Name = "panel5";
            panel5.Size = new Size(281, 180);
            panel5.TabIndex = 2;
            // 
            // txtMiktar
            // 
            txtMiktar.Location = new Point(125, 77);
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(151, 27);
            txtMiktar.TabIndex = 10;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(126, 148);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(151, 29);
            btnOk.TabIndex = 9;
            btnOk.Text = "Ekle";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // cmbUrunName
            // 
            cmbUrunName.FormattingEnabled = true;
            cmbUrunName.Location = new Point(126, 6);
            cmbUrunName.Name = "cmbUrunName";
            cmbUrunName.Size = new Size(151, 28);
            cmbUrunName.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 9);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 7;
            label5.Text = "Urun İsmi:";
            // 
            // cmbHammaddeName
            // 
            cmbHammaddeName.FormattingEnabled = true;
            cmbHammaddeName.Location = new Point(126, 40);
            cmbHammaddeName.Name = "cmbHammaddeName";
            cmbHammaddeName.Size = new Size(151, 28);
            cmbHammaddeName.TabIndex = 6;
            // 
            // cmbBirim
            // 
            cmbBirim.FormattingEnabled = true;
            cmbBirim.Items.AddRange(new object[] { "Ad", "Kg", "Gr" });
            cmbBirim.Location = new Point(126, 114);
            cmbBirim.Name = "cmbBirim";
            cmbBirim.Size = new Size(151, 28);
            cmbBirim.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 117);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 2;
            label4.Text = "Birimi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 80);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 1;
            label3.Text = "Miktarı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1, 46);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 0;
            label2.Text = "Hammadde Adı:";
            // 
            // panel4
            // 
            panel4.Controls.Add(label6);
            panel4.Controls.Add(cmbSelectedRecete);
            panel4.Controls.Add(cmbSelected);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 58);
            panel4.Name = "panel4";
            panel4.Size = new Size(281, 119);
            panel4.TabIndex = 1;
            // 
            // cmbSelected
            // 
            cmbSelected.FormattingEnabled = true;
            cmbSelected.Location = new Point(126, 6);
            cmbSelected.Name = "cmbSelected";
            cmbSelected.Size = new Size(152, 28);
            cmbSelected.TabIndex = 1;
            cmbSelected.SelectedIndexChanged += cmbSelected_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 9);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 0;
            label1.Text = "Seçili Satır:";
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.Controls.Add(btnEdit);
            panel3.Controls.Add(btnNew);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(281, 58);
            panel3.TabIndex = 0;
            // 
            // btnEdit
            // 
            btnEdit.Dock = DockStyle.Top;
            btnEdit.Location = new Point(0, 29);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(281, 29);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Düzenle";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnNew
            // 
            btnNew.Dock = DockStyle.Top;
            btnNew.Location = new Point(0, 0);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(281, 29);
            btnNew.TabIndex = 0;
            btnNew.Text = "Yeni Satır";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // cmbSelectedRecete
            // 
            cmbSelectedRecete.FormattingEnabled = true;
            cmbSelectedRecete.Location = new Point(125, 40);
            cmbSelectedRecete.Name = "cmbSelectedRecete";
            cmbSelectedRecete.Size = new Size(153, 28);
            cmbSelectedRecete.TabIndex = 2;
            cmbSelectedRecete.SelectedIndexChanged += cmbSelectedRecete_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 43);
            label6.Name = "label6";
            label6.Size = new Size(104, 20);
            label6.TabIndex = 3;
            label6.Text = "Reçete Seçiniz";
            // 
            // ReceteTanimla
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "ReceteTanimla";
            Size = new Size(1177, 516);
            panel1.ResumeLayout(false);
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
        private Panel panel2;
        private Panel panel3;
        private Button btnEdit;
        private Button btnNew;
        private Panel panel4;
        private Panel panel6;
        private Panel panel5;
        private ComboBox comboBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cmbSelected;
        private Label label1;
        private ComboBox cmbBirim;
        private ComboBox cmbHammaddeName;
        private ComboBox cmbUrunName;
        private Label label5;
        private Button btnOk;
        private TextBox txtMiktar;
        private DataGridViewTextBoxColumn No;
        private DataGridViewTextBoxColumn HammaddeAdi;
        private DataGridViewTextBoxColumn Miktar;
        private DataGridViewTextBoxColumn Birim;
        private Button btnOutTheExcell;
        private Button InToExcell;
        private Button button1;
        private Label label6;
        private ComboBox cmbSelectedRecete;
    }
}
