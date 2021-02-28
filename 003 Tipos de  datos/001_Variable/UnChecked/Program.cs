using System;

/* La palabra clave unchecked - (unchecked)
  se utiliza con el fin de suprimir la comprobación de sobrecargas para operaciones aritméticas
 y conversiones de tipo integral*/

namespace UnChecked
{
    class Program
    {
        static void Main()
        {
            sbyte a = 127;

            // NO comprueba la sobrecarga .
            unchecked
            {
                a++; // ERROR lógico
            }

            //127 + 1 = -128;
            Console.WriteLine(a);

            // Demora.
            Console.ReadKey();
        }
    }
}
