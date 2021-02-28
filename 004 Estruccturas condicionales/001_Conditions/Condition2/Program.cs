using System;

// Operador condicional (Instrucción ) - if - else (con dos sentencias).

namespace Condition
{
    class Program
    {
        static void Main()
        {
            int a = 3, b = 2;

            if (a < b)  // SI  La condición satisface la veracidad, entonces ejecuta el cuerpo del bloque if.
            {
                Console.WriteLine("a < b");               // Sentencia  1
            }
            else        // DE OTRO MODO , ejecuta el cuerpo del bloque else.       
            {
               Console.WriteLine("a no es menor que b");       // sentencia 2
            }

            // Retraso.
            Console.ReadKey();
        }
    }
}
