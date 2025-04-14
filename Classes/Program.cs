// Função Main()
using Classes; //autoriza usar os arquivos da pasta Classes


//tipo - nomeDoObjeto
Conta objetoConta; //declarando a variável objetoConta / tipo classe


objetoConta = new Conta(); //instanciando objeto
objetoConta.numero = 1;
objetoConta.titular = "John";
objetoConta.saldo = 100;
objetoConta.MostrarAtributos();
objetoConta.Depositar(30);
objetoConta.MostrarAtributos();
/*
           //instância de objeto

Conta c1 = new Conta();
/ classe / nome do obj = ALOCAÇÃO DE MEMÓRIA / construtor da classe
  tipo
  de dado     variável        
            da instância

Console.Write("Digite o número da conta: ");
c1.numero = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite o titular da conta: ");
c1.titular = Console.ReadLine();
Console.Write("Digite o saldo da conta: ");
c1.saldo = Convert.ToDouble(Console.ReadLine());
c1.MostrarAtributos(); */

Conta c2 = new Conta();
c2.numero = 2;
c2.titular = "Jane";
c2.saldo = 110;
c2.MostrarAtributos();
c2.Sacar(30);
c2.MostrarAtributos();

Console.WriteLine($"Valor descontado do Iof {c2.Descontar(4.37):c}");
c2.MostrarAtributos();

//Realizando a transferência 
c2.Transferencia(50, objetoConta);
c2.MostrarAtributos();
objetoConta.MostrarAtributos();