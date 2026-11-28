namespace DemoMuhasebeProgram
{
    partial class KullanıcıGiris
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            textBox2 = new TextBox();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 503);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(352, 163);
            panel2.Name = "panel2";
            panel2.Size = new Size(228, 136);
            panel2.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(25, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 27);
            textBox2.TabIndex = 2;
            textBox2.Text = "Kerim Uygar Oynar";
            // 
            // button3
            // 
            button3.Location = new Point(25, 104);
            button3.MaximumSize = new Size(200, 29);
            button3.MinimumSize = new Size(200, 29);
            button3.Name = "button3";
            button3.Size = new Size(200, 29);
            button3.TabIndex = 4;
            button3.Text = "Çıkış Yap";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(25, 69);
            button1.Name = "button1";
            button1.Size = new Size(95, 29);
            button1.TabIndex = 0;
            button1.Text = "Giriş";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(130, 69);
            button2.Name = "button2";
            button2.Size = new Size(95, 29);
            button2.TabIndex = 3;
            button2.Text = "Yeni Kullanıcı";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(25, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 27);
            textBox1.TabIndex = 1;
            textBox1.Text = "123456";
            // 
            // KullanıcıGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(982, 503);
            Controls.Add(panel1);
            MaximumSize = new Size(1000, 550);
            MinimumSize = new Size(1000, 550);
            Name = "KullanıcıGiris";
            Text = "KullanıcıGiris";
            SizeChanged += KullanıcıGiris_SizeChanged;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel2;
    }
}