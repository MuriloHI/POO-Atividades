using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayProduto
{
    public class Produto
    {
        //Criar a classe do Produto(codigo, nome, preco, qtde)
        public int codigo;
        public string nome;
        public double preco;
        public int qtde;

    //Criar o método MostrarAtributos() dentro da classe Produto
        public void MostrarAtributos() {
            Console.WriteLine("Código: "+codigo+ "\tNome: "+nome+
            "\tPreço R$ "+preco+"\tQuantidade: "+qtde);
        }
    }
}