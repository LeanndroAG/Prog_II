using System;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numero;
            int auxiliar = 0;
            int min = int.MaxValue;
            int max = int.MinValue;
            int promedio = 0;
            int i = 0;

            Console.WriteLine("Ingresar 5 numeros: ");

            for (i = 0; i < 5; i++)
            {
                numero = Console.ReadLine();

                if(int.TryParse(numero, out auxiliar))
                {
                    if (auxiliar > max)
                    {
                        max = auxiliar;
                    }
                    if (auxiliar < min)
                    {
                        min = auxiliar;
                    }
                    promedio = promedio + auxiliar;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Numero invalido");
                    Console.ForegroundColor = ConsoleColor.White;
                    i--;
                }
            }

            promedio = promedio / i;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Maximo: {0}", max);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Minimo: {0}", min);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Promedio: {0}", promedio);

            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
