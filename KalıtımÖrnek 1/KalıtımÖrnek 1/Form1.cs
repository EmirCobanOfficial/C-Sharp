using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalıtımÖrnek_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          INSAN ins = new INSAN();
            ins.ad = "Emir";
            ins.soyad = "Coban";
            ins.yaş = 17;
            ins.kilo = 50;

            PERSONEL pers = new PERSONEL();
            pers.department = "Eğitmen";
            pers.boy = 167;
            pers.yer = "Şube-1";

            label1.Text = ins.ad.ToString();
            label2.Text = ins.soyad.ToString();
            label3.Text  = ins.yaş.ToString();
            label4.Text = ins.kilo.ToString();

            label5.Text = pers.department.ToString();
            label6.Text = pers.boy.ToString();
            label7.Text = pers.yer.ToString();

            ins.mevki = "Müdür Yardımcısı";
            label8.Text = ins.mevki.ToString();

        }
    }
}
