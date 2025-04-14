using ConstrutorAluno;

Aluno a1 = new Aluno(1570482313000+Aluno.Contador, "Murilo");
a1.MostrarAtributos();

Aluno a2 = new Aluno (1570482313000+Aluno.Contador, "Marcia");
a2.MostrarAtributos();

Aluno a3 = new Aluno (1570482313000+Aluno.Contador,"Ely");
a3.MostrarAtributos();

Console.WriteLine("A quantidade de instâncias foi de: "+Aluno.Contador);