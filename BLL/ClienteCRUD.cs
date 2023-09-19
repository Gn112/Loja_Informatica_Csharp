using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using ClienteDTO;

namespace LojaInformatica.BLL
{


    /*internal class ClienteDAL
    {
        Conexao objDAL = new Conexao();

        public void InserirCliente(Cliente objClienteDTO)
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
    }*/
}
