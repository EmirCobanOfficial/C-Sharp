using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumericUpDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam;
            toplam=Convert.ToInt32(numericUpDown1.Value+numericUpDown2.Value);
            label2.Text = toplam.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int carp;
            carp = Convert.ToInt32(numericUpDown1.Value * numericUpDown2.Value);
            label2.Text = carp.ToString();
        }
    }
}
