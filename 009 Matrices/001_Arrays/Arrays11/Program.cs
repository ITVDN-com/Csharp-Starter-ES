using System;

// Matrices escalonadas o "jagged arrays".

namespace Arrays
{
    class Program
    {
        static void Main()
        {

            int[][] jagged = new int[3][];

            jagged[0] = new int[] { 1, 2 };
            jagged[1] = new int[] { 1, 2, 3, 4, 5 };
            jagged[2] = new int[] { 1, 2, 3 };


            // En el bucle externo Se cumple el paso por todas las matrices impuestas.
            for (int i = 0; i < jagged.Length; ++i)
            {
                // En el bucle interno Se cumple trato A cada elemento de la matriz anidada.
                for (int j = 0; j < jagged[i].Length; ++j)
                {
                    Console.Write("{0} ", jagged[i][j]);
                }
                Console.Write("\n");
            }
            

            // Pausa.
            Console.ReadKey();
        }
    }
}
