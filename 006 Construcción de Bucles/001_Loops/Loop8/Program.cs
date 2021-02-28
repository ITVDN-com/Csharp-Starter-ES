using System;

// Construcción de bucles - do-while.

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
            }
            while (counter < 3);

            Console.WriteLine("Producir {0} iteraciones.", counter);

            // Delay.
            Console.ReadKey();
        }
    }
}
