namespace SaatDakikaMod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayý;
            int saat, dakika;

            sayý = Convert.ToInt32(textBox1.Text);
            saat = sayý / 60;
            label3.Text=saat.ToString();

            dakika = sayý % 60;
            label5.Text = dakika.ToString();
        }
    }
}
