using System;

namespace ExercicioSoma
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int somatorio = 0;
            int numero = 0;

            while (somatorio < 300)
            {
                Console.Write("Digite um número: ");
                numero = Int32.Parse(Console.ReadLine());

                if (numero > 0)
                {
                    somatorio += numero;
                }

                if (numero < 0)
                {
                    Console.WriteLine("Números negativos não são permitidos");
                }

                else if (somatorio > 300)
                {
                    Console.WriteLine($"O somatório foi: {somatorio}");
                    Console.ReadLine();
                }
            }
        }
    }
}
