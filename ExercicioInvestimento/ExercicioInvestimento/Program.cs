using System;

namespace ExercicioInvestimento
{
    public class Program
    {
        public static void Main(string[] args)
        {
            InvestimentoComIR investimentoComIR = new InvestimentoComIR(5000, 1.2);
            double valorLucroComIR = Math.Round(investimentoComIR.calcularLucro(17), 2);
            Console.WriteLine($"O valor do lucro do investimento foi de: R${valorLucroComIR}");

            InvestimentoSemIR investimentoSemIR = new InvestimentoSemIR(3000, 0.7);
            double valorLucroSemIR = Math.Round(investimentoSemIR.calcularLucro(17), 2);
            Console.WriteLine($"O valor do lucro do investimento foi de: R${valorLucroSemIR}");

            Console.ReadLine();
        }
    }
}
