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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source = EMIRMONSTER\\SQLEXPRESS;Initial Catalog =library; Integrated Security = True ");

        private void verilerimigörüntüle()
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * from Books", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read()) {
               ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["bookname"].ToString());
                ekle.SubItems.Add(oku["writer"].ToString());
                ekle.SubItems.Add(oku["publishinghouse"].ToString());
                ekle.SubItems.Add(oku["page"].ToString());

                listView1.Items.Add(ekle);
            }
            baglan.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            verilerimigörüntüle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("insert into Books (id,bookname,writer,publishinghouse,page) values ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString()+ "')",baglan);

            komut.ExecuteNonQuery();
            baglan.Close();
            verilerimigörüntüle();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

        }
        int id = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Delete From Books where id = ("+id+")",baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verilerimigörüntüle();  
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[4].Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand(" Update Books set id='" + textBox1.Text.ToString() + "',page='" + textBox5.Text.ToString() + "',publishinghouse='" + textBox4.Text.ToString() +"',writer='" + textBox3.Text.ToString() + "',bookname='" + textBox2.Text.ToString() + "' where id=" + id + "", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verilerimigörüntüle();
        }
    }
}