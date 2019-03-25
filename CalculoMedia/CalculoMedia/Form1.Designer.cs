namespace CalculoMedia
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.textNota1 = new System.Windows.Forms.TextBox();
            this.textNota2 = new System.Windows.Forms.TextBox();
            this.textNota3 = new System.Windows.Forms.TextBox();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.textMedia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(79, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(202, 22);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CALCULO DE MÉDIA";
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.BackColor = System.Drawing.Color.Transparent;
            this.lblNota1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota1.Location = new System.Drawing.Point(25, 103);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(122, 18);
            this.lblNota1.TabIndex = 1;
            this.lblNota1.Text = "Digite a 1ª Nota:";
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.BackColor = System.Drawing.Color.Transparent;
            this.lblNota2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota2.Location = new System.Drawing.Point(28, 152);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(122, 18);
            this.lblNota2.TabIndex = 2;
            this.lblNota2.Text = "Digite a 2ª Nota:";
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.BackColor = System.Drawing.Color.Transparent;
            this.lblNota3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota3.Location = new System.Drawing.Point(28, 200);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(122, 18);
            this.lblNota3.TabIndex = 3;
            this.lblNota3.Text = "Digite a 3ª Nota:";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.BackColor = System.Drawing.Color.Transparent;
            this.lblMedia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia.Location = new System.Drawing.Point(80, 253);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(56, 18);
            this.lblMedia.TabIndex = 4;
            this.lblMedia.Text = "Média:";
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(131, 300);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(106, 42);
            this.BtnCalcular.TabIndex = 5;
            this.BtnCalcular.Text = "Calcular Média";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // textNota1
            // 
            this.textNota1.Location = new System.Drawing.Point(154, 104);
            this.textNota1.Name = "textNota1";
            this.textNota1.Size = new System.Drawing.Size(139, 20);
            this.textNota1.TabIndex = 6;
            // 
            // textNota2
            // 
            this.textNota2.Location = new System.Drawing.Point(154, 153);
            this.textNota2.Name = "textNota2";
            this.textNota2.Size = new System.Drawing.Size(139, 20);
            this.textNota2.TabIndex = 7;
            // 
            // textNota3
            // 
            this.textNota3.Location = new System.Drawing.Point(154, 201);
            this.textNota3.Name = "textNota3";
            this.textNota3.Size = new System.Drawing.Size(139, 20);
            this.textNota3.TabIndex = 8;
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.Location = new System.Drawing.Point(85, 376);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(82, 32);
            this.BtnLimpar.TabIndex = 10;
            this.BtnLimpar.Text = "Limpar ";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Location = new System.Drawing.Point(200, 376);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(81, 32);
            this.BtnSair.TabIndex = 11;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo2.Location = new System.Drawing.Point(127, 50);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(109, 22);
            this.lblTitulo2.TabIndex = 12;
            this.lblTitulo2.Text = "DO ALUNO";
            // 
            // textMedia
            // 
            this.textMedia.Location = new System.Drawing.Point(142, 253);
            this.textMedia.Name = "textMedia";
            this.textMedia.Size = new System.Drawing.Size(128, 20);
            this.textMedia.TabIndex = 9;
            this.textMedia.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(376, 430);
            this.ControlBox = false;
            this.Controls.Add(this.lblTitulo2);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.textMedia);
            this.Controls.Add(this.textNota3);
            this.Controls.Add(this.textNota2);
            this.Controls.Add(this.textNota1);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.lblNota3);
            this.Controls.Add(this.lblNota2);
            this.Controls.Add(this.lblNota1);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo Média de Aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.Label lblNota3;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.TextBox textNota1;
        private System.Windows.Forms.TextBox textNota2;
        private System.Windows.Forms.TextBox textNota3;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.TextBox textMedia;
    }
}

