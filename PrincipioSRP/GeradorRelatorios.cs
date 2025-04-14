using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrincipioSRP
{
    public class GeradorRelatorios
    {
        public string GerarRelatorio(string titular, decimal saldo)
        {
            return $"Titular: {titular}\tSaldo: {saldo:C}";
        }
    }
}