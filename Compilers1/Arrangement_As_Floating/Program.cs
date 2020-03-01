using System;

namespace Arrangement_As_Floating
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("6. Declaración de una variable tipo arreglo como flotante(estándar, doble o cuádruple).");
            double[] arrDoubles = new double[3];
            arrDoubles[0] = 8.16;
            arrDoubles[1] = 16.64;
            arrDoubles[2] = 64.128;

            Console.WriteLine(arrDoubles[0]);
            Console.WriteLine(arrDoubles[1]);
            Console.WriteLine(arrDoubles[2]);

            Console.ReadKey();
        }
    }
}
