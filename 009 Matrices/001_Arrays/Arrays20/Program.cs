using System;

// Palabra clave  params, Permite determinar el parámetro del método, Que acepta la cantidad variable de los argumentos.

namespace Arrays
{
    class Program
    {
        static void ShowArray(params int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }
        
        static void Main()
        {
            ShowArray(0, 1, 2, 3, 4, 5, 6, 7, 8, 9);

            // Pausa.
            Console.ReadKey();
        }
    }
}
