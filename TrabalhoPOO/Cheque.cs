using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoPOO
{
    public class Cheque : Pagamento
    {
        protected long numero;
        protected DateTime dataDeposito;
        protected int situacao;
        public long Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public DateTime DataDeposito
        {
            get { return dataDeposito; }
            set { dataDeposito = value; }
        }
        public int Situacao
        {
            get { return situacao; }
            set { situacao = value; }
        }
        
        public Cheque(DateTime data, double total ,long numero, DateTime dataDeposito, int situacao) : base(data, total)
        {
            Numero = numero;
            DataDeposito = dataDeposito;
            Situacao = situacao;
        }
    }
}