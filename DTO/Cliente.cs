using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PessoaDTO;

namespace ClienteDTO
{
    class Cliente : Pessoa
    {
        private int Idcliente;

        private int IDcliente { get { return Idcliente; } set { Idcliente = value; } }
    }
}
