using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    public class Secretario : Funcionario //secretario é derivado de funcionario
    {
        public Secretario(int codigo, string nome, double salario) : base(codigo,nome,salario)
        {
        }
    }
}