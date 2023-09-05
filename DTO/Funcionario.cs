using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaInformatica
{
    internal class Funcionario : Pessoa
    {
        private int Idfuncionario;
        private String cargo;
        private float salario;

        private int IDfuncionario { get { return Idfuncionario; } set { Idfuncionario = value; } }
        private String Cargo { get { return cargo; } set { cargo = value; } }
        private float Salario { get { return salario; } set { salario = value; } }
    }
}
