namespace Sayısalİşlemler
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
            double üs;
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);

            üs = Math.Pow(sayi1, sayi2);
            label3.Text = üs.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sayi3;
            double karakök;

            sayi3 = Convert.ToDouble(textBox3.Text);

            karakök = Math.Sqrt(sayi3);
            label6.Text = karakök.ToString();
        }
    }
}
