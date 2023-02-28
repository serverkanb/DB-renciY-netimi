namespace DbSinavNotu
{
    partial class Form1
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnListele = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.Btngüncelle = new System.Windows.Forms.Button();
            this.BtnBul = new System.Windows.Forms.Button();
            this.BtnNotListele = new System.Windows.Forms.Button();
            this.BtnOgrenciListele = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtıd = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfotograf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Öğrenciler = new System.Windows.Forms.GroupBox();
            this.Dersler = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Notlar = new System.Windows.Forms.GroupBox();
            this.txtortalama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsinav3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsinav2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtsinav1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnProsedür = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.btn80 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Öğrenciler.SuspendLayout();
            this.Dersler.SuspendLayout();
            this.Notlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(12, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(973, 288);
            this.dataGridView1.TabIndex = 0;
            // 
            // BtnListele
            // 
            this.BtnListele.Location = new System.Drawing.Point(12, 298);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(116, 34);
            this.BtnListele.TabIndex = 1;
            this.BtnListele.Text = "Listele";
            this.BtnListele.UseVisualStyleBackColor = true;
            this.BtnListele.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(12, 339);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(116, 34);
            this.BtnKaydet.TabIndex = 2;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(12, 379);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(116, 34);
            this.BtnSil.TabIndex = 3;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // Btngüncelle
            // 
            this.Btngüncelle.Location = new System.Drawing.Point(12, 419);
            this.Btngüncelle.Name = "Btngüncelle";
            this.Btngüncelle.Size = new System.Drawing.Size(116, 34);
            this.Btngüncelle.TabIndex = 4;
            this.Btngüncelle.Text = "Güncelle";
            this.Btngüncelle.UseVisualStyleBackColor = true;
            this.Btngüncelle.Click += new System.EventHandler(this.Btngüncelle_Click);
            // 
            // BtnBul
            // 
            this.BtnBul.Location = new System.Drawing.Point(12, 459);
            this.BtnBul.Name = "BtnBul";
            this.BtnBul.Size = new System.Drawing.Size(116, 34);
            this.BtnBul.TabIndex = 5;
            this.BtnBul.Text = "Bul";
            this.BtnBul.UseVisualStyleBackColor = true;
            this.BtnBul.Click += new System.EventHandler(this.BtnBul_Click);
            // 
            // BtnNotListele
            // 
            this.BtnNotListele.Location = new System.Drawing.Point(12, 539);
            this.BtnNotListele.Name = "BtnNotListele";
            this.BtnNotListele.Size = new System.Drawing.Size(116, 34);
            this.BtnNotListele.TabIndex = 6;
            this.BtnNotListele.Text = "Not Listele";
            this.BtnNotListele.UseVisualStyleBackColor = true;
            this.BtnNotListele.Click += new System.EventHandler(this.BtnNotListele_Click);
            // 
            // BtnOgrenciListele
            // 
            this.BtnOgrenciListele.Location = new System.Drawing.Point(12, 499);
            this.BtnOgrenciListele.Name = "BtnOgrenciListele";
            this.BtnOgrenciListele.Size = new System.Drawing.Size(116, 34);
            this.BtnOgrenciListele.TabIndex = 7;
            this.BtnOgrenciListele.Text = "Ders Listele";
            this.BtnOgrenciListele.UseVisualStyleBackColor = true;
            this.BtnOgrenciListele.Click += new System.EventHandler(this.BtnOgrenciListele_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtıd
            // 
            this.txtıd.Location = new System.Drawing.Point(139, 23);
            this.txtıd.Name = "txtıd";
            this.txtıd.Size = new System.Drawing.Size(157, 22);
            this.txtıd.TabIndex = 9;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(139, 58);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(157, 22);
            this.txtad.TabIndex = 11;
            this.txtad.TextChanged += new System.EventHandler(this.txtad_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "AD";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(139, 104);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(157, 22);
            this.txtsoyad.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "SOYAD";
            // 
            // txtfotograf
            // 
            this.txtfotograf.Location = new System.Drawing.Point(139, 144);
            this.txtfotograf.Name = "txtfotograf";
            this.txtfotograf.Size = new System.Drawing.Size(157, 22);
            this.txtfotograf.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "FOTOĞRAF";
            // 
            // Öğrenciler
            // 
            this.Öğrenciler.Controls.Add(this.txtfotograf);
            this.Öğrenciler.Controls.Add(this.label4);
            this.Öğrenciler.Controls.Add(this.txtsoyad);
            this.Öğrenciler.Controls.Add(this.label3);
            this.Öğrenciler.Controls.Add(this.txtad);
            this.Öğrenciler.Controls.Add(this.label2);
            this.Öğrenciler.Controls.Add(this.txtıd);
            this.Öğrenciler.Controls.Add(this.label1);
            this.Öğrenciler.Location = new System.Drawing.Point(134, 298);
            this.Öğrenciler.Name = "Öğrenciler";
            this.Öğrenciler.Size = new System.Drawing.Size(391, 203);
            this.Öğrenciler.TabIndex = 16;
            this.Öğrenciler.TabStop = false;
            this.Öğrenciler.Text = "Öğrenciler";
            // 
            // Dersler
            // 
            this.Dersler.Controls.Add(this.textBox7);
            this.Dersler.Controls.Add(this.label7);
            this.Dersler.Controls.Add(this.textBox8);
            this.Dersler.Controls.Add(this.label8);
            this.Dersler.Location = new System.Drawing.Point(134, 517);
            this.Dersler.Name = "Dersler";
            this.Dersler.Size = new System.Drawing.Size(391, 113);
            this.Dersler.TabIndex = 17;
            this.Dersler.TabStop = false;
            this.Dersler.Text = "Dersler";
            this.Dersler.Enter += new System.EventHandler(this.Dersler_Enter);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(139, 64);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(157, 22);
            this.textBox7.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "AD";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(139, 23);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(157, 22);
            this.textBox8.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "ID";
            // 
            // Notlar
            // 
            this.Notlar.Controls.Add(this.txtortalama);
            this.Notlar.Controls.Add(this.label5);
            this.Notlar.Controls.Add(this.txtsinav3);
            this.Notlar.Controls.Add(this.label6);
            this.Notlar.Controls.Add(this.txtsinav2);
            this.Notlar.Controls.Add(this.label9);
            this.Notlar.Controls.Add(this.txtsinav1);
            this.Notlar.Controls.Add(this.label10);
            this.Notlar.Location = new System.Drawing.Point(594, 298);
            this.Notlar.Name = "Notlar";
            this.Notlar.Size = new System.Drawing.Size(391, 203);
            this.Notlar.TabIndex = 18;
            this.Notlar.TabStop = false;
            this.Notlar.Text = "Sınavlar";
            // 
            // txtortalama
            // 
            this.txtortalama.Location = new System.Drawing.Point(139, 133);
            this.txtortalama.Name = "txtortalama";
            this.txtortalama.Size = new System.Drawing.Size(157, 22);
            this.txtortalama.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "ORTALAMA";
            // 
            // txtsinav3
            // 
            this.txtsinav3.Location = new System.Drawing.Point(139, 93);
            this.txtsinav3.Name = "txtsinav3";
            this.txtsinav3.Size = new System.Drawing.Size(157, 22);
            this.txtsinav3.TabIndex = 13;
            this.txtsinav3.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "SINAV3";
            // 
            // txtsinav2
            // 
            this.txtsinav2.Location = new System.Drawing.Point(139, 58);
            this.txtsinav2.Name = "txtsinav2";
            this.txtsinav2.Size = new System.Drawing.Size(157, 22);
            this.txtsinav2.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "SINAV2";
            // 
            // txtsinav1
            // 
            this.txtsinav1.Location = new System.Drawing.Point(139, 23);
            this.txtsinav1.Name = "txtsinav1";
            this.txtsinav1.Size = new System.Drawing.Size(157, 22);
            this.txtsinav1.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "SINAV1";
            // 
            // BtnProsedür
            // 
            this.BtnProsedür.Location = new System.Drawing.Point(12, 579);
            this.BtnProsedür.Name = "BtnProsedür";
            this.BtnProsedür.Size = new System.Drawing.Size(116, 34);
            this.BtnProsedür.TabIndex = 19;
            this.BtnProsedür.Text = "PROSEDÜR";
            this.BtnProsedür.UseVisualStyleBackColor = true;
            this.BtnProsedür.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(1024, 130);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 20);
            this.radioButton1.TabIndex = 20;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "A===>Z";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(1024, 156);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 20);
            this.radioButton2.TabIndex = 21;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Z===>A";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1038, 424);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 58);
            this.button2.TabIndex = 22;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(1024, 182);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(82, 20);
            this.radioButton3.TabIndex = 23;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "ilk 3 kayıt";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(1024, 208);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(112, 20);
            this.radioButton4.TabIndex = 24;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Toplam Sınav";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(1024, 234);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(125, 20);
            this.radioButton5.TabIndex = 25;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Toplam Öğrenci";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.radioButton6.Location = new System.Drawing.Point(1024, 260);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(127, 20);
            this.radioButton6.TabIndex = 26;
            this.radioButton6.Text = "Sınav1 Ortalama";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.radioButton7.Location = new System.Drawing.Point(1024, 286);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(117, 20);
            this.radioButton7.TabIndex = 27;
            this.radioButton7.Text = "Değer  Var mı?";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.radioButton8.Location = new System.Drawing.Point(1024, 312);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(162, 20);
            this.radioButton8.TabIndex = 28;
            this.radioButton8.Text = "En yüksek Sınav1 notu";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(733, 517);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 34);
            this.button3.TabIndex = 29;
            this.button3.Text = "Hesapla";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.radioButton9.Location = new System.Drawing.Point(1024, 339);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(189, 20);
            this.radioButton9.TabIndex = 30;
            this.radioButton9.Text = "En yüksel sınav notu kimde";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // btn80
            // 
            this.btn80.AutoSize = true;
            this.btn80.Location = new System.Drawing.Point(1024, 362);
            this.btn80.Name = "btn80";
            this.btn80.Size = new System.Drawing.Size(107, 20);
            this.btn80.TabIndex = 31;
            this.btn80.TabStop = true;
            this.btn80.Text = "80\'den büyük";
            this.btn80.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1214, 678);
            this.Controls.Add(this.btn80);
            this.Controls.Add(this.radioButton9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.radioButton8);
            this.Controls.Add(this.radioButton7);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.BtnProsedür);
            this.Controls.Add(this.Notlar);
            this.Controls.Add(this.Dersler);
            this.Controls.Add(this.Öğrenciler);
            this.Controls.Add(this.BtnOgrenciListele);
            this.Controls.Add(this.BtnNotListele);
            this.Controls.Add(this.BtnBul);
            this.Controls.Add(this.Btngüncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "GG";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Öğrenciler.ResumeLayout(false);
            this.Öğrenciler.PerformLayout();
            this.Dersler.ResumeLayout(false);
            this.Dersler.PerformLayout();
            this.Notlar.ResumeLayout(false);
            this.Notlar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button Btngüncelle;
        private System.Windows.Forms.Button BtnBul;
        private System.Windows.Forms.Button BtnNotListele;
        private System.Windows.Forms.Button BtnOgrenciListele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtıd;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtfotograf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox Öğrenciler;
        private System.Windows.Forms.GroupBox Dersler;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox Notlar;
        private System.Windows.Forms.TextBox txtortalama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsinav3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsinav2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtsinav1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnProsedür;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton btn80;
    }
}

