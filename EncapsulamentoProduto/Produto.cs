using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoProduto
{
    public class Produto
    {
        private int codigo; //atributo em minusculo
        public int Codigo //Propriedade em Maiusculo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        
        private double preco;
        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        
        private int qtde;
        public int Qtde
        {
            get { return qtde; }
            set { qtde = value; }
        }
    }
}