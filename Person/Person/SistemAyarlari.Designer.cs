namespace Person
{
    partial class SistemAyarları
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SistemAyarları));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnSehirEkle = new System.Windows.Forms.Button();
            this.BtnSehirSil = new System.Windows.Forms.Button();
            this.BtnSehirGuncelle = new System.Windows.Forms.Button();
            this.LblSehir = new System.Windows.Forms.Label();
            this.TxtSehir = new System.Windows.Forms.TextBox();
            this.dataGridViewSehir = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnMeslekSil = new System.Windows.Forms.Button();
            this.BtnMeslekGuncelle = new System.Windows.Forms.Button();
            this.BtnMeslekEkle = new System.Windows.Forms.Button();
            this.LblMeslek = new System.Windows.Forms.Label();
            this.TxtMeslek = new System.Windows.Forms.TextBox();
            this.dataGridViewMeslek = new System.Windows.Forms.DataGridView();
            this.BtnAnaSayfa = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSehir)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeslek)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1064, 623);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.tabPage1.Controls.Add(this.BtnSehirEkle);
            this.tabPage1.Controls.Add(this.BtnSehirSil);
            this.tabPage1.Controls.Add(this.BtnSehirGuncelle);
            this.tabPage1.Controls.Add(this.LblSehir);
            this.tabPage1.Controls.Add(this.TxtSehir);
            this.tabPage1.Controls.Add(this.dataGridViewSehir);
            this.tabPage1.Location = new System.Drawing.Point(4, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1056, 579);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Şehir";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // BtnSehirEkle
            // 
            this.BtnSehirEkle.Location = new System.Drawing.Point(7, 500);
            this.BtnSehirEkle.Name = "BtnSehirEkle";
            this.BtnSehirEkle.Size = new System.Drawing.Size(193, 70);
            this.BtnSehirEkle.TabIndex = 4;
            this.BtnSehirEkle.Text = "Ekle";
            this.BtnSehirEkle.UseVisualStyleBackColor = true;
            this.BtnSehirEkle.Click += new System.EventHandler(this.BtnSehirEkle_Click);
            // 
            // BtnSehirSil
            // 
            this.BtnSehirSil.Location = new System.Drawing.Point(857, 500);
            this.BtnSehirSil.Name = "BtnSehirSil";
            this.BtnSehirSil.Size = new System.Drawing.Size(193, 70);
            this.BtnSehirSil.TabIndex = 4;
            this.BtnSehirSil.Text = "Sil";
            this.BtnSehirSil.UseVisualStyleBackColor = true;
            this.BtnSehirSil.Click += new System.EventHandler(this.BtnSehirSil_Click);
            // 
            // BtnSehirGuncelle
            // 
            this.BtnSehirGuncelle.Location = new System.Drawing.Point(414, 500);
            this.BtnSehirGuncelle.Name = "BtnSehirGuncelle";
            this.BtnSehirGuncelle.Size = new System.Drawing.Size(193, 70);
            this.BtnSehirGuncelle.TabIndex = 4;
            this.BtnSehirGuncelle.Text = "Güncelle";
            this.BtnSehirGuncelle.UseVisualStyleBackColor = true;
            this.BtnSehirGuncelle.Click += new System.EventHandler(this.BtnSehirGuncelle_Click);
            // 
            // LblSehir
            // 
            this.LblSehir.AutoSize = true;
            this.LblSehir.Location = new System.Drawing.Point(286, 407);
            this.LblSehir.Name = "LblSehir";
            this.LblSehir.Size = new System.Drawing.Size(96, 32);
            this.LblSehir.TabIndex = 3;
            this.LblSehir.Text = "Şehir:";
            // 
            // TxtSehir
            // 
            this.TxtSehir.Location = new System.Drawing.Point(388, 404);
            this.TxtSehir.Name = "TxtSehir";
            this.TxtSehir.Size = new System.Drawing.Size(382, 38);
            this.TxtSehir.TabIndex = 1;
            // 
            // dataGridViewSehir
            // 
            this.dataGridViewSehir.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSehir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSehir.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewSehir.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewSehir.Name = "dataGridViewSehir";
            this.dataGridViewSehir.RowTemplate.Height = 24;
            this.dataGridViewSehir.Size = new System.Drawing.Size(1050, 339);
            this.dataGridViewSehir.TabIndex = 0;
            this.dataGridViewSehir.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSehir_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.tabPage2.Controls.Add(this.BtnMeslekSil);
            this.tabPage2.Controls.Add(this.BtnMeslekGuncelle);
            this.tabPage2.Controls.Add(this.BtnMeslekEkle);
            this.tabPage2.Controls.Add(this.LblMeslek);
            this.tabPage2.Controls.Add(this.TxtMeslek);
            this.tabPage2.Controls.Add(this.dataGridViewMeslek);
            this.tabPage2.Location = new System.Drawing.Point(4, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1056, 579);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Meslek";
            // 
            // BtnMeslekSil
            // 
            this.BtnMeslekSil.Location = new System.Drawing.Point(857, 500);
            this.BtnMeslekSil.Name = "BtnMeslekSil";
            this.BtnMeslekSil.Size = new System.Drawing.Size(193, 70);
            this.BtnMeslekSil.TabIndex = 3;
            this.BtnMeslekSil.Text = "Sil";
            this.BtnMeslekSil.UseVisualStyleBackColor = true;
            this.BtnMeslekSil.Click += new System.EventHandler(this.BtnMeslekSil_Click);
            // 
            // BtnMeslekGuncelle
            // 
            this.BtnMeslekGuncelle.Location = new System.Drawing.Point(414, 500);
            this.BtnMeslekGuncelle.Name = "BtnMeslekGuncelle";
            this.BtnMeslekGuncelle.Size = new System.Drawing.Size(193, 70);
            this.BtnMeslekGuncelle.TabIndex = 3;
            this.BtnMeslekGuncelle.Text = "Güncelle";
            this.BtnMeslekGuncelle.UseVisualStyleBackColor = true;
            this.BtnMeslekGuncelle.Click += new System.EventHandler(this.BtnMeslekGuncelle_Click);
            // 
            // BtnMeslekEkle
            // 
            this.BtnMeslekEkle.Location = new System.Drawing.Point(7, 500);
            this.BtnMeslekEkle.Name = "BtnMeslekEkle";
            this.BtnMeslekEkle.Size = new System.Drawing.Size(193, 70);
            this.BtnMeslekEkle.TabIndex = 3;
            this.BtnMeslekEkle.Text = "Ekle";
            this.BtnMeslekEkle.UseVisualStyleBackColor = true;
            this.BtnMeslekEkle.Click += new System.EventHandler(this.BtnMeslekEkle_Click);
            // 
            // LblMeslek
            // 
            this.LblMeslek.AutoSize = true;
            this.LblMeslek.Location = new System.Drawing.Point(274, 407);
            this.LblMeslek.Name = "LblMeslek";
            this.LblMeslek.Size = new System.Drawing.Size(120, 32);
            this.LblMeslek.TabIndex = 2;
            this.LblMeslek.Text = "Meslek:";
            // 
            // TxtMeslek
            // 
            this.TxtMeslek.Location = new System.Drawing.Point(400, 404);
            this.TxtMeslek.Name = "TxtMeslek";
            this.TxtMeslek.Size = new System.Drawing.Size(382, 38);
            this.TxtMeslek.TabIndex = 1;
            // 
            // dataGridViewMeslek
            // 
            this.dataGridViewMeslek.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMeslek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMeslek.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewMeslek.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewMeslek.Name = "dataGridViewMeslek";
            this.dataGridViewMeslek.RowTemplate.Height = 24;
            this.dataGridViewMeslek.Size = new System.Drawing.Size(1050, 339);
            this.dataGridViewMeslek.TabIndex = 0;
            this.dataGridViewMeslek.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMeslek_CellClick);
            this.dataGridViewMeslek.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMeslek_CellContentClick);
            // 
            // BtnAnaSayfa
            // 
            this.BtnAnaSayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAnaSayfa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.BtnAnaSayfa.ImageOptions.Image = global::Person.Properties.Resources.icons8_my_asus;
            this.BtnAnaSayfa.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.BtnAnaSayfa.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.BtnAnaSayfa.Location = new System.Drawing.Point(1071, 115);
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
            this.BtnKapat.Location = new System.Drawing.Point(1071, 3);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(113, 106);
            this.BtnKapat.TabIndex = 7;
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // SistemAyarları
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(1186, 622);
            this.Controls.Add(this.BtnAnaSayfa);
            this.Controls.Add(this.BtnKapat);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "SistemAyarları";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SistemAyarları";
            this.Load += new System.EventHandler(this.SistemAyarlari_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSehir)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeslek)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewSehir;
        private System.Windows.Forms.Button BtnSehirEkle;
        private System.Windows.Forms.Button BtnSehirGuncelle;
        private System.Windows.Forms.Label LblSehir;
        private System.Windows.Forms.TextBox TxtSehir;
        private System.Windows.Forms.Button BtnSehirSil;
        private System.Windows.Forms.DataGridView dataGridViewMeslek;
        private System.Windows.Forms.Button BtnMeslekEkle;
        private System.Windows.Forms.Label LblMeslek;
        private System.Windows.Forms.TextBox TxtMeslek;
        private System.Windows.Forms.Button BtnMeslekSil;
        private System.Windows.Forms.Button BtnMeslekGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnAnaSayfa;
        private DevExpress.XtraEditors.SimpleButton BtnKapat;
    }
}