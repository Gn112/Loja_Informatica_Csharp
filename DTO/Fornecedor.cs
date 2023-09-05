using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaInformatica
{
    internal class Fornecedores
    {
        private int idfornecedores;
        private string razao_social;
        private string endereco;
        private string email;
        private string telefone;
        private string cnpj;
        private string insc_estadual;

        public int IdFornecedores { get { return idfornecedores; } set { idfornecedores = value; } }
        public string RazaoSocial { get { return razao_social; } set { razao_social = value; } }
        public string Endereco { get { return endereco; } set { endereco = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Telefone { get { return telefone; } set { telefone = value; } }
        public string CNPJ { get { return cnpj; } set { cnpj = value; } }
        public string InscEstadual { get { return insc_estadual; } set { insc_estadual = value; } }
    }
}

