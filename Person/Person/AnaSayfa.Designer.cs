namespace Person
{
    partial class AnaSayfa
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
            this.BtnPersoneller = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKullanicilar = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSistemAyarları = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // BtnPersoneller
            // 
            this.BtnPersoneller.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnPersoneller.Appearance.Options.UseFont = true;
            this.BtnPersoneller.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPersoneller.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.BtnPersoneller.ImageOptions.Image = global::Person.Properties.Resources.icons8_people;
            this.BtnPersoneller.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.BtnPersoneller.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.BtnPersoneller.Location = new System.Drawing.Point(185, 228);
            this.BtnPersoneller.Name = "BtnPersoneller";
            this.BtnPersoneller.Size = new System.Drawing.Size(179, 167);
            this.BtnPersoneller.TabIndex = 11;
            this.BtnPersoneller.Text = "Personeller";
            this.BtnPersoneller.Click += new System.EventHandler(this.BtnPersoneller_Click);
            // 
            // BtnKullanicilar
            // 
            this.BtnKullanicilar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKullanicilar.Appearance.Options.UseFont = true;
            this.BtnKullanicilar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnKullanicilar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.BtnKullanicilar.ImageOptions.Image = global::Person.Properties.Resources.icons8_person_1;
            this.BtnKullanicilar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.BtnKullanicilar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.BtnKullanicilar.Location = new System.Drawing.Point(504, 228);
            this.BtnKullanicilar.Name = "BtnKullanicilar";
            this.BtnKullanicilar.Size = new System.Drawing.Size(179, 167);
            this.BtnKullanicilar.TabIndex = 10;
            this.BtnKullanicilar.Text = "Kullanıcılar";
            this.BtnKullanicilar.Click += new System.EventHandler(this.BtnKullanicilar_Click);
            // 
            // BtnSistemAyarları
            // 
            this.BtnSistemAyarları.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSistemAyarları.Appearance.Options.UseFont = true;
            this.BtnSistemAyarları.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSistemAyarları.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.BtnSistemAyarları.ImageOptions.Image = global::Person.Properties.Resources.icons8_administrative_tools_5;
            this.BtnSistemAyarları.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.BtnSistemAyarları.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.BtnSistemAyarları.Location = new System.Drawing.Point(823, 228);
            this.BtnSistemAyarları.Name = "BtnSistemAyarları";
            this.BtnSistemAyarları.Size = new System.Drawing.Size(179, 167);
            this.BtnSistemAyarları.TabIndex = 9;
            this.BtnSistemAyarları.Text = "Sistem Ayarları";
            this.BtnSistemAyarları.Click += new System.EventHandler(this.BtnSistemAyarları_Click);
            // 
            // BtnKapat
            // 
            this.BtnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnKapat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.BtnKapat.ImageOptions.Image = global::Person.Properties.Resources.icons8_cancel;
            this.BtnKapat.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.BtnKapat.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.BtnKapat.Location = new System.Drawing.Point(1070, 3);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(113, 106);
            this.BtnKapat.TabIndex = 7;
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(1186, 622);
            this.Controls.Add(this.BtnPersoneller);
            this.Controls.Add(this.BtnKullanicilar);
            this.Controls.Add(this.BtnSistemAyarları);
            this.Controls.Add(this.BtnKapat);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaSayfa";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnKapat;
        private DevExpress.XtraEditors.SimpleButton BtnSistemAyarları;
        private DevExpress.XtraEditors.SimpleButton BtnKullanicilar;
        private DevExpress.XtraEditors.SimpleButton BtnPersoneller;
    }
}