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
    public partial class HastaKayit : Form
    {
        public HastaKayit()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

       

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into HastaKayit(HastaAd,HastaTelefon,HastaTC,HastaSehir,IlacRaporu,RenkliRecete,Sifre) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAdSoyad.Text);
            komut.Parameters.AddWithValue("@p2", TxtTelefon.Text);
            komut.Parameters.AddWithValue("@p3", TxtTC.Text);
            komut.Parameters.AddWithValue("@p4", TxtSehir.Text);
            komut.Parameters.AddWithValue("@p5", TxtIlacRapor.Text);
            komut.Parameters.AddWithValue("@p6", TxtRenkliRecete.Text);
            komut.Parameters.AddWithValue("@p7", TxtSifre.Text);
            komut.ExecuteNonQuery();
            
            
            bgl.baglanti().Close();
            MessageBox.Show("Kaydiniz Gerceklesmistir şifreniz :" + TxtSifre.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void HastaKayit_Load(object sender, EventArgs e)
        {

        }
    }
}
