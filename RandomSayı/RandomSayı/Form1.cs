using System.Reflection.Emit;

namespace RandomSayı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random sayıüret = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            int a = sayıüret.Next(1, 7);
            int b = sayıüret.Next(1, 7);

            label1.Text = a.ToString();
            label2.Text = b.ToString();
        }
    }
}
