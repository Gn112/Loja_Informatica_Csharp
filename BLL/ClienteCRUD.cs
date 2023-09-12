using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using ClienteDTO;

namespace ClienteBLL
{
    class ClienteCRUD
    {
        Conexao objDAL = new Conexao();
        string tabela = "tbl_cliente";

        public void InserirCliente(ClienteDTO objClienteDTO)
        {
            string sql = String.Format($@"INSERT INTO {tabela} VALUES(
                        '{objClienteDTO.Idcliente}',
                        '{objClienteDTO.nome}'
                        '{objClienteDTO.CPF}'
                        '{objClienteDTO.email}'
                        '{objClienteDTO.endereco}'
                        '{objClienteDTO.telefone}')");
            objClienteDTO.ExecutarComando(sql);
        }
    }
}
