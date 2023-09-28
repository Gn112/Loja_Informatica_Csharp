using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LojaInformatica.BLL
{
    internal class Inserir
    {
        MySqlConnection conexao = null;
        FabricaConexao f = new FabricaConexao();
        public void InsertCliente(Cliente c)
        {
            try
            {
                conexao = f.Conectar();
                var comando = conexao.CreateCommand();
                comando.CommandText = 
                    "INSERT INTO clientes (nome,cpf,email,endereco,telefone) VALUES ('" + c.Nome + "','" + c.Cpf + "','" + c.Email + "','" + c.Endereco + "','" + c.Telefone + "')";
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
