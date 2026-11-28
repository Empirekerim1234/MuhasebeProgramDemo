namespace DemoMuhasebeProgram.UserControls
{
    partial class GelirKartlariTanimla
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
            Ad = new DataGridViewTextBoxColumn();
            Katagori = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            panel4 = new Panel();
            label3 = new Label();
            cmbSelect = new ComboBox();
            btnOk = new Button();
            label2 = new Label();
            label1 = new Label();
            cmbTur = new ComboBox();
            txtName = new TextBox();
            panel3 = new Panel();
            button1 = new Button();
            btnNew = new Button();
            btnEdit = new Button();
            panel5 = new Panel();
            panel6 = new Panel();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1021, 511);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { No, Ad, Katagori });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(773, 511);
            dataGridView1.TabIndex = 1;
            // 
            // No
            // 
            No.HeaderText = "No";
            No.MinimumWidth = 6;
            No.Name = "No";
            No.Width = 125;
            // 
            // Ad
            // 
            Ad.HeaderText = "Ad";
            Ad.MinimumWidth = 6;
            Ad.Name = "Ad";
            Ad.Width = 125;
            // 
            // Katagori
            // 
            Katagori.HeaderText = "Katagori";
            Katagori.MinimumWidth = 6;
            Katagori.Name = "Katagori";
            Katagori.Width = 125;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(773, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(248, 511);
            panel2.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(label3);
            panel4.Controls.Add(cmbSelect);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 87);
            panel4.Name = "panel4";
            panel4.Size = new Size(248, 45);
            panel4.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 9);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 1;
            label3.Text = "Seçim:";
            // 
            // cmbSelect
            // 
            cmbSelect.FormattingEnabled = true;
            cmbSelect.Location = new Point(94, 6);
            cmbSelect.Name = "cmbSelect";
            cmbSelect.Size = new Size(151, 28);
            cmbSelect.TabIndex = 0;
            cmbSelect.SelectedIndexChanged += cmbSelect_SelectedIndexChanged;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(94, 73);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(151, 29);
            btnOk.TabIndex = 5;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 42);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 4;
            label2.Text = "Gelir Türü:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 9);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 3;
            label1.Text = "Gelir Adı:";
            // 
            // cmbTur
            // 
            cmbTur.FormattingEnabled = true;
            cmbTur.Location = new Point(94, 39);
            cmbTur.Name = "cmbTur";
            cmbTur.Size = new Size(151, 28);
            cmbTur.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(94, 6);
            txtName.Name = "txtName";
            txtName.Size = new Size(151, 27);
            txtName.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.Controls.Add(btnEdit);
            panel3.Controls.Add(btnNew);
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(248, 87);
            panel3.TabIndex = 0;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(248, 29);
            button1.TabIndex = 0;
            button1.Text = "Yeni Katagori Oluştur";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnNew
            // 
            btnNew.Dock = DockStyle.Top;
            btnNew.Location = new Point(0, 29);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(248, 29);
            btnNew.TabIndex = 1;
            btnNew.Text = "Yeni Kayıt";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnEdit
            // 
            btnEdit.Dock = DockStyle.Top;
            btnEdit.Location = new Point(0, 58);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(248, 29);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Düzenle";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // panel5
            // 
            panel5.AutoSize = true;
            panel5.Controls.Add(txtName);
            panel5.Controls.Add(cmbTur);
            panel5.Controls.Add(btnOk);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(label2);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 132);
            panel5.Name = "panel5";
            panel5.Size = new Size(248, 105);
            panel5.TabIndex = 7;
            // 
            // panel6
            // 
            panel6.AutoSize = true;
            panel6.Controls.Add(button3);
            panel6.Controls.Add(button2);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 453);
            panel6.Name = "panel6";
            panel6.Size = new Size(248, 58);
            panel6.TabIndex = 8;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Bottom;
            button2.Location = new Point(0, 29);
            button2.Name = "button2";
            button2.Size = new Size(248, 29);
            button2.TabIndex = 0;
            button2.Text = "Excelle Veri Aktar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Bottom;
            button3.Location = new Point(0, 0);
            button3.Name = "button3";
            button3.Size = new Size(248, 29);
            button3.TabIndex = 1;
            button3.Text = "Excellden Veri Al";
            button3.UseVisualStyleBackColor = true;
            // 
            // GelirKartlariTanimla
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "GelirKartlariTanimla";
            Size = new Size(1021, 511);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Panel panel3;
        private Button button1;
        private DataGridViewTextBoxColumn No;
        private DataGridViewTextBoxColumn Ad;
        private DataGridViewTextBoxColumn Katagori;
        private Label label2;
        private Label label1;
        private ComboBox cmbTur;
        private TextBox txtName;
        private Button btnOk;
        private Panel panel4;
        private Label label3;
        private ComboBox cmbSelect;
        private Button btnNew;
        private Panel panel5;
        private Button btnEdit;
        private Panel panel6;
        private Button button3;
        private Button button2;
    }
}
