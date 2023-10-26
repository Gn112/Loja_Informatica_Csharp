using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using LojaInformatica.BLL;
using LojaInformatica.UI;
using LojaInformatica.DTO;

namespace LojaInformatica.BLL
{
    internal class DAOCliente
    {
        MySqlConnection conexao = null;
        Conexao l = new Conexao();

        public void Insert(Clientes c)
        {
            try
            {
                conexao = l.Conectar();
                var comando = conexao.CreateCommand();
                comando.CommandText = "INSERT INTO clientes (nome, cpf, telefone, email, endereco)" +
                    "VALUES('" + c.nome + "','" + c.cpf + "','" + c.telefone + "','" + c.email + "','" + c.endereco +"')";
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

        public void Delete(Clientes c)

        {

            try
            {

                conexao = l.Conectar();

                var comando = conexao.CreateCommand();

                string tabela = "clientes";
                comando.CommandText = String.Format(

        $@"DELETE from {tabela} WHERE idcliente = '{c.id}';");

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

        public void Update(Clientes c)

        {
            try {

                conexao = l.Conectar();

                var comando = conexao.CreateCommand();

                string tabela = "clientes";

                comando.CommandText = String.Format($@"UPDATE {tabela}

            SET nome = '{c.nome}', 

            cpf = '{c.cpf}',

            telefone= '{c.telefone}',

            email='{c.email}',

            endereco= '{c.endereco}'

            WHERE idcliente '{c.id}';");

                comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {

                throw new Exception("Problemas ao Alterar no banco" + ex.Message);

            }

            finally { 

l.Conectar().Close();

            }

        }

    }
}
