using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULADORA_CIRCULO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double r = Convert.ToDouble(txtRaio.Text);
            if (rbArea.Checked) // é TRUE?
            {
                double a = Math.PI * Math.Pow(r, 2);
                lbResposta.Text = "Area = " + a.ToString("N4");
            }

            if (rbPerimetro.Checked)
            {
                double p = 2 * Math.PI * r;
                lbResposta.Text = "Perimetro = " + p.ToString("N4");
            }
            if (rbVolume.Checked)
            {
                double v = 4f/3f * Math.PI * Math.Pow(r, 3);
                lbResposta.Text = "Volume = " + v.ToString("N4");
            }

            if (cbDesenhar.Checked)
            {
                DesenharCirculo();
            }

        }

        private void DesenharCirculo()
        {
            Graphics g = pnCenter.CreateGraphics();
            Pen p = new Pen(Color.Black, 2);
            g.Clear(Color.White);
            int diametro = Convert.ToInt32(txtRaio.Text) * 2;
            int cx = pnCenter.Width / 2;
            int cy = pnCenter.Height / 2;
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            g.DrawEllipse(p, cx - diametro / 2,
                cy - diametro / 2, diametro, diametro);
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            p.Color = Color.Red;

            SolidBrush corSolida = new SolidBrush(Color.Red);
            corSolida.Color = colorDialog1.Color;
            g.FillEllipse(corSolida, cx - diametro / 2,
               cy - diametro / 2, diametro, diametro);

            g.DrawLine(p, 0, cy, pnCenter.Width, cy);
            g.DrawLine(p, cx, 0, cx, pnCenter.Height);

            corSolida.Color = Color.Green;
            g.DrawString("D = " + diametro, new Font("Arial", 16),
                corSolida, cx, cy);

        }

        private void btnCor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            btnCalcular_Click(sender, e);
        }

    }
}
