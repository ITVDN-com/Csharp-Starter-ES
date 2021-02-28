using System;

// Construcción de estructuras bucles  (bucle con el medidor) - for (con omitir las iteraciones - continue).

namespace Loop
{
    class Program
    {
        static void Main()
        {

            for (int counter = 0; counter < 3; counter++)
            {
                Console.WriteLine("Counter = {0}", counter);

                continue;

                Console.WriteLine("Esta línea no se ejecutará.");
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
