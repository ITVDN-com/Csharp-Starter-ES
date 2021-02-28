using System;

// La condición del operador ternario. Las restricciones se seguridad ante en cambio de tipos de variables.

namespace Condition
{
    class Program
    {
        static void Main()
        {
            int a = 1;
            double b = 10.1;
            int max;

            // Expresión [?] y [:]  - Tendrá que ser de un tipo.

            max = (int)((a > b) ? a : b);

            // ... o así

            max = (a > b) ? a : (int)b;

            Console.WriteLine(max);

            // retraso.
            Console.ReadKey();
        }
    }
}
