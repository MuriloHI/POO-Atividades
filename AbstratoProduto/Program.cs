using AbstratoProduto;

Disco d = new Disco(01, 100.00, "MRLO", "Gravadora Atlantic");
Livro l = new Livro(02, 20.00, "Clarice Lispector", 12222);

Console.WriteLine($"Disco - Artista: {d.Artista}, Gravadora: {d.Gravadora}, Preço: {d.Preco:C}");
Console.WriteLine($"Livro - Autor: {l.Autor}, ISBN: {l.Isbn}, Preço: {l.Preco:C}");

d.AtualizarPreco(400.00);
l.AtualizarPreco(5.00);