// Método Main()
using InterfaceAutenticavel;

Gerente g = new Gerente();
g.Senha = 423;
//g.Mostrar();

Cliente c = new Cliente();
c.Senha = 200;

//IAutenticavel ia = new IAutenticavel(); erro de compilação
IAutenticavel ia = g;
Console.WriteLine("Acessou o sistema? " + ia.Autentica(123));

ia = c;
Console.WriteLine("\n\nAcessou o sistema? " + ia.Autentica(200));

