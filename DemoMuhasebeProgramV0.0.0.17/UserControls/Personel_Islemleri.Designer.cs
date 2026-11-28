namespace DemoMuhasebeProgram
{
    partial class Personel_Islemleri
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
            PersonelNo = new DataGridViewTextBoxColumn();
            Personel_Name = new DataGridViewTextBoxColumn();
            Personel_Last_Name = new DataGridViewTextBoxColumn();
            TC = new DataGridViewTextBoxColumn();
            Tel = new DataGridViewTextBoxColumn();
            Personel_Durum = new DataGridViewCheckBoxColumn();
            panel2 = new Panel();
            InToExcell = new Button();
            OutToExcell = new Button();
            txtPersonelKod = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            txtLastName = new TextBox();
            panel3 = new Panel();
            label6 = new Label();
            comboBox1 = new ComboBox();
            checkBox1 = new CheckBox();
            btnEdit = new Button();
            label2 = new Label();
            btnNew = new Button();
            txtTelNo = new TextBox();
            button1 = new Button();
            label5 = new Label();
            label4 = new Label();
            txtTC = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
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
            panel1.Size = new Size(1405, 692);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { PersonelNo, Personel_Name, Personel_Last_Name, TC, Tel, Personel_Durum });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Enabled = false;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1071, 692);
            dataGridView1.TabIndex = 1;
            // 
            // PersonelNo
            // 
            PersonelNo.HeaderText = "Personel No";
            PersonelNo.MinimumWidth = 6;
            PersonelNo.Name = "PersonelNo";
            PersonelNo.ReadOnly = true;
            PersonelNo.Width = 125;
            // 
            // Personel_Name
            // 
            Personel_Name.HeaderText = "İsim";
            Personel_Name.MinimumWidth = 6;
            Personel_Name.Name = "Personel_Name";
            Personel_Name.ReadOnly = true;
            Personel_Name.Width = 125;
            // 
            // Personel_Last_Name
            // 
            Personel_Last_Name.HeaderText = "Soyadı";
            Personel_Last_Name.MinimumWidth = 6;
            Personel_Last_Name.Name = "Personel_Last_Name";
            Personel_Last_Name.ReadOnly = true;
            Personel_Last_Name.Width = 125;
            // 
            // TC
            // 
            TC.HeaderText = "TC No";
            TC.MinimumWidth = 6;
            TC.Name = "TC";
            TC.Width = 125;
            // 
            // Tel
            // 
            Tel.HeaderText = "Tel No";
            Tel.MinimumWidth = 6;
            Tel.Name = "Tel";
            Tel.Width = 125;
            // 
            // Personel_Durum
            // 
            Personel_Durum.HeaderText = "Aktif";
            Personel_Durum.MinimumWidth = 6;
            Personel_Durum.Name = "Personel_Durum";
            Personel_Durum.ReadOnly = true;
            Personel_Durum.Width = 125;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(InToExcell);
            panel2.Controls.Add(OutToExcell);
            panel2.Controls.Add(txtPersonelKod);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtLastName);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(btnEdit);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnNew);
            panel2.Controls.Add(txtTelNo);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtTC);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1071, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(334, 692);
            panel2.TabIndex = 0;
            // 
            // InToExcell
            // 
            InToExcell.Dock = DockStyle.Bottom;
            InToExcell.Location = new Point(0, 634);
            InToExcell.Name = "InToExcell";
            InToExcell.Size = new Size(334, 29);
            InToExcell.TabIndex = 23;
            InToExcell.Text = "Excelle Veri Aktar";
            InToExcell.UseVisualStyleBackColor = true;
            InToExcell.Click += InToExcell_Click;
            // 
            // OutToExcell
            // 
            OutToExcell.Dock = DockStyle.Bottom;
            OutToExcell.Location = new Point(0, 663);
            OutToExcell.Name = "OutToExcell";
            OutToExcell.Size = new Size(334, 29);
            OutToExcell.TabIndex = 22;
            OutToExcell.Text = "Excellden veri Al";
            OutToExcell.UseVisualStyleBackColor = true;
            OutToExcell.Click += OutToExcell_Click;
            // 
            // txtPersonelKod
            // 
            txtPersonelKod.Enabled = false;
            txtPersonelKod.Location = new Point(74, 414);
            txtPersonelKod.Name = "txtPersonelKod";
            txtPersonelKod.Size = new Size(125, 27);
            txtPersonelKod.TabIndex = 20;
            txtPersonelKod.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 148);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 19;
            label3.Text = "Soyad:";
            // 
            // txtName
            // 
            txtName.Location = new Point(123, 112);
            txtName.Name = "txtName";
            txtName.Size = new Size(204, 27);
            txtName.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 115);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 17;
            label1.Text = "Ad:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(123, 145);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(204, 27);
            txtLastName.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Controls.Add(label6);
            panel3.Controls.Add(comboBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 58);
            panel3.Name = "panel3";
            panel3.Size = new Size(334, 48);
            panel3.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 13);
            label6.Name = "label6";
            label6.Size = new Size(118, 20);
            label6.TabIndex = 1;
            label6.Text = "Seçilen Personel:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(127, 10);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 28);
            comboBox1.TabIndex = 0;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(123, 246);
            checkBox1.Name = "checkBox1";
            checkBox1.RightToLeft = RightToLeft.Yes;
            checkBox1.Size = new Size(18, 17);
            checkBox1.TabIndex = 2;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Dock = DockStyle.Top;
            btnEdit.Location = new Point(0, 29);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(334, 29);
            btnEdit.TabIndex = 14;
            btnEdit.Text = "Düzenle";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 243);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 3;
            label2.Text = "Aktif:";
            // 
            // btnNew
            // 
            btnNew.Dock = DockStyle.Top;
            btnNew.FlatStyle = FlatStyle.System;
            btnNew.Location = new Point(0, 0);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(334, 29);
            btnNew.TabIndex = 13;
            btnNew.Text = "Yeni Kayıt";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // txtTelNo
            // 
            txtTelNo.Location = new Point(123, 211);
            txtTelNo.Name = "txtTelNo";
            txtTelNo.Size = new Size(204, 27);
            txtTelNo.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(123, 269);
            button1.Name = "button1";
            button1.Size = new Size(179, 29);
            button1.TabIndex = 4;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 181);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 9;
            label5.Text = "T.C No:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 214);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 10;
            label4.Text = "Tel No:";
            // 
            // txtTC
            // 
            txtTC.Location = new Point(123, 178);
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(204, 27);
            txtTC.TabIndex = 8;
            // 
            // Personel_Islemleri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "Personel_Islemleri";
            Size = new Size(1405, 692);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private TextBox txtName;
        private Label label2;
        private CheckBox checkBox1;
        private Button button1;
        private TextBox txtLastName;
        private TextBox txtTelNo;
        private Label label4;
        private TextBox txtTC;
        private Label label5;
        private DataGridViewTextBoxColumn PersonelNo;
        private DataGridViewTextBoxColumn Personel_Name;
        private DataGridViewTextBoxColumn Personel_Last_Name;
        private DataGridViewTextBoxColumn TC;
        private DataGridViewTextBoxColumn Tel;
        private DataGridViewCheckBoxColumn Personel_Durum;
        private RadioButton radioButton2;
        private Button btnNew;
        private Button btnEdit;
        private Panel panel3;
        private ComboBox comboBox1;
        private Label label6;
        private Label label1;
        private Label label3;
        private TextBox txtPersonelKod;
        private Button button3;
        private Button InToExcell;
        private Button OutToExcell;
    }
}
