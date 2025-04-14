using ComposicaoBanco;

Banco banco = new Banco();
banco.IniciarBanco();

ContaCorrente contaCorrente = new ContaCorrente(500.00, 1000.00);
banco.AbrirConta(contaCorrente);

Poupanca poupanca = new Poupanca(1000.00);
banco.AbrirPoupanca(poupanca);

contaCorrente.Depositar(200.00);
contaCorrente.Sacar(100.00);
contaCorrente.GerarExtrato();

poupanca.Depositar(300.00);
poupanca.GerarRendimento(0.05); // 5% de rendimento
poupanca.Sacar(150.00);