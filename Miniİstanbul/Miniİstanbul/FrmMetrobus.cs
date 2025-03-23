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
    public partial class FrmMetrobus : Form
    {
        public FrmMetrobus()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa frm = new FrmAnaSayfa();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMetrobus_Load(object sender, EventArgs e)
        {
            textBox1.Text = " Minİstanbul Programı Metrobüs Durak ve Hat Bilgileri";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(1) + textBox1.Text.Substring(0, 1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                textBox1.Text = "Avcilar Kampüs - Sükrübey - IBB Sosyal Tesisler - Küçükçekmece - Cennet Mah.- Florya - Besyal - Sefaköy -Yenibosna - Sirinevler - Bahçelievler - Incirli - Zeytinburnu - Merter - Cevizlibag - Topkapi - Bayrampasa (Maltepe) - Edirnekapi - Ayvansaray - Halicioglu - Okmeydani - Darülaceze - Okmeydani Hastane - Calayan -Mecidiyeköy - Zincirlikuyu";
            }
            if (comboBox1.SelectedIndex == 1)
            {
                textBox1.Text = "Cevizlibag - Topkapi - Bayrampasa Maltepe - Edirnekapi - Ayvansaray - Halicioglu - Okmeydani -Darülaceze - Okmeydani Hastane - Caglayan - Mecidiyeköy - Zincirlikuyu - Bogaziçi Köprüsü -Burhaniye - Altunizade - Acibadem - Uzuncayir - Fikirtepe - Sogutlücesme";
            }
            if (comboBox1.SelectedIndex == 2)
            {
                textBox1.Text = "Avilar Kampüs-Sükrübey - IBB Sosyal Tesisler - Küçükgekmece - Cennet Mah. - Florya-Besyol -Sefaköy -Yenibosna - Sirinevler - Bahgelievler - Incirli - Zeytinburnu - Merter - Cevizlibag -Topkapi -Bayrampasa (Maltepe) -Edirnekapi - Ayvansaray - Halicioglu - Okmeydani - Darülaceze - Okmeydani Hastane - Caglayan -Mecidiyeköy - Zincirlikuyu - Bogaziçi Köprüs - Burhaniye - Altunizade -Acibadem - Uzuncavir - Fikirtene -Socut ucesme";
            }
            if (comboBox1.SelectedIndex == 3)
            {
                textBox1.Text = "Beylikdüzü Sondurak - Hadimköy - Cumhuriyet Mah.- Beylikdüzü Belediye - Beylikdüzü - Güzelyurt -Haramidere - Haramidere Sanayi - Saadetdere Mah. - Mustafa Kemal Paça - Cihangir/Universite mah. - Avcilar Kampüs-Sükqübey - IBB Sosyal Tesisler - Küçükçekmece - Cennet Mah. - Florya-Besyol -Sefaköy -Yenibosna - Sirinevler - Bahgelievler - incirli - Zeytinburnu - Merter - Cevizlibag - Topkapi -Bayrampasa (Maltepe) -Edirnekapi - Ayvansaray - Halicioglu - Okmeydani - Darülaceze - Okmeydani Hastano. Caõlavan MecidivekOv - Zincirlikumil";
            }
            if (comboBox1.SelectedIndex == 4)
            {
                textBox1.Text = "Beylikdüzü Sondurak - Hadimköy - Cumhuriyet Mah. - Beylikdüzü Belediye - BeylikdüzÜ - Güzelyurt -Haramidere - Haramidere Sanayi - Saadetdere Mah. - Mustafa Kemal Pasa - Cihangir/Universite mah.- Avcilar Kampüs - Sükrübey - IBB Sosyal Tesisler - Kügükçekmece - Cennet Mah. - Florya - Besyol -Sefaköy - Yenibosna -Sirinevler - Bahcelievler - Incirli - Zevtinburnu - Merter - Cevizlibaē";
            }
            if (comboBox1.SelectedIndex == 5)
            {
                textBox1.Text = "Bevlikdüzü Sondurak-Hadumköy-Cumburivet Mah.- BexlikduzU Beledive - Bevlikdüzü -Güzelyurt Haramidere - Haramidere Sanayi- Saadetdere Mah. - Mustafa Kemal Pasa - Cihangir/Universite mah.-Avcilar Kampüs-Sukrübex.-JBB Sosyal Tesisler - Kücüksekmese - Cennet Mah. - Florya-Besvol-Sefaköx-Yenibosna - Sirinever - Bahseliever-Incirli - Zeytinkurnu - Merter - Cevizliba&-TopkaRL-Bayrampasa (Maltepe) -Edirnekap:- Ayyansaray-Halicioglu - Okmeydani- Dardlaceze - Okmeydani Hastane -Caslavan-Mecidiyeköy-Zincirlikuyu - Bogazisi KoRrüsi - Burhaniye - Altunizade.-Acibadem - Uzuncavir - Fikirtene -Sogutlücesme";
            }
            if (comboBox1.SelectedIndex == 6)
            {
                textBox1.Text = "Zincirlikuyu - Bogaziçi KöpÜs - Burhaniye - Altunizade - Acibadem - Uzuncavit. - Fikirtepe -Sogutlücesme";
            }
        }
    }
}
