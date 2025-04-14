using ConstrutorConta;

Conta c1 = new Conta();
//Criar o método mostrar e chamar após cada instância
c1.MostrarAtributos();

Conta c2 = new Conta(120);
c2.MostrarAtributos();

Conta c3 = new Conta(200, "Ana");
c3.MostrarAtributos();