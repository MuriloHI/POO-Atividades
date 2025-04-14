using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoCliente
{
    public class Teste
    {
        public void AvaliarIdade(Cliente cliente) //Objeto da superclasse "cliente" pode representar os objetos das classes derivadas // tem que ser generalizado desse jeito
        {
            cliente.VerificarIdade();
        }
    }
}