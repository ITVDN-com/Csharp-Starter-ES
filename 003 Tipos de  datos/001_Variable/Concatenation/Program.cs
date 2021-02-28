using System;

// Union de caracteres. (Concatenación)

namespace Concatenation
{
    class Program
    {
        static void Main()
        {
            // 1era variant.
            string word1 = "Hola ";
            string word2 = "Mundo!";            
            string phrase = word1 + word2;
            Console.WriteLine(phrase);
            
            // 2do variante.
            Console.WriteLine("Hola " + "Mundo!");

            // Demora.
            Console.ReadKey();
        }
    }
}
