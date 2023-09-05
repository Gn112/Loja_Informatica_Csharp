using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaInformatica
{
    internal class Produto
    {
        private int idProduto;
        private string descricao;
        private string categoria;
        private decimal precoCompra;
        private decimal precoVenda;
        private int qtdeEstoque;

        public int IdProduto { get { return idProduto; } set { idProduto = value; } }
        public string Descricao { get { return descricao; } set { descricao = value; } }
        public string Categoria { get { return categoria; } set { categoria = value; } }
        public decimal PrecoCompra { get { return precoCompra; } set { precoCompra = value; } }
        public decimal PrecoVenda { get { return precoVenda; } set { precoVenda = value; } }
        public int QtdeEstoque { get { return qtdeEstoque; } set { qtdeEstoque = value; } }
    }
}


