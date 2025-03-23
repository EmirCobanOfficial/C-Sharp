using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sınıf_ve_Nesne_Kavramı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Arabalar rb = new Arabalar();
            rb.renk = "Gri";
            rb.fiyat = 25000000;
            rb.durum = 's';
            rb.model = 2024;
            rb.hız = 300;

            label1.Text = rb.renk;
            label2.Text = rb.fiyat.ToString();
            label3.Text = rb.durum.ToString();
            label4.Text = rb.model.ToString();
            label5.Text = rb.hız.ToString();

            this.BackColor = Color.Gray;


        }
    }
}
