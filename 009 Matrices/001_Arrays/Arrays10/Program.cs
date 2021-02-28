using System;

// Matrices compuestas por un elemento . 

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            int[] vector = new int[1];
            vector[0] = 100;
            Console.WriteLine(vector[0]);


            int[,] matrix = new int[1, 1];
            matrix[0, 0] = 200;
            Console.WriteLine(matrix[0, 0]);


            // Pausa.
            Console.ReadKey();
        }
    }
}
