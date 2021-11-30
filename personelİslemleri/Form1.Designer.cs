
namespace personelİslemleri
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.cmbDogTarih = new System.Windows.Forms.ComboBox();
            this.cmbDogYer = new System.Windows.Forms.ComboBox();
            this.cmbİsBasla = new System.Windows.Forms.ComboBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPrimHesap = new System.Windows.Forms.Label();
            this.txtKira = new System.Windows.Forms.TextBox();
            this.txtSat = new System.Windows.Forms.TextBox();
            this.btnPrimHesap = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblhesap = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.cmbTazİsBas = new System.Windows.Forms.ComboBox();
            this.lstPersonel = new System.Windows.Forms.ListBox();
            this.cmbBirim = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbBirim);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.cmbDogTarih);
            this.groupBox1.Controls.Add(this.cmbDogYer);
            this.groupBox1.Controls.Add(this.cmbİsBasla);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtTc);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Location = new System.Drawing.Point(22, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 426);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Ekle";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(139, 337);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(121, 38);
            this.btnEkle.TabIndex = 30;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // cmbDogTarih
            // 
            this.cmbDogTarih.FormattingEnabled = true;
            this.cmbDogTarih.Items.AddRange(new object[] {
            "12 mart 1960",
            "17 eylül 1974",
            "26 aralık 1977"});
            this.cmbDogTarih.Location = new System.Drawing.Point(139, 281);
            this.cmbDogTarih.Name = "cmbDogTarih";
            this.cmbDogTarih.Size = new System.Drawing.Size(121, 24);
            this.cmbDogTarih.TabIndex = 29;
            // 
            // cmbDogYer
            // 
            this.cmbDogYer.FormattingEnabled = true;
            this.cmbDogYer.Items.AddRange(new object[] {
            "İstanbul",
            "Ankara",
            "Burdur"});
            this.cmbDogYer.Location = new System.Drawing.Point(139, 244);
            this.cmbDogYer.Name = "cmbDogYer";
            this.cmbDogYer.Size = new System.Drawing.Size(121, 24);
            this.cmbDogYer.TabIndex = 28;
            // 
            // cmbİsBasla
            // 
            this.cmbİsBasla.FormattingEnabled = true;
            this.cmbİsBasla.Items.AddRange(new object[] {
            "29 kasım 2019",
            "29 kasım 2018",
            "29 kasım 2017"});
            this.cmbİsBasla.Location = new System.Drawing.Point(139, 205);
            this.cmbİsBasla.Name = "cmbİsBasla";
            this.cmbİsBasla.Size = new System.Drawing.Size(121, 24);
            this.cmbİsBasla.TabIndex = 27;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(139, 133);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtSoyad.TabIndex = 25;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(139, 99);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 22);
            this.txtAd.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Doğum Tarihi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Doğum Yeri:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "İşe Başlama Tarihi:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Birim:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 17);
            this.label12.TabIndex = 19;
            this.label12.Text = "Soyad:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 17);
            this.label13.TabIndex = 18;
            this.label13.Text = "Ad:";
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(139, 58);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(100, 22);
            this.txtTc.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(-27, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 17);
            this.label14.TabIndex = 16;
            this.label14.Text = "Tc:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Tc:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPrimHesap);
            this.groupBox2.Controls.Add(this.txtSat);
            this.groupBox2.Controls.Add(this.txtKira);
            this.groupBox2.Controls.Add(this.lblPrimHesap);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(349, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(486, 223);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Maaş Hesapla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kiralanan Ev Sayısı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Satılan Ev Sayısı:";
            // 
            // lblPrimHesap
            // 
            this.lblPrimHesap.AutoSize = true;
            this.lblPrimHesap.Location = new System.Drawing.Point(95, 188);
            this.lblPrimHesap.Name = "lblPrimHesap";
            this.lblPrimHesap.Size = new System.Drawing.Size(68, 17);
            this.lblPrimHesap.TabIndex = 2;
            this.lblPrimHesap.Text = "...............";
            // 
            // txtKira
            // 
            this.txtKira.Location = new System.Drawing.Point(173, 29);
            this.txtKira.Name = "txtKira";
            this.txtKira.Size = new System.Drawing.Size(100, 22);
            this.txtKira.TabIndex = 3;
            // 
            // txtSat
            // 
            this.txtSat.Location = new System.Drawing.Point(173, 67);
            this.txtSat.Name = "txtSat";
            this.txtSat.Size = new System.Drawing.Size(100, 22);
            this.txtSat.TabIndex = 4;
            // 
            // btnPrimHesap
            // 
            this.btnPrimHesap.Location = new System.Drawing.Point(98, 117);
            this.btnPrimHesap.Name = "btnPrimHesap";
            this.btnPrimHesap.Size = new System.Drawing.Size(156, 38);
            this.btnPrimHesap.TabIndex = 5;
            this.btnPrimHesap.Text = "Primli Maaşı Hesapla";
            this.btnPrimHesap.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbTazİsBas);
            this.groupBox3.Controls.Add(this.txtYil);
            this.groupBox3.Controls.Add(this.btnHesapla);
            this.groupBox3.Controls.Add(this.lblhesap);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(349, 231);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(486, 197);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Yıllık Tazminat Hesapla";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(383, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tazminat hesaplanabilmesi için yıl giriniz veya tarih seçiniz  ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "İşe Başlama Tarihi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Yıl:";
            // 
            // lblhesap
            // 
            this.lblhesap.AutoSize = true;
            this.lblhesap.Location = new System.Drawing.Point(360, 150);
            this.lblhesap.Name = "lblhesap";
            this.lblhesap.Size = new System.Drawing.Size(68, 17);
            this.lblhesap.TabIndex = 3;
            this.lblhesap.Text = "...............";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(347, 74);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(84, 36);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            // 
            // txtYil
            // 
            this.txtYil.Location = new System.Drawing.Point(173, 77);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(100, 22);
            this.txtYil.TabIndex = 5;
            // 
            // cmbTazİsBas
            // 
            this.cmbTazİsBas.FormattingEnabled = true;
            this.cmbTazİsBas.Location = new System.Drawing.Point(173, 114);
            this.cmbTazİsBas.Name = "cmbTazİsBas";
            this.cmbTazİsBas.Size = new System.Drawing.Size(121, 24);
            this.cmbTazİsBas.TabIndex = 6;
            // 
            // lstPersonel
            // 
            this.lstPersonel.FormattingEnabled = true;
            this.lstPersonel.ItemHeight = 16;
            this.lstPersonel.Location = new System.Drawing.Point(22, 434);
            this.lstPersonel.Name = "lstPersonel";
            this.lstPersonel.Size = new System.Drawing.Size(813, 100);
            this.lstPersonel.TabIndex = 19;
            // 
            // cmbBirim
            // 
            this.cmbBirim.FormattingEnabled = true;
            this.cmbBirim.Items.AddRange(new object[] {
            "Yönetici",
            "Çalışan",
            "Hizmetli"});
            this.cmbBirim.Location = new System.Drawing.Point(139, 166);
            this.cmbBirim.Name = "cmbBirim";
            this.cmbBirim.Size = new System.Drawing.Size(121, 24);
            this.cmbBirim.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 534);
            this.Controls.Add(this.lstPersonel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbBirim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ComboBox cmbDogTarih;
        private System.Windows.Forms.ComboBox cmbDogYer;
        private System.Windows.Forms.ComboBox cmbİsBasla;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPrimHesap;
        private System.Windows.Forms.TextBox txtSat;
        private System.Windows.Forms.TextBox txtKira;
        private System.Windows.Forms.Label lblPrimHesap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbTazİsBas;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblhesap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstPersonel;
    }
}

