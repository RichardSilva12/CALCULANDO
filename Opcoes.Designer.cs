namespace Projeto_Calculando
{
    partial class Opcoes
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
            this.Opcoeslbl = new System.Windows.Forms.Label();
            this.SomButton = new System.Windows.Forms.Label();
            this.slider = new System.Windows.Forms.PictureBox();
            this.VoltarButtonOpcoes = new System.Windows.Forms.Button();
            this.Voltaropcoeslbl = new System.Windows.Forms.Label();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).BeginInit();
            this.SuspendLayout();
            // 
            // Opcoeslbl
            // 
            this.Opcoeslbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Opcoeslbl.BackColor = System.Drawing.Color.Transparent;
            this.Opcoeslbl.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Opcoeslbl.ForeColor = System.Drawing.Color.Gold;
            this.Opcoeslbl.Location = new System.Drawing.Point(200, 18);
            this.Opcoeslbl.Name = "Opcoeslbl";
            this.Opcoeslbl.Size = new System.Drawing.Size(440, 80);
            this.Opcoeslbl.TabIndex = 0;
            this.Opcoeslbl.Text = "OPÇÕES";
            this.Opcoeslbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SomButton
            // 
            this.SomButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SomButton.BackColor = System.Drawing.Color.Transparent;
            this.SomButton.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SomButton.ForeColor = System.Drawing.Color.Gold;
            this.SomButton.Location = new System.Drawing.Point(35, 206);
            this.SomButton.Name = "SomButton";
            this.SomButton.Size = new System.Drawing.Size(73, 35);
            this.SomButton.TabIndex = 1;
            this.SomButton.Text = "Som";
            // 
            // slider
            // 
            this.slider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.slider.BackColor = System.Drawing.Color.Transparent;
            this.slider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slider.Location = new System.Drawing.Point(142, 211);
            this.slider.Name = "slider";
            this.slider.Size = new System.Drawing.Size(450, 30);
            this.slider.TabIndex = 2;
            this.slider.TabStop = false;
            this.slider.Paint += new System.Windows.Forms.PaintEventHandler(this.slider_Paint);
            this.slider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.slider_mousedown);
            // 
            // VoltarButtonOpcoes
            // 
            this.VoltarButtonOpcoes.BackgroundImage = global::Projeto_Calculando.Properties.Resources.Voltar;
            this.VoltarButtonOpcoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VoltarButtonOpcoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VoltarButtonOpcoes.Location = new System.Drawing.Point(41, 18);
            this.VoltarButtonOpcoes.Name = "VoltarButtonOpcoes";
            this.VoltarButtonOpcoes.Size = new System.Drawing.Size(80, 42);
            this.VoltarButtonOpcoes.TabIndex = 12;
            this.VoltarButtonOpcoes.UseVisualStyleBackColor = true;
            this.VoltarButtonOpcoes.Click += new System.EventHandler(this.VoltarButtonOpcoes_Click);
            this.VoltarButtonOpcoes.MouseEnter += new System.EventHandler(this.MudaCor_VoltarOpcoes);
            this.VoltarButtonOpcoes.MouseLeave += new System.EventHandler(this.Voltacor_VoltarOpcoes);
            // 
            // Voltaropcoeslbl
            // 
            this.Voltaropcoeslbl.AutoSize = true;
            this.Voltaropcoeslbl.BackColor = System.Drawing.Color.Transparent;
            this.Voltaropcoeslbl.Cursor = System.Windows.Forms.Cursors.Default;
            this.Voltaropcoeslbl.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Voltaropcoeslbl.ForeColor = System.Drawing.Color.Gold;
            this.Voltaropcoeslbl.Location = new System.Drawing.Point(37, 66);
            this.Voltaropcoeslbl.Name = "Voltaropcoeslbl";
            this.Voltaropcoeslbl.Size = new System.Drawing.Size(84, 23);
            this.Voltaropcoeslbl.TabIndex = 13;
            this.Voltaropcoeslbl.Text = "Voltar";
            // 
            // Opcoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Calculando.Properties.Resources.Fundo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Voltaropcoeslbl);
            this.Controls.Add(this.VoltarButtonOpcoes);
            this.Controls.Add(this.slider);
            this.Controls.Add(this.SomButton);
            this.Controls.Add(this.Opcoeslbl);
            this.Name = "Opcoes";
            this.Text = "Opcoes";
            ((System.ComponentModel.ISupportInitialize)(this.slider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Opcoeslbl;
        private System.Windows.Forms.Label SomButton;
        private System.Windows.Forms.PictureBox slider;
        private System.Windows.Forms.Button VoltarButtonOpcoes;
        private System.Windows.Forms.Label Voltaropcoeslbl;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
    }
}