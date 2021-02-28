using System;

// Encontrar factorial DE un número.

namespace MethodsRecFact
{

    class Program
    {
        static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            else 
                return n * Factorial(n - 1);
        }
        
        static void Main()
        {            
            int factorial = Factorial(5);

            Console.WriteLine(factorial);

            // Demora.
            Console.ReadKey();
        }
    }
}
