using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    public class GerenciadorBonificacao
    {
        private double totalBonificacao;
        public double TotalBonificacao
        {
            get { return totalBonificacao; }
            set { totalBonificacao = value; }
        }

        public void TotalizadorBonificacao(Funcionario funcionario)
        {
            TotalBonificacao = TotalBonificacao + funcionario.CalcularBonificacao();
        }
        
        public void TotalizadorBonificacao(Secretario s)
        {
            TotalBonificacao = TotalBonificacao + s.CalcularBonificacao();
        }

        public void TotalizadorBonificacao(Gerente g)
        {
            TotalBonificacao = TotalBonificacao + g.CalcularBonificacao();
        }

        public void TotalizadorBonificacao(Diretor d)
        {
            TotalBonificacao = TotalBonificacao + d.CalcularBonificacao();
        }

    }
}