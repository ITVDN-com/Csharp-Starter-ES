using System;

// Operador condicional (Instrucciónes) - if-else (con varias sentencias). cascada .

namespace Condition
{
    class Program
    {
        static void Main()
        {
            int a = 2, b = 2;

            if (a < b)      // cascada de sentencias condicionales.
            {
                Console.WriteLine("a < b");   // Sentencia 1
            }
            else if (a > b) //Vamos a una nueva comprobación.
            {
                Console.WriteLine("a > b");   // Sentencia 2
            }
            else 
            {
                Console.WriteLine("a == b");  // Sentencia 3
            }
            
            // Retraso.
            Console.ReadKey();
        }
    }
}
