namespace Forca
{
    partial class Game
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.pnLetra = new System.Windows.Forms.Panel();
            this.btnJogar = new System.Windows.Forms.Button();
            this.txtLetra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDica = new System.Windows.Forms.Label();
            this.pnPalavra = new System.Windows.Forms.Panel();
            this.pbForca = new System.Windows.Forms.PictureBox();
            this.pbMorcego = new System.Windows.Forms.PictureBox();
            this.pbFantasma = new System.Windows.Forms.PictureBox();
            this.pbCoruja = new System.Windows.Forms.PictureBox();
            this.pbAbobora = new System.Windows.Forms.PictureBox();
            this.pbGato = new System.Windows.Forms.PictureBox();
            this.pbBoneco = new System.Windows.Forms.PictureBox();
            this.lbLetras = new System.Windows.Forms.Label();
            this.lbRelogio = new System.Windows.Forms.Label();
            this.cronometro = new System.Windows.Forms.Timer(this.components);
            this.btnNovoJogo = new System.Windows.Forms.Button();
            this.pnLetra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbForca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMorcego)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFantasma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoruja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAbobora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoneco)).BeginInit();
            this.SuspendLayout();
            // 
            // pnLetra
            // 
            this.pnLetra.BackColor = System.Drawing.Color.Transparent;
            this.pnLetra.Controls.Add(this.btnJogar);
            this.pnLetra.Controls.Add(this.txtLetra);
            this.pnLetra.Controls.Add(this.label1);
            this.pnLetra.Location = new System.Drawing.Point(24, 58);
            this.pnLetra.Name = "pnLetra";
            this.pnLetra.Size = new System.Drawing.Size(211, 257);
            this.pnLetra.TabIndex = 0;
            // 
            // btnJogar
            // 
            this.btnJogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJogar.ForeColor = System.Drawing.Color.Orange;
            this.btnJogar.Location = new System.Drawing.Point(30, 166);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(152, 78);
            this.btnJogar.TabIndex = 2;
            this.btnJogar.Text = "JOGAR";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // txtLetra
            // 
            this.txtLetra.BackColor = System.Drawing.Color.Black;
            this.txtLetra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLetra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLetra.Font = new System.Drawing.Font("Snap ITC", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLetra.ForeColor = System.Drawing.Color.Orange;
            this.txtLetra.Location = new System.Drawing.Point(30, 81);
            this.txtLetra.MaxLength = 1;
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.Size = new System.Drawing.Size(152, 55);
            this.txtLetra.TabIndex = 1;
            this.txtLetra.Text = "A";
            this.txtLetra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLetra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLetra_KeyPress);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "LETRA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDica
            // 
            this.lbDica.BackColor = System.Drawing.Color.Transparent;
            this.lbDica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDica.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDica.Location = new System.Drawing.Point(244, 58);
            this.lbDica.Name = "lbDica";
            this.lbDica.Size = new System.Drawing.Size(842, 43);
            this.lbDica.TabIndex = 1;
            this.lbDica.Text = "DICA DA PALAVRA";
            this.lbDica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnPalavra
            // 
            this.pnPalavra.BackColor = System.Drawing.Color.Transparent;
            this.pnPalavra.Location = new System.Drawing.Point(244, 104);
            this.pnPalavra.Name = "pnPalavra";
            this.pnPalavra.Size = new System.Drawing.Size(842, 211);
            this.pnPalavra.TabIndex = 2;
            // 
            // pbForca
            // 
            this.pbForca.BackColor = System.Drawing.Color.Transparent;
            this.pbForca.Image = ((System.Drawing.Image)(resources.GetObject("pbForca.Image")));
            this.pbForca.Location = new System.Drawing.Point(24, 342);
            this.pbForca.Name = "pbForca";
            this.pbForca.Size = new System.Drawing.Size(211, 322);
            this.pbForca.TabIndex = 3;
            this.pbForca.TabStop = false;
            // 
            // pbMorcego
            // 
            this.pbMorcego.BackColor = System.Drawing.Color.Transparent;
            this.pbMorcego.Image = ((System.Drawing.Image)(resources.GetObject("pbMorcego.Image")));
            this.pbMorcego.Location = new System.Drawing.Point(263, 342);
            this.pbMorcego.Name = "pbMorcego";
            this.pbMorcego.Size = new System.Drawing.Size(105, 75);
            this.pbMorcego.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMorcego.TabIndex = 4;
            this.pbMorcego.TabStop = false;
            // 
            // pbFantasma
            // 
            this.pbFantasma.BackColor = System.Drawing.Color.Transparent;
            this.pbFantasma.Image = ((System.Drawing.Image)(resources.GetObject("pbFantasma.Image")));
            this.pbFantasma.Location = new System.Drawing.Point(642, 431);
            this.pbFantasma.Name = "pbFantasma";
            this.pbFantasma.Size = new System.Drawing.Size(143, 134);
            this.pbFantasma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFantasma.TabIndex = 5;
            this.pbFantasma.TabStop = false;
            // 
            // pbCoruja
            // 
            this.pbCoruja.BackColor = System.Drawing.Color.Transparent;
            this.pbCoruja.Image = ((System.Drawing.Image)(resources.GetObject("pbCoruja.Image")));
            this.pbCoruja.Location = new System.Drawing.Point(570, 278);
            this.pbCoruja.Name = "pbCoruja";
            this.pbCoruja.Size = new System.Drawing.Size(100, 88);
            this.pbCoruja.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCoruja.TabIndex = 6;
            this.pbCoruja.TabStop = false;
            // 
            // pbAbobora
            // 
            this.pbAbobora.BackColor = System.Drawing.Color.Transparent;
            this.pbAbobora.Image = ((System.Drawing.Image)(resources.GetObject("pbAbobora.Image")));
            this.pbAbobora.Location = new System.Drawing.Point(893, 525);
            this.pbAbobora.Name = "pbAbobora";
            this.pbAbobora.Size = new System.Drawing.Size(182, 125);
            this.pbAbobora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAbobora.TabIndex = 7;
            this.pbAbobora.TabStop = false;
            // 
            // pbGato
            // 
            this.pbGato.BackColor = System.Drawing.Color.Transparent;
            this.pbGato.Image = ((System.Drawing.Image)(resources.GetObject("pbGato.Image")));
            this.pbGato.Location = new System.Drawing.Point(856, 396);
            this.pbGato.Name = "pbGato";
            this.pbGato.Size = new System.Drawing.Size(100, 86);
            this.pbGato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGato.TabIndex = 8;
            this.pbGato.TabStop = false;
            // 
            // pbBoneco
            // 
            this.pbBoneco.BackColor = System.Drawing.Color.Transparent;
            this.pbBoneco.Location = new System.Drawing.Point(146, 382);
            this.pbBoneco.Name = "pbBoneco";
            this.pbBoneco.Size = new System.Drawing.Size(138, 222);
            this.pbBoneco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBoneco.TabIndex = 9;
            this.pbBoneco.TabStop = false;
            // 
            // lbLetras
            // 
            this.lbLetras.BackColor = System.Drawing.Color.Transparent;
            this.lbLetras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbLetras.Location = new System.Drawing.Point(676, 318);
            this.lbLetras.Name = "lbLetras";
            this.lbLetras.Size = new System.Drawing.Size(410, 48);
            this.lbLetras.TabIndex = 10;
            this.lbLetras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbRelogio
            // 
            this.lbRelogio.BackColor = System.Drawing.Color.Transparent;
            this.lbRelogio.Font = new System.Drawing.Font("BubbleGum", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRelogio.Location = new System.Drawing.Point(372, 451);
            this.lbRelogio.Name = "lbRelogio";
            this.lbRelogio.Size = new System.Drawing.Size(171, 65);
            this.lbRelogio.TabIndex = 11;
            this.lbRelogio.Text = "120";
            this.lbRelogio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cronometro
            // 
            this.cronometro.Enabled = true;
            this.cronometro.Interval = 1000;
            this.cronometro.Tick += new System.EventHandler(this.cronometro_Tick);
            // 
            // btnNovoJogo
            // 
            this.btnNovoJogo.BackColor = System.Drawing.Color.Transparent;
            this.btnNovoJogo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.btnNovoJogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoJogo.Location = new System.Drawing.Point(642, 594);
            this.btnNovoJogo.Name = "btnNovoJogo";
            this.btnNovoJogo.Size = new System.Drawing.Size(143, 70);
            this.btnNovoJogo.TabIndex = 12;
            this.btnNovoJogo.Text = "Novo Jogo";
            this.btnNovoJogo.UseVisualStyleBackColor = false;
            this.btnNovoJogo.Click += new System.EventHandler(this.btnNovoJogo_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1098, 676);
            this.Controls.Add(this.btnNovoJogo);
            this.Controls.Add(this.lbRelogio);
            this.Controls.Add(this.lbLetras);
            this.Controls.Add(this.pbBoneco);
            this.Controls.Add(this.pbGato);
            this.Controls.Add(this.pbAbobora);
            this.Controls.Add(this.pbCoruja);
            this.Controls.Add(this.pbFantasma);
            this.Controls.Add(this.pbMorcego);
            this.Controls.Add(this.pbForca);
            this.Controls.Add(this.pnPalavra);
            this.Controls.Add(this.lbDica);
            this.Controls.Add(this.pnLetra);
            this.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Orange;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.MaximizeBox = false;
            this.Name = "Game";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JOGO DA FORCA";
            this.Load += new System.EventHandler(this.Game_Load);
            this.pnLetra.ResumeLayout(false);
            this.pnLetra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbForca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMorcego)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFantasma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoruja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAbobora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoneco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLetra;
        private System.Windows.Forms.TextBox txtLetra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Label lbDica;
        private System.Windows.Forms.Panel pnPalavra;
        private System.Windows.Forms.PictureBox pbForca;
        private System.Windows.Forms.PictureBox pbMorcego;
        private System.Windows.Forms.PictureBox pbFantasma;
        private System.Windows.Forms.PictureBox pbCoruja;
        private System.Windows.Forms.PictureBox pbAbobora;
        private System.Windows.Forms.PictureBox pbGato;
        private System.Windows.Forms.PictureBox pbBoneco;
        private System.Windows.Forms.Label lbLetras;
        private System.Windows.Forms.Label lbRelogio;
        private System.Windows.Forms.Timer cronometro;
        private System.Windows.Forms.Button btnNovoJogo;
    }
}

