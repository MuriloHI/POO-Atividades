using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoAluno
{
    public class Aluno
    {
        //Criar os atributos e encapsulamentos necessários dos atributos: matrícula, nome, p1, p2, media;
        private int matricula;
        public int Matricula
        {
            get { return matricula; } 
            set { //Trate os atributos matricula para não cadastrar valor zero ou negativo (fazer if e retorno)
                if (value > 0)
                    matricula = value;
                else
                    Console.WriteLine("Matrícula inválida");
                }
        }
        
        private string nome; 
        public string Nome
        {
            get { return nome.ToUpper(); }//No atributo nome, retorne em letras maiúsculas

            set { nome = value; }
        }
        
        private double p1;
        public double P1
        { //get -> ler // set -> modifica
            get { return p1; }
            set { //Trate os atributos p1 para não cadastrar valor zero ou negativo (fazer if e retorno)
                if (value > 0)
                    p1 = value;
                else
                    Console.WriteLine("P1 inválida");
            }
        }

        private double p2;
        public double P2
        {
            get { return p2; }
            set { //Trate os atributos p2 para não cadastrar valor zero ou negativo (fazer if e retorno)
                if (value > 0)
                    p2 = value;
                else
                    Console.WriteLine("P2 inválida");
             }
        }

        private double media;
        public double Media
        {
            get { return media; }//O atributo média não tera set pq vc tem uma regra de negócio CalcularMedia() que vai alterar 

            //set { media = value; } //se eu colocar essa linha eu POSSO usar as propriedades Media na linha 64
        }
        //Criar um método para CalcularMedia() 
        public void CalcularMedia() {
            media = (p1 + p2)/2; //altera a média (é o "set" praticamente)
        }

        //Criar o método MostrarAtributos()
        public void MostrarAtributos() {
            Console.WriteLine("Nome: "+nome+ "\tMatrícula: "+matricula+
            "\tP1 : "+p1+"\tP2 : "+p2+ "\tMédia : "+media);
        }
    }
}