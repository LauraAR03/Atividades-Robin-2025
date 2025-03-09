using System;
public class Exercicio6
{
    static void Main()
    {
        double S = 1.0;
        int numerador = 3;
        int denominador = 2;

        while (numerador <= 99 && denominador <= 50)
        {
            S += (double)numerador / denominador;
            numerador += 2;
            denominador++;
        }

        Console.WriteLine($"O valor de S é: {S:F2}");
    }
}