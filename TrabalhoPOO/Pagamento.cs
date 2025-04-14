using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoPOO
{
    public class Pagamento //Classe mãe
    {
        protected DateTime data;
        protected double total;
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
        public double Total
        {
            get { return total; }
            set { total = value; }
        }
        public Pagamento(DateTime data, double total)
        {
            Data = data;
            Total = total;
        } 
    }
}