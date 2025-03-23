using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafıza_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            int sayı1, sayı2, sayı3,sayı4, sayı5, sayı6, sayı7, sayı8, sayı9, sayı10, sayı11, sayı12;

            sayı1 = random.Next(0, 50);
            sayı2 = random.Next(0, 50);
            sayı3 = random.Next(0, 50);
            sayı4 = random.Next(0, 50);
            sayı5 = random.Next(0, 50);
            sayı6 = random.Next(0, 50);
            sayı7 = random.Next(0, 50);
            sayı8 = random.Next(0, 50);
            sayı9 = random.Next(0, 50);
            sayı10 = random.Next(0, 50);
            sayı11 = random.Next(0, 50);
            sayı12 = random.Next(0, 50);

            label1.Text = sayı1.ToString();
            label2.Text = sayı2.ToString();
            label3.Text = sayı3.ToString();
            label4.Text = sayı4.ToString();
            label5.Text = sayı5.ToString();
            label6.Text = sayı6.ToString();
            label7.Text = sayı7.ToString();
            label8.Text = sayı8.ToString();
            label9.Text = sayı9.ToString();
            label10.Text = sayı10.ToString();
            label11.Text = sayı11.ToString();
            label12.Text = sayı12.ToString();
        }
    }
}
