//Método Main()
using ClasseFuncionario;

//Realizar instâncias
Funcionario f1 = new Funcionario();

f1.codigo = 17;
f1.nome = "Murilo";
f1.salario = 200;
f1.MostrarAtributos();

f1.AumentoSalarial(50.00);
f1.MostrarAtributos();