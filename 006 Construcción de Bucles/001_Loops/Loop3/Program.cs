using System;

// Instrucción de transción inmediata o bucle - goto.

namespace Loop
{
    class Program
    {
        static void Main()
        {
            bool condition = true;

            if (condition == true)
            {
                goto Label;
            }

            Console.WriteLine("primera línea");

        Label:
            Console.WriteLine("Segunda línea");

            // Demora.
            Console.ReadKey();
        }
    }
}
