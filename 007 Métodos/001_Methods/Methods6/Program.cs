using System;

// Мetodos  (función). 

namespace Methods
{
    class Program
    {
        // Мetodos, que devuelven un valor booleano, métodos llamados predicados.

        static bool And(bool a, bool b)
        {
            return a && b;
        }

        static void Main()
        {
            bool operand1 = true, operand2 = true;

            bool result = And(operand1, operand2);

            Console.WriteLine("{0} && {1} = {2}", operand1, operand2, result);

            // Demora.
            Console.ReadKey();
        }
    }
}
