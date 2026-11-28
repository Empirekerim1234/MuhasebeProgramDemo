namespace DemoMuhasebeProgram.UserControls
{
    partial class PersonelGiderIsleme
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
            SatirNo = new DataGridViewTextBoxColumn();
            PersonelAd = new DataGridViewTextBoxColumn();
            Katagori = new DataGridViewTextBoxColumn();
            Tutar = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            panel5 = new Panel();
            btnKaydet = new Button();
            btnExceldenVeriAl = new Button();
            btnOk = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtTutar = new TextBox();
            cmbTur = new ComboBox();
            cmbName = new ComboBox();
            dtpTarih = new DateTimePicker();
            panel4 = new Panel();
            label1 = new Label();
            cmbSelected = new ComboBox();
            panel3 = new Panel();
            btnEdit = new Button();
            btnNew = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
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
            panel1.Size = new Size(1450, 563);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { SatirNo, PersonelAd, Katagori, Tutar });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1177, 563);
            dataGridView1.TabIndex = 1;
            // 
            // SatirNo
            // 
            SatirNo.HeaderText = "No";
            SatirNo.MinimumWidth = 6;
            SatirNo.Name = "SatirNo";
            SatirNo.Width = 125;
            // 
            // PersonelAd
            // 
            PersonelAd.HeaderText = "Ad";
            PersonelAd.MinimumWidth = 6;
            PersonelAd.Name = "PersonelAd";
            PersonelAd.Width = 125;
            // 
            // Katagori
            // 
            Katagori.HeaderText = "Tur";
            Katagori.MinimumWidth = 6;
            Katagori.Name = "Katagori";
            Katagori.Width = 125;
            // 
            // Tutar
            // 
            Tutar.HeaderText = "Tutar";
            Tutar.MinimumWidth = 6;
            Tutar.Name = "Tutar";
            Tutar.Width = 125;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(btnOk);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtTutar);
            panel2.Controls.Add(cmbTur);
            panel2.Controls.Add(cmbName);
            panel2.Controls.Add(dtpTarih);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1177, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(273, 563);
            panel2.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.AutoSize = true;
            panel5.Controls.Add(btnKaydet);
            panel5.Controls.Add(btnExceldenVeriAl);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 505);
            panel5.Name = "panel5";
            panel5.Size = new Size(273, 58);
            panel5.TabIndex = 10;
            // 
            // btnKaydet
            // 
            btnKaydet.Dock = DockStyle.Bottom;
            btnKaydet.Location = new Point(0, 0);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(273, 29);
            btnKaydet.TabIndex = 0;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            // 
            // btnExceldenVeriAl
            // 
            btnExceldenVeriAl.Dock = DockStyle.Bottom;
            btnExceldenVeriAl.Location = new Point(0, 29);
            btnExceldenVeriAl.Name = "btnExceldenVeriAl";
            btnExceldenVeriAl.Size = new Size(273, 29);
            btnExceldenVeriAl.TabIndex = 1;
            btnExceldenVeriAl.Text = "Excellden Veri Al";
            btnExceldenVeriAl.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(119, 237);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(151, 29);
            btnOk.TabIndex = 9;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 207);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 8;
            label4.Text = "Tutar:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 173);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 7;
            label3.Text = "Ödeme Türü:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 139);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 6;
            label2.Text = "Personel Adı:";
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(119, 204);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(151, 27);
            txtTutar.TabIndex = 5;
            // 
            // cmbTur
            // 
            cmbTur.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTur.FormattingEnabled = true;
            cmbTur.Location = new Point(119, 170);
            cmbTur.Name = "cmbTur";
            cmbTur.Size = new Size(151, 28);
            cmbTur.TabIndex = 4;
            // 
            // cmbName
            // 
            cmbName.FormattingEnabled = true;
            cmbName.Location = new Point(119, 136);
            cmbName.Name = "cmbName";
            cmbName.Size = new Size(151, 28);
            cmbName.TabIndex = 3;
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(20, 103);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(250, 27);
            dtpTarih.TabIndex = 2;
            dtpTarih.ValueChanged += dtpTarih_ValueChanged;
            // 
            // panel4
            // 
            panel4.AutoSize = true;
            panel4.Controls.Add(label1);
            panel4.Controls.Add(cmbSelected);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 60);
            panel4.Name = "panel4";
            panel4.Size = new Size(273, 37);
            panel4.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 9);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 1;
            label1.Text = "Seçili Satır No:";
            // 
            // cmbSelected
            // 
            cmbSelected.FormattingEnabled = true;
            cmbSelected.Location = new Point(119, 6);
            cmbSelected.Name = "cmbSelected";
            cmbSelected.Size = new Size(151, 28);
            cmbSelected.TabIndex = 0;
            cmbSelected.SelectedIndexChanged += cmbSelected_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnEdit);
            panel3.Controls.Add(btnNew);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(273, 60);
            panel3.TabIndex = 0;
            // 
            // btnEdit
            // 
            btnEdit.Dock = DockStyle.Top;
            btnEdit.Location = new Point(0, 29);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(273, 29);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Satır Düzenle";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnNew
            // 
            btnNew.Dock = DockStyle.Top;
            btnNew.Location = new Point(0, 0);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(273, 29);
            btnNew.TabIndex = 0;
            btnNew.Text = "Yeni Satır";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // PersonelGiderIsleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "PersonelGiderIsleme";
            Size = new Size(1450, 563);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn SatirNo;
        private DataGridViewTextBoxColumn PersonelAd;
        private DataGridViewTextBoxColumn Katagori;
        private DataGridViewTextBoxColumn Tutar;
        private Panel panel2;
        private Panel panel3;
        private Button btnNew;
        private Panel panel4;
        private ComboBox cmbSelected;
        private Button btnEdit;
        private DateTimePicker dtpTarih;
        private Label label1;
        private TextBox txtTutar;
        private ComboBox cmbTur;
        private ComboBox cmbName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel5;
        private Button btnKaydet;
        private Button btnExceldenVeriAl;
        private Button btnOk;
    }
}
