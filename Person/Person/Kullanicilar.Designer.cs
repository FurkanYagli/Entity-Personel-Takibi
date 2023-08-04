namespace Person
{
    partial class Kullanicilar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnAnaSayfa = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.LblSoyad = new System.Windows.Forms.Label();
            this.LblAd = new System.Windows.Forms.Label();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonYetkisiz = new System.Windows.Forms.RadioButton();
            this.radioButtonAdmin = new System.Windows.Forms.RadioButton();
            this.radioButtonSuperAdmin = new System.Windows.Forms.RadioButton();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.maskedTextBoxTc = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTel = new System.Windows.Forms.MaskedTextBox();
            this.BtnAktifEt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1070, 298);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BtnAnaSayfa
            // 
            this.BtnAnaSayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAnaSayfa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.BtnAnaSayfa.ImageOptions.Image = global::Person.Properties.Resources.icons8_my_asus;
            this.BtnAnaSayfa.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.BtnAnaSayfa.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.BtnAnaSayfa.Location = new System.Drawing.Point(1071, 117);
            this.BtnAnaSayfa.Name = "BtnAnaSayfa";
            this.BtnAnaSayfa.Size = new System.Drawing.Size(113, 106);
            this.BtnAnaSayfa.TabIndex = 8;
            this.BtnAnaSayfa.Click += new System.EventHandler(this.BtnAnaSayfa_Click);
            // 
            // BtnKapat
            // 
            this.BtnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnKapat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.BtnKapat.ImageOptions.Image = global::Person.Properties.Resources.icons8_cancel;
            this.BtnKapat.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.BtnKapat.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.BtnKapat.Location = new System.Drawing.Point(1071, 5);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(113, 106);
            this.BtnKapat.TabIndex = 7;
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // LblSoyad
            // 
            this.LblSoyad.AutoSize = true;
            this.LblSoyad.Location = new System.Drawing.Point(275, 391);
            this.LblSoyad.Name = "LblSoyad";
            this.LblSoyad.Size = new System.Drawing.Size(110, 32);
            this.LblSoyad.TabIndex = 11;
            this.LblSoyad.Text = "Soyad:";
            // 
            // LblAd
            // 
            this.LblAd.AutoSize = true;
            this.LblAd.Location = new System.Drawing.Point(324, 348);
            this.LblAd.Name = "LblAd";
            this.LblAd.Size = new System.Drawing.Size(61, 32);
            this.LblAd.TabIndex = 12;
            this.LblAd.Text = "Ad:";
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(388, 386);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(477, 38);
            this.TxtSoyad.TabIndex = 9;
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(388, 342);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(477, 38);
            this.TxtAd.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 476);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "TC:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonSuperAdmin);
            this.groupBox1.Controls.Add(this.radioButtonAdmin);
            this.groupBox1.Controls.Add(this.radioButtonYetkisiz);
            this.groupBox1.Location = new System.Drawing.Point(908, 330);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 181);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yetki";
            // 
            // radioButtonYetkisiz
            // 
            this.radioButtonYetkisiz.AutoSize = true;
            this.radioButtonYetkisiz.Location = new System.Drawing.Point(28, 50);
            this.radioButtonYetkisiz.Name = "radioButtonYetkisiz";
            this.radioButtonYetkisiz.Size = new System.Drawing.Size(143, 36);
            this.radioButtonYetkisiz.TabIndex = 0;
            this.radioButtonYetkisiz.TabStop = true;
            this.radioButtonYetkisiz.Text = "Yetkisiz";
            this.radioButtonYetkisiz.UseVisualStyleBackColor = true;
            this.radioButtonYetkisiz.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonAdmin
            // 
            this.radioButtonAdmin.AutoSize = true;
            this.radioButtonAdmin.Location = new System.Drawing.Point(28, 93);
            this.radioButtonAdmin.Name = "radioButtonAdmin";
            this.radioButtonAdmin.Size = new System.Drawing.Size(122, 36);
            this.radioButtonAdmin.TabIndex = 1;
            this.radioButtonAdmin.TabStop = true;
            this.radioButtonAdmin.Text = "Admin";
            this.radioButtonAdmin.UseVisualStyleBackColor = true;
            this.radioButtonAdmin.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButtonSuperAdmin
            // 
            this.radioButtonSuperAdmin.AutoSize = true;
            this.radioButtonSuperAdmin.Location = new System.Drawing.Point(28, 136);
            this.radioButtonSuperAdmin.Name = "radioButtonSuperAdmin";
            this.radioButtonSuperAdmin.Size = new System.Drawing.Size(211, 36);
            this.radioButtonSuperAdmin.TabIndex = 2;
            this.radioButtonSuperAdmin.TabStop = true;
            this.radioButtonSuperAdmin.Text = "Süper Admin";
            this.radioButtonSuperAdmin.UseVisualStyleBackColor = true;
            this.radioButtonSuperAdmin.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(989, 560);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(185, 51);
            this.BtnSil.TabIndex = 18;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(501, 560);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(185, 51);
            this.BtnGuncelle.TabIndex = 19;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(12, 560);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(185, 51);
            this.BtnEkle.TabIndex = 20;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // maskedTextBoxTc
            // 
            this.maskedTextBoxTc.Location = new System.Drawing.Point(388, 430);
            this.maskedTextBoxTc.Mask = "00000000000";
            this.maskedTextBoxTc.Name = "maskedTextBoxTc";
            this.maskedTextBoxTc.Size = new System.Drawing.Size(477, 38);
            this.maskedTextBoxTc.TabIndex = 21;
            this.maskedTextBoxTc.ValidatingType = typeof(int);
            // 
            // maskedTextBoxTel
            // 
            this.maskedTextBoxTel.Location = new System.Drawing.Point(388, 474);
            this.maskedTextBoxTel.Mask = "0 (999) 000-0000";
            this.maskedTextBoxTel.Name = "maskedTextBoxTel";
            this.maskedTextBoxTel.Size = new System.Drawing.Size(477, 38);
            this.maskedTextBoxTel.TabIndex = 22;
            // 
            // BtnAktifEt
            // 
            this.BtnAktifEt.Location = new System.Drawing.Point(12, 466);
            this.BtnAktifEt.Name = "BtnAktifEt";
            this.BtnAktifEt.Size = new System.Drawing.Size(112, 88);
            this.BtnAktifEt.TabIndex = 23;
            this.BtnAktifEt.Text = "Aktif Et";
            this.BtnAktifEt.UseVisualStyleBackColor = true;
            this.BtnAktifEt.Click += new System.EventHandler(this.BtnAktifEt_Click);
            // 
            // Kullanicilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(1186, 622);
            this.Controls.Add(this.BtnAktifEt);
            this.Controls.Add(this.maskedTextBoxTel);
            this.Controls.Add(this.maskedTextBoxTc);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblSoyad);
            this.Controls.Add(this.LblAd);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.BtnAnaSayfa);
            this.Controls.Add(this.BtnKapat);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Kullanicilar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanicilar";
            this.Load += new System.EventHandler(this.Kullanicilar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.SimpleButton BtnAnaSayfa;
        private DevExpress.XtraEditors.SimpleButton BtnKapat;
        private System.Windows.Forms.Label LblSoyad;
        private System.Windows.Forms.Label LblAd;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonSuperAdmin;
        private System.Windows.Forms.RadioButton radioButtonAdmin;
        private System.Windows.Forms.RadioButton radioButtonYetkisiz;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTc;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTel;
        private System.Windows.Forms.Button BtnAktifEt;
    }
}