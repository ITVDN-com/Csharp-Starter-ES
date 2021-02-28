using System;

// Comparaciones de igualdad y y revición de igualdades (<, <=, >, >=, ==, !=)

namespace Comparison
{
    class Program
    {
        static void Main()
        {
            byte value1 = 0, value2 = 1;
            bool result = false;

            // Menor que
            result = value1 < value2;
            Console.WriteLine(result);

            // Mayor que
            result = value1 > value2;
            Console.WriteLine(result);

            // Menor que o igual que
            result = value1 <= value2;
            Console.WriteLine(result);

            // Mayor que o igual que
            result = value1 >= value2;
            Console.WriteLine(result);

            // Igual que
            result = value1 == value2;
            Console.WriteLine(result);

            // No es igual que
            result = value1 != value2;
            Console.WriteLine(result);

            // Demora.
            Console.ReadKey();
        }
    }
}
