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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Arabalar rbl = new Arabalar();
            rbl.renk = "Mor";
            rbl.fiyat = 28.235;
            rbl.durum = 'i';
            rbl.model = 2025;
            rbl.hız = 270;

            label1.Text = rbl.renk;
            label2.Text = rbl.fiyat.ToString();
            label3.Text = rbl.durum.ToString();
            label4.Text = rbl.model.ToString();
            label5.Text = rbl.hız.ToString();
            this.BackColor = Color.White;
        }
    }
}
