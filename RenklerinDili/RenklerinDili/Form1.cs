namespace RenklerinDili
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="yönetici" && textBox2.Text=="1234")
            {
                Form2 renkformu = new Form2();
                renkformu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanýcý adý veya parola yanlýþ");
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}
