using System;

// El parámetro con la palabra clave params, Debe ser solamente uno y estar último en la lista de los parámetros del método.

namespace Arrays
{
    class Program
    {
        static void ShowArray(string name, params int[] array)
        {
            Console.Write(name);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }

        static void Main()
        {
            ShowArray("Numbers: ", 0, 1, 2, 3, 4, 5, 6, 7, 8, 9);

            // Pausa.
            Console.ReadKey();
        }
    }
}
