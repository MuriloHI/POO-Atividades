using InterfaceTributavel;

ContaCorrente cc1 = new ContaCorrente();
cc1.Saldo = 1000.00;
Console.WriteLine($"O saldo de {cc1.Saldo:c} após o calculo de tributos passou a ser de {cc1.CalculaTributos():c}");

SeguroDeVida sdv1 = new SeguroDeVida();
Console.WriteLine($"O valor do seguro de vida é: {sdv1.CalculaTributos():c}");

TotalizadorDeTributos totalizador = new TotalizadorDeTributos();

totalizador.Adicional(cc1);
totalizador.Adicional(sdv1);
Console.WriteLine($"Total de tributos acumulados: {totalizador.Total:c}");