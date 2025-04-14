using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoProduto
{
    public abstract class Produto
    {
        private int codigo;
        private double preco;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        
        public Produto(int codigo, double preco)
        {
            Codigo = codigo;
            Preco = preco;
        }

        public virtual void AtualizarPreco(double preco)
        {
            this.preco = preco;
            Console.WriteLine("Preço atualizado para: " + this.preco);
        }
    }
}