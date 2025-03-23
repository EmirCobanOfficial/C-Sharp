using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Sehir_Tahmin_Oyunu
{
    public partial class Form1 : Form
    {
        string[] citylist = { "İstanbul", "Ankara", "İzmir", "Adana,", "Adiyaman", "AfyonKarahisar", "Ağrı", "Aksaray", "Amasya", "Antalya", "Ardahan", "Artvin", "Aydın", "Balıkesir", "Bartın", "Batman", "Bayburt", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Düzce", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Karabük", "Karaman", "Kars", "Manisa", "Kütahya", "Malatya", "Uşak", "Zonguldak", "Tokat" };
        string citynametobefound = "";
        int numberoffoundletters = 0;
        int yourremainingrights = 4;
        Random rsg;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numberoffoundletters = 0;
            enteredletters.Text = "";
            btn_letterenter.Enabled = true;
            yourremainingrights = 4;
            btnpredict.Enabled = true;

            grpgame.Controls.Clear();

            for (int i = 0; i < citynametobefound.Length; i++)
            {
                Label label = new Label();
                label.Location = new Point(20 * i + 30, 20);
                label.Text = citynametobefound[i].ToString();
                label.Font= new System.Drawing.Font("Microsoft Sans Serif", 8.50F,System.Drawing.FontStyle.Bold,System.Drawing.GraphicsUnit.Point,((byte)(162)));
                label.Size = new System.Drawing.Size(15, 20);
                label.BackColor = Color.Red;
                label.ForeColor = Color.Red;
                grpgame.Controls.Add(label);
            }


        }

        private void btn_letterenter_Click(object sender, EventArgs e)
        {
            bool Arethereletters = false;
            if (txt_letter.Text.Length != 1)
            {
                MessageBox.Show("Lütfen Tek Harf Giriniz");
            }
            else
            {
                if (enteredletters.Text.Contains(txt_letter.Text))
                {
                    MessageBox.Show("Bu harfi daha önce girmiştiniz");
                    txt_letter.Text = "";
                    txt_letter.Focus();
                    return; 
                }
                foreach (Control item in grpgame.Controls)
                {
                    if (item is Label)
                    {
                        Label label = item as Label;
                        if (enteredletters.Text.ToUpper() == txt_letter.Text.ToUpper())
                        {
                            label.ForeColor = Color.Black;
                            label.BackColor = Color.Lime;
                            Arethereletters = true;
                            numberoffoundletters++;
                        }
                    }
                }
            }
            if (true)
            {
                yourremainingrights--;
                yourremainingentitlement.Text = yourremainingrights.ToString();
                if (yourremainingrights == 0)
                {
                    btnpredict.Enabled = false;
                    btn_letterenter.Enabled = false;
                    MessageBox.Show("Oyun Bitti. Kaybettiniz Yeni Oyun için, yeni oyun butonuna tıklayınız");
                }
            }
            enteredletters.Text += txt_letter.Text + " ";
            if (numberoffoundletters == citynametobefound.Length)
            {
                btn_letterenter.Enabled = false;
                btnpredict.Enabled = false;
                MessageBox.Show("Oyun Bitti, Tebrikler, Oyunu Kazandınız :)");
            }
            txt_letter.Text = "";
            txt_letter.Focus(); // harf butonuna bizi konumlasın

        }
    }
}
