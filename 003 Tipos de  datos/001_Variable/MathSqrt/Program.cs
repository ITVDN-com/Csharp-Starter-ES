using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Math.Sqrt() - Funcion matemática,  que devuelve la raíz cuadrada de un número especificado.
namespace MathSqrt
{
    class Program
    {
        static void Main()
        {
            double x = 256;

            double result = Math.Sqrt(x);  
    
            Console.Write("Raíz cuadrada igual: ");
            Console.WriteLine(result);
            
            // Demora.
            Console.ReadKey();
        }
    }
}
