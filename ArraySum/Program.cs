class Program
{
    static void Main(string[] args)
    {
        // Esse era o desafio da entrevista para a Dell

        /* Desafio:
         Dado uma array e um número X, descubra se a soma de dois elementos da array davam o número X. Retornar VERDADEIRO se sim, ou FALSO se não

        Input: arr[] = { 0, -1, 2, -3, 1 }, x = -2
        Output: Sim
        Explanation:  Se calcularmos a soma do Output,1 + (-3) = -2

        Input: arr[] = { 1, -2, 1, 0, 5 }, x = 0
        Output: Nao */

        // Exemplo de Não
        //int[] arrayDeInteiros = { 1, -2, 1, 0, 5 };
        //int numeroX = 0;

        // Exemplo de Sim
        int[] arrayDeInteiros = { 0, -1, 2, -3, 1 };
        int numeroX = -2;

        for (int i = 0; i < arrayDeInteiros.Length; i++)
        {
            for (int j = 0; j < arrayDeInteiros.Length; j++)
            {
                if (i != j)
                {
                    if(arrayDeInteiros[i] + arrayDeInteiros[j] == numeroX)
                    {
                        Console.WriteLine("Sim");
                        Console.WriteLine(arrayDeInteiros[i] + " + " + arrayDeInteiros[j] + " = " + numeroX);
                        return;
                    }
                }
            }
        }

        Console.WriteLine("Nao");
        return;

    }
}