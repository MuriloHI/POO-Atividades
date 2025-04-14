using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoProduto
{
    public class Livro : Produto
    {
        private string autor;
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        
        private long isbn;
        public long Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public Livro(int codigo, double preco, string autor, long isbn) : base(codigo, preco)
        {
            Autor = autor;
        }
        
        public override void AtualizarPreco(double preco)
        {
            base.AtualizarPreco(preco);
            Console.WriteLine("Livro de: " + autor + ", com o ISBN de: " + isbn + " foi alterado");
        }
    }
}