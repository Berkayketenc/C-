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
using Microsoft.Office.Interop.Word;
using word= Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Excel;
using Excel=Microsoft.Office.Interop.Excel;

namespace eczsistemi
{
    public partial class ItsIlacVer : Form
    {
        
        


        public ItsIlacVer()
        {
            InitializeComponent();
        }
        SqlConnection baglantii = new SqlConnection("Data Source=DESKTOP-C6I80RT\\SQLEXPRESS;Initial Catalog=EczSistemProje;Integrated Security=True;");
        public void verilerigoster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglantii);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            baglantii.Open();
            SqlCommand komut = new SqlCommand("Select * from ItsIlac where AdSoyad like '%" + TxtIsımBul.Text + "%'", baglantii);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglantii.Close();
        }

        

        private void BtnGoster_Click(object sender, EventArgs e)
        {
            verilerigoster("Select * from ItsIlac ");
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            baglantii.Open();
            SqlCommand komut = new SqlCommand("insert into ItsIlac(IlacAdi,AdSoyad,Tc,Tarih,ITSkodu)values (@ilacismi,@adi,@tci,@tarihi,@its)", baglantii);

            komut.Parameters.AddWithValue("@ilacismi", TxtIlacAdi.Text);
            komut.Parameters.AddWithValue("@Adi", TxtIsım.Text);
            komut.Parameters.AddWithValue("@tci", TxtTc.Text);
            komut.Parameters.AddWithValue("@tarihi", TxtTarih.Text);
            komut.Parameters.AddWithValue("@its", TxtIts.Text);
            komut.ExecuteNonQuery();
            verilerigoster("Select * from ItsIlac");
            baglantii.Close();
            TxtIlacAdi.Clear();
            TxtIsım.Clear();
            TxtTc.Clear();
            TxtTarih.Clear();
            TxtIts.Clear();
            TxtIlacAdi.Focus();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglantii.Open();
            SqlCommand komut = new SqlCommand("delete from ItsIlac where id=@idii", baglantii);
            komut.Parameters.AddWithValue("@idii",TxtSil.Text);
            komut.ExecuteNonQuery();
            verilerigoster("Select * from ItsIlac");
            baglantii.Close();
            TxtSil.Clear();
        }

        private void BtnTcBul_Click(object sender, EventArgs e)
        {
            baglantii.Open();
            SqlCommand komut = new SqlCommand("Select * from ItsIlac where Tc like '%" + TxtTcBul.Text + "%'", baglantii);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglantii.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dataGridView1.SelectedCells[0].RowIndex;
            string IlacAdi = dataGridView1.Rows[secilialan].Cells[1].Value.ToString();
            string AdSoyad = dataGridView1.Rows[secilialan].Cells[2].Value.ToString();
            string Tc = dataGridView1.Rows[secilialan].Cells[3].Value.ToString();
            string Tarih = dataGridView1.Rows[secilialan].Cells[4].Value.ToString();
            string ITSkodu = dataGridView1.Rows[secilialan].Cells[5].Value.ToString();

            TxtIlacAdi.Text = IlacAdi;
            TxtIsım.Text = AdSoyad;
            TxtTc.Text = Tc;
            TxtTarih.Text = Tarih;
            TxtIts.Text = ITSkodu;
            
        }

        private void BtnGuncelle_Click_1(object sender, EventArgs e)
        {
            baglantii.Open();
            SqlCommand komut = new SqlCommand(" update ItsIlac set AdSoyad='" + TxtIsım.Text + "',Tc='" + TxtTc.Text + "',Tarih='" + TxtTarih.Text + "',ITSkodu='" + TxtIts.Text + "' where IlacAdi='" + TxtIlacAdi.Text + "'", baglantii);
            komut.ExecuteNonQuery();
            verilerigoster(" select * from ItsIlac ");
            baglantii.Close();

        }






        private void BtnAnaSayfa_Click(object sender, EventArgs e)
        {
            FrmGirisler fr = new FrmGirisler();

            
            fr.Show();
            this.Hide();
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
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

        private void ItsIlacVer_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnWorld_Click(object sender, EventArgs e)
        {
            word.Application app = new word.Application();
            app.Visible = true;
            word.Document aktar;
            aktar = app.Documents.Add(System.Reflection.Missing.Value);
            app.Selection.Font.Size = 20;
            app.Selection.TypeText(TxtIlacAdi.Text);
            app.Selection.TypeText(TxtIsım.Text);
            app.Selection.TypeText(TxtTc.Text);
            app.Selection.TypeText(TxtTarih.Text);
            app.Selection.TypeText(TxtIts.Text);
        }

        private void BtnTxt_Click(object sender, EventArgs e)
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
            MessageBox.Show("Bu Program : Visual Studio Derleyicisinde C# Dilinde Object Oriented Olarak Geliştirilip , Veri Tabanı Olarak SQL2019 Kullanılmıştır");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
