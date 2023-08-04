namespace Person
{
    partial class GirisSayfasi
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
            this.maskedTextBoxTC = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTel = new System.Windows.Forms.MaskedTextBox();
            this.LblTc = new System.Windows.Forms.Label();
            this.LnlTel = new System.Windows.Forms.Label();
            this.BtnGiris = new System.Windows.Forms.Button();
            this.BtnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // maskedTextBoxTC
            // 
            this.maskedTextBoxTC.Location = new System.Drawing.Point(71, 108);
            this.maskedTextBoxTC.Mask = "00000000000";
            this.maskedTextBoxTC.Name = "maskedTextBoxTC";
            this.maskedTextBoxTC.Size = new System.Drawing.Size(322, 34);
            this.maskedTextBoxTC.TabIndex = 0;
            this.maskedTextBoxTC.ValidatingType = typeof(int);
            // 
            // maskedTextBoxTel
            // 
            this.maskedTextBoxTel.Location = new System.Drawing.Point(71, 206);
            this.maskedTextBoxTel.Mask = "0 (999) 000-0000";
            this.maskedTextBoxTel.Name = "maskedTextBoxTel";
            this.maskedTextBoxTel.Size = new System.Drawing.Size(322, 34);
            this.maskedTextBoxTel.TabIndex = 1;
            // 
            // LblTc
            // 
            this.LblTc.AutoSize = true;
            this.LblTc.Location = new System.Drawing.Point(52, 76);
            this.LblTc.Name = "LblTc";
            this.LblTc.Size = new System.Drawing.Size(266, 29);
            this.LblTc.TabIndex = 2;
            this.LblTc.Text = "T.C. Kimlik Numarası:";
            // 
            // LnlTel
            // 
            this.LnlTel.AutoSize = true;
            this.LnlTel.Location = new System.Drawing.Point(52, 174);
            this.LnlTel.Name = "LnlTel";
            this.LnlTel.Size = new System.Drawing.Size(228, 29);
            this.LnlTel.TabIndex = 3;
            this.LnlTel.Text = "Telefon Numarası:";
            // 
            // BtnGiris
            // 
            this.BtnGiris.Location = new System.Drawing.Point(100, 264);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(215, 62);
            this.BtnGiris.TabIndex = 4;
            this.BtnGiris.Text = "Giriş Yap";
            this.BtnGiris.UseVisualStyleBackColor = true;
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // BtnKapat
            // 
            this.BtnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnKapat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.BtnKapat.ImageOptions.Image = global::Person.Properties.Resources.icons8_cancel;
            this.BtnKapat.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.BtnKapat.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.BtnKapat.Location = new System.Drawing.Point(324, -1);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(91, 84);
            this.BtnKapat.TabIndex = 6;
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // GirisSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(415, 501);
            this.Controls.Add(this.BtnKapat);
            this.Controls.Add(this.BtnGiris);
            this.Controls.Add(this.LnlTel);
            this.Controls.Add(this.LblTc);
            this.Controls.Add(this.maskedTextBoxTel);
            this.Controls.Add(this.maskedTextBoxTC);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "GirisSayfasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GirisSayfasi";
            this.Load += new System.EventHandler(this.GirisSayfasi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBoxTC;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTel;
        private System.Windows.Forms.Label LblTc;
        private System.Windows.Forms.Label LnlTel;
        private System.Windows.Forms.Button BtnGiris;
        private DevExpress.XtraEditors.SimpleButton BtnKapat;
    }
}