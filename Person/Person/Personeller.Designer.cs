namespace Person
{
    partial class Personeller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personeller));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtMaas = new System.Windows.Forms.TextBox();
            this.comboBoxSehir = new System.Windows.Forms.ComboBox();
            this.comboBoxMeslek = new System.Windows.Forms.ComboBox();
            this.LblAd = new System.Windows.Forms.Label();
            this.LblSoyad = new System.Windows.Forms.Label();
            this.LblSehir = new System.Windows.Forms.Label();
            this.LblMeslek = new System.Windows.Forms.Label();
            this.LblMaas = new System.Windows.Forms.Label();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnAnaSayfa = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAktifEt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(355, 328);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(477, 38);
            this.TxtAd.TabIndex = 1;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(355, 372);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(477, 38);
            this.TxtSoyad.TabIndex = 1;
            // 
            // TxtMaas
            // 
            this.TxtMaas.Location = new System.Drawing.Point(355, 506);
            this.TxtMaas.Name = "TxtMaas";
            this.TxtMaas.Size = new System.Drawing.Size(477, 38);
            this.TxtMaas.TabIndex = 1;
            // 
            // comboBoxSehir
            // 
            this.comboBoxSehir.FormattingEnabled = true;
            this.comboBoxSehir.Location = new System.Drawing.Point(355, 416);
            this.comboBoxSehir.Name = "comboBoxSehir";
            this.comboBoxSehir.Size = new System.Drawing.Size(477, 39);
            this.comboBoxSehir.TabIndex = 2;
            // 
            // comboBoxMeslek
            // 
            this.comboBoxMeslek.FormattingEnabled = true;
            this.comboBoxMeslek.Location = new System.Drawing.Point(355, 461);
            this.comboBoxMeslek.Name = "comboBoxMeslek";
            this.comboBoxMeslek.Size = new System.Drawing.Size(477, 39);
            this.comboBoxMeslek.TabIndex = 2;
            // 
            // LblAd
            // 
            this.LblAd.AutoSize = true;
            this.LblAd.Location = new System.Drawing.Point(287, 334);
            this.LblAd.Name = "LblAd";
            this.LblAd.Size = new System.Drawing.Size(61, 32);
            this.LblAd.TabIndex = 3;
            this.LblAd.Text = "Ad:";
            // 
            // LblSoyad
            // 
            this.LblSoyad.AutoSize = true;
            this.LblSoyad.Location = new System.Drawing.Point(238, 377);
            this.LblSoyad.Name = "LblSoyad";
            this.LblSoyad.Size = new System.Drawing.Size(110, 32);
            this.LblSoyad.TabIndex = 3;
            this.LblSoyad.Text = "Soyad:";
            // 
            // LblSehir
            // 
            this.LblSehir.AutoSize = true;
            this.LblSehir.Location = new System.Drawing.Point(252, 420);
            this.LblSehir.Name = "LblSehir";
            this.LblSehir.Size = new System.Drawing.Size(96, 32);
            this.LblSehir.TabIndex = 3;
            this.LblSehir.Text = "Şehir:";
            // 
            // LblMeslek
            // 
            this.LblMeslek.AutoSize = true;
            this.LblMeslek.Location = new System.Drawing.Point(228, 463);
            this.LblMeslek.Name = "LblMeslek";
            this.LblMeslek.Size = new System.Drawing.Size(120, 32);
            this.LblMeslek.TabIndex = 3;
            this.LblMeslek.Text = "Meslek:";
            // 
            // LblMaas
            // 
            this.LblMaas.AutoSize = true;
            this.LblMaas.Location = new System.Drawing.Point(251, 506);
            this.LblMaas.Name = "LblMaas";
            this.LblMaas.Size = new System.Drawing.Size(97, 32);
            this.LblMaas.TabIndex = 3;
            this.LblMaas.Text = "Maaş:";
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(12, 559);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(185, 51);
            this.BtnEkle.TabIndex = 4;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(501, 559);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(185, 51);
            this.BtnGuncelle.TabIndex = 4;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(989, 559);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(185, 51);
            this.BtnSil.TabIndex = 4;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnAnaSayfa
            // 
            this.BtnAnaSayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAnaSayfa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.BtnAnaSayfa.ImageOptions.Image = global::Person.Properties.Resources.icons8_my_asus;
            this.BtnAnaSayfa.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.BtnAnaSayfa.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.BtnAnaSayfa.Location = new System.Drawing.Point(1071, 116);
            this.BtnAnaSayfa.Name = "BtnAnaSayfa";
            this.BtnAnaSayfa.Size = new System.Drawing.Size(113, 106);
            this.BtnAnaSayfa.TabIndex = 6;
            this.BtnAnaSayfa.Click += new System.EventHandler(this.BtnAnaSayfa_Click);
            // 
            // BtnKapat
            // 
            this.BtnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnKapat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.BtnKapat.ImageOptions.Image = global::Person.Properties.Resources.icons8_cancel;
            this.BtnKapat.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.BtnKapat.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.BtnKapat.Location = new System.Drawing.Point(1071, 4);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(113, 106);
            this.BtnKapat.TabIndex = 5;
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // BtnAktifEt
            // 
            this.BtnAktifEt.Location = new System.Drawing.Point(12, 465);
            this.BtnAktifEt.Name = "BtnAktifEt";
            this.BtnAktifEt.Size = new System.Drawing.Size(112, 88);
            this.BtnAktifEt.TabIndex = 24;
            this.BtnAktifEt.Text = "Aktif Et";
            this.BtnAktifEt.UseVisualStyleBackColor = true;
            this.BtnAktifEt.Click += new System.EventHandler(this.BtnAktifEt_Click);
            // 
            // Personeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(1186, 622);
            this.Controls.Add(this.BtnAktifEt);
            this.Controls.Add(this.BtnAnaSayfa);
            this.Controls.Add(this.BtnKapat);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.LblMaas);
            this.Controls.Add(this.LblMeslek);
            this.Controls.Add(this.LblSehir);
            this.Controls.Add(this.LblSoyad);
            this.Controls.Add(this.LblAd);
            this.Controls.Add(this.comboBoxMeslek);
            this.Controls.Add(this.comboBoxSehir);
            this.Controls.Add(this.TxtMaas);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Personeller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Ayarları";
            this.Load += new System.EventHandler(this.Personeller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtMaas;
        private System.Windows.Forms.ComboBox comboBoxSehir;
        private System.Windows.Forms.ComboBox comboBoxMeslek;
        private System.Windows.Forms.Label LblAd;
        private System.Windows.Forms.Label LblSoyad;
        private System.Windows.Forms.Label LblSehir;
        private System.Windows.Forms.Label LblMeslek;
        private System.Windows.Forms.Label LblMaas;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnKapat;
        private DevExpress.XtraEditors.SimpleButton BtnAnaSayfa;
        private System.Windows.Forms.Button BtnAktifEt;
    }
}

