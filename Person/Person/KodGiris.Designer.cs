namespace Person
{
    partial class KodGiris
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
            this.BtnGiris = new System.Windows.Forms.Button();
            this.LblTc = new System.Windows.Forms.Label();
            this.maskedTextBoxKod = new System.Windows.Forms.MaskedTextBox();
            this.BtnYeniKod = new System.Windows.Forms.Button();
            this.BtnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // BtnGiris
            // 
            this.BtnGiris.Location = new System.Drawing.Point(76, 145);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(231, 62);
            this.BtnGiris.TabIndex = 7;
            this.BtnGiris.Text = "Giriş Yap";
            this.BtnGiris.UseVisualStyleBackColor = true;
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // LblTc
            // 
            this.LblTc.AutoSize = true;
            this.LblTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTc.Location = new System.Drawing.Point(71, 108);
            this.LblTc.Name = "LblTc";
            this.LblTc.Size = new System.Drawing.Size(75, 29);
            this.LblTc.TabIndex = 6;
            this.LblTc.Text = "KOD:";
            // 
            // maskedTextBoxKod
            // 
            this.maskedTextBoxKod.Location = new System.Drawing.Point(152, 105);
            this.maskedTextBoxKod.Mask = "000000";
            this.maskedTextBoxKod.Name = "maskedTextBoxKod";
            this.maskedTextBoxKod.Size = new System.Drawing.Size(392, 34);
            this.maskedTextBoxKod.TabIndex = 5;
            this.maskedTextBoxKod.ValidatingType = typeof(int);
            // 
            // BtnYeniKod
            // 
            this.BtnYeniKod.Location = new System.Drawing.Point(313, 145);
            this.BtnYeniKod.Name = "BtnYeniKod";
            this.BtnYeniKod.Size = new System.Drawing.Size(231, 62);
            this.BtnYeniKod.TabIndex = 8;
            this.BtnYeniKod.Text = "Yeni Kod Gönder";
            this.BtnYeniKod.UseVisualStyleBackColor = true;
            this.BtnYeniKod.Click += new System.EventHandler(this.BtnYeniKod_Click);
            // 
            // BtnKapat
            // 
            this.BtnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnKapat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.BtnKapat.ImageOptions.Image = global::Person.Properties.Resources.icons8_cancel;
            this.BtnKapat.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.BtnKapat.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.BtnKapat.Location = new System.Drawing.Point(521, -1);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(89, 78);
            this.BtnKapat.TabIndex = 9;
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // KodGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(611, 291);
            this.Controls.Add(this.BtnKapat);
            this.Controls.Add(this.BtnYeniKod);
            this.Controls.Add(this.BtnGiris);
            this.Controls.Add(this.LblTc);
            this.Controls.Add(this.maskedTextBoxKod);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "KodGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KodGiris";
            this.Load += new System.EventHandler(this.KodGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGiris;
        private System.Windows.Forms.Label LblTc;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxKod;
        private System.Windows.Forms.Button BtnYeniKod;
        private DevExpress.XtraEditors.SimpleButton BtnKapat;
    }
}