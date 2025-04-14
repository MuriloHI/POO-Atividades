using AbstratoFuncionario;

Assalariado a1 = new Assalariado(1, "Ana", 1000);
Assalariado a2 = new Assalariado(2, "Bel", 1000);
Comissionado c1 = new Comissionado(3, "Bia", 1000, 0.2);
Comissionado c2 = new Comissionado(4, "Leo", 1000, 0.30);

Departamento d1 = new Departamento(10, "DEV");
d1.VetF = new List<Funcionario>();
d1.Admitir(a1); //d1 recebeu um funcionario assalariado
d1.Admitir(c1); //e recbeu um funcionario comissionado
d1.ListarFuncionarios(); //apresentação para ver se está correto no vetor
Console.WriteLine($"Total da folha {d1.CalcularFolha(30):c}");

Departamento d2 = new Departamento(11, "REDES");
d2.VetF = new List<Funcionario>();
d2.Admitir(a2);
d2.Admitir(c2);
d2.ListarFuncionarios();
Console.WriteLine($"Total da folha {d1.CalcularFolha(30):c}");

//EXERCÍCIO AMPLIADO
Dependente dep1 = new Dependente(1, "Murilo", 20);
Dependente dep2 = new Dependente(2, "Vinicius", 17);
Dependente dep3 = new Dependente(3, "Vitor", 22);

a1.VetDepen.Add(dep1); //coloca o dep1 ao funcionario a1 // Codigo = 1 , 20 anos (pode ser removido)
a1.VetDepen.Add(dep2); //coloca o dep2 ao funcionario a1 // Codigo = 2
a1.VetDepen.Add(dep3); //coloca o dep3 ao funcionario a1 // Codigo = 3

a1.RemoverDependentesMaioridade(1); //vai remover sim o dep1 já que ele tem >=18 anos

Console.WriteLine("\nDependentes de Ana após a remoção:");
foreach (var dep in a1.VetDepen)
{
    Console.WriteLine($"{dep.Nome}, {dep.Idade} anos");
}