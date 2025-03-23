namespace For_Döngü_Örnekleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int j = 10; j <= 20; j++)
            {
                listBox1.Items.Add(j);
            }
        }
    }
}
