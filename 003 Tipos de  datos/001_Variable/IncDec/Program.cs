using System;

//  Operadores de incremento y decremento 

namespace IncDec
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("----- Postincremento"); // Postincremento
            
            byte number1 = 0;            
            Console.WriteLine(number1++); // Al principio mostramos en la pantalla, después aumentamos en 1.
            Console.WriteLine(number1);

            Console.WriteLine("----- Preincremento"); // Preincremento

            byte number2 = 0;
            Console.WriteLine(++number2); // Al prinicipio aumentamos en 1, despues mostramos en la pantalla.

            Console.WriteLine("----- Postdecremento"); // Postdecremento

            sbyte number3 = 0;
            Console.WriteLine(number3--); // Al principio mostramos en la pantalla, después disminuimos en 1.
            Console.WriteLine(number3);

            Console.WriteLine("----- Predecremento"); // Predecremento

            sbyte number4 = 0;
            Console.WriteLine(--number4); // Al prinicipio disminuimos en 1, despues mostramos en la pantalla.

            // Demora.
            Console.ReadKey();
        }
    }
}
