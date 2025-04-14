using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrincipioLSP
{
    public class Especie : IPagamento
    {
        public void ProcessarPagamento(decimal valor)
        {
            Console.WriteLine($"Processado pagamento em espécie de {valor:C}.");
        }        
    }
}