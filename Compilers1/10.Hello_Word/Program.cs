using System;
using System.IO;

namespace _10.Hello_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("10. Salida en archivo del programa Hola, Mundo.");
            WriteFile();

            Console.ReadKey();
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
