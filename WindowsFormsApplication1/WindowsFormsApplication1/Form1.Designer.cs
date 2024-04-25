namespace WindowsFormsApplication1
{
    partial class CALCULADORA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CALCULADORA));
            this.pnTop = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbVolume = new System.Windows.Forms.RadioButton();
            this.rbPerimetro = new System.Windows.Forms.RadioButton();
            this.rbArea = new System.Windows.Forms.RadioButton();
            this.txtRaio = new System.Windows.Forms.TextBox();
            this.btvCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbDesenhar = new System.Windows.Forms.CheckBox();
            this.lbResposta = new System.Windows.Forms.Label();
            this.pnCenter = new System.Windows.Forms.Panel();
            this.pnTop.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnTop.Controls.Add(this.groupBox1);
            this.pnTop.Controls.Add(this.txtRaio);
            this.pnTop.Controls.Add(this.btvCalcular);
            this.pnTop.Controls.Add(this.label1);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.pnTop.Size = new System.Drawing.Size(655, 254);
            this.pnTop.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbVolume);
            this.groupBox1.Controls.Add(this.rbPerimetro);
            this.groupBox1.Controls.Add(this.rbArea);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(302, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Size = new System.Drawing.Size(341, 232);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cálculos:";
            // 
            // rbVolume
            // 
            this.rbVolume.AutoSize = true;
            this.rbVolume.Location = new System.Drawing.Point(25, 97);
            this.rbVolume.Name = "rbVolume";
            this.rbVolume.Size = new System.Drawing.Size(110, 27);
            this.rbVolume.TabIndex = 2;
            this.rbVolume.Text = "Volume";
            this.rbVolume.UseVisualStyleBackColor = true;
            // 
            // rbPerimetro
            // 
            this.rbPerimetro.AutoSize = true;
            this.rbPerimetro.Location = new System.Drawing.Point(25, 65);
            this.rbPerimetro.Name = "rbPerimetro";
            this.rbPerimetro.Size = new System.Drawing.Size(135, 27);
            this.rbPerimetro.TabIndex = 1;
            this.rbPerimetro.Text = "Perímetro";
            this.rbPerimetro.UseVisualStyleBackColor = true;
            // 
            // rbArea
            // 
            this.rbArea.AutoSize = true;
            this.rbArea.Checked = true;
            this.rbArea.Location = new System.Drawing.Point(25, 32);
            this.rbArea.Name = "rbArea";
            this.rbArea.Size = new System.Drawing.Size(78, 27);
            this.rbArea.TabIndex = 0;
            this.rbArea.TabStop = true;
            this.rbArea.Text = "Área";
            this.rbArea.UseVisualStyleBackColor = true;
            // 
            // txtRaio
            // 
            this.txtRaio.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRaio.Location = new System.Drawing.Point(15, 44);
            this.txtRaio.Name = "txtRaio";
            this.txtRaio.Size = new System.Drawing.Size(248, 31);
            this.txtRaio.TabIndex = 1;
            this.txtRaio.Text = "0";
            this.txtRaio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btvCalcular
            // 
            this.btvCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btvCalcular.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btvCalcular.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btvCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btvCalcular.Image")));
            this.btvCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btvCalcular.Location = new System.Drawing.Point(15, 94);
            this.btvCalcular.Name = "btvCalcular";
            this.btvCalcular.Size = new System.Drawing.Size(248, 136);
            this.btvCalcular.TabIndex = 2;
            this.btvCalcular.Text = "Calcular";
            this.btvCalcular.UseVisualStyleBackColor = true;
            this.btvCalcular.Click += new System.EventHandler(this.btvCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o raio do círculo:";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 580);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 10);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbDesenhar);
            this.panel2.Controls.Add(this.lbResposta);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 475);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.panel2.Size = new System.Drawing.Size(655, 105);
            this.panel2.TabIndex = 2;
            // 
            // cbDesenhar
            // 
            this.cbDesenhar.AutoSize = true;
            this.cbDesenhar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDesenhar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbDesenhar.Location = new System.Drawing.Point(12, 78);
            this.cbDesenhar.Name = "cbDesenhar";
            this.cbDesenhar.Size = new System.Drawing.Size(226, 29);
            this.cbDesenhar.TabIndex = 1;
            this.cbDesenhar.Text = "Desenhar círculo";
            this.cbDesenhar.UseVisualStyleBackColor = true;
            // 
            // lbResposta
            // 
            this.lbResposta.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResposta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbResposta.Image = ((System.Drawing.Image)(resources.GetObject("lbResposta.Image")));
            this.lbResposta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbResposta.Location = new System.Drawing.Point(12, 10);
            this.lbResposta.Name = "lbResposta";
            this.lbResposta.Size = new System.Drawing.Size(629, 65);
            this.lbResposta.TabIndex = 0;
            this.lbResposta.Text = "Cálculo = 0";
            this.lbResposta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnCenter
            // 
            this.pnCenter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCenter.Location = new System.Drawing.Point(0, 254);
            this.pnCenter.Name = "pnCenter";
            this.pnCenter.Size = new System.Drawing.Size(655, 221);
            this.pnCenter.TabIndex = 3;
            // 
            // CALCULADORA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(655, 590);
            this.Controls.Add(this.pnCenter);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CALCULADORA";
            this.Text = "CALCULADORA_CIRCULO";
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbVolume;
        private System.Windows.Forms.RadioButton rbPerimetro;
        private System.Windows.Forms.RadioButton rbArea;
        private System.Windows.Forms.TextBox txtRaio;
        private System.Windows.Forms.Button btvCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cbDesenhar;
        private System.Windows.Forms.Label lbResposta;
        private System.Windows.Forms.Panel pnCenter;
    }
}

