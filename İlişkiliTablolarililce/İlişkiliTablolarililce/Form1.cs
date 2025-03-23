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

namespace İlişkiliTablolarililce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source = EMIRMONSTER\\SQLEXPRESS;Initial catalog=dboililce;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("Select SehirAd From tblSehirler", connection);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            connection.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            connection.Open();
            SqlCommand komut2 = new SqlCommand("Select ilcead from tblilceler where ilid =@p1", connection);
            komut2.Parameters.AddWithValue("@p1", comboBox1.SelectedIndex + 1);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox2.Items.Add(dr2[0]);
            }
            connection.Close();
        }
    }
}
