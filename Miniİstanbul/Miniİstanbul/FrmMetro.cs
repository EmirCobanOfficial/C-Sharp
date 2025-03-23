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
    public partial class FrmMetro : Form
    {
        public FrmMetro()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa frmAnaSayfa = new FrmAnaSayfa();
            frmAnaSayfa.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMetro_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Min  İstanbul  Programı  Metro  Durakları ";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(1) + textBox1.Text.Substring(0, 1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                textBox1.Text = "Yenikapi, Aksaray,Emnivet Fatih, Ulubath Topkapi, Bayrampaça Maltepe, Sagmalcilar,Kartaltepe/Kocatepe, Otogar, Esenler, Terazidere, Davutpasa Vildiz Teknik Üniversitesi, Merter,Zeytinburnu, Bakirköy-Incirli, Bahçelievler, Ataköy Sirinevler, Yenibosna, DTM istanbul Fuar Merkezi, Havalimant M1B uzatmas istasyonlar Esenler, Menderes, Uc yüzlu, Bagcilar Meydan, Kirazli";
            }
            if (comboBox1.SelectedIndex == 1)
            {
                textBox1.Text = "M2 Yenikapi- Haciosman Metro Hatti Istasyonlar: Yenikapi, Vezneciler, Hali, Sistlane, Taksim, Osmanbey, Sisli/Mecidiyeköy, Gayrettepe, Levent, 4. Levent. Sanavi, iTÜ Avazada, Atatürk Oto Sanavi, Darüssafaka, Haciosman Sevrantene";
            }
            if (comboBox1.SelectedIndex == 2)
            {
                textBox1.Text = "M3 Basaksehir Metro Hatti Istasyonlar : Metrokent, Baçak Konutlan, Siteler, Turgut Özal, Ikitelli Sanayi, Olimpiyat, Ziya Gokalp Mh, Istos,Mahmutbey, Yeni Mahalle, Kirazi";
            }
            if (comboBox1.SelectedIndex == 3)
            {
                textBox1.Text = "M4 Kadiköy-Kartal Metro Hatti Kadiköy, Ayrilik esmesi, Acibadem, Unalan, Göztepe, Yenisahra, Kozyatagi, Bostanci, Küçükyal,Maltepe, Huzurevi, Gülsuyu, Esenkent, Hastane/Adliye, Soganlik, Kartal Aktarma istasyonlar: Kadiköy istasyonu - Sehir Hatlan ve IDO Hatti Kadiköy istasyonu - Moda Nostaljik Tramvay Hatti Avrilk Cosmes: — Marmaray Hattı - Ünalan İstasyonu - Metrobüs Hattı";
            }
            if (comboBox1.SelectedIndex == 4)
            {
                textBox1.Text = "T1 Kabatas-Bagcilar Tramvay Hatti Istasxonlar.: Kabatas, Findikli, Tophane, Karakoy, Eminönü, Sirkeci, Gülhane, Sultanahmet, Cemberlitas, Beyazit, Laleli, Aksaray, Yusufpasa, Haseki,Findikzade, Capa-Sehremini, Pazartekke, Topkapi, Cevizlibal-A.Ö.Y,Merkez Efendi, Aksemsettin, Mithatpasa, Zeytinburnu, Mehmet Akif, Merter Tekstil Sitesi, Güngören,Akinailar. Sodani. Yavuz Selim. Günectene. Radcilar";
            }
            if (comboBox1.SelectedIndex == 5)
            {
                textBox1.Text = "T3 Kadiköy Moda Nostaljik Tramway istasyonlar iDO- iskele Camii- Carsi- Altivol-Bahariye-Kilise- Moda Ilkokulu-Moda Caddesi- Mühurdar - Damga Sokak";
            }
            if (comboBox1.SelectedIndex == 6)
            {
                textBox1.Text = "Т4 Topkapi Habibler Tramvay Hatti istasyonlar Mescid-i Selam, Cebeci, Sultansifligi, Yeni Mahalle, Haci Sükrü, 50.Yil/Bastabya, Cumhuriyet Mah,Metris, Karadeniz, Tasköprü, Ali Fuat Basgil, Bosna/Sukurgesme, Sagmalcilar, Uluyol/Beres, Rami,Toncular. Demirkani. Sehitlik, Edirnekani. Vatan, Fetihkapı, Topkapı";
            }
            if (comboBox1.SelectedIndex == 7)
            {
                textBox1.Text = "F1 Taksim - Kabatas Füniküler Hatti Istasyonlar Kabatas - Taksim";
            }
        }
    }
}
