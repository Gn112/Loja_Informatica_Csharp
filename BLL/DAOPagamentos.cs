using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace LojaInformatica.BLL
{
    internal class DAOPagamentos
    {
        MySqlConnection conexao = null;
        Conexao l = new Conexao();

        public void Insert(Pagamentos p)
        {
            try
            {
                conexao = l.Conectar();
                var comando = conexao.CreateCommand();
                comando.CommandText = "INSERT INTO fornecedores (tipo)" +
                    "VALUES('" + p.tipo + "')";
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

        public void Delete(Pagamentos c)

        {

            try
            {

                conexao = l.Conectar();

                var comando = conexao.CreateCommand();

                string tabela = "pagamentos";
                comando.CommandText = String.Format(

        $@"DELETE from {tabela} WHERE idpagamento = '{c.id}';");

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

        public void Update(Pagamentos c)

        {
            try
            {

                conexao = l.Conectar();

                var comando = conexao.CreateCommand();

                string tabela = "pagamentos";

                comando.CommandText = String.Format($@"UPDATE {tabela}

            SET tipo = {c.tipo}

            WHERE idpagamento '{c.id}';");

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
