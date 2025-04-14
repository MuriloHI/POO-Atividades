using HerancaFuncionario;

GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

Secretario s = new Secretario(2, "Secretário_B", 1000);
s.MostrarAtributos();
Console.WriteLine($"Valor Bonificação {s.CalcularBonificacao():c}");
gerenciador.TotalizadorBonificacao(s); //Somando a bonificação do secretário


Gerente g = new Gerente(3, "Gerente_C", 1000);
g.MostrarAtributos();
Console.WriteLine($"Valor Bonificação {g.CalcularBonificacao():c}");
gerenciador.TotalizadorBonificacao(g); //Somando a bonificação do gerente


Diretor d = new Diretor(4, "Diretor_D", 1000);
d.MostrarAtributos();
Console.WriteLine($"Valor Bonificação {d.CalcularBonificacao():c}");
gerenciador.TotalizadorBonificacao(d); //Somando a bonificação do diretor

Console.WriteLine($"Total de Bonificações: {gerenciador.TotalBonificacao:c}");

