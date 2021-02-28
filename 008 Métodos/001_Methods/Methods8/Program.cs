using System;

// La recursividad (compleja recursividad). 

// compleja recursividad -  autollamda del método,a traves de otro método. 

namespace Methods
{
    class Program
    {
        static void Recursion(int counter)
        {
            counter--;

            Console.WriteLine("La primera mitad del método de recursión: {0}", counter);

            if (counter != 0)
                Method(counter);

            Console.WriteLine("La segunda mitad del método de recursión: {0}", counter);
        }

        static void Method(int counter)
        {
            Console.WriteLine("La primera mitad del Método Method: {0}", counter);

            Recursion(counter);

            Console.WriteLine("La segunda mitad del Método Method: {0}", counter);
        }

        static void Main()
        {
            Method(3);

            // Demora.
            Console.ReadKey();
        }
    }
}
