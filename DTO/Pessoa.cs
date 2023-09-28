using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaDTO
{
    class Pessoa
    {
        private String nome;
        private int CPF;
        private String email;
        private String endereco;
        private String telefone;

        public String Nome { get { return nome; } set { nome = value; } }
        public int Cpf { get { return CPF; } set { CPF = value; } }
        public String Email { get { return email; } set { email = value; } }
        public String Endereco { get { return endereco; } set { endereco = value; } }
        public String Telefone { get { return telefone; } set { telefone = value; } }

    }
}
