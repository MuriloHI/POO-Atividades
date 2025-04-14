using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaProduto
{
    public class Produto
    {
        protected int codigo;
        protected double preco;
        protected string nome;
        public int Codigo

        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        
        public Produto(int codigo, string nome, double preco)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
        }

        public virtual void MostrarAtributos() 
        {
            Console.WriteLine("Código: "+Codigo+"\tNome: "+Nome+"\tPreço: R$"+Preco);
        }
        //nesse exemplo não precisa de um construtor padrão já que na main só tem o construtor de 3 e 5 parâmetros
    }
}