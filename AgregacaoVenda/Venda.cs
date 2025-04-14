using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Venda
    {
        private Comprador comp;
        public Comprador Comp
        {
            get { return comp; }
            set { comp = value; }
        }
        
        private List<Produto> vetProd;
        public List<Produto> VetProd
        {
            get { return vetProd; }
            set { vetProd = value; }
        }
        
        private Vendedor vende;
        public Vendedor Vende
        {
            get { return vende; }
            set { vende = value; }
        }
        
        public void MostrarAtributos()
        {
           double valorTotal = 0;
            foreach (Produto produto in VetProd)
            {
                valorTotal += produto.Preco;
            }
            Console.WriteLine("Valor total da venda: R$ " + valorTotal);


            
        }
        
    }
}