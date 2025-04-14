using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoCliente
{
    public abstract class Cliente //abstract = palavra q indica é uma classe abstrata, ela não deixa instanciar // abstract só pode estar ligada a superclasse
    {
        public int Codigo { get; set; } 
        public string Nome { get; set; }
        public int Idade { get; set; }

        public virtual void MostrarAtributos()
        {
            Console.WriteLine("Código: " + Codigo + "\tNome: " + Nome + "\tIdade: " + Idade);
        }
        public Cliente(int codigo, string nome, int idade)
        {
            Codigo = codigo;
            Nome = nome;
            Idade = idade;
        }

        //Se um método tiver "abstract", ele só pode existir se for numa classe abstract
        //Por exemplo "public abstract void VerificaIdade();" Se tem o ; no final indicando que não vai ter nada depois
        //Assinatura de método = saber o que ele faz pelo nome (por exemplo o VerificarIdade(), verificar a idade) - saber se ele precisa de parâmetrom - saber se ele terá retorno.

        //Assinatura de método : vamos declarar que ele existe, mas sem a lógica de programação
        public abstract void VerificarIdade();
    }
}