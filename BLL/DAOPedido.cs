using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace LojaInformatica.BLL
{
    internal class DAOPedidos
    {
        MySqlConnection conexao = null;
        Conexao l = new Conexao();

        public void Insert(Pedidos p)
        {
            try
            {
                conexao = l.Conectar();
                var comando = conexao.CreateCommand();
                comando.CommandText = "INSERT INTO pedidos (idproduto, idfornecedor, datapedido, precounitario, forma, quantidade)" +
                    "VALUES('" +  p.produtoId + "','" + p.fornecedorId   + "','" + p.data + "','" + p.precoUni + "','" + p.preco + "','" + p.formaPag + "','" + p.quant + "')";
                comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);

            }
            finally
            {
                l.Conectar().Close();
            }
        }

        public void Delete(Pedidos c)

        {

            try
            {

                conexao = l.Conectar();

                var comando = conexao.CreateCommand();

                string tabela = "pedidos";
                comando.CommandText = String.Format(

        $@"DELETE from {tabela} WHERE idpedido = '{c.id}';");

                comando.ExecuteNonQuery();

            }
            catch (MySqlException ex)

            {

                throw new Exception(

                "Problemas ao APAGAR no banco" + ex.Message);

            }
            finally

            {

                l.Conectar().Close();

            }

        }

        public void Update(Pedidos c)

        {
            try
            {

                conexao = l.Conectar();

                var comando = conexao.CreateCommand();

                string tabela = "fornecedores";

                comando.CommandText = String.Format($@"UPDATE {tabela}

            SET idproduto = '{c.produtoId}'

            idfornecedor = '{c.fornecedorId}',

             datapedido ='{c.data}',

            precounitario = '{c.precoUni}', 

            forma = '{c.formaPag}',

            quantidade = '{c.quant}'

            WHERE idpedido '{c.id}';");

                comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {

                throw new Exception("Problemas ao Alterar no banco" + ex.Message);

            }

            finally
            {

                l.Conectar().Close();

            }

        }


    }
}
