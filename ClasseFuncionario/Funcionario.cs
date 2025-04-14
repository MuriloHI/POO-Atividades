using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseFuncionario
{
    public class Funcionario
    {
        //Declaração de atributos
        //codigo, nome, salario
        public int codigo;
        public string nome;
        public double salario;

        //Declaração de métodos
        //Criar um método para calcular o aumento salarial a partir de uma porcentagem passada via parâmetro
        public void AumentoSalarial(double porcentagem) {
            salario = salario + (salario * porcentagem/100);
        }
        public void MostrarAtributos() {
            Console.WriteLine("Código: "+codigo+ " | Nome: "+nome+" | Salário: "+salario);
        }
    }
}