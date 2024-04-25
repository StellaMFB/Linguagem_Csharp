using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RELOGIO_ANALOGICO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap desenho;
        string arquivo = "fundo.jpg";
        Graphics relogio;

        int xseg, yseg, seg;

        int xmin, ymin, min;

        int xhora, yhora, hora;

        private void Form1_Load(object sender, EventArgs e)
        {
            desenho = new Bitmap(pbRelogio.Width, pbRelogio.Height);
            relogio = Graphics.FromImage(desenho);
            relogio.DrawImage(Image.FromFile(arquivo), 0, 0, pbRelogio.Width, pbRelogio.Height);
            pbRelogio.Image = desenho;
        }

        private void pulso_Tick(object sender, EventArgs e)
        {
            seg = DateTime.Now.Second;
            min = DateTime.Now.Minute;
            hora = DateTime.Now.Hour;

            relogio.DrawImage(Image.FromFile(arquivo),
              0, 0, pbRelogio.Width,
              pbRelogio.Height);

            DesenharPonteiroSegundo();
            DesenharPonteiroMinuto();
            DesenharPonteiroHora();
            DesenharCentroRelogio();

            Graphics g = pbRelogio.CreateGraphics();
            g.DrawImage(desenho, 0, 0);
        }

        private void DesenharCentroRelogio()
        {
            int cx = pbRelogio.Width / 2;
            int cy = pbRelogio.Height / 2;
            SolidBrush cor = new SolidBrush(Color.Black);
            relogio.FillEllipse(cor, cx - 20, cy - 20, 40, 40);
            Font fonte = new Font("Agent Red", 20);
            relogio.DrawString(DateTime.Now.ToLongTimeString(), fonte, cor, cx - 90, cy + 80);
        }

        private void DesenharPonteiroHora()
        {
            int cx = pbRelogio.Width / 2;
            int cy = pbRelogio.Height / 2;
            int raio = 100; // tamanho do ponteiro do horaundo ( raio do circulo)

            if (hora > 12) hora = hora - 12;

            int angulo = (hora * 30) - 90;
            Pen p = new Pen(Color.Transparent, 18);
            p.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            p.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            relogio.DrawLine(p, cx, cy, cx + xhora, cy + yhora);
            double rad = Math.PI * angulo / 180;
            xhora = (int)(raio * Math.Cos(rad));
            yhora = (int)(raio * Math.Sin(rad));
            p.Color = Color.Black;
            relogio.DrawLine(p, cx, cy, cx + xhora, cy + yhora);
        }

        private void DesenharPonteiroMinuto()
        {
            int cx = pbRelogio.Width / 2;
            int cy = pbRelogio.Height / 2;
            int raio = 200; // tamanho do ponteiro do minundo ( raio do circulo)
            int angulo = (min * 6) - 90;
            Pen p = new Pen(Color.Transparent, 16);
            p.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            p.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            relogio.DrawLine(p, cx, cy, cx + xmin, cy + ymin);
            double rad = Math.PI * angulo / 180;
            xmin = (int)(raio * Math.Cos(rad));
            ymin = (int)(raio * Math.Sin(rad));
            p.Color = Color.Black;
            relogio.DrawLine(p, cx, cy, cx + xmin, cy + ymin);
        }

        private void DesenharPonteiroSegundo()
        {
            int cx = pbRelogio.Width / 2;
            int cy = pbRelogio.Height / 2;
            int raio = 240; // tamanho do ponteiro do segundo ( raio do circulo)
            int angulo = (seg * 6) - 90;
            Pen p = new Pen(Color.Transparent, 8);
            p.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            relogio.DrawLine(p, cx, cy, cx + xseg, cy + yseg);
            double rad = Math.PI * angulo / 180;
            xseg = (int)(raio * Math.Cos(rad));
            yseg = (int)(raio * Math.Sin(rad));
            p.Color = Color.Red;
            relogio.DrawLine(p, cx, cy, cx + xseg, cy + yseg);
        }

        private void pbRelogio_Click(object sender, EventArgs e)
        {
            OpenFileDialog arquivo = new OpenFileDialog();
            pulso.Stop();
            arquivo.ShowDialog();
            if (File.Exists(arquivo.FileName))
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                File.Delete("fundo.jpg");
                File.Copy(arquivo.FileName, "fundo.jpg");
            }
            pulso.Start();
        }
    }
}
