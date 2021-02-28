using System;

// Las matrices (matriz unidimensional).

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[5];


            // Mostrar en la pantalla el valor de los elementos de la matriz.
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            // Pausa.
            Console.ReadKey();
        }
    }
}
