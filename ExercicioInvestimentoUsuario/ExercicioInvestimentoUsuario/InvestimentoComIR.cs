using System;

namespace ExercicioInvestimento
{
    public class InvestimentoComIR : Investimento
    {
        public InvestimentoComIR(double valorInicial, double jurosMensais) : base(valorInicial, jurosMensais)
        {
        }
        public override double calcularLucro(int meses)
        {
            double desconto = 0;
            double lucroLiquido = 0;

            if (meses < 6)
            {
                desconto = 0.225 * base.calcularLucro(meses);
                lucroLiquido = base.calcularLucro(meses) - desconto;
                return lucroLiquido;
            }
            else if (meses >= 6 && meses < 12)
            {
                desconto = 0.2 * base.calcularLucro(meses);
                lucroLiquido = base.calcularLucro(meses) - desconto;
                return lucroLiquido;
            }
            else if (meses >= 12 && meses < 24)
            {
                desconto = 0.175 * base.calcularLucro(meses);
                lucroLiquido = base.calcularLucro(meses) - desconto;
                return lucroLiquido;
            }
            else
            {
                desconto = 0.15 * base.calcularLucro(meses);
                lucroLiquido = base.calcularLucro(meses) - desconto;
                return lucroLiquido;
            }
        }
    }
}