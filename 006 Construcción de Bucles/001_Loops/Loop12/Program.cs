using System;

// Construcción de bucles - for (bucle con el medidor).

namespace Loop
{
    class Program
    {
        static void Main()
        {

            // for ( Inicialización del medidor de iteraciones; Condición; Medidor de cambio ) { cuerpo del bucle }
           
            for (int counter = 0; counter < 3; counter++)
            {
                Console.WriteLine("Counter = {0}", counter);
            }

            //counter = 0; //  counter - no disponible fuera del bucle for.

            // Delay.
            Console.ReadKey();
        }
    }
}
