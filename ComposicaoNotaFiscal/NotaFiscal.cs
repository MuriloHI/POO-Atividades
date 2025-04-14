using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
    public class NotaFiscal
    {
        public int NumeroNf { get; set; }
        public string Data { get; set; }
        //A composição é estabelecidada
        public List<ItemNotaFiscal> VetItens { get; set; }


        public NotaFiscal(int numeroNf, string data)
        {
            NumeroNf = numeroNf;
            Data = data;
            //Execução da composição
            VetItens = new List<ItemNotaFiscal>();
        }

        ~NotaFiscal(){
            VetItens = null; //liberação do objeto
            Console.WriteLine("Destruindo o objeto Nota Fiscal");
        }
    }
}