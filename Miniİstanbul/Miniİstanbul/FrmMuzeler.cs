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
    public partial class FrmMuzeler : Form
    {
        public FrmMuzeler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa frm = new FrmAnaSayfa();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //İSTANBUL BÜYÜKŞEHİR BELEDİYESİ'NE BAĞLI MÜZELER
        //(MİLLİ SARAYLAR) BAĞLI MÜZELER
        //GENELKURMAY BAŞKANLIĞI'NA BAĞLI MÜZELER
        //ÖZEL MÜZELER
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "KÜLTÜR VE TURİZM BAKANLIĞI'NA BAĞLI MÜZELER")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("TOPKAPI SARAYI MÜZESİ");
                comboBox2.Items.Add("AYASOFYA MÜZESİ");                        
                comboBox2.Items.Add("AYA İRİNİ KİLİSESİ MÜZESİ");
                comboBox2.Items.Add("ANADOLUHİSARI MÜZESİ");
                comboBox2.Items.Add("RUMELİHİSARI MÜZESİ");
            }
            if (comboBox1.Text == "İSTANBUL BÜYÜKŞEHİR BELEDİYESİ'NE BAĞLI MÜZELER")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("YEREBATAN SARNICI MÜZESİ");
                comboBox2.Items.Add("PANAROMA 1453 TARİH MÜZESİ");
                comboBox2.Items.Add("MİNİATATÜRK");
                comboBox2.Items.Add("ATATÜRK MÜZESİ");
                comboBox2.Items.Add("İTFAİYE MÜZESİ");
            }
            if (comboBox1.Text == "(MİLLİ SARAYLAR) BAĞLI MÜZELER")
            {
                comboBox2.Items.Add("AYNALIKAVAK KASRI");
                comboBox2.Items.Add("BEYKOZ SARAYI");
                comboBox2.Items.Add("BEYLERBEYİ SARAYI");
                comboBox2.Items.Add("DOLMABAHÇE SARAYI");
                comboBox2.Items.Add(" FLORYA ATATÜRK DENİZ KÖŞKÜ");
                comboBox2.Items.Add("IHLAMURLARI KASRI");
            }
            if (comboBox1.Text == "GENELKURMAY BAŞKANLIĞI'NA BAĞLI MÜZELER")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("DENİZ MÜZESİ");
                comboBox2.Items.Add("HAVACILIK MÜZESİ");
                comboBox2.Items.Add("ASKERİ MÜZE");
            }
            if (comboBox1.Text == "ÖZEL MÜZELER")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("İSTANBUL MODERN SANAT MÜZESİ");
                comboBox2.Items.Add("İSTANBUL OYUNCAK MÜZESİ");
                comboBox2.Items.Add("JURASSIC LAND");
                comboBox2.Items.Add("SİRKECİ GARI TCDD MÜZESİ");
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "TOPKAPI SARAYI MÜZESİ")
            {
                richTextBox1.Text = "Sultanahmet Meydanı, Eminönü\r\n0212 512 0480\r\nZiyaret gün ve saatleri: Salı günü hariç 09.00 - 19.00 (Yaz saati uygulaması boyunca)\r\nÜcret: 20 TL, Harem: 15 TL";
                pictureBox2.ImageLocation = "C:\\Users\\Emir Çoban\\Desktop\\projeler\\miniistanbul\\topkapı.jfif";
            }
            if (comboBox2.Text == "AYASOFYA MÜZESİ")
            {
                richTextBox1.Text = "Sultanahmet Meydanı, Eminönü\r\n0212 522 1750\r\nZiyaret gün ve saatleri: Pazartesi kapalı, diğer günler 09.00 - 19.00 (Yaz saati uygulaması boyunca)\r\nÜcret: 20 TL";
                pictureBox2.ImageLocation = "C:\\Users\\Emir Çoban\\Desktop\\projeler\\miniistanbul\\ayasofya1.jpg";
            }
            if (comboBox2.Text == "AYA İRİNİ KİLİSESİ MÜZESİ")
            {
                richTextBox1.Text = "Topkapı Sarayı Avlusu, Sultanahmet, Eminönü\r\n0212 528 4500\r\nZiyaret gün ve saatleri: Topkapı Sarayı Müzesi'nden alınacak izinle gezilebilir";
                pictureBox2.ImageLocation = "C:\\Users\\Emir Çoban\\Desktop\\projeler\\miniistanbul\\AYAİRİNİKİLİSESİMÜZESİ.jfif";
            }
            if (comboBox2.Text == "ANADOLU HİSARI MÜZESİ")
            {
                richTextBox1.Text = "Ziyaret saatleri: Pazartesi günleri hariç, haftanın 6 günü ziyaret edilebilen müzeyi 09:00 – 19:00 saatleri arasında ziyaret edebilirsiniz.\r\n\r\nGiriş ücreti:\r\n\r\nİndirimli bilet: 20 TL\r\nTam bilet: 60 TL\r\nYabancı turist bileti: 100 TL\r\nAyrıca: Anadolu Hisarı ziyaretçilerine müze kartı geçerli değildir!";
                pictureBox2.ImageLocation = "C:\\Users\\Emir Çoban\\Desktop\\projeler\\miniistanbul\\AYAİRİNİKİLİSESİMÜZESİ.jfif";
            }
            if (comboBox2.Text == "RUMELİHİSARI MÜZESİ")
            {
                richTextBox1.Text = "Yaz Dönemi: 1 Nisan – 1 Ekim tarihleri arasında 08.00 – 19.00 saatleri arası,\r\n\r\nKış Dönemi: 1 Ekim – 1 Nisan tarihleri arasında 08.00 – 17.00 saatleri arası ziyaret edebilirsiniz.\r\n\r\nÇarşamba günleri KAPALIDIR..\r\n\r\nT.C. Kültür ve Turizm Bakanlığı’nın belirlediği, Müze ve Ören yerlerine girişlerde uygulanacak usul ve esaslar hakkında yönergenin 10.Maddesine göre; Müze ve ören yerleri dini bayramların birinci günü saat 13:00’e kadar kapalıdır.";
                pictureBox2.ImageLocation = "C:\\Users\\Emir Çoban\\Desktop\\projeler\\miniistanbul\\RUMELİHİSARI MÜZESİ.jfif";
            }
        }
    }
}
