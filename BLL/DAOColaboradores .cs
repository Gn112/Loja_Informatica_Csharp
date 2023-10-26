using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace LojaInformatica.BLL
{
    internal class DAOColaboradores
    {
        MySqlConnection conexao = null;
        Conexao l = new Conexao();

        public void Insert(Colaboradores c)
        {
            try
            {
                conexao = l.Conectar();
                var comando = conexao.CreateCommand();
                comando.CommandText = "INSERT INTO colaboradores (nome, cpf, telefone, email, endereco,cargo,salario)" +
"VALUES('" + c.nome + "','" + c.cpf + "','" + c.telefone + "','" + c.email + "','" + c.endereco + "','" + c.cargo + "','" + c.salario + "')";
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
        public void Delete(Colaboradores c)

        {

            try
            {

                conexao = l.Conectar();

                var comando = conexao.CreateCommand();

                string tabela = "colaboradores";
                comando.CommandText = String.Format(

        $@"DELETE from {tabela} WHERE idcolaborador = '{c.id}';");

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

        public void Update(Colaboradores c)

        {
            try
            {

                conexao = l.Conectar();

                var comando = conexao.CreateCommand();

                string tabela = "colaboradores";

                comando.CommandText = String.Format($@"UPDATE {tabela}






            SET nome = '{c.nome}', 

            cpf = '{c.cpf}',

            telefone= '{c.telefone}',

            email='{c.email}',

            endereco= '{c.endereco}',

            cargo = '{c.cargo}',
            salario ='{c.salario}',

            WHERE idcolaborador '{c.id}';");

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

