namespace MEDIA
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnMediaNumerica = new System.Windows.Forms.Button();
            this.btnMediaGeometrica = new System.Windows.Forms.Button();
            this.lbResposta = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(53, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite um número A:";
            // 
            // txtA
            // 
            this.txtA.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtA.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.ForeColor = System.Drawing.SystemColors.Window;
            this.txtA.Location = new System.Drawing.Point(58, 114);
            this.txtA.MaxLength = 10;
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(253, 33);
            this.txtA.TabIndex = 1;
            this.txtA.Text = "0";
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_KeyPress);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(58, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Digite um número B:";
            // 
            // txtB
            // 
            this.txtB.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtB.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.ForeColor = System.Drawing.SystemColors.Window;
            this.txtB.Location = new System.Drawing.Point(63, 230);
            this.txtB.MaxLength = 10;
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(249, 33);
            this.txtB.TabIndex = 2;
            this.txtB.Text = "0";
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtB_KeyPress);
            // 
            // btnMediaNumerica
            // 
            this.btnMediaNumerica.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMediaNumerica.FlatAppearance.BorderSize = 0;
            this.btnMediaNumerica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMediaNumerica.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMediaNumerica.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMediaNumerica.Image = ((System.Drawing.Image)(resources.GetObject("btnMediaNumerica.Image")));
            this.btnMediaNumerica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMediaNumerica.Location = new System.Drawing.Point(12, 326);
            this.btnMediaNumerica.Name = "btnMediaNumerica";
            this.btnMediaNumerica.Size = new System.Drawing.Size(351, 62);
            this.btnMediaNumerica.TabIndex = 3;
            this.btnMediaNumerica.Text = "Média Numérica";
            this.btnMediaNumerica.UseVisualStyleBackColor = true;
            this.btnMediaNumerica.Click += new System.EventHandler(this.btnMediaNumerica_Click);
            // 
            // btnMediaGeometrica
            // 
            this.btnMediaGeometrica.FlatAppearance.BorderSize = 0;
            this.btnMediaGeometrica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMediaGeometrica.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMediaGeometrica.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMediaGeometrica.Image = ((System.Drawing.Image)(resources.GetObject("btnMediaGeometrica.Image")));
            this.btnMediaGeometrica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMediaGeometrica.Location = new System.Drawing.Point(12, 394);
            this.btnMediaGeometrica.Name = "btnMediaGeometrica";
            this.btnMediaGeometrica.Size = new System.Drawing.Size(351, 65);
            this.btnMediaGeometrica.TabIndex = 4;
            this.btnMediaGeometrica.Text = "Média Geométrica";
            this.btnMediaGeometrica.UseVisualStyleBackColor = true;
            this.btnMediaGeometrica.Click += new System.EventHandler(this.btnMediaGeometrica_Click);
            // 
            // lbResposta
            // 
            this.lbResposta.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lbResposta.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResposta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbResposta.Image = ((System.Drawing.Image)(resources.GetObject("lbResposta.Image")));
            this.lbResposta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbResposta.Location = new System.Drawing.Point(12, 477);
            this.lbResposta.Name = "lbResposta";
            this.lbResposta.Size = new System.Drawing.Size(351, 97);
            this.lbResposta.TabIndex = 5;
            this.lbResposta.Text = "0";
            this.lbResposta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFechar
            // 
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFechar.Location = new System.Drawing.Point(12, 589);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(351, 70);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.Text = "Sair da Aplicação";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(375, 671);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lbResposta);
            this.Controls.Add(this.btnMediaGeometrica);
            this.Controls.Add(this.btnMediaNumerica);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALCULADORA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnMediaNumerica;
        private System.Windows.Forms.Button btnMediaGeometrica;
        private System.Windows.Forms.Label lbResposta;
        private System.Windows.Forms.Button btnFechar;
    }
}

