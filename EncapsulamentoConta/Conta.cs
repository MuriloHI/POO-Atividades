using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoConta
{
    public class Conta
    {
        private int numero; //O atributo está encapsulado
        private string titular;
        private double saldo;
        
        /* EXEMPLO DE MÉTODO DE ENCAPSULAMENTO - MODELO JAVA OU PHP
        public void setNumero(int numero)
        {
            this.numero = numero;
        }

        public int getNumero()
        {
            return this.numero;
        }
        */

        //CONVENÇÃO C# 
        public int Numero //propriedade (dentro da propriedade está o set e o get)
        {                   //Numero é propriedade - numero é atributo
            set
            {
                if (value > 0)
                    this.numero = value;
            }
            get
            {
                return numero;
            }
        }

        public string Titular
        {
            get { return titular.ToUpper(); }
            set { 
                if (value != "")
                    titular = value;
                else
                    Console.WriteLine("Nome inválido.");
                }
        }
        
        public double Saldo
        {
            get { return saldo; }
            //set { saldo = value; }
        }
        

        

        public void MostrarAtributos()
        {
            Console.WriteLine("Número: "+numero+ "\tTitular: "+titular+
            "\tSaldo R$ "+saldo);
        }
        public void Sacar(double valorSaque)
        {
            saldo = saldo - valorSaque;
        }
        public void Depositar(double valorDeposito)
        {
            saldo = saldo + valorDeposito;
        }
        //desenvolva um método para calcular IOF % desconte
        //retorne o valor que será descontado e apresente na main()
        public double Descontar (double porcentagem) //se tem return NÃO usa void
        {
            double valorDescontado = saldo * porcentagem/100;
            saldo -= valorDescontado; // saldo = saldo - valorDescontado
            return valorDescontado;
        }
        public void Transferencia(double valorTranferencia, Conta outraConta)
        {
            saldo = saldo - valorTranferencia;
            outraConta.saldo = outraConta.saldo + valorTranferencia;
        }
    }
}