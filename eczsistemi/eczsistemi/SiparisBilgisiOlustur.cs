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
using System.Net.Http.Headers;
using Microsoft.Office.Interop.Word;
using word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace eczsistemi
{
    public partial class SiparisBilgisiOlustur : Form
    {
        public SiparisBilgisiOlustur()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-C6I80RT\\SQLEXPRESS;Initial Catalog=EczSistemProje;Integrated Security=True");
        public string tc,parola;
        

        sqlbaglantisi bglt = new sqlbaglantisi();


        public void verilerigoster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        

        

        

        private void BtnGoster_Click(object sender, EventArgs e)
        {
            verilerigoster("Select * from SiparisBilgisi ");
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from SiparisBilgisi where id=@adii", baglanti);
            komut.Parameters.AddWithValue("@adii", TxtSil.Text);
            komut.ExecuteNonQuery();
            verilerigoster("Select * From SiparisBilgisi");
            baglanti.Close();
            TxtSil.Clear();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmGirisler fr = new FrmGirisler();


            fr.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmKullaniciGiris fr = new FrmKullaniciGiris();


            fr.Show();
            this.Hide();
        }

        private void geriGitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGirisler fr = new FrmGirisler();


            fr.Show();
            this.Hide();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKullaniciGiris fr = new FrmKullaniciGiris();


            fr.Show();
            this.Hide();
        }

        private void SiparisBilgisiOlustur_Load(object sender, EventArgs e)
        {
          
        }

        private void BtnWorlAktar_Click(object sender, EventArgs e)
        {
            word.Application app = new word.Application();
            app.Visible = true;
            word.Document aktar;
            aktar = app.Documents.Add(System.Reflection.Missing.Value);
            app.Selection.Font.Size = 20;
            app.Selection.TypeText(TxtIlacAdi.Text);
            app.Selection.TypeText(TxtIlacAdeti.Text);
            app.Selection.TypeText(TxtIlacDeposu.Text);
            app.Selection.TypeText(TxtSiparisTarihi.Text);
           
        }

        private void BtnTxtAktar_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            excel.Visible = true;

            Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);

            Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];

            int StartCol = 1;

            int StartRow = 1;

            for (int j = 0; j < dataGridView1.Columns.Count; j++)

            {

                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + j];

                myRange.Value2 = dataGridView1.Columns[j].HeaderText;

            }

            StartRow++;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)

            {

                for (int j = 0; j < dataGridView1.Columns.Count; j++)

                {

                    try

                    {

                        Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];

                        myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;

                    }

                    catch

                    {

                    }
                }
                }

            }

        private void yardımToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İletişim kısmında bulunan bilgilerden bize ulaşabilirsiniz.");
        }

        private void iletişimToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Berkay KETENCİ \n"+
                            "berkayketenc@outlook.com \n" + 
                            "Telefon : 05396515970" );
        }

        private void versionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version:1.0 - Eylül/2020");
        }

        private void hakkındaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Program : Visual Studio Derleyicisinde C# Dilinde Object Oriented Olarak Geliştirilip , Veri Tabanı Olarak SQL2019 Kullanılmıştır");
        }

        private void personelBilgileriGörToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            eczacı eczacı = new eczacı();
            teknisyen teknisyen = new teknisyen();

            if (comboBox2.SelectedIndex==0)
            {
                eczacı.gorevi = "İşlem Eczacı Nurhan Gül tarafından gerçekleştirilmiştir.";
                label2.Text = eczacı.gorevi.ToString();
            }
            else if (comboBox2.SelectedIndex==1)
            {
                teknisyen.gorevi = "İşlem 1. Teknisyen Ercan Küçükkaslan tarafından gerçekleştirilmiştir.";
                label2.Text = teknisyen.gorevi.ToString();
            }
            else if (comboBox2.SelectedIndex==2)
            {
                teknisyen.gorevi = "İşlem 2. Teknisyen Kenan Dayı tarafından gerçekleştirilmiştir.";
                label2.Text = teknisyen.gorevi.ToString();
            }
        }

       

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into SiparisBilgisi ( IlacAdi,IlacAdet,IlacDepo,IlacTarih)values(@adi,@adeti,@deposu,@tarihi)", baglanti);
            komut.Parameters.AddWithValue("@adi", TxtIlacAdi.Text);
            komut.Parameters.AddWithValue("@adeti", TxtIlacAdeti.Text);
            komut.Parameters.AddWithValue("@deposu", TxtIlacDeposu.Text);
            komut.Parameters.AddWithValue("@tarihi", TxtSiparisTarihi.Text);
            komut.ExecuteNonQuery();
            verilerigoster("Select * from SiparisBilgisi");
            baglanti.Close();
            TxtIlacAdi.Clear();
            TxtIlacAdeti.Clear();
            TxtIlacDeposu.Clear();
            TxtSiparisTarihi.Clear();
        }
    }
}
