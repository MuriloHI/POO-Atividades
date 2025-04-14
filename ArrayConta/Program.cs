//Método Main()

using ArrayConta;

//Declara uma variávle como vetor da classe Conta
Conta[] vetContas = new Conta[3];

//Manipular/digitar valores dos atributos dentro de cada índice do vetor
for (int i=0 ; i<vetContas.Length ; i++)
{
    //Instâncie cada índice do vetor
    vetContas[i] = new Conta();
    //Manipule/cadastre/digite em cada índice do vetor os atributos
    Console.Write("Cadastre o número: ");
    vetContas[i].numero = int.Parse(Console.ReadLine());
    Console.Write("Cadastre o titulo: ");
    vetContas[i].titular = Console.ReadLine();
    Console.Write("Cadastre o saldo: ");
    vetContas[i].saldo = double.Parse(Console.ReadLine());
}
foreach (Conta c in vetContas)
    c.MostrarAtributos();