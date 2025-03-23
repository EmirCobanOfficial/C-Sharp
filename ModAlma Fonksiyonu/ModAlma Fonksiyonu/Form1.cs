namespace ModAlma_Fonksiyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayý1;
            int sayi2, mod;

            sayý1 = 60 % 16;

            label1.Text = sayý1.ToString();

            sayi2 = Convert.ToInt32(label1.Text);
            mod = 100 % sayi2;

            label2.Text = mod.ToString();
        }
    }
}
