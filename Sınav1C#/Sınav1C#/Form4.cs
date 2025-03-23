using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sınav1C_
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sinav1 = Convert.ToDouble(textBox1.Text);
            double sinav2 = Convert.ToDouble(textBox2.Text);
            double sinav3 = Convert.ToDouble(textBox3.Text);
            double proje = Convert.ToDouble(textBox4.Text);

                double ortalama = (sinav1 + sinav2 + sinav3 + proje) / 4;

                label5.Text = "Ortalama  " + ortalama.ToString();
            }
        }
    }