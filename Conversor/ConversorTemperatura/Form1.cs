using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorTemperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            if (rbFromC.Checked && rbToK.Checked) {
                double c = Convert.ToDouble(txtTemperatura.Text);
                double k = c + 273;
                lbResposta.Text = k.ToString("N2") + " Kelvin";
            }

            else if (rbFromK.Checked && rbToC.Checked)
            {
                double k = Convert.ToDouble(txtTemperatura.Text);
                double c = k - 273;
                lbResposta.Text = k.ToString("N2") + " Celsius";
            }

            else if (rbFromC.Checked && rbToF.Checked)
            {
                double c = Convert.ToDouble(txtTemperatura.Text);
                double f = 32 + (1.8) * c;
                lbResposta.Text = f.ToString("N2") + " Fahrenheit";
            }

            else if (rbFromF.Checked && rbToC.Checked)
            {
                double f = Convert.ToDouble(txtTemperatura.Text);
                double c = (f - 32) / 1.8;
                lbResposta.Text = c.ToString("N2") + " Celsius";
            }

            else if (rbFromK.Checked && rbToF.Checked)
            {
                double k = Convert.ToDouble(txtTemperatura.Text);
                double f = (k * 1.8) - 459.67;
                lbResposta.Text = f.ToString("N2") + " Farenheit";
            }

            else if (rbFromF.Checked && rbToK.Checked)
            {
                double f = Convert.ToDouble(txtTemperatura.Text);
                double k = (f + 459.67) * (5f / 9f);
                lbResposta.Text = k.ToString("N2") + " Kelvin";
            }

            else if (rbFromC.Checked && rbToC.Checked || rbFromF.Checked && rbToF.Checked || rbFromK.Checked && rbToK.Checked)
            {
                lbResposta.Text = "Conversão inválida";
            }
        }
    }
}
