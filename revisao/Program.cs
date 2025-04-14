internal class Program
{
    private static void Main(string[] args)
    {
        /*
        Console.WriteLine("Digite seu ano de nascimento: ");
        int ano = int.Parse(Console.ReadLine());
        int idade = 2024 - ano;
        System.Console.WriteLine("Sua idade é de "+idade+ " anos");
        if (idade >= 18)
            System.Console.WriteLine("Maior de idade");
        else if (idade == 1)
            System.Console.WriteLine("É um bebê");
        else 
            System.Console.WriteLine("Menor de idade");


        //estrutura de condicional de multipla escolha
        int opcao = 3;
        switch (opcao) //não serve para float
        {
            case 1: Console.WriteLine("1 - Somar"); //se opcao for igual a 1
                    //qualquer lógica
                    break;
            case 2: Console.WriteLine("2 - Subtrair");
                    //qualquer lógica
                    break;
            default: System.Console.WriteLine("Opção Inválida!");
                    break;
        }

        //Estruturas de repetição
        int num = 1;
        while (num <= 10)
        {
            System.Console.WriteLine("5 x "+num+" = " +num*5);
            num++;
        }

        for (int tabuada = 1; tabuada <= 10; tabuada++) //só coloca {} se tiver mais de uma linha
            for (int num = 1; num <= 10; num++)
                System.Console.WriteLine(tabuada+ " x "+num+" = " +num*tabuada);

        int num = 1;
        do 
        {
            System.Console.WriteLine("9 x "+num+" = " +num*9);
            num++;
        } while(num <= 10);
        */

        int[] vetor = new int[3];
        vetor[0] = 99;
        vetor[1] = 88;
        vetor[2] = 77;
        foreach (int vet in vetor)
            System.Console.WriteLine(vet); //
        System.Console.WriteLine("Exemplo com for");
        for (int i = 0; i < vetor.Length; i++)
        {
            System.Console.WriteLine(vetor[i]);
        }
    }
}