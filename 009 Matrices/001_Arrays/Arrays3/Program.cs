using System;

// Matrices (matriz unidimensional).

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            // En la línea 14 declaramos la matriz  de elementos enteros con el nombre array con una dimensión para  5   elementos -  размерностью в 5 элементов
            // En el bloque de la inicialización rellenamos su valor 1,2,3,4,5.
            
            int[] array = new int[5] { 1, 2, 3, 4, 5 };
                        
            // Mostrar en la pantalla el valorde los elementos  de la matriz значений элементов массива.
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            // pausa.
            Console.ReadKey();
        }
    }
}
