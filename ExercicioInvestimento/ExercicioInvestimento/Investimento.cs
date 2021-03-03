using System;

namespace ExercicioInvestimento
{
    public class Investimento
    {
        public double ValorInicial { get; set; }
        public double JurosMensais { get; set; }

        public Investimento(double valorInicial, double jurosMensais)
        {
            ValorInicial = valorInicial;
            JurosMensais = jurosMensais / 100;
        }

        public virtual double calcularLucro(int meses)
        {
            return (ValorInicial * Math.Pow((1 + JurosMensais), meses)) - ValorInicial;
        }
    }
}