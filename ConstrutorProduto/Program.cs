using ConstrutorProduto;

Produto p1 = new Produto();
p1.MostrarAtributos();
Produto p2 = new Produto(560);
p2.MostrarAtributos();
Produto p3 = new Produto(570, "Ely", 30.00);
p3.MostrarAtributos();

Console.WriteLine("Quantidade de instâncias: "+Produto.Cont);