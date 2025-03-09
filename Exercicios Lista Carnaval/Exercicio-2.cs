using System;

namespace MyApp
{
    public class Exercicio2
    {
        static void Main(string[] args)
        {
            double Altura, PesoIdeal;
            string sexo;

            Console.WriteLine("Digite o sexo da pessoa - Masculino (M) ou Feminino (F):");
            sexo = Console.ReadLine().ToUpper();

            Console.WriteLine("Digite a altura da pessoa:");
            Altura = double.Parse(Console.ReadLine());

            if (sexo == "M")
            {
                PesoIdeal = (72.7 * Altura) - 58;
                Console.WriteLine($"O peso ideal é: {PesoIdeal:F2}kg.");
            }
            else if (sexo == "F") 
            {
                PesoIdeal = (62.1 * Altura) - 44.7;
                Console.WriteLine($"O peso ideal é: {PesoIdeal:F2}kg.");
            }
        }
    }
}