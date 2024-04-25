using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class CALCULADORA : Form
    {
        public CALCULADORA()
        {
            InitializeComponent();
        }

        private void btvCalcular_Click(object sender, EventArgs e)
        {
            double r = Convert.ToDouble(txtRaio.Text);
            if (rbArea.Checked)
            {
                double a = Math.PI * Math.Pow(r, 2);
                lbResposta.Text = "Área = " + a.ToString("N4");
            }

            if (rbPerimetro.Checked)
            {
                double p = 2 * Math.PI * r;
                lbResposta.Text = "Perímetro = " + p.ToString("N4");
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

            g.DrawEllipse(p, cx, cy, diametro, diametro);
        }
    }
}
