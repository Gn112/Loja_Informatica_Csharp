using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaInformatica
{
    internal class Pessoa
    {
        private String nome;
        private int CPF;
        private String email;
        private String endereco;
        private String telefone;

        private String Nome { get { return nome; } set { nome = value; } }
        private int Cpf { get { return CPF; } set { CPF = value; } }
        private String Email { get { return email; } set { email = value; } }
        private String Endereco { get { return endereco; } set { endereco = value; } }
        private String Telefone { get { return telefone; } set { telefone = value; } }

    }
}
