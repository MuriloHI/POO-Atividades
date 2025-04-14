using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoPOO
{
    public class ItemVenda
    {
        private int quantidade;
        private double preco;
        private double subtotal;
        private Produto produto;
        public Produto Produto
        {
            get { return produto; }
            set { produto = value; }
        }
        
        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }
        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        public double Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }
        
        public ItemVenda(int quantidade, Produto produto) //não colocamos o subtotal como parâmetro no construtor, n da pra saber qnt será
        {
            Quantidade = quantidade;
            Produto = produto;
            Preco = produto.Preco;

            Subtotal = 0;
        }
       /* public double CalcularSubTotal()
        {
            Subtotal = quantidade * preco;
            return Subtotal;
        } */

        public double CalcularSubTotal()
        {
            if (quantidade >= 50)
            {
                preco = preco * 0.8; 
            }
            Subtotal = quantidade * preco;
            return Subtotal;
        }

        public double DescontoSeForAtacado(int quantidade)
        {
            if (quantidade >= 50)
            {
                return preco - (preco * 20/100);
            }
            return preco;
        }
    }
}