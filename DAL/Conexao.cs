using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace DAL
{
    class Conexao
    {
		static MySqlConnection conexao = null;

		public static MySqlConnection Conectar()
		{
			string conn = @"Persist Security Info = false;
								server= localhost;
								database= db_teste;
								uid= root;
								pwd= ROOT";
			try
			{
				conexao = new MySqlConnection(conn);
				conexao.Open();
				Console.WriteLine("Conectado");
			}

			catch (MySqlException)
			{
				throw new Exception("Problemas ao conectar no banco");
			}
			return conexao;
		}

		public void ExecutarComando(string sql)
        {
			Conectar();

            try
            {
				MySqlCommand comando = new MySqlCommand(sql, conexao);
				comando.ExecuteNonQuery();
            }

			catch(MySqlException ex)
            {
				throw new Exception ($"Não foi possível executar a instrução.\n {ex.Message}");
            }
            finally
            {
				conexao.Close();
            }
        }

		public DataTable ExecutarConsulta(string sql)
        {
			Conectar();

            try
            {
				DataTable dt = new DataTable();
				MySqlDataAdapter dados = new MySqlDataAdapter(sql, conexao);
				dados.Fill(dt);
				return dt;
            }
			catch (MySqlException ex)
            {
				throw new Exception($"Não foi possível executar a consulta.\n {ex.Message}");
            }
            finally
            {
				conexao.Close();
            }
        }

	}
}
