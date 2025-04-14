using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorAluno
{
    public class Aluno
    {
        //Criar a classe Aluno, com os atributos
        //matricula, nome
        public long Matricula { get; set; } //O atributo matricula não será static
        public string Nome { get; set; }
        public static int Contador { get; set; } //Utilize se quiser o atributo contador para  auxiliar a contagem e registro da matricula

        /*Utilizar o atributos static para criar as 
        matriculas de forma automática a cada instância
        seguindo o padrão Fatec 1570482313000 */

        //Instancie pelo menos 2 objetos de construtores diferentes
        public Aluno(long matricula, string nome)
        {
            Matricula = matricula;
            Nome = nome;

            Contador++;
        }

        public Aluno(long matricula)
        {
            Matricula = matricula;

            Contador++;
        }

        public Aluno(string nome)
        {
            Nome = nome;

            Contador++;
        }

        public void MostrarAtributos()
        {
            Console.WriteLine("Matricula: "+Matricula+ "\tNome: "+Nome);
        }
    }
}

//Entregar pelo Teams o arquivo Aluno.cs e Program.cs Até dia 20/09