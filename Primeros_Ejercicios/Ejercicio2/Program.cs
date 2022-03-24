using System;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ingresar un número y mostrar el cuadrado y el cubo del mismo. Se debe validar que el número sea mayor que cero,
            //caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
            char respuesta = ' ';

            do
            {
                Console.Write("Ingresar un numero para calcular raices: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Cuadrado {0}", Math.Pow(2, numero));
                    Console.WriteLine("Cubo {0}", Math.Pow(3, numero));
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;

                }
                Console.Write("Seguir? s/n: ");
                respuesta = char.Parse(Console.ReadLine());
            } while (respuesta == 's');
        }
    }
}
