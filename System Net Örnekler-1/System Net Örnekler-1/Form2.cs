using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace System_Net_Örnekler_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            listView1.Items.Clear();
            try
            {
                IPHostEntry siteadi = Dns.GetHostEntry(textBox1.Text);
                IPAddress[] ip = siteadi.AddressList; // site adını tutacak
                label4.Text = ip[0].ToString();
                ListViewItem ekle = new ListViewItem();
                ekle.Text = textBox1.Text.ToString();
                ekle.SubItems.Add(label4.Text.ToString());
                listView1.Items.Add(ekle);
                textBox1.Clear();
                label4.Text = "";

            }
            catch (Exception)
            {
                MessageBox.Show("Böyle bir site bulunamadı");

            }
        }
    }
}
