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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int sayı;
            int faktoriyel = 1;

            sayı = Convert.ToInt32(textBox1.Text);
            for (int i = 1; i <= sayı; i++)
            {
                faktoriyel = faktoriyel * i;
                label2.Text = faktoriyel.ToString();
            }
        }
    }
}