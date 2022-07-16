using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************");
            Console.WriteLine("    Menú");
            Console.WriteLine("************");

            Console.WriteLine();
            Console.WriteLine("1: Sumar dos números");
            Console.WriteLine("2: Restar dos números");
            Console.WriteLine("3: Multiplicar dos números");
            Console.WriteLine("4: Factorial de un número");
            Console.WriteLine("5: Potencia");

            Console.Write("Opción: ");
            int valor = Convert.ToInt32(Console.ReadLine());

            switch (valor)
            {
                case 1:
                    sumar();
                    break;
                default:
                    Console.WriteLine("Ninguna opción conocida. chauuu");
                    break;

            }

            Console.ReadLine();
        }

        private static void sumar()
        {
            Console.WriteLine("Sumar");
            Console.Write("Número 1: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Número 2: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("La suma de {0} y {1} es {2}", n1, n2, n1 + n2);
        }
    }
}
