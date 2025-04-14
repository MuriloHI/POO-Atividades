using ComposicaoNotaFiscal;

internal class Program
{

    private static void Main(string[] args)
    {
        ItemNotaFiscal it1 = new ItemNotaFiscal(4);
        ItemNotaFiscal it2 = new ItemNotaFiscal(10);

        NotaFiscal nf = new NotaFiscal(1,"20/09/2024");
        nf.VetItens.Add(it1);
        nf.VetItens.Add(it2);

        foreach (ItemNotaFiscal it in nf.VetItens)
            Console.WriteLine("Qtde: "+it.Qtde);

        nf = null;
        GC.Collect();
    }

}