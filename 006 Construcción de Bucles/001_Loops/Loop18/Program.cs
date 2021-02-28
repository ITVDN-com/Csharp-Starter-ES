using System;

// Simplificando el bucle Araña (Spider).  

namespace Loop
{
    class Program
    {
        static void Main()
        {
            char character = '\0';            

            for (; ; )
            {
                character = Console.ReadKey().KeyChar;

                switch (character)
                {
                    case 'l': // 'l' - condición guardada 1.
                        {
                            Console.WriteLine("Go left"); continue; // comando guardado.
                        }
                    case 'r': // 'r' - condición guardada 2.
                        {
                            Console.WriteLine("Go right"); continue; // comando guardado.
                        }
                }

                switch (character)
                {
                    case 'x': // 'x' - condición de salida 1.
                        {
                            Console.WriteLine("Exit"); break; // comando terminado.
                        }
                    case 'q': // 'q' - condición de salida 2.
                        {
                            Console.WriteLine("Quit"); break; // comando terminado.
                        }
                    default: // Finalización de la rama alternativa.
                        {
                            Console.WriteLine("Alternative exit"); break;
                        }
                }

                break;  // Interrupción del bucle.
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
