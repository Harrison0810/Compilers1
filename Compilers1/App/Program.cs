using System;
using System.IO;

namespace App
{
    /// <summary>
    /// Autor: Harrison Cardona Barrera
    /// Evento Evaluativo 1 CPI82-1/2 Compiladores 2020-1
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1. Declaración de una variable tipo entero (corto, estándar o largo).");
            int number = 16;
            Console.WriteLine(number);

            Console.WriteLine(string.Empty);

            Console.WriteLine("2. Declaración de una variable tipo carácter.");
            char character = 'c';
            Console.WriteLine(character);

            Console.WriteLine(string.Empty);

            Console.WriteLine("3. Declaración de una variable tipo coma flotante(estándar, doble o cuádruple).");
            double currency = 128.64;
            Console.WriteLine(currency);

            Console.WriteLine(string.Empty);

            Console.WriteLine("4. Declaración de una variable tipo arreglo entero(corto, estándar o largo).");
            int[] arrNumbers = new int[2];
            arrNumbers[0] = 16;
            arrNumbers[1] = 64;

            Console.WriteLine(arrNumbers[0]);
            Console.WriteLine(arrNumbers[1]);

            Console.WriteLine(string.Empty);

            Console.WriteLine("5. Declaración de una variable tipo cadena de caracteres.");
            string chain = "Compiladores ITM 2020-1";
            Console.WriteLine(chain);

            Console.WriteLine(string.Empty);

            Console.WriteLine("6. Declaración de una variable tipo arreglo como flotante(estándar, doble o cuádruple).");
            double[] arrDoubles = new double[3];
            arrDoubles[0] = 8.16;
            arrDoubles[1] = 16.64;
            arrDoubles[2] = 64.128;

            Console.WriteLine(arrDoubles[0]);
            Console.WriteLine(arrDoubles[1]);
            Console.WriteLine(arrDoubles[2]);

            Console.WriteLine(string.Empty);

            Console.WriteLine("7. Declaración de los numerales 1.al 6.");
            int number1 = 16;
            char character2 = 'c';
            double currency3 = 128.64;
            int[] arrNumbers4 = new int[2];
            string chain5 = "Compiladores ITM 2020-1";
            double[] arrDoubles6 = new double[3];

            Console.WriteLine(string.Empty);

            Console.WriteLine("8. Salida en pantalla de los n primeros números de la serie Fibonacci(n ingresado por el usuario).");
            Fibonacci();

            Console.WriteLine(string.Empty);

            Console.WriteLine("9. Salida en pantalla de la productoria de n(n ingresado por el usuario).");
            Console.WriteLine("Ingrese los n números que desee conocer su productoria");
            int cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine(Producer(cantidad, 1));

            Console.WriteLine(string.Empty);

            Console.WriteLine("10. Salida en archivo del programa Hola, Mundo.");
            WriteFile();

            Console.ReadKey();
        }

        private static void Fibonacci()
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
        }

        private static int Producer(int cantidad, int count)
        {
            if (count < cantidad)
            {
                count = Producer(cantidad, count + 1) * count;
            }

            return count;
        }

        private static void WriteFile()
        {
            // Create a file to write to.
            string path = Path.Combine(Directory.GetCurrentDirectory(), "Hola, Mundo.txt");

            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Hola, Mundo");
                }
            }

            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

            Console.WriteLine("Ruta del archivo: " + path);
        }
    }
}
