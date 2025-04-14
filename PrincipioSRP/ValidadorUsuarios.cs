using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrincipioSRP
{
    public class ValidadorUsuarios
    {
        public bool ValidarUsuario(string titularDaConta, string nomeParaValidacao)
        {
            return titularDaConta == nomeParaValidacao;
        }
    }
}