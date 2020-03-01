using System;

namespace _8.Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese los n primeros números que desee consultar la de serie de Fibonacci");
            int cantidad = int.Parse(Console.ReadLine());
            long a = 0;
            long b = 1;

            for (int i = 0; i < cantidad; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("{0}", a);
                }
                else
                {
                    long aux = a;
                    a = b;
                    b = aux + a;

                    Console.WriteLine(", {0}", a);
                }
            }

            Console.ReadKey();
        }
    }
}
