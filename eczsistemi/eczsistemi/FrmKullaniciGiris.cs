using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace eczsistemi
{
    public partial class FrmKullaniciGiris : Form
    {
        public FrmKullaniciGiris()
        {
            InitializeComponent();

            

        }

        

        

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From HastaKayit Where HastaAd=@p1 and Sifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("p1", TxtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("p2" ,TxtParola.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                FrmGirisler fr = new FrmGirisler();
                fr.tc = TxtKullaniciAdi.Text;
                
                fr.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("BİLGİLER HATALI");
            }
            bgl.baglanti().Close();

           


        }

              

        sqlbaglantisi bgl = new sqlbaglantisi(); 
        private void LnkUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            HastaKayit fr = new HastaKayit();
            
            fr.Show();
            
            
        }

        private void FrmKullaniciGiris_Load(object sender, EventArgs e)
        {
           
        }
    }
}