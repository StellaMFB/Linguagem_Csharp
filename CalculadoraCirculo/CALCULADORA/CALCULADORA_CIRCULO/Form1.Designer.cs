namespace CALCULADORA_CIRCULO
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnTop = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbVolume = new System.Windows.Forms.RadioButton();
            this.rbPerimetro = new System.Windows.Forms.RadioButton();
            this.rbArea = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtRaio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnBotom = new System.Windows.Forms.Panel();
            this.cbDesenhar = new System.Windows.Forms.CheckBox();
            this.lbResposta = new System.Windows.Forms.Label();
            this.pnCenter = new System.Windows.Forms.Panel();
            this.btnCor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pnTop.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnBotom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.pnTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnTop.Controls.Add(this.groupBox1);
            this.pnTop.Controls.Add(this.btnCalcular);
            this.pnTop.Controls.Add(this.txtRaio);
            this.pnTop.Controls.Add(this.label1);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(18, 16);
            this.pnTop.Name = "pnTop";
            this.pnTop.Padding = new System.Windows.Forms.Padding(10);
            this.pnTop.Size = new System.Drawing.Size(725, 263);
            this.pnTop.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbVolume);
            this.groupBox1.Controls.Add(this.rbPerimetro);
            this.groupBox1.Controls.Add(this.rbArea);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(302, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 241);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculos:";
            // 
            // rbVolume
            // 
            this.rbVolume.AutoSize = true;
            this.rbVolume.Location = new System.Drawing.Point(32, 181);
            this.rbVolume.Name = "rbVolume";
            this.rbVolume.Size = new System.Drawing.Size(180, 22);
            this.rbVolume.TabIndex = 2;
            this.rbVolume.Text = "Volume da Esfera";
            this.rbVolume.UseVisualStyleBackColor = true;
            // 
            // rbPerimetro
            // 
            this.rbPerimetro.AutoSize = true;
            this.rbPerimetro.Location = new System.Drawing.Point(32, 109);
            this.rbPerimetro.Name = "rbPerimetro";
            this.rbPerimetro.Size = new System.Drawing.Size(205, 22);
            this.rbPerimetro.TabIndex = 1;
            this.rbPerimetro.Text = "Perímetro do Circulo";
            this.rbPerimetro.UseVisualStyleBackColor = true;
            // 
            // rbArea
            // 
            this.rbArea.AutoSize = true;
            this.rbArea.Checked = true;
            this.rbArea.Location = new System.Drawing.Point(32, 45);
            this.rbArea.Name = "rbArea";
            this.rbArea.Size = new System.Drawing.Size(159, 22);
            this.rbArea.TabIndex = 0;
            this.rbArea.TabStop = true;
            this.rbArea.Text = "Área do Círculo";
            this.rbArea.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
            this.btnCalcular.Location = new System.Drawing.Point(13, 101);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(272, 150);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtRaio
            // 
            this.txtRaio.Location = new System.Drawing.Point(13, 55);
            this.txtRaio.Name = "txtRaio";
            this.txtRaio.Size = new System.Drawing.Size(272, 27);
            this.txtRaio.TabIndex = 1;
            this.txtRaio.Text = "0";
            this.txtRaio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o Raio do Circulo:";
            // 
            // pnBotom
            // 
            this.pnBotom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.pnBotom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnBotom.Controls.Add(this.btnCor);
            this.pnBotom.Controls.Add(this.cbDesenhar);
            this.pnBotom.Controls.Add(this.lbResposta);
            this.pnBotom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBotom.Location = new System.Drawing.Point(18, 570);
            this.pnBotom.Name = "pnBotom";
            this.pnBotom.Size = new System.Drawing.Size(725, 157);
            this.pnBotom.TabIndex = 1;
            // 
            // cbDesenhar
            // 
            this.cbDesenhar.AutoSize = true;
            this.cbDesenhar.Location = new System.Drawing.Point(13, 109);
            this.cbDesenhar.Name = "cbDesenhar";
            this.cbDesenhar.Size = new System.Drawing.Size(176, 22);
            this.cbDesenhar.TabIndex = 1;
            this.cbDesenhar.Text = "Desenhar Círculo";
            this.cbDesenhar.UseVisualStyleBackColor = true;
            // 
            // lbResposta
            // 
            this.lbResposta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbResposta.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbResposta.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResposta.Image = ((System.Drawing.Image)(resources.GetObject("lbResposta.Image")));
            this.lbResposta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbResposta.Location = new System.Drawing.Point(0, 0);
            this.lbResposta.Name = "lbResposta";
            this.lbResposta.Size = new System.Drawing.Size(723, 87);
            this.lbResposta.TabIndex = 0;
            this.lbResposta.Text = "Calculo = 0";
            this.lbResposta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnCenter
            // 
            this.pnCenter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnCenter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCenter.Location = new System.Drawing.Point(18, 279);
            this.pnCenter.Name = "pnCenter";
            this.pnCenter.Size = new System.Drawing.Size(725, 291);
            this.pnCenter.TabIndex = 2;
            // 
            // btnCor
            // 
            this.btnCor.ForeColor = System.Drawing.Color.Black;
            this.btnCor.Location = new System.Drawing.Point(517, 99);
            this.btnCor.Name = "btnCor";
            this.btnCor.Size = new System.Drawing.Size(152, 41);
            this.btnCor.TabIndex = 2;
            this.btnCor.Text = "CORES...";
            this.btnCor.UseVisualStyleBackColor = true;
            this.btnCor.Click += new System.EventHandler(this.btnCor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(761, 743);
            this.Controls.Add(this.pnCenter);
            this.Controls.Add(this.pnBotom);
            this.Controls.Add(this.pnTop);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(18, 16, 18, 16);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALCULADORA CIRCULO";
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnBotom.ResumeLayout(false);
            this.pnBotom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbVolume;
        private System.Windows.Forms.RadioButton rbPerimetro;
        private System.Windows.Forms.RadioButton rbArea;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtRaio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnBotom;
        private System.Windows.Forms.CheckBox cbDesenhar;
        private System.Windows.Forms.Label lbResposta;
        private System.Windows.Forms.Panel pnCenter;
        private System.Windows.Forms.Button btnCor;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

