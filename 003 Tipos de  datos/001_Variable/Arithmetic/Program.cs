using System;

// Operadores aritmeticos  (Arithmetic Operators) - +, −, *, /, %

namespace Arithmetic
{
    class Program
    {
        static void Main()
        {
            // Adición (+) 
            byte summand1 = 1, summand2 = 2; // El anuncio plural.
            int sum = 0;
            sum = summand1 + summand2;
            
            Console.WriteLine(sum);

            // Sustracción (-)
            byte minuend = 5, subtrahend = 3;
            int difference = 0;
            difference = minuend - subtrahend;
            
            Console.WriteLine(difference);

            // Multiplicación (*)
            byte factor1 = 2, factor2 = 3;
            int product = 0;
            product = factor1 * factor2;
            
            Console.WriteLine(product);

            // División (/)
            byte dividend = 5, divisor = 2;
            int quotient = 0, remainder = 0;
            quotient = dividend / divisor;

            Console.WriteLine(quotient);

            // Residuo despues de la división (%)
            remainder = dividend % divisor;

            Console.WriteLine(remainder);
 
            // Demora.
            Console.ReadKey();
        }
    }
}
