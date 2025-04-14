using AgregacaoVenda;

Comprador comp = new Comprador(4000.00); //4000 de verba
comp.MostrarAtributos();
Vendedor vende = new Vendedor(); //comissão
Produto prod1 = new Produto(500, "CAMISA", 1000.00); //código , produto , preço
Produto prod2 = new Produto(2, "SAPATO", 2000.00);

Venda vend_a = new Venda(); //instancia a Venda (que é a classe "principal")
vend_a.VetProd = new List<Produto>(); //AGREGRAÇÃO EXECUTOU!!

vend_a.VetProd.Add(prod1);
vend_a.VetProd.Add(prod2);

foreach (Produto pr in vend_a.VetProd) //mostra TODOS os produtos e seus ATRIBUTOS
    pr.MostrarAtributos();

vend_a.MostrarAtributos(); //mostra valor total da venda

//Quando realizar uma venda subtraia o valor da verba
double valor_total_venda = prod1.Preco + prod2.Preco;
double subtracao = comp.Verba - valor_total_venda;
Console.WriteLine("O valor da venda menos o valor da verba é de: "+subtracao);

//A comissão do vendedor é gerada referente a 2% dopreço do produto vendido
vende.Comissao = valor_total_venda * 0.02;
Console.WriteLine("Após a venda, a comissão do vendedor é de R$: "+vende.Comissao);



