using System;

// Operador condicional (Instrucción ) - if-else .

namespace Condition
{
    class Program
    {
        static void Main()
        {
            int a = 1, b = 2;

            // SI el cuerpo del bloque if o else estan compuestos de una expresión, entonces Los paréntesis se puede excluir

            if (a < b)
                Console.WriteLine("a < b");                  // Sentencia 1 
            else
                Console.WriteLine("a no es menor que b");   // Sentencia 2
            
            // Retraso.
            Console.ReadKey();
        }
    }
}
