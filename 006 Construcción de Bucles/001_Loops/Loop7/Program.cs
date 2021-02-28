using System;

// Construcción del bucle - while. 

namespace Loop
{

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Adivine el color pensando en 5 oportunidades.");
            Console.WriteLine("Para la salida del programa introduzca - exit.");

            const int maxAttempt = 5; // Número permitido de intentos.
            int attempt = 0;          // medidor de intentos.
            string color = "rojo";     // color imaginado.

            while (attempt < maxAttempt)
            {
                attempt++;
                Console.WriteLine("intento {0}:", attempt);
                
                string value = Console.ReadLine();

                if (value == "exit")
                {
                    break;
                }

                if (value != color)
                {
                    continue;
                }

                Console.WriteLine("Felicidades, Usted ha adivinado con {0} intentos!", attempt);
                break;
            }

            Console.WriteLine("Final del juego!");

            // Demora.
            Console.ReadKey();
        }
    }
}
