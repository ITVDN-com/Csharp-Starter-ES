using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* Math.Pow() - Elevando un número a la potencia
 * Devuelve un número especificado elevado a la potencia especificada.
 (1er argumento - número, que es elevado a la potencia, 2do – grado, en el cual elevamos el número)*/

namespace MathPow
{
    class Program
    {
        static void Main()
        {
            double x = 2, y = 8;

            double result = Math.Pow(x, y);  
     
            Console.WriteLine(result);

            // Demora.
            Console.ReadKey();
        }
    }
}
