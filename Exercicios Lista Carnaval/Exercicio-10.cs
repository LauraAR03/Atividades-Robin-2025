using System;

public class Exercicio10
{
    static void Main()
    {
        int[,] matriz = new int[4, 4];

        Console.WriteLine("Digite os valores da matriz 4x4:");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write($" [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
      
        int A = 0;
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                A += matriz[i, j];
            }
        }

        int B = 0;
        for (int i = 2; i < 4; i++)
        {
            for (int j = 2; j < 4; j++)
            {
                B += matriz[i, j];
            }
        }

        int C = 0;
        for (int i = 0; i < 4; i++)
        {
            for (int j = i + 1; j < 4; j++)
            {
                C += matriz[i, j];
            }
        }

        int D = 0;
        for (int i = 1; i < 4; i++)
        {
            for (int j = 0; j < i; j++)
            {
                D += matriz[i, j];
            }
        }

        Console.WriteLine("\nSomas das partes hachuradas:");
        Console.WriteLine($"(a) Quadrante superior esquerdo: {A}");
        Console.WriteLine($"(b) Quadrante inferior direito: {B}");
        Console.WriteLine($"(c) Triângulo superior direito: {C}");
        Console.WriteLine($"(d) Triângulo inferior esquerdo: {D}");
    }
}