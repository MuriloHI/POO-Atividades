using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public class Dependente
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
        
        private int idade;
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        public Dependente(int codigo, string nome, int idade)
        {
            Codigo = codigo;
            Nome = nome;
            Idade = idade;
        }

        public bool verificarMaiorIdade()
        {
            return Idade >= 18;
        }


    }
}