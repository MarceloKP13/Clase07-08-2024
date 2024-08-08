using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Entrada de datos
            Console.WriteLine("Ingrese un número:");
            int numero = int.Parse(Console.ReadLine());

            // Proceso
            bool esPar = EsNumeroPar(numero);

            // Salida de datos
            if (esPar)
            {
                Console.WriteLine("El número es par.");
            }
            else
            {
                Console.WriteLine("El número es impar.");
            }

            Console.ReadKey();
        }

        static bool EsNumeroPar(int num)
        {
            return num % 2 == 0;
        }

    }
}
