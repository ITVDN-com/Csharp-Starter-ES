using System;

// Construcción de bucles - while. (con omitir las iteraciones - continue)

namespace Loop
{
    class Program
    {
        static void Main()
        {
            int counter = 0;

            while (counter < 3)
            {
                counter++;
                Console.WriteLine("Counter {0}", counter);

                continue;

                Console.WriteLine("Esta línea no se ejecutará.");
            }

            Console.WriteLine("se producio  {0}  la iteración.", counter);

            // Demora.
             Console.ReadKey();
        }
    }
}
