using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceTributavel
{
    public class SeguroDeVida : ITributavel
    {
        public double CalculaTributos()
        {
            double valorConstante = 75;
            return valorConstante;
        }

    }
}