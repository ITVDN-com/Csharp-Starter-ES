using System;

// Construcción de bucles - do-while. (con omitir las iteraciones - continue)

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

                continue;

                Console.WriteLine("Esta línea no se ejecutará.");
            }
            while (counter < 3);

            Console.WriteLine("producir {0} iteraciones.", counter);

            // Delay.
            Console.ReadKey();
        }
    }
}
