using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Klasör_İşlemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_klasorolustur_Click(object sender, EventArgs e)
        {
            string klasor = textBox1.Text;
            Directory.CreateDirectory("C:\\Users\\Emir Çoban\\Desktop\\" + klasor);
        }

        private void btn_klasorsil_Click(object sender, EventArgs e)
        {
            string klasor = textBox1.Text;
            Directory.Delete("C:\\Users\\Emir Çoban\\Desktop\\" + klasor);
        }

        private void btn_yolkontrol_Click(object sender, EventArgs e)
        {
            string yol = "C:\\Users\\Emir Çoban\\Desktop\\projeler";
            MessageBox.Show(Directory.Exists(yol).ToString());
        }

        private void btn_olusturulma_Click(object sender, EventArgs e)
        {
            string adres = "C:\\Users\\Emir Çoban\\Desktop\\projeler";
            MessageBox.Show(Directory.GetCreationTime(adres).ToString());
        }

        private void btn_programfiles_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label2.Text = "Program Files";
            string adres = "C:\\Users\\Emir Çoban\\Desktop\\projeler\\ELIFNUR";
            string[] klasor = Directory.GetDirectories(adres);
            foreach  (string i in klasor)
            {
                listBox1.Items.Add(i.ToString());
            }
        }

        private void btn_sonerisimzamanı_Click(object sender, EventArgs e)
        {
            string yol = "C:\\Users\\Emir Çoban\\Desktop\\projeler";
            MessageBox.Show(Directory.GetLastAccessTime(yol).ToString());
        }

        private void btn_klasoraddegistir_Click(object sender, EventArgs e)
        {
            Directory.Move("C:\\Users\\Emir Çoban\\Desktop\\drivers", "C:\\Users\\Emir Çoban\\Desktop\\driver");
        }

        private void btn_sürücüler_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label2.Text = "Drivers";
            string[] dizi = System.IO.Directory.GetLogicalDrives(); // sürücülere listeler
            listBox1.Items.AddRange(dizi);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo ustdizin = Directory.GetParent("C:\\Users\\Emir Çoban\\Desktop\\driver");
            MessageBox.Show(ustdizin.ToString());
        }
    }
}
