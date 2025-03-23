using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace MailGönderme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mailgönderme_Click(object sender, EventArgs e)
        {

            //// KODU ÇALIŞTIRAMADIM :( NEDENİNİ BİLMİYORUM ÇOK ARAŞTIRDIM OLMADI.
            MailMessage mymessage = new MailMessage();
            SmtpClient client = new SmtpClient();

            client.Credentials = new System.Net.NetworkCredential("emircobanoffical3@gmail.com", "emirka114@@");

            // Gmail SMTP ayarları 
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;

            // Mail bilgileri
            mymessage.To.Add(textBox1.Text);
            mymessage.From = new MailAddress("emircobanoffical3@gmail.com");
            mymessage.Subject = textBox2.Text;
            mymessage.Body = textBox3.Text;
            client.Send(mymessage);
        }
    }
}