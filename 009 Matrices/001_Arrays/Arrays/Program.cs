using System;

// Matrices (matriz unidimensional).

namespace Arrays
{
    class Program
    {
        static void Main()
        {

            // En la línea 14  declaramos la matriz De los elementos íntegros  con el nombre array  con una capacidad para  5  distintos elementos.

            int[] array = new int[5];

            // En la linea 18  los  elementos de la matriz  array con el indice 0 le asignamos el 10

            array[0] = 10;
            array[1] = 20;
            array[2] = 30;
            array[3] = 40;
            array[4] = 50;

            // En la línea 26 mostramos en la pantalla los valores de los elementos de la matriz array por el indice 0

            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);
            Console.WriteLine(array[3]);
            Console.WriteLine(array[4]);

            // Demora.
            Console.ReadKey();
        }
    }
}
