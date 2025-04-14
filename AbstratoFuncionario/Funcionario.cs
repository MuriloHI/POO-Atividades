using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public abstract class Funcionario
    {
        private int codigo;
        private string nome;
        private double salario;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public List<Dependente> VetDepen { get; set; } //Exercício novo

        public Funcionario(int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
            VetDepen = new List<Dependente>(); //Ex novo
        }
        public virtual void MostrarAtributos()
        {
            Console.WriteLine($"Código: {Codigo} Nome: {Nome} Salário: {Salario:c}");
        }

        public abstract double CalcularSalario(int diasUteis);


        //MÉTODOS NOVOS - EXERCÍCIO AMPLIFICADO
        public int CalcularTotalDependente() 
        {
            return VetDepen.Count;
        }

        public void RemoverDependentesMaioridade(int codigo) //FALTA ESSE
        {
            for (int i=0; i<VetDepen.Count; i++)
            {
                if (VetDepen[i].Codigo == codigo && VetDepen[i].verificarMaiorIdade())
                {
                    Console.WriteLine($"Dependente {VetDepen[i].Nome} removido por ser maior de idade.");
                    VetDepen.RemoveAt(i);
                }
            }
        }

        public void AdicionarDependente(Dependente novoDep)
        {
            VetDepen.Add(novoDep);
        }

        public void ListarDependentes()
        {
            Console.WriteLine($"Dependentes de: {Nome}");
            foreach (Dependente dep in VetDepen)
            {
                Console.WriteLine($"Código: {dep.Codigo}, Nome: {dep.Nome}, Idade: {dep.Idade}");
            }
        }
    }
}