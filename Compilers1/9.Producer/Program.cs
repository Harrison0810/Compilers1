using System;

namespace _9.Producer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("9. Salida en pantalla de la productoria de n(n ingresado por el usuario).");
            Console.WriteLine("Ingrese los n números que desee conocer su productoria");
            int cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine(Producer(cantidad, 1));

            Console.ReadKey();
        }

        private static int Producer(int cantidad, int count)
        {
            if (count < cantidad)
            {
                count = Producer(cantidad, count + 1) * count;
            }

            return count;
        }
    }
}
