using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public class Departamento
    {
        private int codigo;
        private string nome;
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

        public List<Funcionario> VetF { get; set; }
        public Departamento(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }

        public void Admitir(Funcionario f) //Nesse parâmetro usamos a generalização
        {
            VetF.Add(f);
        }
        public void ListarFuncionarios()
        {
            Console.WriteLine("\nNome do departamento: " + nome);
            foreach(Funcionario f in VetF)
                f.MostrarAtributos();
        }

        public void Demitir(int codigo)
        {
            for (int i=0; i<VetF.Count; i++)
            {
                Funcionario f = VetF.ElementAt<Funcionario>(i);
                if (f.Codigo == codigo)
                    VetF.Remove(f);
                    Console.WriteLine("Funcionário excluido com sucesso.");
            }
        }

        public double CalcularFolha(int diasUteis)
        {
            double folha = 0;
            for (int i=0; i<VetF.Count; i++)
            {
                Funcionario f = VetF.ElementAt<Funcionario>(i); //pega cada indice do vetor e coloca variavel f (generalizando o objeto)
                folha += f.CalcularSalario(diasUteis);
            }
            return folha;
        }

        //NOVOS MÉTODOS - EXERCÍCIO AMPLIFICADO
        public void MostrarQtdeDependentesFuncionario()
        {
            foreach (Funcionario f in VetF)
            {
                Console.WriteLine($"Funcionário {f.Nome}, Total de Dependentes: {f.CalcularTotalDependente}");
            }
        }
    }
}