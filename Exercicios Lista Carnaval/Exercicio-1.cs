using System;

namespace Myapp
{
    public class Exercicio1
    {
        static void Main(string[] args)
        {
            int VendaMediaMensal;
            double CurrentPrice = 30;
            double newCharge;

            Console.WriteLine("Qual foi a média de venda mensal?");
            VendaMediaMensal = int.Parse(Console.ReadLine());

            if (VendaMediaMensal< 500)
            {
                newCharge = CurrentPrice * 1.10;

                Console.WriteLine("O novo valor é:" + newCharge);
            }
            else
            {
                newCharge = CurrentPrice * 0.80;

                Console.WriteLine("O novo valor é:" + newCharge);
            }
        }
    }
}