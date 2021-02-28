using System;

// bucle for dentro del bucle for. ( Construcción de un cuadrado de estrellas - * )

namespace Loop
{
    class Program
    {
        static void Main()
        {

            for (int i = 0; i < 10; i++)
            {
                // Mostramos solo una línea de 10 estrellas.
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("*");
                }

                // Paso a una nueva línea.
                Console.WriteLine();
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
