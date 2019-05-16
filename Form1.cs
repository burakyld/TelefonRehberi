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

namespace TelefonRehberi
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        void KisiGetir()
        {
            baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbRehber;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("select * from Kisiler",baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            gridview.DataSource = tablo;

            baglanti.Close();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KisiGetir();
        }

        private void buton_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_telefon.Text != "")
                {
                    string sorgu = "INSERT INTO Kisiler (telefon,ad,soyad) values (@telefon,@ad,@soyad)";
                    komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@ad", tb_ad.Text);
                    komut.Parameters.AddWithValue("@soyad", tb_soyad.Text);
                    komut.Parameters.AddWithValue("@telefon", tb_telefon.Text); // toInt32 metodu iptal edilip databasede veri türü varchar yapıldı.
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Kişi başarıyla eklendi."); // Kişinin eklendiğine dair messageBox eklendi.
                }
                else
                {
                    MessageBox.Show("Telefon boş bırakılamaz.");
                }
                

            }
            catch (SqlException)
            {
                MessageBox.Show("Bu numara kayıtlı.");
            }
            
            finally
            {
                baglanti.Close();
                KisiGetir();
            }      
        }

        private void gridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            tb_ad.Text = gridview.CurrentRow.Cells[0].Value.ToString();
            tb_soyad.Text = gridview.CurrentRow.Cells[1].Value.ToString();
            tb_telefon.Text = gridview.CurrentRow.Cells[2].Value.ToString();
        }

        private void buton_sil_Click(object sender, EventArgs e)
        {
            
            string sorgu = "delete from Kisiler where ad=@ad";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ad", tb_ad.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            KisiGetir();
        }
        private void buton_guncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "update Kisiler set ad=@ad, soyad=@soyad where telefon=@telefon";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ad",tb_ad.Text);
            komut.Parameters.AddWithValue("@soyad", tb_soyad.Text);
            komut.Parameters.AddWithValue("@telefon", tb_telefon.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            KisiGetir();
        }

        private void tb_arama_TextChanged(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from Kisiler where ad like '"+tb_arama.Text+"%'",baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "Kisiler");
            gridview.DataSource = ds.Tables["Kisiler"];
            baglanti.Close();
        }
    }
}
