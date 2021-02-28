using System;

// Estructura de bucles - do-while. 

// Valor factorial n (significa n!, se produncia - EN factorial) — El producto de todos los valores naturales,
// desde 1 hasta n inclusive:
//     n! = 1 * 2 * 3 * ... * n
//     0! = 1

// En combinatoria factorial del valor natural n se interpreta como cantidad de permutaciones de n elementos. 
// Ejemplo, para el conjunto {A,B,C,D} de los 4-х elementos existentes: 4! = 1 * 2 * 3 * 4 = 24 trasladados:

//     ABCD  BACD  CABD  DABC
//     ABDC  BADC  CADB  DACB
//     ACBD  BCAD  CBAD  DBAC
//     ACDB  BCDA  CBDA  DBCA
//     ADBC  BDAC  CDAB  DCAB
//     ADCB  BDCA  CDBA  DCBA

namespace Loop
{
    class Program
    {
        static void Main()
        {
            int counter = 4;
            int factorial = 1;

            Console.Write("Valor factorial: {0}! = ", counter);

            do
            {
                // Primero la multiplicación, después el decremento. 
                factorial *= counter--;
                
                // Esta línea es equivalente:

                //factorial = factorial * counter;
                //counter = counter - 1;
            }
            while (counter > 0);

            Console.WriteLine("{0}", factorial);

            // Delay.
            Console.ReadKey();
        }
    }
}
