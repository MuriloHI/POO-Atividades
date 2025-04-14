using PrincipioSRP;

Conta c1 = new Conta("Murilo");
ValidadorUsuarios validador = new ValidadorUsuarios();
GeradorRelatorios geradorRelatorios = new GeradorRelatorios();

c1.Deposito(500);
c1.Sacar(100);

                    
bool usuarioValido = validador.ValidarUsuario(c1.Titular, "Murilo");

if (!usuarioValido)
{
    Console.WriteLine("Usuário inválido!");
}
else
{
    string relatorio = geradorRelatorios.GerarRelatorio(c1.Titular, c1.Saldo);
    Console.WriteLine(relatorio);
}





