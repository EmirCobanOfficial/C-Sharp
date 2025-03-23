namespace SayaçTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.Second.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.Minute.ToString();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label3.Text= DateTime.Now.Hour.ToString();
        }
    }
}
