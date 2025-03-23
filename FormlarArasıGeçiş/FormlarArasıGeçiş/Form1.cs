using System.Diagnostics.Eventing.Reader;

namespace FormlarArasıGeçiş
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "1234")
            {
                Form2 yeni = new Form2();
                yeni.Show();
                this.Hide();
            }
            else
            {
                label3.Text = "Sifre veya kullanıcı adı yanlış";
                MessageBox.Show("Sifre veya kullanıcı adı yanlış");
            }
        }
    }
}
