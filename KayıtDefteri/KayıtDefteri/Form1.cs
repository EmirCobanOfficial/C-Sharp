namespace KayıtDefteri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = textBox1.Text;
            label5.Text = textBox2.Text;
            label8.Text=comboBox1.Text;
            label11.Text = textBox3.Text;
            label13.Text = textBox4.Text;
        }
    }
}
