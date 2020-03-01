using System;

namespace _4.IntegerArrayVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4. Declaración de una variable tipo arreglo entero(corto, estándar o largo).");
            int[] arrNumbers = new int[2];
            arrNumbers[0] = 16;
            arrNumbers[1] = 64;

            Console.WriteLine(arrNumbers[0]);
            Console.WriteLine(arrNumbers[1]);

            Console.ReadKey();
        }
    }
}
