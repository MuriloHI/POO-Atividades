using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoPOO
{
    public class Especie : Pagamento
    {
        protected double quantia;
        public double Quantia
        {
            get { return quantia; }
            set { quantia = value; }
        }
        
        protected double troco;
        public double Troco
        {
            get { return troco; }
            set { troco = value; }
        }
        
        public Especie(DateTime data, double total, double quantia) : base(data, total)
        {
            Data = data;
            Quantia = quantia;

            Troco = 0;
        }
        
        public double CalcularTroco()
        {
            if (quantia <= total)
            {
                Console.WriteLine("Não foi necessário troco");
            }
            else
            {
                Troco = quantia - total;
            }
            return Troco;
        }
    }
}