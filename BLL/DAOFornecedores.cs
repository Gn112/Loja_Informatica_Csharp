using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace LojaInformatica.BLL
{
    internal class DAOFornecedores
    {
        MySqlConnection conexao = null;
        Conexao l = new Conexao();

        public void Insert(Fornecedores f)
        {
            try
            {
                conexao = l.Conectar();
                var comando = conexao.CreateCommand();
                comando.CommandText = "INSERT INTO fornecedores ( razao_social, endereco, email, telefone, cnpj, insc)" +
                    "VALUES('" + f.Razao + "','" + f.Endereco + "','" + f.Email + "','" + f.Telefone + "','" + f.cnpj + "','" + f.Insc + "')";
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

        public void Delete(Fornecedores c)

        {

            try
            {

                conexao = l.Conectar();

                var comando = conexao.CreateCommand();

                string tabela = "fornecedores";
                comando.CommandText = String.Format(

        $@"DELETE from {tabela} WHERE idfornecedor = '{c.Id}';");

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

        public void Update(Fornecedores c)

        {
            try
            {

                conexao = l.Conectar();

                var comando = conexao.CreateCommand();

                string tabela = "fornecedores";

                comando.CommandText = String.Format($@"UPDATE {tabela}

            SET razao_social = '{c.Razao}'

            endereco= '{c.Endereco}',

             email='{c.Email}',

            telefone= '{c.Telefone}', 

            cnpj = '{c.cnpj}',

            insc = '{c.Insc}'

            WHERE idfornecedor '{c.Id}';");

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

