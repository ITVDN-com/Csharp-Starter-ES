using System;

// Construcción de bucles - do-while. (con salida temprana del bucle - break)

namespace Loop
{
    class Program
    {
        static void Main()
        {
            int counter = 0;

            do
            {
                counter++;
                Console.WriteLine("Counter {0}", counter);

                break;

                Console.WriteLine("Esta línea no se ejecutará.");
            }
            while (counter < 3) ;

            Console.WriteLine("Producir {0} iteraciones.", counter);

            // Delay.
            Console.ReadKey();
        }
    }
}
