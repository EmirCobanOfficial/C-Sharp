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

namespace SQL_de_Mükerrer_Kayıt_Engelleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connetion = new SqlConnection("Data Source=EMIRMONSTER\\SQLEXPRESS;Initial Catalog=DersVeriTabanı;Integrated Security=True;");

        bool durum;

        void mukerrer()
        {
            connetion.Open();
            SqlCommand komut = new SqlCommand("Select * from bilgi where Numara=@p1", connetion);
            komut.Parameters.AddWithValue("@p1", txtnumara.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                durum = false; // Kayıt zaten var.
            }
            else
            {
                durum = true; // Kayıt yok, eklenebilir.
            }
            connetion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mukerrer();
            if (durum == true)
            {
                connetion.Open();
                SqlCommand komut = new SqlCommand("insert into bilgi (Numara,AdSoyad) values (@p1,@p2)", connetion);
                komut.Parameters.AddWithValue("@p1", txtnumara.Text);
                komut.Parameters.AddWithValue("@p2", txt_ad.Text);
                komut.ExecuteNonQuery();
                connetion.Close();
                MessageBox.Show("Kayıt Eklendi");
            }
            else
            {
                MessageBox.Show("Bu kayıt zaten var", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
