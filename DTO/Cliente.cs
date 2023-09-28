using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PessoaDTO;

namespace LojaInformatica
{
    class Cliente : Pessoa
    {
        private int Idcliente;

        protected int IDcliente { get { return Idcliente; } set { Idcliente = value; } }
    }
}
