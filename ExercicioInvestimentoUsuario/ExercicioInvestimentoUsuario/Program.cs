using ExercicioInvestimento;
using System;

namespace ExercicioInvestimentoUsuario
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Informe o valor do investimento inicial: R$");
            double valorInicialUsuario = Double.Parse(Console.ReadLine());

            InvestimentoComIR investimentoComIR = new InvestimentoComIR(valorInicialUsuario, 0.35);
            InvestimentoSemIR investimentoSemIR = new InvestimentoSemIR(valorInicialUsuario, 0.3);

            for (int i = 1; i <= 36; i++)
            {

                double lucroComIR = Math.Round(investimentoComIR.calcularLucro(i), 2);
                double lucroSemIR = Math.Round(investimentoSemIR.calcularLucro(i), 2);

                Console.WriteLine($"Mês: {i} | Investimento sem IR: {lucroSemIR} | Investimento com IR: {lucroComIR}");
            }

            Console.ReadLine();
        }
    }
}