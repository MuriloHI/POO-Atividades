using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoProduto
{
    public class Disco : Produto
    {
        private string artista;
        private string gravadora;
        public string Artista
        {
            get { return artista; }
            set { artista = value; }
        }
        public string Gravadora
        {
            get { return gravadora; }
            set { gravadora = value; }
        }
        
        public Disco(int codigo, double preco, string artista, string gravadora) : base(codigo, preco)
        {
            Artista = artista;
            Gravadora = gravadora;
        }

        public override void AtualizarPreco(double preco)
        {
            base.AtualizarPreco(preco);
            Console.WriteLine("Dico do artista: " + artista + ", da gravadora: " + gravadora + " foi alterado");
        }
    }
}