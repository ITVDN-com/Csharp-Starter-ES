using System;

// La recursividad (sencilla recursividad). 

// En el cuerpo del metodo Recursion en la linea 19 método se llama de forma recursiva Recursion.
// sencilla recursividad - La autollamada por el método (La autollamada). Con cada llamada se basa una nueva copia del método.

namespace Methods
{
    class Program
    {
        static void Recursion(int counter)
        {
            counter--;

            Console.WriteLine("La primera mitad del método: {0}", counter);

            
              if (counter != 0)
                Recursion(counter);

              Console.WriteLine("La segunda mitad del método: {0}", counter);
        }

        static void Main()
        {
            Recursion(3);

            // Demora.
            Console.ReadKey();
        }
    }
}
