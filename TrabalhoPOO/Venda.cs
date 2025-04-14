using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoPOO
{
    public class Venda
    {
        private DateTime data;
        private double total;
        private List<ItemVenda> vetVenda;
        private Pagamento pagamento;
        public Pagamento Pagamento
        {
            get { return pagamento; }
            set { pagamento = value; }
        }
        
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
        public List<ItemVenda> VetVenda
        {
            get { return vetVenda; }
            set { vetVenda = value; }
        }
        
        public Venda(DateTime data)
        {
            Data = data;
            Total = 0;

            vetVenda = new List<ItemVenda>();
        }


        //Método para calcular TOTAL
        public void CalcularTotal()
        {
            Total = 0;
            foreach (var item in vetVenda)
            {
                Total += item.CalcularSubTotal();
            }
        }
    }
}