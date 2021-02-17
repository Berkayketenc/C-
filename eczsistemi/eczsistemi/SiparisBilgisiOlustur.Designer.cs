namespace eczsistemi
{
    partial class SiparisBilgisiOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisBilgisiOlustur));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GbİlacBilgisi = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.TxtSiparisTarihi = new System.Windows.Forms.TextBox();
            this.TxtIlacDeposu = new System.Windows.Forms.TextBox();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.TxtIlacAdeti = new System.Windows.Forms.TextBox();
            this.TxtIlacAdi = new System.Windows.Forms.TextBox();
            this.TxtSil = new System.Windows.Forms.TextBox();
            this.BtnGoster = new System.Windows.Forms.Button();
            this.LblSiparisTarihi = new System.Windows.Forms.Label();
            this.BtnSil = new System.Windows.Forms.Button();
            this.LbllacDeposu = new System.Windows.Forms.Label();
            this.LblIlacAdeti = new System.Windows.Forms.Label();
            this.LblİlacAdi = new System.Windows.Forms.Label();
            this.GbAktifSiparis = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geriGitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelBilgileriGörToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.iletişimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iletişimToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnAnaSayfa = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BtnLogOut = new System.Windows.Forms.Button();
            this.BtnTxtAktar = new System.Windows.Forms.Button();
            this.BtnWorlAktar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GbİlacBilgisi.SuspendLayout();
            this.GbAktifSiparis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // GbİlacBilgisi
            // 
            this.GbİlacBilgisi.BackColor = System.Drawing.Color.Transparent;
            this.GbİlacBilgisi.Controls.Add(this.label1);
            this.GbİlacBilgisi.Controls.Add(this.TxtSiparisTarihi);
            this.GbİlacBilgisi.Controls.Add(this.TxtIlacDeposu);
            this.GbİlacBilgisi.Controls.Add(this.comboBox2);
            this.GbİlacBilgisi.Controls.Add(this.BtnEkle);
            this.GbİlacBilgisi.Controls.Add(this.TxtIlacAdeti);
            this.GbİlacBilgisi.Controls.Add(this.TxtIlacAdi);
            this.GbİlacBilgisi.Controls.Add(this.TxtSil);
            this.GbİlacBilgisi.Controls.Add(this.BtnGoster);
            this.GbİlacBilgisi.Controls.Add(this.LblSiparisTarihi);
            this.GbİlacBilgisi.Controls.Add(this.BtnSil);
            this.GbİlacBilgisi.Controls.Add(this.LbllacDeposu);
            this.GbİlacBilgisi.Controls.Add(this.LblIlacAdeti);
            this.GbİlacBilgisi.Controls.Add(this.LblİlacAdi);
            this.GbİlacBilgisi.Location = new System.Drawing.Point(34, 132);
            this.GbİlacBilgisi.Name = "GbİlacBilgisi";
            this.GbİlacBilgisi.Size = new System.Drawing.Size(299, 574);
            this.GbİlacBilgisi.TabIndex = 1;
            this.GbİlacBilgisi.TabStop = false;
            this.GbİlacBilgisi.Text = "İlac Bilgisi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "İşlemi Yapan:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Eczacı",
            "Teknisyen 1",
            "Teknisyen 2"});
            this.comboBox2.Location = new System.Drawing.Point(155, 309);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 36);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // TxtSiparisTarihi
            // 
            this.TxtSiparisTarihi.Location = new System.Drawing.Point(155, 245);
            this.TxtSiparisTarihi.Name = "TxtSiparisTarihi";
            this.TxtSiparisTarihi.Size = new System.Drawing.Size(100, 36);
            this.TxtSiparisTarihi.TabIndex = 4;
            // 
            // TxtIlacDeposu
            // 
            this.TxtIlacDeposu.Location = new System.Drawing.Point(155, 184);
            this.TxtIlacDeposu.Name = "TxtIlacDeposu";
            this.TxtIlacDeposu.Size = new System.Drawing.Size(100, 36);
            this.TxtIlacDeposu.TabIndex = 3;
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(24, 376);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(225, 35);
            this.BtnEkle.TabIndex = 5;
            this.BtnEkle.Text = "EKLE";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // TxtIlacAdeti
            // 
            this.TxtIlacAdeti.Location = new System.Drawing.Point(155, 121);
            this.TxtIlacAdeti.Name = "TxtIlacAdeti";
            this.TxtIlacAdeti.Size = new System.Drawing.Size(100, 36);
            this.TxtIlacAdeti.TabIndex = 2;
            // 
            // TxtIlacAdi
            // 
            this.TxtIlacAdi.Location = new System.Drawing.Point(155, 66);
            this.TxtIlacAdi.Name = "TxtIlacAdi";
            this.TxtIlacAdi.Size = new System.Drawing.Size(100, 36);
            this.TxtIlacAdi.TabIndex = 1;
            // 
            // TxtSil
            // 
            this.TxtSil.Location = new System.Drawing.Point(149, 503);
            this.TxtSil.Name = "TxtSil";
            this.TxtSil.Size = new System.Drawing.Size(100, 36);
            this.TxtSil.TabIndex = 8;
            // 
            // BtnGoster
            // 
            this.BtnGoster.Location = new System.Drawing.Point(24, 439);
            this.BtnGoster.Name = "BtnGoster";
            this.BtnGoster.Size = new System.Drawing.Size(225, 36);
            this.BtnGoster.TabIndex = 6;
            this.BtnGoster.Text = "GÖSTER";
            this.BtnGoster.UseVisualStyleBackColor = true;
            this.BtnGoster.Click += new System.EventHandler(this.BtnGoster_Click);
            // 
            // LblSiparisTarihi
            // 
            this.LblSiparisTarihi.AutoSize = true;
            this.LblSiparisTarihi.Location = new System.Drawing.Point(6, 252);
            this.LblSiparisTarihi.Name = "LblSiparisTarihi";
            this.LblSiparisTarihi.Size = new System.Drawing.Size(140, 29);
            this.LblSiparisTarihi.TabIndex = 3;
            this.LblSiparisTarihi.Text = "Sipariş Tarihi";
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(24, 503);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(100, 35);
            this.BtnSil.TabIndex = 7;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // LbllacDeposu
            // 
            this.LbllacDeposu.AutoSize = true;
            this.LbllacDeposu.Location = new System.Drawing.Point(6, 187);
            this.LbllacDeposu.Name = "LbllacDeposu";
            this.LbllacDeposu.Size = new System.Drawing.Size(140, 29);
            this.LbllacDeposu.TabIndex = 2;
            this.LbllacDeposu.Text = "İlaç Deposu :";
            // 
            // LblIlacAdeti
            // 
            this.LblIlacAdeti.AutoSize = true;
            this.LblIlacAdeti.Location = new System.Drawing.Point(6, 128);
            this.LblIlacAdeti.Name = "LblIlacAdeti";
            this.LblIlacAdeti.Size = new System.Drawing.Size(117, 29);
            this.LblIlacAdeti.TabIndex = 1;
            this.LblIlacAdeti.Text = "İlaç Adeti :";
            // 
            // LblİlacAdi
            // 
            this.LblİlacAdi.AutoSize = true;
            this.LblİlacAdi.Location = new System.Drawing.Point(6, 69);
            this.LblİlacAdi.Name = "LblİlacAdi";
            this.LblİlacAdi.Size = new System.Drawing.Size(97, 29);
            this.LblİlacAdi.TabIndex = 0;
            this.LblİlacAdi.Text = "İlaç Adı :";
            // 
            // GbAktifSiparis
            // 
            this.GbAktifSiparis.Controls.Add(this.dataGridView1);
            this.GbAktifSiparis.Location = new System.Drawing.Point(364, 165);
            this.GbAktifSiparis.Name = "GbAktifSiparis";
            this.GbAktifSiparis.Size = new System.Drawing.Size(962, 484);
            this.GbAktifSiparis.TabIndex = 3;
            this.GbAktifSiparis.TabStop = false;
            this.GbAktifSiparis.Text = "Aktif Sipariş";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(956, 449);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.hakkındaToolStripMenuItem,
            this.iletişimToolStripMenuItem,
            this.yardımToolStripMenuItem,
            this.versionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1398, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geriGitToolStripMenuItem,
            this.çıkışYapToolStripMenuItem,
            this.personelBilgileriGörToolStripMenuItem});
            this.dosyaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // geriGitToolStripMenuItem
            // 
            this.geriGitToolStripMenuItem.Name = "geriGitToolStripMenuItem";
            this.geriGitToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.geriGitToolStripMenuItem.Text = "Geri Git";
            this.geriGitToolStripMenuItem.Click += new System.EventHandler(this.geriGitToolStripMenuItem_Click);
            // 
            // çıkışYapToolStripMenuItem
            // 
            this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            this.çıkışYapToolStripMenuItem.Click += new System.EventHandler(this.çıkışYapToolStripMenuItem_Click);
            // 
            // personelBilgileriGörToolStripMenuItem
            // 
            this.personelBilgileriGörToolStripMenuItem.Name = "personelBilgileriGörToolStripMenuItem";
            this.personelBilgileriGörToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.personelBilgileriGörToolStripMenuItem.Text = "personel bilgileri gör";
            this.personelBilgileriGörToolStripMenuItem.Click += new System.EventHandler(this.personelBilgileriGörToolStripMenuItem_Click);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hakkındaToolStripMenuItem1});
            this.hakkındaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            // 
            // hakkındaToolStripMenuItem1
            // 
            this.hakkındaToolStripMenuItem1.Name = "hakkındaToolStripMenuItem1";
            this.hakkındaToolStripMenuItem1.Size = new System.Drawing.Size(154, 26);
            this.hakkındaToolStripMenuItem1.Text = "Hakkında";
            this.hakkındaToolStripMenuItem1.Click += new System.EventHandler(this.hakkındaToolStripMenuItem1_Click);
            // 
            // iletişimToolStripMenuItem
            // 
            this.iletişimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iletişimToolStripMenuItem1});
            this.iletişimToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iletişimToolStripMenuItem.Name = "iletişimToolStripMenuItem";
            this.iletişimToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.iletişimToolStripMenuItem.Text = "İletişim";
            // 
            // iletişimToolStripMenuItem1
            // 
            this.iletişimToolStripMenuItem1.Name = "iletişimToolStripMenuItem1";
            this.iletişimToolStripMenuItem1.Size = new System.Drawing.Size(140, 26);
            this.iletişimToolStripMenuItem1.Text = "İletişim";
            this.iletişimToolStripMenuItem1.Click += new System.EventHandler(this.iletişimToolStripMenuItem1_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yardımToolStripMenuItem1});
            this.yardımToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // yardımToolStripMenuItem1
            // 
            this.yardımToolStripMenuItem1.Name = "yardımToolStripMenuItem1";
            this.yardımToolStripMenuItem1.Size = new System.Drawing.Size(138, 26);
            this.yardımToolStripMenuItem1.Text = "Yardım";
            this.yardımToolStripMenuItem1.Click += new System.EventHandler(this.yardımToolStripMenuItem1_Click);
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripMenuItem1});
            this.versionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.versionToolStripMenuItem.Text = "Version";
            // 
            // versionToolStripMenuItem1
            // 
            this.versionToolStripMenuItem1.Name = "versionToolStripMenuItem1";
            this.versionToolStripMenuItem1.Size = new System.Drawing.Size(140, 26);
            this.versionToolStripMenuItem1.Text = "Version";
            this.versionToolStripMenuItem1.Click += new System.EventHandler(this.versionToolStripMenuItem1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::eczsistemi.Properties.Resources.GLOSS_DARK_GREY;
            this.pictureBox2.Location = new System.Drawing.Point(0, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1690, 61);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // BtnAnaSayfa
            // 
            this.BtnAnaSayfa.BackColor = System.Drawing.Color.Transparent;
            this.BtnAnaSayfa.ImageKey = "ev.png";
            this.BtnAnaSayfa.ImageList = this.ımageList1;
            this.BtnAnaSayfa.Location = new System.Drawing.Point(44, 31);
            this.BtnAnaSayfa.Name = "BtnAnaSayfa";
            this.BtnAnaSayfa.Size = new System.Drawing.Size(58, 42);
            this.BtnAnaSayfa.TabIndex = 15;
            this.BtnAnaSayfa.UseVisualStyleBackColor = false;
            this.BtnAnaSayfa.Click += new System.EventHandler(this.button2_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "ev.png");
            this.ımageList1.Images.SetKeyName(1, "logout.png");
            this.ımageList1.Images.SetKeyName(2, "microsoft-word-5-734997.png");
            this.ımageList1.Images.SetKeyName(3, "txt-file-1433031-1211709.png");
            this.ımageList1.Images.SetKeyName(4, "Excel_D-512.png");
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.BtnLogOut.ImageIndex = 1;
            this.BtnLogOut.ImageList = this.ımageList1;
            this.BtnLogOut.Location = new System.Drawing.Point(129, 31);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(50, 44);
            this.BtnLogOut.TabIndex = 16;
            this.BtnLogOut.UseVisualStyleBackColor = false;
            this.BtnLogOut.Click += new System.EventHandler(this.button5_Click);
            // 
            // BtnTxtAktar
            // 
            this.BtnTxtAktar.BackColor = System.Drawing.Color.Transparent;
            this.BtnTxtAktar.ImageIndex = 4;
            this.BtnTxtAktar.ImageList = this.ımageList1;
            this.BtnTxtAktar.Location = new System.Drawing.Point(205, 31);
            this.BtnTxtAktar.Name = "BtnTxtAktar";
            this.BtnTxtAktar.Size = new System.Drawing.Size(50, 42);
            this.BtnTxtAktar.TabIndex = 17;
            this.BtnTxtAktar.UseVisualStyleBackColor = false;
            this.BtnTxtAktar.Click += new System.EventHandler(this.BtnTxtAktar_Click);
            // 
            // BtnWorlAktar
            // 
            this.BtnWorlAktar.BackColor = System.Drawing.Color.Transparent;
            this.BtnWorlAktar.ImageKey = "microsoft-word-5-734997.png";
            this.BtnWorlAktar.ImageList = this.ımageList1;
            this.BtnWorlAktar.Location = new System.Drawing.Point(279, 33);
            this.BtnWorlAktar.Name = "BtnWorlAktar";
            this.BtnWorlAktar.Size = new System.Drawing.Size(44, 40);
            this.BtnWorlAktar.TabIndex = 18;
            this.BtnWorlAktar.UseVisualStyleBackColor = false;
            this.BtnWorlAktar.Click += new System.EventHandler(this.BtnWorlAktar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 36);
            this.comboBox1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 677);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(436, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "İşlemi Gerçekleştiren Kişinin Adı ve Soyadı";
            // 
            // SiparisBilgisiOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImage = global::eczsistemi.Properties.Resources.walpapernev;
            this.ClientSize = new System.Drawing.Size(1398, 728);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BtnWorlAktar);
            this.Controls.Add(this.BtnTxtAktar);
            this.Controls.Add(this.BtnLogOut);
            this.Controls.Add(this.BtnAnaSayfa);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.GbAktifSiparis);
            this.Controls.Add(this.GbİlacBilgisi);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "SiparisBilgisiOlustur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SiparisBilgisiOlustur";
            this.Load += new System.EventHandler(this.SiparisBilgisiOlustur_Load);
            this.GbİlacBilgisi.ResumeLayout(false);
            this.GbİlacBilgisi.PerformLayout();
            this.GbAktifSiparis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox GbİlacBilgisi;
        private System.Windows.Forms.TextBox TxtIlacAdeti;
        private System.Windows.Forms.TextBox TxtIlacAdi;
        private System.Windows.Forms.Label LblSiparisTarihi;
        private System.Windows.Forms.Label LbllacDeposu;
        private System.Windows.Forms.Label LblIlacAdeti;
        private System.Windows.Forms.Label LblİlacAdi;
        private System.Windows.Forms.GroupBox GbAktifSiparis;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.TextBox TxtSiparisTarihi;
        private System.Windows.Forms.TextBox TxtIlacDeposu;
        private System.Windows.Forms.Button BtnGoster;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.TextBox TxtSil;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geriGitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem iletişimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iletişimToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnAnaSayfa;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button BtnLogOut;
        private System.Windows.Forms.Button BtnTxtAktar;
        private System.Windows.Forms.Button BtnWorlAktar;
        private System.Windows.Forms.ToolStripMenuItem personelBilgileriGörToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}