using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoFuncionario
{
    public class Funcionario
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }   
        public decimal Salario { get; set; }

        public void CalcularAumento(decimal porcentagem)
        {
            Salario += Salario * porcentagem/100;
        }
    }
}