using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geriye_Değer_Döndürmeyen_Metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void metot1()
        {
            label1.Text = "07 Ağustos 2017";
            label2.Text = "Soğuk bir gün";
            label3.Text = "Peynir - Karpuz - Su";
            label4.Text = "İstanbul / Şisli / Mecidiyeköy";
        }

        void metot2()
        {
            label1.BackColor = Color.Orange;
            label2.BackColor = Color.Blue;
            label3.BackColor = Color.Pink;
            label4.BackColor = Color.LemonChiffon;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            metot1();
            metot2();

        }
    }
}
