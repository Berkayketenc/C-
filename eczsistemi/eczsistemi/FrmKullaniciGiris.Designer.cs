namespace eczsistemi
{
    partial class FrmKullaniciGiris
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKullaniciGiris));
            this.LblHastaAdi = new System.Windows.Forms.Label();
            this.LblHastaTc = new System.Windows.Forms.Label();
            this.TxtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.TxtParola = new System.Windows.Forms.TextBox();
            this.LnkUyeOl = new System.Windows.Forms.LinkLabel();
            this.BtnGirisYap = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblHastaAdi
            // 
            this.LblHastaAdi.AutoSize = true;
            this.LblHastaAdi.BackColor = System.Drawing.Color.Transparent;
            this.LblHastaAdi.Font = new System.Drawing.Font("Corbel Light", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblHastaAdi.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.LblHastaAdi.Location = new System.Drawing.Point(45, 216);
            this.LblHastaAdi.Name = "LblHastaAdi";
            this.LblHastaAdi.Size = new System.Drawing.Size(97, 27);
            this.LblHastaAdi.TabIndex = 1;
            this.LblHastaAdi.Text = "Personel :";
            // 
            // LblHastaTc
            // 
            this.LblHastaTc.AutoSize = true;
            this.LblHastaTc.BackColor = System.Drawing.Color.Transparent;
            this.LblHastaTc.Font = new System.Drawing.Font("Corbel Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblHastaTc.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.LblHastaTc.Location = new System.Drawing.Point(45, 262);
            this.LblHastaTc.Name = "LblHastaTc";
            this.LblHastaTc.Size = new System.Drawing.Size(84, 29);
            this.LblHastaTc.TabIndex = 2;
            this.LblHastaTc.Text = "Parola :";
            // 
            // TxtKullaniciAdi
            // 
            this.TxtKullaniciAdi.BackColor = System.Drawing.Color.White;
            this.TxtKullaniciAdi.Location = new System.Drawing.Point(155, 212);
            this.TxtKullaniciAdi.Name = "TxtKullaniciAdi";
            this.TxtKullaniciAdi.Size = new System.Drawing.Size(180, 36);
            this.TxtKullaniciAdi.TabIndex = 3;
            // 
            // TxtParola
            // 
            this.TxtParola.BackColor = System.Drawing.Color.White;
            this.TxtParola.Location = new System.Drawing.Point(155, 262);
            this.TxtParola.Name = "TxtParola";
            this.TxtParola.Size = new System.Drawing.Size(180, 36);
            this.TxtParola.TabIndex = 4;
            // 
            // LnkUyeOl
            // 
            this.LnkUyeOl.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.LnkUyeOl.AutoSize = true;
            this.LnkUyeOl.BackColor = System.Drawing.Color.Transparent;
            this.LnkUyeOl.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LnkUyeOl.LinkColor = System.Drawing.Color.DarkRed;
            this.LnkUyeOl.Location = new System.Drawing.Point(151, 307);
            this.LnkUyeOl.Name = "LnkUyeOl";
            this.LnkUyeOl.Size = new System.Drawing.Size(72, 23);
            this.LnkUyeOl.TabIndex = 6;
            this.LnkUyeOl.TabStop = true;
            this.LnkUyeOl.Text = "Kayıt Ol";
            this.LnkUyeOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkUyeOl_LinkClicked);
            // 
            // BtnGirisYap
            // 
            this.BtnGirisYap.BackColor = System.Drawing.Color.DarkRed;
            this.BtnGirisYap.ForeColor = System.Drawing.Color.Black;
            this.BtnGirisYap.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnGirisYap.Location = new System.Drawing.Point(245, 307);
            this.BtnGirisYap.Name = "BtnGirisYap";
            this.BtnGirisYap.Size = new System.Drawing.Size(90, 38);
            this.BtnGirisYap.TabIndex = 7;
            this.BtnGirisYap.Text = "Giriş Yap";
            this.BtnGirisYap.UseVisualStyleBackColor = false;
            this.BtnGirisYap.Click += new System.EventHandler(this.BtnGirisYap_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "loginicon.jpg");
            this.ımageList1.Images.SetKeyName(1, "2888.jpg");
            this.ımageList1.Images.SetKeyName(2, "loginicon.jpg");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Corbel Light", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(79, 572);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(446, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Made with ♥ in Copenhagen © 2020 EczaneTools, ApS. All rights reserved. @BK";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::eczsistemi.Properties.Resources.e;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(356, 233);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 58);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // FrmKullaniciGiris
            // 
            this.AcceptButton = this.BtnGirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = global::eczsistemi.Properties.Resources._1331;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(449, 543);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnGirisYap);
            this.Controls.Add(this.LnkUyeOl);
            this.Controls.Add(this.TxtParola);
            this.Controls.Add(this.TxtKullaniciAdi);
            this.Controls.Add(this.LblHastaTc);
            this.Controls.Add(this.LblHastaAdi);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "FrmKullaniciGiris";
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.FrmKullaniciGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblHastaAdi;
        private System.Windows.Forms.Label LblHastaTc;
        private System.Windows.Forms.TextBox TxtKullaniciAdi;
        private System.Windows.Forms.TextBox TxtParola;
        private System.Windows.Forms.LinkLabel LnkUyeOl;
        private System.Windows.Forms.Button BtnGirisYap;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}