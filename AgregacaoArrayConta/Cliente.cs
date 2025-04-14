using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoArrayConta
{
    public class Cliente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int Telefone { get; set; }

        public Cliente(string nome, int idade, int telefone)
        {
            Nome = nome;
            Idade = idade;
            Telefone = telefone;
        }

       
    }
}