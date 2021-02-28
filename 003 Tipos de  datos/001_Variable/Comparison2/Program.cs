using System;

// Comparación de valores de diferentes tipos.

namespace Comparison
{
    class Program
    {
        static void Main()
        {
            bool result = false;

            int a = 1;
            float b = 2.0f;
            result = a < b;   // Comparación valor de tipo int, con el valor de tipo float - Permitido.

            string c = "Hola";
          //  result = c < a; // Comparación valor de tipo int, con el valor de tipo string - no esta permitido.

            // Demora.
            Console.ReadKey();
        }
    }
}
