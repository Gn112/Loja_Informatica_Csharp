using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaInformatica
{
    internal class Pedidos
    {
        private int idPedido;
        private int produto;
        private int fornecedor;
        private DateTime dataPedido;
        private decimal precoUnitario;
        private int quantidade;
        private decimal total;
        private string formaPagamento;

        public int IdPedido { get { return idPedido; } set { idPedido = value; } }
        public int IdProduto { get { return produto; } set { produto = value; } }
        public int IdFornecedor { get { return fornecedor; } set { fornecedor = value; } }
        public DateTime DataPedido { get { return dataPedido; } set { dataPedido = value; } }
        public decimal PrecoUnitario { get { return precoUnitario; } set { precoUnitario = value; } }
        public int Quantidade { get { return quantidade; } set { quantidade = value; } }
        public decimal Total { get { return total; } set { total = value; } }
        public string FormaPagamento { get { return formaPagamento; } set { formaPagamento = value; } }
    }
}

