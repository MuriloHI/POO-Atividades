using TrabalhoPOO;
Produto produto1 = new Produto(001, "Salgado", 4.00, 100);
Produto produto2 = new Produto (002, "Doce", 6.00, 50);

                            //qtde
ItemVenda iv1 = new ItemVenda(51, produto1); //2 * 4 = 8 
ItemVenda iv2 = new ItemVenda(1, produto2); //6 * 6 = 36

Venda venda = new Venda(DateTime.Now);
venda.VetVenda.Add(iv1);
venda.VetVenda.Add(iv2);

venda.CalcularTotal();
Console.WriteLine($"Total da venda: {venda.Total:c}");

Console.WriteLine("Escolha o método de pagamento:");
Console.WriteLine("1 - Espécie");
Console.WriteLine("2 - Cheque");
Console.WriteLine("3 - Cartão");
int escolha = int.Parse(Console.ReadLine());

Pagamento pagamento;
    switch (escolha)
    {
        case 1:
            Console.WriteLine("Informe a quantia em espécie:");
            double quantia = double.Parse(Console.ReadLine());
            pagamento = new Especie(DateTime.Now, venda.Total, quantia);
            ((Especie)pagamento).CalcularTroco();
            Console.WriteLine($"Troco: R${((Especie)pagamento).Troco:F2}");
            break;

        case 2:
            Console.WriteLine("Informe o número do cheque:");
            long numeroCheque = long.Parse(Console.ReadLine());
            Console.WriteLine("Informe a data de depósito:");
            DateTime dataDeposito = DateTime.Parse(Console.ReadLine());
            pagamento = new Cheque(DateTime.Now, venda.Total, numeroCheque, dataDeposito, 1);
            Console.WriteLine("Pagamento com cheque registrado.");
            break;

        case 3:
            Console.WriteLine("Informe os dados da transação do cartão:");
            string dadosTransacao = Console.ReadLine();
            pagamento = new Cartao(DateTime.Now, venda.Total, dadosTransacao, 1);
            Console.WriteLine("Pagamento com cartão registrado.");
            break;

        default:
            Console.WriteLine("Opção inválida.");
            return;
        }
venda.Pagamento = pagamento;
Console.WriteLine("Venda concluída com sucesso.");