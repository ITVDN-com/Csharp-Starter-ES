using System;

// Operador condicional (Instrucción ) - if (con una sentencia).

namespace Condition
{
    class Program
    {
        static void Main()
        {
            int a = 10, b = 2; // Declaramos dos variables de tipo entero.

            // En la linea 15 declaramos la  condicional if,la condición el cual  comprueba : a menor que b   

            if (a < b)      // SI  La condición satisface la veracidad, ejecuta el cuerpo de la condicional.
            {
                Console.WriteLine("a < b");     // sentencia 1
            }
            
            // Retraso.
            Console.ReadKey();
        }
    }
}
