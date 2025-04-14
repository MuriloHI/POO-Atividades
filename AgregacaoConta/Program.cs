using AgregacaoConta;

Cliente cli = new Cliente("Ana",20,11111111);

Conta c1 = new Conta();
c1.Numero = 1;  //se tem sinal de =, é o set que está sendo atribuido
c1.Saldo = 100;
c1.Titular = cli; //aqui vc realmente está executando a sua agregração
//Titular deixou de set atributo e passou a ser Objeto

Conta c2 = new Conta();
c2.Numero = 2;
c2.Saldo = 200;
c2.Titular = new Cliente();
c2.Titular.Nome = "Bia";
c2.Titular.Idade = 20;
c2.Titular.Telefone = 222222;
