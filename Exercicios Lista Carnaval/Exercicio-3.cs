using System;

namespace MyApp
{
    public class Exercicio3
    {
        static void Main(string[] args)
        {
            string[] diasDaSemana = new string[8];
            int numero;

            diasDaSemana [0] = "Domingo";
            diasDaSemana [1] = "Segunda-Feira";
            diasDaSemana [2] = "Terça-Feira";
            diasDaSemana [3] = "Quarta-Feira";
            diasDaSemana [4] = "Quinta-Feira";
            diasDaSemana [5] = "Sexta-Feira";
            diasDaSemana [6] = "Sabado";

            Console.WriteLine("Escreva um número inteiro entre 1 e 7:");

            numero = int.Parse(Console.ReadLine());

            if (numero >= 0 && numero <= 7)
            {
                Console.WriteLine("O dia da semana é:" + diasDaSemana[numero - 1]);
            }

            else
            {
                Console.WriteLine("Número inválido, tente um número entre 1 e 7");
            }
        }
    }
}