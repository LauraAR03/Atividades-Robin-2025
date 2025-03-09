using System;

public class Exercicio7
{
    static void Main()
    {
      
        int[] gabarito = new int[5];

      
        Console.WriteLine("Digite os 5 n�meros do gabarito:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"N�mero {i + 1}: ");
            gabarito[i] = int.Parse(Console.ReadLine());
        }

        int[] aposta = new int[10];

       
        Console.WriteLine("Digite os 10 n�meros da sua aposta:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"N�mero {i + 1}: ");
            aposta[i] = int.Parse(Console.ReadLine());
        }

        int pontos = 0;
        for (int i = 0; i < 5; i++)  
        {
            for (int j = 0; j < 10; j++)  
            {
                if (gabarito[i] == aposta[j])  
                {
                    pontos++;
                    break;  
                }
            }
        }

        Console.WriteLine($"Voc� acertou {pontos}");
    }
}