using System;

public class Exercicio5
{
    static void Main()
    {
        Console.WriteLine("Responda com 'sim' ou 'não'.");

        Console.WriteLine("É mamífero? ");
        string resposta = Console.ReadLine().ToLower();

        if (resposta == "sim")
        {
            Console.WriteLine("É quadrúpede? ");
            resposta = Console.ReadLine().ToLower();

            if (resposta == "sim")
            {
                Console.WriteLine("É carnívoro? ");
                resposta = Console.ReadLine().ToLower();

                if (resposta == "sim")
                {
                    Console.WriteLine("O animal escolhido foi o leão.");
                }
                else
                {
                    Console.WriteLine("O animal escolhido foi o cavalo.");
                }
            }
            else
            {
                Console.WriteLine("É onívoro? ");
                resposta = Console.ReadLine().ToLower();

                if (resposta == "sim")
                {
                    Console.WriteLine("O animal escolhido foi o homem.");
                }
                else
                {
                    Console.WriteLine("O animal escolhido foi o macaco.");
                }
            }
        }
        else
        {
            Console.WriteLine("É uma ave? ");
            resposta = Console.ReadLine().ToLower();

            if (resposta == "sim")
            {
                Console.WriteLine("É uma ave não-voadora? ");
                resposta = Console.ReadLine().ToLower();

                if (resposta == "sim")
                {
                    Console.WriteLine("É tropical? ");
                    resposta = Console.ReadLine().ToLower();

                    if (resposta == "sim")
                    {
                        Console.WriteLine("O animal escolhido foi o avestruz.");
                    }
                    else
                    {
                        Console.WriteLine("O animal escolhido foi o pinguim.");
                    }
                }
                else
                {
                    Console.WriteLine("É uma ave nadadora? ");
                    resposta = Console.ReadLine().ToLower();

                    if (resposta == "sim")
                    {
                        Console.WriteLine("O animal escolhido foi o pato.");
                    }
                    else
                    {
                        Console.WriteLine("O animal escolhido foi a águia.");
                    }
                }
            }
            else
            {
                Console.WriteLine("O animal escolhido foi a baleia.");
            }
        }
    }
}
