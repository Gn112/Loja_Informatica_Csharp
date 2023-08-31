using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaInformatica
{
    internal class Pagamentos
    {
        private int idPagamento;
        private string tipo;

        public int IdPagamento { get { return idPagamento; } set { idPagamento = value; } }
        public string Tipo { get { return tipo; } set { tipo = value; } }
    }
}