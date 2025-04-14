using EncapsulamentoConta;

Conta c1 = new Conta();
/* MODELO JAVA OU PHP
c1.setNumero(1);
Console.WriteLine("Número: "+c1.getNumero()); */

c1.Numero = 1; //set (tem sinal de atribuição)
Console.WriteLine("Número: "+c1.Numero); //get (não tem sinal de atribuição)
//if (c1.Numero == 10) get
