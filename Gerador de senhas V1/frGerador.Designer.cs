namespace Gerador_de_senhas_V1
{
    partial class frGerador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frGerador));
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkGrandes = new System.Windows.Forms.CheckBox();
            this.chkpequenas = new System.Windows.Forms.CheckBox();
            this.chkNumeros = new System.Windows.Forms.CheckBox();
            this.chkSimbolos = new System.Windows.Forms.CheckBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.BtnAumentar = new System.Windows.Forms.Button();
            this.BtnDecrementar = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.LblEstado = new System.Windows.Forms.Label();
            this.BtnCopiar = new System.Windows.Forms.Button();
            this.txtPass1 = new System.Windows.Forms.TextBox();
            this.BtnCriptografar = new System.Windows.Forms.Button();
            this.BtnCarregar = new System.Windows.Forms.Button();
            this.BtnCopiarPassCriptografada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(11, 13);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(661, 35);
            this.txtPassword.TabIndex = 0;
            // 
            // chkGrandes
            // 
            this.chkGrandes.AutoSize = true;
            this.chkGrandes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGrandes.Location = new System.Drawing.Point(13, 142);
            this.chkGrandes.Name = "chkGrandes";
            this.chkGrandes.Size = new System.Drawing.Size(101, 26);
            this.chkGrandes.TabIndex = 1;
            this.chkGrandes.Text = "Grandes";
            this.chkGrandes.UseVisualStyleBackColor = true;
            // 
            // chkpequenas
            // 
            this.chkpequenas.AutoSize = true;
            this.chkpequenas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkpequenas.Location = new System.Drawing.Point(145, 142);
            this.chkpequenas.Name = "chkpequenas";
            this.chkpequenas.Size = new System.Drawing.Size(113, 26);
            this.chkpequenas.TabIndex = 2;
            this.chkpequenas.Text = "Pequenas";
            this.chkpequenas.UseVisualStyleBackColor = true;
            // 
            // chkNumeros
            // 
            this.chkNumeros.AutoSize = true;
            this.chkNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNumeros.Location = new System.Drawing.Point(305, 142);
            this.chkNumeros.Name = "chkNumeros";
            this.chkNumeros.Size = new System.Drawing.Size(104, 26);
            this.chkNumeros.TabIndex = 3;
            this.chkNumeros.Text = "Numeros";
            this.chkNumeros.UseVisualStyleBackColor = true;
            // 
            // chkSimbolos
            // 
            this.chkSimbolos.AutoSize = true;
            this.chkSimbolos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSimbolos.Location = new System.Drawing.Point(443, 142);
            this.chkSimbolos.Name = "chkSimbolos";
            this.chkSimbolos.Size = new System.Drawing.Size(105, 26);
            this.chkSimbolos.TabIndex = 4;
            this.chkSimbolos.Text = "Simbolos";
            this.chkSimbolos.UseVisualStyleBackColor = true;
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(665, 132);
            this.txtNumero.Multiline = true;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(78, 36);
            this.txtNumero.TabIndex = 5;
            // 
            // BtnAumentar
            // 
            this.BtnAumentar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnAumentar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnAumentar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAumentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAumentar.Location = new System.Drawing.Point(612, 132);
            this.BtnAumentar.Name = "BtnAumentar";
            this.BtnAumentar.Size = new System.Drawing.Size(47, 36);
            this.BtnAumentar.TabIndex = 6;
            this.BtnAumentar.Text = "+";
            this.BtnAumentar.UseVisualStyleBackColor = true;
            this.BtnAumentar.Click += new System.EventHandler(this.BtnAumentar_Click);
            // 
            // BtnDecrementar
            // 
            this.BtnDecrementar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnDecrementar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnDecrementar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDecrementar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDecrementar.Location = new System.Drawing.Point(749, 132);
            this.BtnDecrementar.Name = "BtnDecrementar";
            this.BtnDecrementar.Size = new System.Drawing.Size(53, 36);
            this.BtnDecrementar.TabIndex = 7;
            this.BtnDecrementar.Text = "-";
            this.BtnDecrementar.UseVisualStyleBackColor = true;
            this.BtnDecrementar.Click += new System.EventHandler(this.BtnDecrementar_Click);
            // 
            // btnGerar
            // 
            this.btnGerar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnGerar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnGerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerar.Location = new System.Drawing.Point(5, 195);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(101, 39);
            this.btnGerar.TabIndex = 8;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpar.Location = new System.Drawing.Point(332, 195);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(104, 39);
            this.BtnLimpar.TabIndex = 9;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.Location = new System.Drawing.Point(447, 195);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(101, 39);
            this.BtnSair.TabIndex = 10;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // LblEstado
            // 
            this.LblEstado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblEstado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstado.ForeColor = System.Drawing.Color.White;
            this.LblEstado.Location = new System.Drawing.Point(5, 248);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(797, 41);
            this.LblEstado.TabIndex = 11;
            this.LblEstado.Text = "Estado!...";
            this.LblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnCopiar
            // 
            this.BtnCopiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnCopiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnCopiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCopiar.Location = new System.Drawing.Point(679, 13);
            this.BtnCopiar.Name = "BtnCopiar";
            this.BtnCopiar.Size = new System.Drawing.Size(123, 35);
            this.BtnCopiar.TabIndex = 12;
            this.BtnCopiar.Text = "Copiar";
            this.BtnCopiar.UseVisualStyleBackColor = true;
            this.BtnCopiar.Click += new System.EventHandler(this.BtnCopiar_Click);
            // 
            // txtPass1
            // 
            this.txtPass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass1.Location = new System.Drawing.Point(11, 69);
            this.txtPass1.Multiline = true;
            this.txtPass1.Name = "txtPass1";
            this.txtPass1.Size = new System.Drawing.Size(661, 35);
            this.txtPass1.TabIndex = 0;
            // 
            // BtnCriptografar
            // 
            this.BtnCriptografar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnCriptografar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnCriptografar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCriptografar.Location = new System.Drawing.Point(222, 195);
            this.BtnCriptografar.Name = "BtnCriptografar";
            this.BtnCriptografar.Size = new System.Drawing.Size(104, 39);
            this.BtnCriptografar.TabIndex = 13;
            this.BtnCriptografar.Text = "Criptografar";
            this.BtnCriptografar.UseVisualStyleBackColor = true;
            this.BtnCriptografar.Click += new System.EventHandler(this.BtnCriptografar_Click);
            // 
            // BtnCarregar
            // 
            this.BtnCarregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnCarregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnCarregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCarregar.Location = new System.Drawing.Point(112, 195);
            this.BtnCarregar.Name = "BtnCarregar";
            this.BtnCarregar.Size = new System.Drawing.Size(104, 39);
            this.BtnCarregar.TabIndex = 14;
            this.BtnCarregar.Text = "Carregar";
            this.BtnCarregar.UseVisualStyleBackColor = true;
            this.BtnCarregar.Click += new System.EventHandler(this.BtnCarregar_Click);
            // 
            // BtnCopiarPassCriptografada
            // 
            this.BtnCopiarPassCriptografada.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnCopiarPassCriptografada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnCopiarPassCriptografada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCopiarPassCriptografada.Location = new System.Drawing.Point(679, 69);
            this.BtnCopiarPassCriptografada.Name = "BtnCopiarPassCriptografada";
            this.BtnCopiarPassCriptografada.Size = new System.Drawing.Size(123, 35);
            this.BtnCopiarPassCriptografada.TabIndex = 12;
            this.BtnCopiarPassCriptografada.Text = "Copiar";
            this.BtnCopiarPassCriptografada.UseVisualStyleBackColor = true;
            this.BtnCopiarPassCriptografada.Click += new System.EventHandler(this.BtnCopiarPassCriptografada_Click);
            // 
            // frGerador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(814, 298);
            this.Controls.Add(this.BtnCarregar);
            this.Controls.Add(this.BtnCriptografar);
            this.Controls.Add(this.BtnCopiarPassCriptografada);
            this.Controls.Add(this.BtnCopiar);
            this.Controls.Add(this.LblEstado);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.BtnDecrementar);
            this.Controls.Add(this.BtnAumentar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.chkSimbolos);
            this.Controls.Add(this.chkNumeros);
            this.Controls.Add(this.chkpequenas);
            this.Controls.Add(this.chkGrandes);
            this.Controls.Add(this.txtPass1);
            this.Controls.Add(this.txtPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frGerador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frGerador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkGrandes;
        private System.Windows.Forms.CheckBox chkpequenas;
        private System.Windows.Forms.CheckBox chkNumeros;
        private System.Windows.Forms.CheckBox chkSimbolos;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button BtnAumentar;
        private System.Windows.Forms.Button BtnDecrementar;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.Button BtnCopiar;
        private System.Windows.Forms.TextBox txtPass1;
        private System.Windows.Forms.Button BtnCriptografar;
        private System.Windows.Forms.Button BtnCarregar;
        private System.Windows.Forms.Button BtnCopiarPassCriptografada;
    }
}