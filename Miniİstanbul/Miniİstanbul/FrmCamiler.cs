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

namespace Miniİstanbul
{
    public partial class FrmCamiler : Form
    {
        public FrmCamiler()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=EMIRMONSTER\\SQLEXPRESS;Initial Catalog=istanbul; Integrated Security=True;");
        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();

            SqlCommand komut = new SqlCommand();
            komut.Connection = baglan;
            komut.CommandText = "Select * from İstanbulCamileri";
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                richTextBox1.Text = oku["SultanAhmetCami"].ToString();
            }
            baglan.Close();

            pictureBox1.ImageLocation = ("C:\\Users\\Emir Çoban\\Desktop\\projeler\\miniistanbul\\sultanahmet.jpg");
        }

        private void btn_yenicami_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection= baglan;
            komut.CommandText = "select * from İstanbulCamileri";
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                richTextBox1.Text = oku["YeniCami"].ToString();
            }
            baglan.Close();
            pictureBox1.ImageLocation = ("C:\\Users\\Emir Çoban\\Desktop\\projeler\\miniistanbul\\yenicami.jpg");
        }

        private void btn_ayasofya_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection= baglan;
            komut.CommandText = ("Select * from İstanbulCamileri");
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                richTextBox1.Text = oku["AyaSofyaCami"].ToString();
            }
            baglan.Close(); ;
            pictureBox1.ImageLocation = "C:\\Users\\Emir Çoban\\Desktop\\projeler\\miniistanbul\\ayasofya.jpg";
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa frmAnaSayfa = new FrmAnaSayfa();
            frmAnaSayfa.Show();
            this.Close();
        }

        private void btn_ortaköy_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection= baglan;
            komut.CommandText = "select * from İstanbulCamileri";
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                richTextBox1.Text = oku["BüyükCami"].ToString();
                pictureBox1.ImageLocation = "C:\\Users\\Emir Çoban\\Desktop\\projeler\\miniistanbul\\mecidiye.jpg";
            }
            baglan.Close();
        }

        private void btn_fatih_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection= baglan;
            komut.CommandText = "select * from İstanbulCamileri";
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                richTextBox1.Text = oku["FatihCami"].ToString();
                pictureBox1.ImageLocation = "C:\\Users\\Emir Çoban\\Desktop\\projeler\\miniistanbul\\fatihcami.jpg";
            }
            baglan.Close();
        }

        private void btn_süleymaniye_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglan;
            komut.CommandText = "select * from İstanbulCamileri";
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                richTextBox1.Text = oku["SüleymaniyeCami"].ToString();
                pictureBox1.ImageLocation = "C:\\Users\\Emir Çoban\\Desktop\\projeler\\miniistanbul\\süleymaniye.jpg";
            }
            baglan.Close();
        }

        private void btn_beyazit_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new  SqlCommand();
            komut.Connection = baglan;
            komut.CommandText = "select * from İstanbulCamileri";
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                richTextBox1.Text = oku["BeyazitCami"].ToString();
                pictureBox1.ImageLocation = "C:\\Users\\Emir Çoban\\Desktop\\projeler\\miniistanbul\\BeyazıtCami.jpg";
            }
            baglan.Close();
        }
    }
}
