using System;

// Construcción de bucles- while. (con salida temprana la instrucción - break)

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

                break;

                Console.WriteLine("Esta línea no se ejecutará.");
            }

            Console.WriteLine("Producir {0} iteraciones.", counter);

            // Demora.
            Console.ReadKey();
        }
    }
}
