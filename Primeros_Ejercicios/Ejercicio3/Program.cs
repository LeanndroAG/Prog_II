using System;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string respuesta = "";
           
            do
            {
                int numero = 2;
                int divisible = 0;
                Console.Write("Ingresar un numero: ");
                string numeroFinal = Console.ReadLine();
                int auxNumeroFinal = 0;

                if(int.TryParse(numeroFinal, out auxNumeroFinal))
                {
                    while (numero <= auxNumeroFinal)
                    {
                        for (int i = 1; i <= numero; i++)
                        {
                            if(numero % i == 0)
                            {
                                divisible++;
                            }
                            if (divisible > 2)
                            {
                                break;
                            }
                        }
                        if (divisible == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Red; 
                            Console.WriteLine("Numero primo: {0}", numero);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        divisible = 0;
                        numero++;
                    }
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("No es un numero!");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.Write("Seguir? salir/seguir: ");
                respuesta = (Console.ReadLine());
            } while (respuesta !=  "salir");
        }
    }
}
