using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miniİstanbul
{
    public partial class FrmKamera : Form
    {
        public FrmKamera()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://istanbuluseyret.ibb.gov.tr/beyazit-meydani/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.canlimobeseizle.com/sariyer-carsi-canli-mobese-izle/");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa frm = new FrmAnaSayfa();
            frm.Show();
            this.Hide();
        }
    }
}