using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Crypto.Parameters;

namespace Gerador_de_senhas_V1
{
    public partial class frGerador : Form
    {
        public frGerador()
        {
            InitializeComponent();
            Application.EnableVisualStyles();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            Gerar();
        }

        private void Gerar()
        {
            string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowerCase = "abcdefghijklmnopqrstuvwxyz";
            string numbers = "0123456789";
            string symbols = "!@#$%^&*()";

            StringBuilder allowedChars = new StringBuilder();

            if (chkGrandes.Checked) allowedChars.Append(upperCase);
            if (chkpequenas.Checked) allowedChars.Append(lowerCase);
            if (chkNumeros.Checked) allowedChars.Append(numbers);
            if (chkSimbolos.Checked) allowedChars.Append(symbols);

            int passwordLength;
            if (int.TryParse(txtNumero.Text, out passwordLength) && passwordLength > 0)
            {
                StringBuilder password = new StringBuilder();
                Random rnd = new Random();
                for (int i = 0; i < passwordLength; i++)
                {
                    int index = rnd.Next(allowedChars.Length);
                    password.Append(allowedChars[index]);
                }

                txtPassword.Text = password.ToString();
                LblEstado.Text = "Password Gerada com sucesso!";
            }
            else
            {
                LblEstado.Text = "Por favor, insira um número válido de caracteres.";
            }
        }

        private void BtnCopiar_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            Copiar();
        }

        private void Copiar()
        {
            if (!string.IsNullOrEmpty(txtPassword.Text))
            {
                Clipboard.SetText(txtPassword.Text);
                LblEstado.Text = "Senha copiada para a área de transferência!";
            }
            else
            {
                LblEstado.Text = "Nenhuma senha para copiar.";
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            Limpar();
        }

        private void Limpar()
        {
            chkGrandes.Checked = false;
            chkpequenas.Checked = false;
            chkNumeros.Checked = false;
            chkSimbolos.Checked = false;
            txtPassword.Text = string.Empty;
            txtPass1.Text = string.Empty;
            txtNumero.Text = string.Empty;
            LblEstado.Text = "Dados Limpos com sucesso!";
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            Sair();
        }

        private void Sair()
        {
            if (MessageBox.Show("Deseja Sair do Programa? ", "Sair",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            Application.Exit();
        }

        private void BtnAumentar_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            aumentar();
        }

        private void aumentar()
        {
            int numero;
            if (int.TryParse(txtNumero.Text, out numero))
            {
                if (numero < 255)
                {
                    numero++;
                    txtNumero.Text = numero.ToString();
                }

                if (numero == 255)
                {
                    LblEstado.Text = "Contagem concluída!";
                }
                else
                {
                    LblEstado.Text = string.Empty; // Limpa a mensagem quando não for 255
                }
            }
            else
            {
                txtNumero.Text = "0"; // Inicializa com 0 caso o conteúdo de txtNumero não seja um número válido
            }
        }

        private void BtnDecrementar_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            deminuir();
        }

        private void deminuir()
        {
            int numero;
            if (int.TryParse(txtNumero.Text, out numero))
            {
                if (numero > 0)
                {
                    numero--;
                    txtNumero.Text = numero.ToString();
                }

                if (numero == 0)
                {
                    LblEstado.Text = "Valor mínimo atingido!";
                }
                else
                {
                    LblEstado.Text = string.Empty; // Limpa a mensagem quando não for 0
                }
            }
            else
            {
                txtNumero.Text = "255"; // Inicializa com 255 caso o conteúdo de txtNumero não seja um número válido
            }
        }

        private void BtnCriptografar_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            Criptografar();
        }

        private void Criptografar()
        {
            if (!string.IsNullOrEmpty(txtPassword.Text))
            {
                DialogResult result256 = MessageBox.Show("Deseja criptografar com HmacSha3_256?", "Escolha o Método", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                string secret = "secreto123";
                string hashedPassword = null;

                if (result256 == DialogResult.Yes)
                {
                    hashedPassword = HmacSha3_256Hash(txtPassword.Text, secret);
                }
                else
                {
                    DialogResult result512 = MessageBox.Show("Deseja criptografar com HmacSha3_512?", "Escolha o Método", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result512 == DialogResult.Yes)
                    {
                        hashedPassword = HmacSha3_512Hash(txtPassword.Text, secret);
                    }
                }

                if (!string.IsNullOrEmpty(hashedPassword))
                {
                    txtPass1.Text = hashedPassword;
                    LblEstado.Text = "Senha criptografada com sucesso!";
                }
                else
                {
                    LblEstado.Text = "Criptografia cancelada.";
                }
            }
            else
            {
                LblEstado.Text = "Nenhuma senha para criptografar.";
            }
        }

        private string HmacSha3_256Hash(string message, string secret)
        {
            byte[] key = Encoding.UTF8.GetBytes(secret);
            Sha3Digest sha3 = new Sha3Digest(256);
            HMac hmac = new HMac(sha3);
            hmac.Init(new KeyParameter(key));
            byte[] messageBytes = Encoding.UTF8.GetBytes(message);
            byte[] result = new byte[hmac.GetMacSize()];
            hmac.BlockUpdate(messageBytes, 0, messageBytes.Length);
            hmac.DoFinal(result, 0);
            return Convert.ToBase64String(result);
        }

        private string HmacSha3_512Hash(string message, string secret)
        {
            byte[] key = Encoding.UTF8.GetBytes(secret);
            Sha3Digest sha3 = new Sha3Digest(512);
            HMac hmac = new HMac(sha3);
            hmac.Init(new KeyParameter(key));
            byte[] messageBytes = Encoding.UTF8.GetBytes(message);
            byte[] result = new byte[hmac.GetMacSize()];
            hmac.BlockUpdate(messageBytes, 0, messageBytes.Length);
            hmac.DoFinal(result, 0);
            return Convert.ToBase64String(result);
        }

        private void BtnCarregar_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            Carregar();
        }

        private void Carregar()
        {
            txtPass1.Text = txtPassword.Text;
            LblEstado.Text = "Password Carregada Com sucesso";
        }

        private void BtnCopiarPassCriptografada_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            Copiar1();
        }

        private void Copiar1()
        {
            if (!string.IsNullOrEmpty(txtPassword.Text))
            {
                Clipboard.SetText(txtPass1.Text);
                LblEstado.Text = "Senha criptografada copiada para a área de transferência!";
            }
            else
            {
                LblEstado.Text = "Nenhuma senha para copiar.";
            }
        }
    }
}

