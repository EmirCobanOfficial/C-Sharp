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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        int sayı;
        private void button1_Click(object sender, EventArgs e)
        {
            sayı = Convert.ToInt32(textBox1.Text);
            if (sayı % 2 == 0)
            {
                MessageBox.Show("Sayı Çifttir");
            }
            if (sayı % 2 == 1)
            {
                MessageBox.Show("Sayı Tektir");
            }
        }
    }
}