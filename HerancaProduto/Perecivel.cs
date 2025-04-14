using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaProduto
{
    public class Perecivel : Produto
    {
        protected string dtValidade;
        protected string dtFabricaolote;
        public string DtValidade
        {
            get { return dtValidade; }
            set { dtValidade = value; }
        }
        public string DtFabricaolote
        {
            get { return dtFabricaolote; }
            set { dtFabricaolote = value; }
        }
        
        public override void MostrarAtributos() 
        {
            base.MostrarAtributos(); //chama o método da superclasse (classe mãe)
            Console.WriteLine("Data de Validade: "+DtValidade+"\tData de Fabricação de Lote: "+DtFabricaolote);
        }

        //No parâmetro do construtor da classe filha, tem que ter TODOS os atributos da classe mãe + os novos da filha
        public Perecivel(int codigo, string nome, double preco, string dtValidade, string dtFabricaolote) : base(codigo, nome, preco)
        //mas depois precisa ter o : base(atributos da mãe)
        {
            DtValidade = dtValidade;
            DtFabricaolote = dtFabricaolote;
        }

        //nesse exemplo não precisa de um construtor padrão já que na main só tem o construtor de 3 e 5 parâmetros
    }
}