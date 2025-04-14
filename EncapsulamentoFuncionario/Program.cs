using EncapsulamentoFuncionario;

Funcionario f1 = new Funcionario();
Console.WriteLine("Digite o salário: ");
f1.Salario = decimal.Parse(Console.ReadLine()); //set

f1.CalcularAumento(5);
Console.WriteLine($"Salário após o aumento {f1.Salario:c}"); //get