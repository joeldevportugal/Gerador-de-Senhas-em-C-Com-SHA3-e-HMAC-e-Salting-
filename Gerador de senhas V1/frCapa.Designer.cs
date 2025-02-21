namespace Gerador_de_senhas_V1
{
    partial class frCapa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frCapa));
            this.Avanco = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LBLAutor = new System.Windows.Forms.Label();
            this.LblCarregar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Avanco
            // 
            this.Avanco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Avanco.Location = new System.Drawing.Point(12, 578);
            this.Avanco.Name = "Avanco";
            this.Avanco.Size = new System.Drawing.Size(986, 14);
            this.Avanco.TabIndex = 0;
            this.Avanco.Click += new System.EventHandler(this.Avanco_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(185, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(608, 374);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LBLAutor
            // 
            this.LBLAutor.AutoSize = true;
            this.LBLAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLAutor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.LBLAutor.Location = new System.Drawing.Point(30, 31);
            this.LBLAutor.Name = "LBLAutor";
            this.LBLAutor.Size = new System.Drawing.Size(913, 38);
            this.LBLAutor.TabIndex = 2;
            this.LBLAutor.Text = "Gerador de Senhas DevJoel2025 © Portugal Versão europeia";
            // 
            // LblCarregar
            // 
            this.LblCarregar.AutoSize = true;
            this.LblCarregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCarregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LblCarregar.Location = new System.Drawing.Point(12, 531);
            this.LblCarregar.Name = "LblCarregar";
            this.LblCarregar.Size = new System.Drawing.Size(149, 29);
            this.LblCarregar.TabIndex = 3;
            this.LblCarregar.Text = "Carregar 0%";
            // 
            // frCapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1010, 604);
            this.Controls.Add(this.LblCarregar);
            this.Controls.Add(this.LBLAutor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Avanco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frCapa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capa";
            this.Load += new System.EventHandler(this.frCapa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar Avanco;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LBLAutor;
        private System.Windows.Forms.Label LblCarregar;
    }
}

