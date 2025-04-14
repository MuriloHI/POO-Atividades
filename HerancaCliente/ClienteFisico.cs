using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{   //          ClasseDerivada : ClasseBase
    public class ClienteFisico : Cliente
    {
        public int Cpf { get; set; } //Esse prop pq seu atributo É PRIVATE
        public int Rg { get; set; }


        //Polimorfismo está ocorrendo por cause do override (ele indica o polimorfismo), vc está alterando o método.
        public override void MostrarAtributos() 
        {
            base.MostrarAtributos(); //chama o método da superclasse (classe mãe)
            Console.WriteLine("CPF: "+Cpf+"\tRG: "+Rg);
        }

        public ClienteFisico(int codigo, string nome, int cpf, int rg) : base(codigo, nome)
        {
            Cpf = cpf;
            Rg = rg;
        }

        public ClienteFisico() : base() 
        //constutor padrão
        //base() -> chama o construtor
        //base.Metodo() -> chama o método da classe base
        {

        }
    }
}