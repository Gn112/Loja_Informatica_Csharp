using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace LojaInformatica.BLL
{
    internal class DAOProduto
    {
        MySqlConnection conexao = null;
        Conexao l = new Conexao();

        public void Insert(Produto p)
        {
            try
            {
                conexao = l.Conectar();
                var comando = conexao.CreateCommand();
                comando.CommandText = "INSERT INTO produto (descricao, categoria, precocompra, precovenda, precoestoque)" +
                    "VALUES('" + p.descricao + "','" + p.categoria + "','" + p.precoCompra + "','" + p.precoVenda + "','" + p.estoque + "')";
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

        public void Delete(Produto c)

        {

            try
            {

                conexao = l.Conectar();

                var comando = conexao.CreateCommand();

                string tabela = "clientes";
                comando.CommandText = String.Format(

        $@"DELETE from {tabela} WHERE idproduto = '{c.id}';");

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

        public void Update(Produto c)

        {
            try
            {

                conexao = l.Conectar();

                var comando = conexao.CreateCommand();

                string tabela = "produtos";

                comando.CommandText = String.Format($@"UPDATE {tabela}

descricao 
categoria 
precocompra 
precovenda 
estoque


            SET descricao = '{c.descricao}'

            categoria = '{c.categoria}',

            precocompra  ='{c.precoCompra}',

            precovenda  = '{c.precoVenda}', 

            estoque = '{c.estoque}'

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
