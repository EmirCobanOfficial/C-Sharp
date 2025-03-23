using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kapsülleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Emlak evim = new Emlak();
            evim.Semt = textBox1.Text;
            evim.Odayısı = Convert.ToInt32(textBox2.Text);
            evim.Katno = Convert.ToInt32(textBox3.Text);
            evim.Alan=Convert.ToInt32(textBox4.Text);

            ListViewItem ekle = new ListViewItem();
            ekle.Text = evim.Semt;
            ekle.SubItems.Add(evim.Odayısı.ToString());
            ekle.SubItems.Add(evim.Katno.ToString());
            ekle.SubItems.Add(evim.Alan.ToString());

            listView1.Items.Add(ekle);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }
    }
}
