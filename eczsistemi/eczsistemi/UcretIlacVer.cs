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
using word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace eczsistemi
{
    public partial class UcretIlacVer : Form
    {
        public UcretIlacVer()
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
        

        private void BtnIsımBul_Click(object sender, EventArgs e)
        {
            baglantii.Open();
            SqlCommand komut = new SqlCommand("Select * from UcretBorc where HastaAdi like '%" + TxtIsimBul.Text + "%'", baglantii);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglantii.Close();
        }

        private void BtnGoster_Click(object sender, EventArgs e)
        {
            verilerigoster("Select * from UcretBorc ");
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            baglantii.Open();
            SqlCommand komut = new SqlCommand("insert into UcretBorc(HastaAdi,HastaTelefon,Tc,IlacAdi,Tarih,TeslimAlan,Ucret,ITS)values (@adi,@tel,@tci,@ilacismi,@tarihi,@teslim,@fiyat,@its)", baglantii);

            komut.Parameters.AddWithValue("@adi", TxtHastaAdi.Text);
            komut.Parameters.AddWithValue("@tel", TxtHastaTel.Text);
            komut.Parameters.AddWithValue("@tci", TxtTc.Text);
            komut.Parameters.AddWithValue("@ilacismi", TxtIlacAdi.Text);
            komut.Parameters.AddWithValue("@tarihi", TxtTarih.Text);
            komut.Parameters.AddWithValue("@teslim", TxtAlan.Text);
            komut.Parameters.AddWithValue("@fiyat", TxtUcret.Text);
            komut.Parameters.AddWithValue("@its", TxtIts.Text);
            komut.ExecuteNonQuery();
            verilerigoster("Select * from UcretBorc");
            baglantii.Close();
            TxtHastaAdi.Clear();
            TxtHastaTel.Clear();
            TxtTc.Clear();
            TxtIlacAdi.Clear();
            TxtTarih.Clear();
            TxtAlan.Clear();
            TxtUcret.Clear();
            TxtIts.Clear();
            TxtHastaAdi.Focus();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglantii.Open();
            SqlCommand komut = new SqlCommand("delete from UcretBorc where id=@idii", baglantii);
            komut.Parameters.AddWithValue("@idii", TxtBorc.Text);
            komut.ExecuteNonQuery();
            verilerigoster("Select * from UcretBorc");
            baglantii.Close();
            TxtBorc.Clear();
        }

        private void BtnTcBul_Click(object sender, EventArgs e)
        {
            baglantii.Open();
            SqlCommand komut = new SqlCommand("Select * from UcretBorc where Tc like '%" + TxtTcBul.Text + "%'", baglantii);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglantii.Close();
        }

        

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            baglantii.Open();
            SqlCommand komut = new SqlCommand(" update UcretBorc set HastaTelefon='" + TxtHastaTel.Text + "',IlacAdi='" + TxtIlacAdi.Text + "',Tarih='" + TxtTarih.Text + "',TeslimAlan='" + TxtAlan.Text + "',Ucret='"+TxtUcret.Text+"',Tc='"+TxtTc.Text+"',ITS='"+TxtIts.Text+"' where HastaAdi='" + TxtHastaAdi.Text + "'", baglantii);
            komut.ExecuteNonQuery();
            verilerigoster(" select * from UcretBorc ");
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dataGridView1.SelectedCells[0].RowIndex;
            string HastaAdi = dataGridView1.Rows[secilialan].Cells[1].Value.ToString();
            string HastaTelefon = dataGridView1.Rows[secilialan].Cells[2].Value.ToString();
            string IlacAdi = dataGridView1.Rows[secilialan].Cells[3].Value.ToString();
            string Tarih = dataGridView1.Rows[secilialan].Cells[4].Value.ToString();
            string TeslimAlan = dataGridView1.Rows[secilialan].Cells[5].Value.ToString();
            string Ucret = dataGridView1.Rows[secilialan].Cells[6].Value.ToString();
            string Tc = dataGridView1.Rows[secilialan].Cells[7].Value.ToString();
            string ITS = dataGridView1.Rows[secilialan].Cells[8].Value.ToString();

            TxtHastaAdi.Text = HastaAdi;
            TxtHastaTel.Text = HastaTelefon;
            TxtIlacAdi.Text = IlacAdi;
            TxtTarih.Text = Tarih;
            TxtAlan.Text = TeslimAlan;
            TxtUcret.Text = Ucret;
            TxtTc.Text = Tc;
            TxtIts.Text = ITS;
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

        private void Btnworld_Click(object sender, EventArgs e)
        {
            word.Application app = new word.Application();
            app.Visible = true;
            word.Document aktar;
            aktar = app.Documents.Add(System.Reflection.Missing.Value);
            app.Selection.Font.Size = 20;
            app.Selection.TypeText(TxtHastaAdi.Text);
            app.Selection.TypeText(TxtHastaTel.Text);
            app.Selection.TypeText(TxtIlacAdi.Text);
            app.Selection.TypeText(TxtTarih.Text);
            app.Selection.TypeText(TxtAlan.Text);
            app.Selection.TypeText(TxtUcret.Text);
            app.Selection.TypeText(TxtTc.Text);
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

        private void UcretIlacVer_Load(object sender, EventArgs e)
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
            MessageBox.Show("Bu Program : Visual Studio Derleyicisinde C# Dilinde Object Oriented Olarak Geliştirilip , Veri Tabanı Olarak SQL2019 Kullanılmıştır");
        }
    }
}
