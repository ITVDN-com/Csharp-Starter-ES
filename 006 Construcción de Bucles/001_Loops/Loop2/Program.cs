﻿using System;

// Instrucción de transción inmediata o bucle - goto.

namespace Loop
{
    class Program
    {
        static void Main()
        {
            int counter = 0;

        Label:
            counter++;
            Console.WriteLine("Counter = {0}", counter);

            if (counter < 3)
            {
                goto Label;
            }

            Console.WriteLine("End");

            // Demora.
            Console.ReadKey();
        }
    }
}
