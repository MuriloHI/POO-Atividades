//Método Main()
using ArrayProduto;

//Declarar uma variável vetorProdutos[3];
Produto[] vetProdutos = new Produto[3];

double multiplicar = 0;
//Cadastrar estes produtos
for (int i=0; i<vetProdutos.Length; i++)
{
    vetProdutos[i] = new Produto();
    Console.Write("Digite o código do produto: ");
    vetProdutos[i].codigo = int.Parse(Console.ReadLine());
    Console.Write("Digite o nome do produto: ");
    vetProdutos[i].nome = Console.ReadLine();
    Console.Write("Digite o preço do produto: ");
    vetProdutos[i].preco = double.Parse(Console.ReadLine());
    Console.Write("Digite a quantidade do produto: ");
    vetProdutos[i].qtde = int.Parse(Console.ReadLine());
    
    //Calcular o valor total (soma) dos preços, lembrando de multiplicar a quantidade pelo preço e apresente
    multiplicar = multiplicar + vetProdutos[i].preco * vetProdutos[i].qtde;
}

Console.WriteLine($"Soma total: {multiplicar:c}");

foreach (Produto p in vetProdutos)
    p.MostrarAtributos();