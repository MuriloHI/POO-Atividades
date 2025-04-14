using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Comprador
    {
        private double verba;
        public double Verba
        {
            get { return verba; }
            set { verba = value; }
        }
        
        public void MostrarAtributos()
        {
            Console.WriteLine("(COMPRADOR) Verba: R$ "+Verba);
        }

        public Comprador(double verba)
        {
            Verba = verba;
        }
    }
}