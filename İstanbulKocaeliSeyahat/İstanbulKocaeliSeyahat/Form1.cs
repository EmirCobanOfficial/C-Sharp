namespace İstanbulKocaeliSeyahat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1" && textBox2.Text == "2")
            {
                Form3 seyahat = new Form3();
                seyahat.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adını veya şifreyi yanlış girdiniz");
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
            this.Hide();
        }
    }
}
