using System;

public class Exercicio8
{
    static void Main()
    {
        int[] D = new int[20];

        Console.WriteLine("Digite 20 elementos para o vetor D:");
        for (int i = 0; i < 20; i++)
        {
            Console.Write($"Elemento {i + 1}: ");
            D[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Digite o valor de N: ");
        int N = int.Parse(Console.ReadLine());

        Console.WriteLine($"Elementos maiores que {N} no vetor D:");
        for (int i = 0; i < 20; i++)
        {
            if (D[i] > N)
            {
                Console.Write(D[i] + " ");
            }
        }

        Console.WriteLine();
    }
}
