namespace ConversorTemperatura
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
            this.pnTop = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.lbTemperatura = new System.Windows.Forms.Label();
            this.gbEscala2 = new System.Windows.Forms.GroupBox();
            this.rbToK = new System.Windows.Forms.RadioButton();
            this.rbToF = new System.Windows.Forms.RadioButton();
            this.rbToC = new System.Windows.Forms.RadioButton();
            this.gbEscala1 = new System.Windows.Forms.GroupBox();
            this.rbFromK = new System.Windows.Forms.RadioButton();
            this.rbFromF = new System.Windows.Forms.RadioButton();
            this.rbFromC = new System.Windows.Forms.RadioButton();
            this.pnBottom = new System.Windows.Forms.Panel();
            this.lbResposta = new System.Windows.Forms.Label();
            this.pnTop.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbEscala2.SuspendLayout();
            this.gbEscala1.SuspendLayout();
            this.pnBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(151)))), ((int)(((byte)(177)))));
            this.pnTop.Controls.Add(this.groupBox1);
            this.pnTop.Controls.Add(this.gbEscala2);
            this.pnTop.Controls.Add(this.gbEscala1);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(15, 15);
            this.pnTop.Name = "pnTop";
            this.pnTop.Padding = new System.Windows.Forms.Padding(5);
            this.pnTop.Size = new System.Drawing.Size(879, 208);
            this.pnTop.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConverter);
            this.groupBox1.Controls.Add(this.txtTemperatura);
            this.groupBox1.Controls.Add(this.lbTemperatura);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(75)))));
            this.groupBox1.Location = new System.Drawing.Point(602, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnConverter
            // 
            this.btnConverter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(57)))), ((int)(((byte)(108)))));
            this.btnConverter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(57)))), ((int)(((byte)(108)))));
            this.btnConverter.FlatAppearance.BorderSize = 0;
            this.btnConverter.ForeColor = System.Drawing.SystemColors.Window;
            this.btnConverter.Location = new System.Drawing.Point(51, 127);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(147, 38);
            this.btnConverter.TabIndex = 2;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = false;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(57)))), ((int)(((byte)(108)))));
            this.txtTemperatura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTemperatura.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemperatura.ForeColor = System.Drawing.Color.White;
            this.txtTemperatura.Location = new System.Drawing.Point(21, 74);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(210, 36);
            this.txtTemperatura.TabIndex = 1;
            this.txtTemperatura.Text = "0";
            this.txtTemperatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbTemperatura
            // 
            this.lbTemperatura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(57)))), ((int)(((byte)(108)))));
            this.lbTemperatura.ForeColor = System.Drawing.Color.White;
            this.lbTemperatura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbTemperatura.Location = new System.Drawing.Point(21, 29);
            this.lbTemperatura.Name = "lbTemperatura";
            this.lbTemperatura.Size = new System.Drawing.Size(210, 46);
            this.lbTemperatura.TabIndex = 0;
            this.lbTemperatura.Text = "TEMPERATURA";
            this.lbTemperatura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbEscala2
            // 
            this.gbEscala2.Controls.Add(this.rbToK);
            this.gbEscala2.Controls.Add(this.rbToF);
            this.gbEscala2.Controls.Add(this.rbToC);
            this.gbEscala2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(75)))));
            this.gbEscala2.Location = new System.Drawing.Point(307, 8);
            this.gbEscala2.Name = "gbEscala2";
            this.gbEscala2.Size = new System.Drawing.Size(253, 192);
            this.gbEscala2.TabIndex = 0;
            this.gbEscala2.TabStop = false;
            this.gbEscala2.Text = "Escala Destino:";
            // 
            // rbToK
            // 
            this.rbToK.AutoSize = true;
            this.rbToK.Checked = true;
            this.rbToK.Location = new System.Drawing.Point(42, 127);
            this.rbToK.Name = "rbToK";
            this.rbToK.Size = new System.Drawing.Size(84, 29);
            this.rbToK.TabIndex = 2;
            this.rbToK.TabStop = true;
            this.rbToK.Text = "Kelvin";
            this.rbToK.UseVisualStyleBackColor = true;
            // 
            // rbToF
            // 
            this.rbToF.AutoSize = true;
            this.rbToF.Location = new System.Drawing.Point(42, 78);
            this.rbToF.Name = "rbToF";
            this.rbToF.Size = new System.Drawing.Size(123, 29);
            this.rbToF.TabIndex = 1;
            this.rbToF.Text = "Fahrenheit";
            this.rbToF.UseVisualStyleBackColor = true;
            // 
            // rbToC
            // 
            this.rbToC.AutoSize = true;
            this.rbToC.Location = new System.Drawing.Point(42, 33);
            this.rbToC.Name = "rbToC";
            this.rbToC.Size = new System.Drawing.Size(90, 29);
            this.rbToC.TabIndex = 0;
            this.rbToC.Text = "Celsius";
            this.rbToC.UseVisualStyleBackColor = true;
            // 
            // gbEscala1
            // 
            this.gbEscala1.Controls.Add(this.rbFromK);
            this.gbEscala1.Controls.Add(this.rbFromF);
            this.gbEscala1.Controls.Add(this.rbFromC);
            this.gbEscala1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(75)))));
            this.gbEscala1.Location = new System.Drawing.Point(8, 8);
            this.gbEscala1.Name = "gbEscala1";
            this.gbEscala1.Size = new System.Drawing.Size(253, 192);
            this.gbEscala1.TabIndex = 0;
            this.gbEscala1.TabStop = false;
            this.gbEscala1.Text = "Escala Origem:";
            // 
            // rbFromK
            // 
            this.rbFromK.AutoSize = true;
            this.rbFromK.Location = new System.Drawing.Point(42, 127);
            this.rbFromK.Name = "rbFromK";
            this.rbFromK.Size = new System.Drawing.Size(84, 29);
            this.rbFromK.TabIndex = 2;
            this.rbFromK.Text = "Kelvin";
            this.rbFromK.UseVisualStyleBackColor = true;
            // 
            // rbFromF
            // 
            this.rbFromF.AutoSize = true;
            this.rbFromF.Location = new System.Drawing.Point(42, 78);
            this.rbFromF.Name = "rbFromF";
            this.rbFromF.Size = new System.Drawing.Size(123, 29);
            this.rbFromF.TabIndex = 1;
            this.rbFromF.Text = "Fahrenheit";
            this.rbFromF.UseVisualStyleBackColor = true;
            // 
            // rbFromC
            // 
            this.rbFromC.AutoSize = true;
            this.rbFromC.Checked = true;
            this.rbFromC.Location = new System.Drawing.Point(42, 33);
            this.rbFromC.Name = "rbFromC";
            this.rbFromC.Size = new System.Drawing.Size(90, 29);
            this.rbFromC.TabIndex = 0;
            this.rbFromC.TabStop = true;
            this.rbFromC.Text = "Celsius";
            this.rbFromC.UseVisualStyleBackColor = true;
            // 
            // pnBottom
            // 
            this.pnBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(151)))), ((int)(((byte)(177)))));
            this.pnBottom.Controls.Add(this.lbResposta);
            this.pnBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBottom.Location = new System.Drawing.Point(15, 395);
            this.pnBottom.Name = "pnBottom";
            this.pnBottom.Padding = new System.Windows.Forms.Padding(5);
            this.pnBottom.Size = new System.Drawing.Size(879, 100);
            this.pnBottom.TabIndex = 1;
            // 
            // lbResposta
            // 
            this.lbResposta.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbResposta.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResposta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(75)))));
            this.lbResposta.Image = ((System.Drawing.Image)(resources.GetObject("lbResposta.Image")));
            this.lbResposta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbResposta.Location = new System.Drawing.Point(5, 5);
            this.lbResposta.Name = "lbResposta";
            this.lbResposta.Size = new System.Drawing.Size(869, 79);
            this.lbResposta.TabIndex = 0;
            this.lbResposta.Text = "Resposta = 0";
            this.lbResposta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(205)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(909, 510);
            this.Controls.Add(this.pnBottom);
            this.Controls.Add(this.pnTop);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONVERSOR DE TEMPERATURA";
            this.pnTop.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbEscala2.ResumeLayout(false);
            this.gbEscala2.PerformLayout();
            this.gbEscala1.ResumeLayout(false);
            this.gbEscala1.PerformLayout();
            this.pnBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.Label lbTemperatura;
        private System.Windows.Forms.GroupBox gbEscala2;
        private System.Windows.Forms.RadioButton rbToK;
        private System.Windows.Forms.RadioButton rbToF;
        private System.Windows.Forms.RadioButton rbToC;
        private System.Windows.Forms.GroupBox gbEscala1;
        private System.Windows.Forms.RadioButton rbFromK;
        private System.Windows.Forms.RadioButton rbFromF;
        private System.Windows.Forms.RadioButton rbFromC;
        private System.Windows.Forms.Panel pnBottom;
        private System.Windows.Forms.Label lbResposta;
    }
}

