using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sınav1C_
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Kenar uzunluklarını al ve decimal türüne dönüştür
                decimal kenar1 = Convert.ToDecimal(txtKenar1.Text);
                decimal kenar2 = Convert.ToDecimal(txtKenar2.Text);
                decimal kenar3 = Convert.ToDecimal(txtKenar3.Text);

                
                if (kenar1 + kenar2 > kenar3 && kenar1 + kenar3 > kenar2 && kenar2 + kenar3 > kenar1)
                {
                    
                    if (kenar1 == kenar2 && kenar2 == kenar3)
                    {
                        lblSonuc.Text = "Üçgen Türü: Eşkenar Üçgen";
                    }
                    else if (kenar1 == kenar2 || kenar1 == kenar3 || kenar2 == kenar3)
                    {
                        lblSonuc.Text = "Üçgen Türü: İkizkenar Üçgen";
                    }
                    else
                    {
                        lblSonuc.Text = "Üçgen Türü: Çeşitkenar Üçgen";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen geçerli kenar uzunlukları girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
            