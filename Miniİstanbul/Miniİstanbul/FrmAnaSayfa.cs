using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Miniİstanbul
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCamiler camibilgi = new FrmCamiler();
            camibilgi.Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            FrmHarita frmHarita = new FrmHarita();
            frmHarita.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmKamera frmKamera = new FrmKamera();
            frmKamera.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmMetro frmMetro = new FrmMetro();
            frmMetro.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmMetrobus frm = new FrmMetrobus();
            frm.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            FrmNeAlınır frmalınır = new FrmNeAlınır();
            frmalınır.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            FrmNeYenir frm = new FrmNeYenir();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Kopruler frm = new Kopruler();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmMuzeler frm = new FrmMuzeler();
            frm.Show();
            this.Hide();
        }
    }
}
