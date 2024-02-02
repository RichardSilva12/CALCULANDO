namespace Projeto_Calculando
{
    partial class TelaInicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.JogarButton = new System.Windows.Forms.Button();
            this.SairButton = new System.Windows.Forms.Button();
            this.bntCreditos = new System.Windows.Forms.Button();
            this.NomeCursolbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // JogarButton
            // 
            this.JogarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.JogarButton.BackColor = System.Drawing.Color.Gold;
            this.JogarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.JogarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.JogarButton.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JogarButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.JogarButton.Location = new System.Drawing.Point(243, 250);
            this.JogarButton.Name = "JogarButton";
            this.JogarButton.Size = new System.Drawing.Size(326, 50);
            this.JogarButton.TabIndex = 9;
            this.JogarButton.Text = "JOGAR";
            this.JogarButton.UseVisualStyleBackColor = false;
            this.JogarButton.Click += new System.EventHandler(this.JogarButton_Click);
            this.JogarButton.MouseEnter += new System.EventHandler(this.MudaCor_Jogar);
            this.JogarButton.MouseLeave += new System.EventHandler(this.VoltaCor_Jogar);
            // 
            // SairButton
            // 
            this.SairButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SairButton.BackColor = System.Drawing.Color.Gold;
            this.SairButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SairButton.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SairButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.SairButton.Location = new System.Drawing.Point(243, 306);
            this.SairButton.Name = "SairButton";
            this.SairButton.Size = new System.Drawing.Size(326, 50);
            this.SairButton.TabIndex = 7;
            this.SairButton.Text = "SAIR";
            this.SairButton.UseVisualStyleBackColor = false;
            this.SairButton.Click += new System.EventHandler(this.SairButton_Click);
            this.SairButton.MouseEnter += new System.EventHandler(this.MudaCor_Sair);
            this.SairButton.MouseLeave += new System.EventHandler(this.VoltaCor_Sair);
            // 
            // bntCreditos
            // 
            this.bntCreditos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bntCreditos.BackgroundImage = global::Projeto_Calculando.Properties.Resources.informaçoes;
            this.bntCreditos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntCreditos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntCreditos.Location = new System.Drawing.Point(12, 409);
            this.bntCreditos.Name = "bntCreditos";
            this.bntCreditos.Size = new System.Drawing.Size(50, 40);
            this.bntCreditos.TabIndex = 10;
            this.bntCreditos.UseVisualStyleBackColor = false;
            this.bntCreditos.Click += new System.EventHandler(this.bntCreditos_Click);
            // 
            // NomeCursolbl
            // 
            this.NomeCursolbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NomeCursolbl.BackColor = System.Drawing.Color.Transparent;
            this.NomeCursolbl.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.NomeCursolbl.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeCursolbl.ForeColor = System.Drawing.Color.Gold;
            this.NomeCursolbl.Location = new System.Drawing.Point(95, 113);
            this.NomeCursolbl.Name = "NomeCursolbl";
            this.NomeCursolbl.Size = new System.Drawing.Size(634, 89);
            this.NomeCursolbl.TabIndex = 11;
            this.NomeCursolbl.Text = "CALCULANDO";
            this.NomeCursolbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Calculando.Properties.Resources.novo_fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.NomeCursolbl);
            this.Controls.Add(this.bntCreditos);
            this.Controls.Add(this.JogarButton);
            this.Controls.Add(this.SairButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaInicial";
            this.Text = "Tela Inicial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button JogarButton;
        private System.Windows.Forms.Button SairButton;
        private System.Windows.Forms.Button bntCreditos;
        private System.Windows.Forms.Label NomeCursolbl;
    }
}

