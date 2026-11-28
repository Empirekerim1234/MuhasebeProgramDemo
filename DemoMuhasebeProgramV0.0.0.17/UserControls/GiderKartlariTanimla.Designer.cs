namespace DemoMuhasebeProgram.UserControls
{
    partial class GiderKartlariTanimla
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
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            btnGiderTanimla = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            cmbKatagori = new ComboBox();
            btnNewKatagori = new Button();
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
            panel1.Size = new Size(1122, 535);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, GiderName, Katagori });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(866, 535);
            dataGridView1.TabIndex = 1;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
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
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnGiderTanimla);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(cmbKatagori);
            panel2.Controls.Add(btnNewKatagori);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(866, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(256, 535);
            panel2.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(56, 448);
            button2.Name = "button2";
            button2.Size = new Size(154, 29);
            button2.TabIndex = 7;
            button2.Text = "Excellden Veri Al";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(56, 483);
            button1.Name = "button1";
            button1.Size = new Size(154, 29);
            button1.TabIndex = 6;
            button1.Text = "Excelle Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnGiderTanimla
            // 
            btnGiderTanimla.Location = new Point(82, 105);
            btnGiderTanimla.Name = "btnGiderTanimla";
            btnGiderTanimla.Size = new Size(171, 29);
            btnGiderTanimla.TabIndex = 5;
            btnGiderTanimla.Text = "Gider Kartı Tanımla";
            btnGiderTanimla.UseVisualStyleBackColor = true;
            btnGiderTanimla.Click += btnGiderTanimla_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1, 6);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 4;
            label2.Text = "Gider Adı:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(82, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(171, 27);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 39);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 2;
            label1.Text = "Katagori:";
            // 
            // cmbKatagori
            // 
            cmbKatagori.FormattingEnabled = true;
            cmbKatagori.Location = new Point(82, 36);
            cmbKatagori.Name = "cmbKatagori";
            cmbKatagori.Size = new Size(171, 28);
            cmbKatagori.TabIndex = 1;
            // 
            // btnNewKatagori
            // 
            btnNewKatagori.Location = new Point(82, 70);
            btnNewKatagori.Name = "btnNewKatagori";
            btnNewKatagori.Size = new Size(171, 29);
            btnNewKatagori.TabIndex = 0;
            btnNewKatagori.Text = "Yeni Katagori Tanımla";
            btnNewKatagori.UseVisualStyleBackColor = true;
            btnNewKatagori.Click += btnNewKatagori_Click;
            // 
            // GiderKartlariTanimla
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "GiderKartlariTanimla";
            Size = new Size(1122, 535);
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
        private Button btnNewKatagori;
        private ComboBox cmbKatagori;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn GiderName;
        private DataGridViewTextBoxColumn Katagori;
        private Button btnGiderTanimla;
        private Button button1;
        private Button button2;
    }
}
