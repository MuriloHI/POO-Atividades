using AgregacaoArrayConta;

Cliente cli1 = new Cliente("Ana",10,11111);
Cliente cli2 = new Cliente("Bia",20,222222);

Conta c = new Conta();
c.Numero = 1;
c.Saldo = 10000;
c.VetTitulares = new List<Cliente>();
c.VetTitulares.Add(cli1);
c.VetTitulares.Add(cli2);

foreach (Cliente ci in c.VetTitulares)
    Console.WriteLine("Nome: "+ci.Nome);