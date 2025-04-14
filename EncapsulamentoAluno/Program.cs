using EncapsulamentoAluno;

Aluno a1 = new Aluno();

Console.Write("Digite o nome do aluno: ");
a1.Nome = Console.ReadLine(); //usa a propriedade Nome pq ela é PÚBLICA, o atributo nome é privado.

Console.Write("Digite a matrícula do aluno: ");
a1.Matricula = int.Parse(Console.ReadLine());

Console.Write("Digite a nota da p1: ");
a1.P1 = double.Parse(Console.ReadLine());

Console.Write("Digite a nota da p2: ");
a1.P2 = double.Parse(Console.ReadLine());

a1.CalcularMedia();
a1.MostrarAtributos();