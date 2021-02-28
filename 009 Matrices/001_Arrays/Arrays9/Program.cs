using System;

// Las matrices (matriz bidimensional)..

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            // El compilador determina el tamaño de la matriz sobre la base de la expresión de inicialización.
            int[,] array = {
                             { 1, 2, 3 },
                             { 4, 5, 6 },
                             { 7, 8, 9 }
                           };

            Console.WriteLine(array);
            

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0} ", array[i, j]);
                }
                Console.Write("\n");
            }


            // Pausa.
            Console.ReadKey();
        }
    }
}
