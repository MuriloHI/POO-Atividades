using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoCliente
{
    public class CllienteJuridico : Cliente
    {
        public int Cnpj { get; set; }
        public CllienteJuridico(int codigo, string nome, int idade, int cnpj) : base(codigo, nome, idade)
        {
            Cnpj = cnpj;
        }

        public override void MostrarAtributos()
        {
            base.MostrarAtributos();
            Console.WriteLine("CNPJ: " + Cnpj);
        }

        public override void VerificarIdade() //Se o método da classe mãe for "abstract", a classe derivada será override, só que com uma lógica
        {
            if (Idade >= 41)
                Console.WriteLine("Cliente Jurídico");
        }
    }
}