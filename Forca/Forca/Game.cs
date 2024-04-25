using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;

namespace Forca
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        Forca Jogo;

        string[] Lista;
        string[] Dicas;

        List<Label> Letras;
        SoundPlayer fundoMusical;
        WaveOutEvent SomGrito = new WaveOutEvent();

        int Erros = 0;

        private void Game_Load(object sender, EventArgs e)
        {
            CarregarLista();
            Jogo = new Forca(Lista, Dicas);
            NovoJogo();
            TocarMusica();
        }

        private void CarregarLista()
        {
            string arquivo = "lista.txt";
            if (!File.Exists(arquivo))
            {
                MessageBox.Show("Lista não encontrada");
                Environment.Exit(0);
            }

            string[] Linhas = File.ReadAllLines(arquivo);
            Dicas = new string[Linhas.Count()];
            Lista = new string[Linhas.Count()];
            int i = 0;

            foreach (string linha in Linhas)
            {
                if (linha.Equals("")) continue;
                string[] campos = linha.Split(',');
                Lista[i] = campos[0];
                Dicas[i] = campos[1];
                i++;
            }
        }

        private void TocarMusica()
        {
            fundoMusical = new SoundPlayer();
            fundoMusical.SoundLocation = "fundo.wav";

            try
            {
                fundoMusical.PlayLooping();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro:" + Erro.Message);
            }
        }

        private void NovoJogo()
        {
            pnPalavra.Controls.Clear();
            Jogo.Sortear();
            lbDica.Text = Jogo.Dicas[Jogo.Pos].ToUpper();
            DesenharPalavra(Jogo.Palavras[Jogo.Pos]);
            Erros = 0;
            pbBoneco.Image = null;
            lbLetras.Text = String.Empty;
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            string letra = txtLetra.Text;
            ProcurarLetra(letra);
            txtLetra.Clear();
            txtLetra.Focus();
        }

        private void DesenharPalavra(string p)
        {
            Letras = new List<Label>(); // cria lista vazia
            int cx = 10, cy = 10;
            for (int i = 0; i < p.Length; i++)
            {
                Label letra = new Label();
                letra.Text = "?";
                letra.Width = 60;
                letra.Height = 60;
                letra.AutoSize = false;
                letra.BorderStyle = BorderStyle.FixedSingle;
                letra.TextAlign = ContentAlignment.MiddleCenter;
                letra.ForeColor = Color.Orange;
                letra.BackColor = Color.Transparent;
                if (i % 10 == 0 && i != 0)
                {
                    cy += 65;
                    cx = 10;
                }
                letra.Top = cy;
                letra.Left = cx;
                cx += 65;
                Letras.Add(letra);
                pnPalavra.Controls.Add(letra);
            }

        }



        private void ProcurarLetra(string letra)
        {
            string p = Jogo.Palavras[Jogo.Pos];
            bool achou = false;

            if (letra.Equals("") || letra.Equals(" ")) return;
            if (Char.IsNumber(Convert.ToChar(letra))) return;
            if (lbLetras.Text.Contains(letra))
            {
                MessageBox.Show("Letra já digitada");
                return;
            }

            lbLetras.Text += letra + " ";
            for (int i = 0; i < p.Length; i++)
            {
                if (p.Substring(i, 1).Equals(letra))
                {
                    Letras[i].Text = letra;
                    Letras[i].BackColor = Color.Transparent;
                    Letras[i].ForeColor = Color.FromArgb(251, 139, 35);
                    Letras[i].BorderStyle = BorderStyle.None;
                    achou = true;
                }
            }
            if (achou == false) DesenharBoneco();
            if (Erros == 6) Derrota();
            Vitoria();
        }

        private void Vitoria()
        {
            string tmp = "";
            foreach (Label item in Letras) {
                tmp += item.Text;
            }
            string p = Jogo.Palavras[Jogo.Pos];
            if (tmp.Equals(p))
            {
                cronometro.Stop();
                MessageBox.Show("Você venceu!!!!");
                NovoJogo();
                lbRelogio.Text = "120";
                cronometro.Start();

            }
        }

        private void Derrota()
        {
            string p = Jogo.Palavras[Jogo.Pos];
            cronometro.Stop();
            MessageBox.Show("Que pena. A palavra era " + p,
                "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            NovoJogo();
            lbRelogio.Text = "120";
            cronometro.Start();
        }

        private void DesenharBoneco()
        {
            Erros++;
            string local = "forca" + Erros.ToString() + ".png";
            if (Erros < 7)
            {
                if (File.Exists(local))
                {
                    pbBoneco.Image = Image.FromFile(local);
                }
                else MessageBox.Show("Erro ao carregar imagem");
            }

            Gritar();
        }

        private void Gritar()
        {
            string SomFile = "grito.wav";
            AudioFileReader som = new AudioFileReader(SomFile);
            SomGrito.Init(som);
            SomGrito.Play();

        }

        private void txtLetra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                btnJogar_Click(sender, e);
            }
        }

        private void cronometro_Tick(object sender, EventArgs e)
        {
            int seg = Convert.ToInt16(lbRelogio.Text);
            seg--;
            lbRelogio.Text = seg.ToString().PadLeft(3, '0');
            if (seg == 0)
            {
                cronometro.Stop();
                lbRelogio.Text = "120";
                MessageBox.Show("Tempo esgotado. A palavra era " + Jogo.Palavras[Jogo.Pos]);
                NovoJogo();
                cronometro.Start();
            }
        }

        private void btnNovoJogo_Click(object sender, EventArgs e)
        {
            lbRelogio.Text = "120";
            NovoJogo();
        }
    }
}
