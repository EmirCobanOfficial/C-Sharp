using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Köstebek_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int puan = 0;
        Random rnd = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();

            for (int i = 1; i < 73; i++) // bir tane buton olusturduk 72 tane
            {
                Button btn = new Button();
                btn.BackColor = Color.White;
                btn.ForeColor = Color.Black;
                btn.Width = 60;
                btn.Height = 60;
                btn.Text = i.ToString();
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int random = rnd.Next(1,73);
            foreach (var a in flowLayoutPanel1.Controls)
            {
                Button btn =a as Button; //rastgele buton sayısı esitse kırmızıya esist degilse beyaz olacak (timer süresine göre)
                if (btn.Text == random.ToString())
                {
                    btn.BackColor = Color.Red; //rastgele ve rdn birbirine esit olursa kırmızı değişse beyaz olacak
                    btn.Click += new EventHandler(btn_click);
                }
                else
                {
                    btn.BackColor = Color.White;
                }
            }
        }
        void btn_click(object sender, EventArgs e) //herhangi bir event komut kullandığımız komut
        {
            Button btn = sender as Button;
            if (btn.BackColor == Color.Red)
            {
                puan++;
            }
            else
            {
                puan--;
            }
            this.Text = puan.ToString();
        }
    }
}
