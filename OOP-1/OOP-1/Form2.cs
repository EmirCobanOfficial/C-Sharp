using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            otomobil oto = new otomobil();
            oto.marka = "Hyundai";
            oto.model = "Accent";
            oto.modelyılı = 2015;
            oto.renk = "Mavi";
            oto.vitestipi = "Otomatik";

            string marka = oto.markagetir();

            label6.Text = oto.marka.ToString();
            label7.Text=oto.model.ToString();   
            label8.Text=oto.modelyılı.ToString();
            label9.Text=oto.renk.ToString();
            label10.Text = oto.vitestipi.ToString();
        }
    }
}
