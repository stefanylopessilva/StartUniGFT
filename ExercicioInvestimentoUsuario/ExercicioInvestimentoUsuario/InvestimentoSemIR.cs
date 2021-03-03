using System;

namespace ExercicioInvestimento
{
    public class InvestimentoSemIR : Investimento
    {
        public InvestimentoSemIR(double valorInicial, double jurosMensais) : base(valorInicial, jurosMensais)
        {
        }
        public override double calcularLucro(int meses)
        {
            if (ValorInicial < 1000)
            {
                Console.WriteLine("O valor inicial não pode ser menor que R$1.000,00");
                return 0;
            }
            else
            {
                return base.calcularLucro(meses);
            }
        }
    }
}
