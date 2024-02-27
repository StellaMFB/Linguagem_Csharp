using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEDIA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnMediaNumerica_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(txtA.Text);
                double b = Convert.ToDouble(txtB.Text);
                double m = (a + b) / 2;
                lbResposta.Text = "Média Numérica = " + m.ToString("N3");
            }
            catch (Exception)
            {
                lbResposta.Text = "Valor inválido!";
            }
        }

        private void btnMediaGeometrica_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(txtA.Text);
                double b = Convert.ToDouble(txtB.Text);
                double m = Math.Sqrt(a * b);
                lbResposta.Text = "Média Geométrica = " + m.ToString("N3");
            }
            catch (Exception)
            {
                lbResposta.Text = "Valor inválido!";
            }
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == ',' || e.KeyChar == '.') && string.IsNullOrEmpty(txtA.Text))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            if (!(e.KeyChar == ',' || e.KeyChar == '.' || Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' && txtA.Text.Contains(',') || e.KeyChar == '.' && txtA.Text.Contains('.') || e.KeyChar == '.' && txtA.Text.Contains(','))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                txtA.Clear();
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtB.Focus();
            }
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == ',' || e.KeyChar == '.') && string.IsNullOrEmpty(txtB.Text))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            if (!(e.KeyChar == ',' || e.KeyChar == '.' || Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' && txtB.Text.Contains(',') || e.KeyChar == '.' && txtB.Text.Contains('.') || e.KeyChar == '.' && txtB.Text.Contains(','))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                txtB.Clear();
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnMediaNumerica_Click(sender, e);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
