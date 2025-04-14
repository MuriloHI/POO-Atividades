using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public class Comissionado : Funcionario
    {
        private double comissao;
        public double Comissao
        {
            get { return comissao; }
            set { comissao = value; }
        }
        
        public Comissionado(int codigo, string nome, double salario, double comissao) : base(codigo, nome, salario)
        {
            Comissao = comissao;
        }

        public override double CalcularSalario(int diasUteis)
        {
            return (Salario / 30 * diasUteis) * Comissao + Salario;
        }

        public override void MostrarAtributos()
        {
            base.MostrarAtributos();
            Console.WriteLine($"Comissão: {Comissao:c}");
        }
    }
}