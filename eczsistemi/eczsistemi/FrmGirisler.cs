using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace eczsistemi
{
    public partial class FrmGirisler : Form
    {
        public FrmGirisler()
        {
            InitializeComponent();
        }
        public string tc;
        
        
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SiparisBilgisiOlustur frt = new SiparisBilgisiOlustur();
            
            frt.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ItsIlacVer fr = new ItsIlacVer();
            fr.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UcretIlacVer fr = new UcretIlacVer();
            fr.Show();
            this.Hide();
        }

        private void FrmGirisler_Load(object sender, EventArgs e)
        {
            LblTc.Text = tc;

            Rectangle cozunurluk = new Rectangle();
            cozunurluk = Screen.GetBounds(cozunurluk);
            float YWidth = ((float)cozunurluk.Width / (float)1366);
            float YHeight = ((float)cozunurluk.Height / (float)768);
            SizeF scale = new SizeF(YWidth, YHeight);
            this.Scale(scale);
            

        }

        private void dosyaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FrmKullaniciGiris fr = new FrmKullaniciGiris();
            

            fr.Show();
            this.Hide();
        }

        private void geriGitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKullaniciGiris fr = new FrmKullaniciGiris();


            fr.Show();
            this.Hide();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKullaniciGiris fr = new FrmKullaniciGiris();


            fr.Show();
            this.Hide();
        }

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void yardımToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İletişim kısmında bulunan bilgilerden bize ulaşabilirsiniz.");
        }

        private void iletişimToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Berkay KETENCİ \n" +
                           "berkayketenc@outlook.com \n" +
                           "Telefon : 05396515970");
        }

        private void versionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version:1.0 - Eylül/2020");
        }

        private void hakkındaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Program : Visual Studio Derleyicisinde C# Dilinde Object Oriented Olarak Geliştirilip , Veri Tabanı Olarak SQL2019 Kullanılmıştır" );
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
