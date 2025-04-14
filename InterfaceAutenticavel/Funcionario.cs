using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticavel
{
    public class Funcionario
    {
        public int Senha {get; set;}
        public void Mostrar()
        {
            Console.WriteLine("Senha: " + Senha);
        }
    }
}