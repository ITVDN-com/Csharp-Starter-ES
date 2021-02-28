using System;

// Métodos (funciones). 

namespace Methods
{
    class Program
    {
        /// <summary>
        /// La adición  de dos numeros enteros.
        /// </summary>
        /// <param name="summand1">El primer  sumando</param>
        /// <param name="summand2">El segundo  sumando</param>
        /// <returns>Suma</returns>
        static int Add(int summand1, int summand2)
        {
            return summand1 + summand2;
        }

        static void Main()
        {
            int summand1 = 2, summand2 = 3;

            int sum = Add(summand1, summand2);

            Console.WriteLine("{0} + {1} = {2}", summand1, summand2, sum);

            // Demora.
            Console.ReadKey();
        }
    }
}
