using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoCliente
{
    public class ClienteFisico : Cliente //ClienteFisico é uma classe concreta, porque não é uma classe abstrata
    {
        public int Rg { get; set; }
        public ClienteFisico(int codigo, string nome, int idade, int rg) : base(codigo, nome, idade)
        {
            Rg = rg;
        }

        public override void MostrarAtributos()
        {
            base.MostrarAtributos();
            Console.WriteLine("Rg: " + Rg);
        }

        public override void VerificarIdade()
        {
            if (Idade >= 18 && Idade <= 40)
                Console.WriteLine("Cliente Físico");
        }
    }
}