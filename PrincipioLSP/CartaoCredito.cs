using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrincipioLSP
{
    public class CartaoCredito : IPagamento
    {
        public void ProcessarPagamento(decimal valor)
        {
            Console.WriteLine($"Processado pagamento no Cartão de Crédito no valor de: {valor:C}");
        }
    }
}