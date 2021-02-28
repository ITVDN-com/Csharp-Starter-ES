using System;

// Construcción de estructuras bucles (bucle con el medidor) - for (con salida temprana del bucle - break).

namespace Loop
{
    class Program
    {
        static void Main()
        {

            for (int counter = 0; counter < 3; counter++)
            {
                Console.WriteLine("Counter = {0}", counter);

                break;

                Console.WriteLine("Esta línea no se ejutará.");
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
