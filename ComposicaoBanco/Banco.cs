using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class Banco
    {
        private List<Poupanca> vetPoups;
        public List<Poupanca> VetPoups
        {
            get { return vetPoups; }
            set { vetPoups = value; }
        }
        
        private List<ContaCorrente> vetContas;
        public List<ContaCorrente> VetContas
        {
            get { return vetContas; }
            set { vetContas = value; }
        }
        
        public Banco()
        {
            VetPoups = new List<Poupanca>();
            VetContas = new List<ContaCorrente>();
        }

        public void AbrirConta(ContaCorrente conta)
        {
            VetContas.Add(conta);
            Console.WriteLine("Conta Corrente aberta com sucesso.");
        }
        public void AbrirPoupanca(Poupanca poupanca)
        {
            VetPoups.Add(poupanca);
            Console.WriteLine("Poupança aberta com sucesso.");
        }

        public void IniciarBanco()
        {
            Console.WriteLine("Banco iniciado.");
        }

        public void DecretarFalencia()
        {
            VetContas.Clear();
            VetPoups.Clear();
            Console.WriteLine("Falência decretada. Todas as contas foram encerradas.");
        }
        ~Banco()
        {
            Console.WriteLine("Destruindo o Banco");
        }
    }
}