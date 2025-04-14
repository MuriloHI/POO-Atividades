using HerancaCliente;

Cliente c = new Cliente();
c.Codigo = 1;
c.Nome = "Ana";
c.MostrarAtributos();

ClienteFisico cf = new ClienteFisico();
cf.Codigo = 2;
cf.Nome = "Bia";

cf.Cpf = 222222;
cf.Rg = 22;
cf.MostrarAtributos();

ClienteFisico cf2 = new ClienteFisico(3,"Leo",333333,33);
cf2.MostrarAtributos();

Cliente c2 = new Cliente(4,"Teo");
c2.MostrarAtributos();
