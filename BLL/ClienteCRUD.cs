using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace LojaInformatica.BLL
{
    internal class DAOCliente
    {
        MySqlConnection conexao = null;
        FabricaConexao f = new FabricaConexao();

        public void Insert(Cliente c)
        {
            try
            {
                conexao = f.Conectar();
                var comando = conexao.CreateCommand();
                comando.CommandText = "INSERT INTO clientes (nome,cpf,telefone,email,endereco)" +
              "values('" + c.Nome + "','" + c.Cpf + "','" + c.Telefone + "','" + c.Email + "','" + c.Endereco + "')";
                comando.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                throw new Exception("Problemas ao INSERIR no banco" + ex.Message);
            }
            finally
            {
                f.Conectar().Close();
            }
        }

    }
}
