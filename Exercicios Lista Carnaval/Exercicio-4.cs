using System;

namespace MyApp
{
    public class Exercicio4
    {
        static void Main(string[] args)
        {
            double TrabalhoSemanal = 40;
            double HorasTrabalhadas;
            double Salario = 1640;
            double NovoSalario;
            double HorasExtras;
            double SalarioHora;
            double SalarioExtra;

            Console.WriteLine("Escreva as horas trabalhadas:");
            HorasTrabalhadas = int.Parse(Console.ReadLine());



            if (HorasTrabalhadas > 40)
            {
                HorasExtras = HorasTrabalhadas - TrabalhoSemanal;
                SalarioHora = Salario / TrabalhoSemanal;
                SalarioExtra = HorasExtras * SalarioHora * 1.5;
                NovoSalario = Salario + SalarioExtra;

                Console.WriteLine($"Salário é {NovoSalario:F2}");
            }




        }
    }
}