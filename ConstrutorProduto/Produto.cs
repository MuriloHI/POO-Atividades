using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorProduto
{
    public class Produto
    {
        //Criar 3 construtores
        public int Codigo { get; set; } //encapsulamento compacto
        public string Nome { get; set; }
        public double Preco { get; set; }
        public static int Cont { get; set; } //variável da classe (o static)

        public Produto() //atalho -> ctor
        {
            Cont ++;
        }

        public Produto(int codigo)
        {
            Codigo = codigo;

            Cont ++;
        }
        public Produto(int codigo, string nome, double preco)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;

            Cont ++;
        }

        public void MostrarAtributos()
        {
            Console.WriteLine("Código: "+Codigo+ "\tNome: "+Nome+
            "\tPreço R$ "+Preco);
        }
    }
}