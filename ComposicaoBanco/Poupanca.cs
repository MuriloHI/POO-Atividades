using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class Poupanca
    {
        private double saldo;
        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public Poupanca(double saldoInicial)
        {
            Saldo = saldoInicial;
        }

        public void Sacar(double valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine($"Saque de {valor:C} realizado. Saldo atual: {saldo:C}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para saque.");
            }
        }

        public void Depositar(double valor)
        {
            saldo += valor;
            Console.WriteLine($"Depósito de {valor:C} realizado. Saldo atual: {saldo:C}");
        }

        public void GerarRendimento(double taxa)
        {
            double rendimento = saldo * taxa;
            saldo += rendimento;
            Console.WriteLine($"Rendimento de {rendimento:C} gerado. Saldo atual: {saldo:C}");
        }

        ~Poupanca()
        {
            Console.WriteLine("Destruindo a Poupança.");
        }
    }
}