using System;

// La condición del operador ternario.

namespace Condition
{
    class Program
    {
        static void Main()
        {
            int a = 10, b = 2, c = -5, max = 0;

            max = a > b ? c = a : c = b; // Al principio с = а,  solo despues  max = c 

            Console.WriteLine(max);
            Console.WriteLine(c);

            // Retraso.
            Console.ReadKey();
        }
    }
}
