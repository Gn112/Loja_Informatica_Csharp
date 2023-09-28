using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaInformatica.UI
{
    public partial class CadastroClientes : Form
    {
        public CadastroClientes()
        {
            InitializeComponent();
            // LerDados();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            cli.Nome = txtNome.Text;
            cli.Cpf = mtxtCpf.Text;
            cli.Email = txtEmail.Text;
            cli.Endereco = txtEndereco.Text;
            cli.Telefone = mtxtTelefone.Text;
        }
    }
}
