using PrincipioLSP;

CartaoCredito cc1 = new CartaoCredito();
cc1.ProcessarPagamento(100.00m);

PayPal pp1 = new PayPal();
pp1.ProcessarPagamento(200.00m);

Especie especie1 = new Especie();
especie1.ProcessarPagamento(300.00m);