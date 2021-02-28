using System;

// Construcción de bucles - while.

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
            }

            Console.WriteLine("producido {0} Iteración.", counter); /*Iteración: significa el acto de repetir un proceso ,
                                                                      con el objetivo de alcanzar una meta deseada, objetivo o resultado.*/

            // DEmora.
            Console.ReadKey();
        }
    }
}
