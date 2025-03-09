using System;

public class Exercicio9
{
    static void Main()
    {

        double[] notas = new double[6];

       
        Console.WriteLine("Digite as 6 notas dos juízes (de 0 a 10):");
        for (int i = 0; i < 6; i++)
        {
            Console.Write($"Nota {i + 1}: ");
            notas[i] = double.Parse(Console.ReadLine());
        }

        double maiorNota = notas[0];
        double menorNota = notas[0];

        for (int i = 1; i < 6; i++)
        {
            if (notas[i] > maiorNota)
                maiorNota = notas[i];
            if (notas[i] < menorNota)
                menorNota = notas[i];
        }

        double soma = 0;
        for (int i = 0; i < 6; i++)
        {
            if (notas[i] != maiorNota && notas[i] != menorNota)
            {
                soma += notas[i];
            }
        }

        Console.WriteLine($"A nota final do atleta é: {soma}");
    }
}
