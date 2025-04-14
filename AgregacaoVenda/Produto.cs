using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Produto
    {
        private int codigo;
        public int Codigo
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
        
        public void MostrarAtributos()
        {
            Console.WriteLine("(PRODUTO) Código: "+Codigo+ "\tNome: "+Nome+"\tPreço: "+Preco);
        }


        public Produto(int codigo, string nome, double preco)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
        }

    }
}