namespace HesapMakinesiDouble
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2;

            double toplam, fark, çarpým, bölme;

            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);

            toplam = sayi1+ sayi2;
            fark = sayi1 - sayi2;
            çarpým = sayi1 * sayi2;
            bölme = sayi1 / sayi2;

            label7.Text=toplam.ToString();
            label8.Text=fark.ToString();
            label9.Text=çarpým.ToString();
            label10.Text=bölme.ToString();

        }
    }
}
