using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class ContaCorrente
    {
        private double saldo;
        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        
        private double chequeEspecial;
        public double ChequeEspecial
        {
            get { return chequeEspecial; }
            set { chequeEspecial = value; }
        }

        public ContaCorrente(double saldoInicial, double chequeEspecial)
        {
            Saldo = saldoInicial;
            ChequeEspecial = chequeEspecial;
        }

        public void Depositar(double valor)
        {
            saldo += valor;
            Console.WriteLine($"Depósito de {valor:C} realizado. Saldo atual: {saldo:C}");
        }

        public void Sacar(double valor)
        {
            if (saldo + chequeEspecial >= valor)
            {
                saldo -= valor;
                Console.WriteLine($"Saque de {valor:C} realizado. Saldo atual: {saldo:C}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para saque.");
            }
        }

        public void GerarExtrato()
        {
            Console.WriteLine($"Saldo: {saldo:C}, Cheque Especial: {chequeEspecial:C}");
        }

        ~ContaCorrente()
        {
            Console.WriteLine("Destruindo a Conta Corrente.");
        }
    }
}