namespace DemoMuhasebeProgram.UserControls
{
    partial class GiderIsleme
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
            Id = new DataGridViewTextBoxColumn();
            GiderName = new DataGridViewTextBoxColumn();
            Katagori = new DataGridViewTextBoxColumn();
            Tutar = new DataGridViewTextBoxColumn();
            Aciklama = new DataGridViewTextBoxColumn();
            Tarih = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            panel6 = new Panel();
            button2 = new Button();
            button1 = new Button();
            panel5 = new Panel();
            label2 = new Label();
            cmbSelect = new ComboBox();
            btnOk = new Button();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            dtpTarih = new DateTimePicker();
            label1 = new Label();
            cmbName = new ComboBox();
            panel2 = new Panel();
            panel4 = new Panel();
            btnNewGiris = new Button();
            btnDuzenle = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
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
            panel1.Size = new Size(1329, 589);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, GiderName, Katagori, Tutar, Aciklama, Tarih });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1053, 505);
            dataGridView1.TabIndex = 1;
            // 
            // Id
            // 
            Id.HeaderText = "No";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // GiderName
            // 
            GiderName.HeaderText = "Gider Adı";
            GiderName.MinimumWidth = 6;
            GiderName.Name = "GiderName";
            GiderName.Width = 125;
            // 
            // Katagori
            // 
            Katagori.HeaderText = "Katagori";
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
            // Aciklama
            // 
            Aciklama.HeaderText = "Açıklama";
            Aciklama.MinimumWidth = 6;
            Aciklama.Name = "Aciklama";
            Aciklama.Width = 125;
            // 
            // Tarih
            // 
            Tarih.HeaderText = "Tarih";
            Tarih.MinimumWidth = 6;
            Tarih.Name = "Tarih";
            Tarih.Width = 125;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(btnOk);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(dtpTarih);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(cmbName);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(1053, 84);
            panel3.Name = "panel3";
            panel3.Size = new Size(276, 505);
            panel3.TabIndex = 13;
            // 
            // panel6
            // 
            panel6.Controls.Add(button2);
            panel6.Controls.Add(button1);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 357);
            panel6.Name = "panel6";
            panel6.Size = new Size(276, 148);
            panel6.TabIndex = 17;
            // 
            // button2
            // 
            button2.Location = new Point(85, 81);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Kaydet";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(85, 116);
            button1.Name = "button1";
            button1.Size = new Size(149, 29);
            button1.TabIndex = 0;
            button1.Text = "Excellden Vari Al";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel5
            // 
            panel5.AutoSize = true;
            panel5.Controls.Add(label2);
            panel5.Controls.Add(cmbSelect);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(276, 37);
            panel5.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 9);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 1;
            label2.Text = "Seçili Satır No:";
            // 
            // cmbSelect
            // 
            cmbSelect.FormattingEnabled = true;
            cmbSelect.Location = new Point(122, 6);
            cmbSelect.Name = "cmbSelect";
            cmbSelect.Size = new Size(151, 28);
            cmbSelect.TabIndex = 0;
            cmbSelect.SelectedIndexChanged += cmbSelect_SelectedIndexChanged;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(122, 220);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(151, 29);
            btnOk.TabIndex = 15;
            btnOk.Text = "button1";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 146);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 14;
            label4.Text = "Açıklama:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(122, 143);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(151, 71);
            textBox2.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 113);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 12;
            label3.Text = "Tutar:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(122, 110);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 27);
            textBox1.TabIndex = 11;
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(23, 43);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(250, 27);
            dtpTarih.TabIndex = 4;
            dtpTarih.ValueChanged += dtpTarih_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 79);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 9;
            label1.Text = "Ad Filitre:";
            // 
            // cmbName
            // 
            cmbName.FormattingEnabled = true;
            cmbName.Location = new Point(122, 76);
            cmbName.Name = "cmbName";
            cmbName.Size = new Size(151, 28);
            cmbName.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1329, 84);
            panel2.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnNewGiris);
            panel4.Controls.Add(btnDuzenle);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(1079, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 84);
            panel4.TabIndex = 0;
            // 
            // btnNewGiris
            // 
            btnNewGiris.Dock = DockStyle.Top;
            btnNewGiris.Location = new Point(0, 0);
            btnNewGiris.Name = "btnNewGiris";
            btnNewGiris.Size = new Size(250, 42);
            btnNewGiris.TabIndex = 0;
            btnNewGiris.Text = "Yeni Giriş";
            btnNewGiris.UseVisualStyleBackColor = true;
            btnNewGiris.Click += btnNewGiris_Click;
            // 
            // btnDuzenle
            // 
            btnDuzenle.Dock = DockStyle.Bottom;
            btnDuzenle.Location = new Point(0, 42);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(250, 42);
            btnDuzenle.TabIndex = 1;
            btnDuzenle.Text = "Düzenle ";
            btnDuzenle.UseVisualStyleBackColor = true;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // GiderIsleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "GiderIsleme";
            Size = new Size(1329, 589);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn GiderName;
        private DataGridViewTextBoxColumn Katagori;
        private DataGridViewTextBoxColumn Tutar;
        private DataGridViewTextBoxColumn Aciklama;
        private DataGridViewTextBoxColumn Tarih;
        private Button btnNewGiris;
        private Button btnDuzenle;
        private Label label1;
        private ComboBox cmbName;
        private DateTimePicker dtpTarih;
        private Panel panel3;
        private Panel panel4;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Button btnOk;
        private Panel panel5;
        private Label label2;
        private ComboBox cmbSelect;
        private Panel panel6;
        private Button button2;
        private Button button1;
    }
}
