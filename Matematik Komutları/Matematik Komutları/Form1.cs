using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematik_Komutları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_mutlakdeger_Click(object sender, EventArgs e)
        {
            int deger = -10;
            int pozitif;
            pozitif=Math.Abs(deger); //     
            label1.Text = pozitif.ToString();
        }

        private void btn_usteyuvarla_Click(object sender, EventArgs e)
        {
            double deger;
            deger = 5.2;
            double yuvarla=Math.Ceiling(deger); // celiling üst sayısı yavarlama
            label1.Text = yuvarla.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayı = 4.9;
            double yuvarla = Math.Floor(sayı); //alt sayıya yıvarla
            label1.Text=yuvarla.ToString();
        }

        private void btn_maksimum_Click(object sender, EventArgs e)
        {
            double buyukdeger = Math.Max(4.87, 4.21); // max 2 sayı kabul ettiği.
            label1.Text = buyukdeger.ToString();
        }

        private void btn_minimum_Click(object sender, EventArgs e)
        {
            double kucukdeger = Math.Min(1.4, 2.85);
            label1.Text = kucukdeger.ToString();
        }

        private void btn_üsal_Click(object sender, EventArgs e)
        {
            double us = Math.Pow(2, 5); // pow sayının üstü alır. 
            label1.Text = us.ToString();
        }

        private void btn_kökal_Click(object sender, EventArgs e)
        {
            double sayı = 625;
            double kok = Math.Sqrt(sayı); // sqrt sayının kök değerini yazdırır
            label1.Text =(kok).ToString();
        }

        private void btn_pi_Click(object sender, EventArgs e)
        {
            double deger;
            deger = Math.PI;
            label1.Text = (deger).ToString();
        }

        private void btn_kalan_Click(object sender, EventArgs e)
        {
            double deger;
            deger = Math.IEEERemainder(120, 13); // sayının 
            label1.Text = deger.ToString();
        }

        private void btn_sinüs_Click(object sender, EventArgs e)
        {
            double deger;
            deger = Math.Sin(90);
            label1.Text = deger.ToString();

        }

        private void btn_cosinus_Click(object sender, EventArgs e)
        {
            double deger;
            deger = Math.Cos(90);
            label1.Text = deger.ToString();
        }

        private void btanjat_Click(object sender, EventArgs e)
        {
            double deger;
            deger = Math.Tan(180);
            label1.Text = deger.ToString();
        }
    }
}
