﻿using System;

// Métodos (funciones).

namespace Methods
{
    class Program
    {        
        static string Function()
        {
            string word = "Hello!";

            return word;
        }

        static void Main()
        {            
            string word = Function();

            Console.WriteLine(word);

            // Delay.
            Console.ReadKey();
        }
    }
}
