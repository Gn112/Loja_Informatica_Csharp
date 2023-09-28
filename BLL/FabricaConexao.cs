using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LojaInformatica
{
	internal class FabricaConexao
	{
		MySqlConnection conexao = null;

		public MySqlConnection Conectar()
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
	}
}
