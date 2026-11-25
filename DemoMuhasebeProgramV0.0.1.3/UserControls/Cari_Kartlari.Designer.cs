namespace DemoMuhasebeProgram
{
    partial class Cari_Kartlari
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
            Cari_No = new DataGridViewTextBoxColumn();
            Cari_Unvan = new DataGridViewTextBoxColumn();
            Ilatisim_No = new DataGridViewTextBoxColumn();
            Vergi_No = new DataGridViewTextBoxColumn();
            Topalm_Alınan_Mal = new DataGridViewTextBoxColumn();
            Toplam_Odenen_Para = new DataGridViewTextBoxColumn();
            Toplam_Borc_Durum = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            InToExcell = new Button();
            OutToExcell = new Button();
            panel4 = new Panel();
            button2 = new Button();
            panel7 = new Panel();
            txtVergiNo = new TextBox();
            label3 = new Label();
            panel6 = new Panel();
            txtTelNo = new TextBox();
            label2 = new Label();
            panel5 = new Panel();
            txtName = new TextBox();
            label1 = new Label();
            cmbSelectCari = new ComboBox();
            panel3 = new Panel();
            EditCari = new Button();
            NewCari = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
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
            panel1.Size = new Size(1462, 710);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Cari_No, Cari_Unvan, Ilatisim_No, Vergi_No, Topalm_Alınan_Mal, Toplam_Odenen_Para, Toplam_Borc_Durum });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1212, 710);
            dataGridView1.TabIndex = 1;
            // 
            // Cari_No
            // 
            Cari_No.HeaderText = "Cari_No";
            Cari_No.MinimumWidth = 6;
            Cari_No.Name = "Cari_No";
            Cari_No.ReadOnly = true;
            Cari_No.Width = 125;
            // 
            // Cari_Unvan
            // 
            Cari_Unvan.HeaderText = "Cari Unvan";
            Cari_Unvan.MinimumWidth = 6;
            Cari_Unvan.Name = "Cari_Unvan";
            Cari_Unvan.ReadOnly = true;
            Cari_Unvan.Width = 125;
            // 
            // Ilatisim_No
            // 
            Ilatisim_No.HeaderText = "İletisim No";
            Ilatisim_No.MinimumWidth = 6;
            Ilatisim_No.Name = "Ilatisim_No";
            Ilatisim_No.ReadOnly = true;
            Ilatisim_No.Width = 125;
            // 
            // Vergi_No
            // 
            Vergi_No.HeaderText = "Vergi_No";
            Vergi_No.MinimumWidth = 6;
            Vergi_No.Name = "Vergi_No";
            Vergi_No.ReadOnly = true;
            Vergi_No.Width = 125;
            // 
            // Topalm_Alınan_Mal
            // 
            Topalm_Alınan_Mal.HeaderText = "Toplam Alınan Mal";
            Topalm_Alınan_Mal.MinimumWidth = 6;
            Topalm_Alınan_Mal.Name = "Topalm_Alınan_Mal";
            Topalm_Alınan_Mal.ReadOnly = true;
            Topalm_Alınan_Mal.Width = 125;
            // 
            // Toplam_Odenen_Para
            // 
            Toplam_Odenen_Para.HeaderText = "Toplam Ödenen Para";
            Toplam_Odenen_Para.MinimumWidth = 6;
            Toplam_Odenen_Para.Name = "Toplam_Odenen_Para";
            Toplam_Odenen_Para.ReadOnly = true;
            Toplam_Odenen_Para.Width = 125;
            // 
            // Toplam_Borc_Durum
            // 
            Toplam_Borc_Durum.HeaderText = "Toplam Borç Durum";
            Toplam_Borc_Durum.MinimumWidth = 6;
            Toplam_Borc_Durum.Name = "Toplam_Borc_Durum";
            Toplam_Borc_Durum.ReadOnly = true;
            Toplam_Borc_Durum.Width = 125;
            // 
            // panel2
            // 
            panel2.Controls.Add(InToExcell);
            panel2.Controls.Add(OutToExcell);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1212, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 710);
            panel2.TabIndex = 0;
            // 
            // InToExcell
            // 
            InToExcell.Dock = DockStyle.Bottom;
            InToExcell.Location = new Point(0, 652);
            InToExcell.Name = "InToExcell";
            InToExcell.Size = new Size(250, 29);
            InToExcell.TabIndex = 3;
            InToExcell.Text = "Exccele Veri Yükle";
            InToExcell.UseVisualStyleBackColor = true;
            InToExcell.Click += InToExcell_Click;
            // 
            // OutToExcell
            // 
            OutToExcell.Dock = DockStyle.Bottom;
            OutToExcell.Location = new Point(0, 681);
            OutToExcell.Name = "OutToExcell";
            OutToExcell.Size = new Size(250, 29);
            OutToExcell.TabIndex = 2;
            OutToExcell.Text = "Excellden Veri Al";
            OutToExcell.UseVisualStyleBackColor = true;
            OutToExcell.Click += button3_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(button2);
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(cmbSelectCari);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 82);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 179);
            panel4.TabIndex = 1;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.Location = new Point(0, 127);
            button2.Name = "button2";
            button2.Size = new Size(250, 37);
            button2.TabIndex = 4;
            button2.Text = "Ekle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel7
            // 
            panel7.AutoSize = true;
            panel7.Controls.Add(txtVergiNo);
            panel7.Controls.Add(label3);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 94);
            panel7.Name = "panel7";
            panel7.Size = new Size(250, 33);
            panel7.TabIndex = 3;
            // 
            // txtVergiNo
            // 
            txtVergiNo.Location = new Point(96, 3);
            txtVergiNo.Name = "txtVergiNo";
            txtVergiNo.Size = new Size(151, 27);
            txtVergiNo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 6);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 0;
            label3.Text = "Vergi No:";
            // 
            // panel6
            // 
            panel6.AutoSize = true;
            panel6.Controls.Add(txtTelNo);
            panel6.Controls.Add(label2);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 61);
            panel6.Name = "panel6";
            panel6.Size = new Size(250, 33);
            panel6.TabIndex = 2;
            // 
            // txtTelNo
            // 
            txtTelNo.Location = new Point(96, 3);
            txtTelNo.Name = "txtTelNo";
            txtTelNo.Size = new Size(151, 27);
            txtTelNo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 6);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 0;
            label2.Text = "İletişim No:";
            // 
            // panel5
            // 
            panel5.AutoSize = true;
            panel5.Controls.Add(txtName);
            panel5.Controls.Add(label1);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 28);
            panel5.Name = "panel5";
            panel5.Size = new Size(250, 33);
            panel5.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(96, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(151, 27);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 6);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 0;
            label1.Text = "Ad:";
            // 
            // cmbSelectCari
            // 
            cmbSelectCari.Dock = DockStyle.Top;
            cmbSelectCari.FormattingEnabled = true;
            cmbSelectCari.Location = new Point(0, 0);
            cmbSelectCari.Name = "cmbSelectCari";
            cmbSelectCari.Size = new Size(250, 28);
            cmbSelectCari.TabIndex = 0;
            cmbSelectCari.SelectedIndexChanged += cmbSelectCari_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.Controls.Add(EditCari);
            panel3.Controls.Add(NewCari);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 82);
            panel3.TabIndex = 0;
            // 
            // EditCari
            // 
            EditCari.Dock = DockStyle.Top;
            EditCari.Location = new Point(0, 41);
            EditCari.Name = "EditCari";
            EditCari.Size = new Size(250, 41);
            EditCari.TabIndex = 1;
            EditCari.Text = "Düzenle";
            EditCari.UseVisualStyleBackColor = true;
            EditCari.Click += EditCari_Click;
            // 
            // NewCari
            // 
            NewCari.Dock = DockStyle.Top;
            NewCari.Location = new Point(0, 0);
            NewCari.Name = "NewCari";
            NewCari.Size = new Size(250, 41);
            NewCari.TabIndex = 0;
            NewCari.Text = "Yeni Kayıt";
            NewCari.UseVisualStyleBackColor = true;
            NewCari.Click += NewCari_Click;
            // 
            // Cari_Kartlari
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "Cari_Kartlari";
            Size = new Size(1462, 710);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Cari_No;
        private DataGridViewTextBoxColumn Cari_Unvan;
        private DataGridViewTextBoxColumn Ilatisim_No;
        private DataGridViewTextBoxColumn Vergi_No;
        private DataGridViewTextBoxColumn Topalm_Alınan_Mal;
        private DataGridViewTextBoxColumn Toplam_Odenen_Para;
        private DataGridViewTextBoxColumn Toplam_Borc_Durum;
        private Panel panel2;
        private Panel panel3;
        private Button NewCari;
        private Button EditCari;
        private Panel panel4;
        private ComboBox cmbSelectCari;
        private Panel panel5;
        private Label label1;
        private Button InToExcell;
        private Panel panel7;
        private TextBox textBox3;
        private Label label3;
        private Panel panel6;
        private TextBox textBox2;
        private Label label2;
        private TextBox txtName;
        private TextBox txtTelNo;
        private TextBox txtVergiNo;
        private Button button2;
        private Button OutToExcell;
    }
}
