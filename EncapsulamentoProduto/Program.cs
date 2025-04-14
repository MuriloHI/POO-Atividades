using EncapsulamentoProduto;

Produto p1 = new Produto();

Console.Write("Digite o código do produto: ");
p1.Codigo = int.Parse(Console.ReadLine());
Console.Write("Digite o nome do produto: ");
p1.Nome = Console.ReadLine();
Console.Write("Digite o preço do produto: ");
p1.Preco = double.Parse(Console.ReadLine());
Console.Write("Digite a quantidade do produto: ");
p1.Qtde = int.Parse(Console.ReadLine());

Console.WriteLine($"Preço: {p1.Preco:c}") //get