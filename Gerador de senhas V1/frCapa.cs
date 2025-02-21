using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerador_de_senhas_V1
{
    public partial class frCapa : Form
    {
        private Timer timer;
        private int progress = 0;

        public frCapa()
        {
            InitializeComponent();

            // Inicializa o Timer
            timer = new Timer();
            timer.Interval = 100; // Intervalo em milissegundos (ajuste conforme necessário)
            timer.Tick += Timer_Tick;

            // Configure o ProgressBar
            Avanco.Maximum = 100;

            // Adiciona o evento Load do formulário
            this.Load += new EventHandler(frCapa_Load);
        }

        private void frCapa_Load(object sender, EventArgs e)
        {
            // Inicia o Timer automaticamente quando o formulário carregar
            timer.Start();
        }

        private void Avanco_Click(object sender, EventArgs e)
        {
            progress = 0;
            Avanco.Value = 0;
            LblCarregar.Text = "Progresso: 0%";
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            progress += 1;
            Avanco.Value = progress;
            LblCarregar.Text = $"Progresso: {progress}%";

            if (progress >= 100)
            {
                timer.Stop();
                this.Hide(); // Oculta o frCapa
                frGerador f = new frGerador();
                f.FormClosing += (s, args) => Application.Exit(); // Fecha a aplicação quando frGerador fechar
                f.ShowDialog();
            }
        }
    }
}
