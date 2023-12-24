using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaOrdemServico
{
    public partial class TelaInicial : Form
    {
        private readonly Invocador invocador;
        
        public TelaInicial(Invocador invocador)
        {
            InitializeComponent();
            this.invocador = invocador;
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            invocador.ChangeForm<CadastroFunc>(invocador);
        }

        private void btnPecas_Click(object sender, EventArgs e)
        {
            invocador.ChangeForm<CadastroPecas>(invocador);
        }

        private void btnOrcamentos_Click(object sender, EventArgs e)
        {
            invocador.ChangeForm<Orcamento>(invocador);
        }

        private void btnOrdemDeServico_Click(object sender, EventArgs e)
        {
            invocador.ChangeForm<OrdemDeServico>(invocador);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            invocador.ChangeForm<cadPessoa>(invocador);
        }
    }
}
