using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoPOO
{
    public class Cartao : Pagamento
    {
        protected string dadosTransacao;
        protected int resultadoTransacao;
        public string DadosTransacao
        {
            get { return dadosTransacao; }
            set { dadosTransacao = value; }
        }
        public int ResultadoTransacao
        {
            get { return resultadoTransacao; }
            set { resultadoTransacao = value; }
        }
        
        public Cartao(DateTime data, double total, string dadosTransacao, int resultadoTransacao) : base(data, total)
        {
            Data = data;
            DadosTransacao = dadosTransacao;
            ResultadoTransacao = resultadoTransacao;
        }
    }
}