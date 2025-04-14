using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticavel
{//      classe derivada : classe base, interface
    public class Gerente : Funcionario, IAutenticavel
    {
        public bool Autentica(int senha)//este método liga com a interface
        {
            if (Senha == senha)
            {
                Console.WriteLine("Gerente autenticado!");
                return true;
            }
            return false;
        }
    }
}