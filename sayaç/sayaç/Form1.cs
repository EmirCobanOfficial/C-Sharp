namespace sayaç
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayı = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            sayı = sayı + 1;
            label1.Text = sayı.ToString();

        }
    }
}
