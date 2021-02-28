using System;

/* checked  - (checked)
 La palabra clave checked se usa con el fin de habilitar explícitamente la comprobación de sobrecargas para 
 * operaciones aritméticas y conversiones de tipo integral.*/

namespace Checked
{
    class Program
    {
        static void Main()
        {
            sbyte a = 127;

            // Comprobar la sobrecarga.
            
            //checked
            {
                a++; // ERROR a nivel del compilador.
            }

             //127 + 1 = -128
            Console.WriteLine(a);

            // Demora.
            Console.ReadKey();
        }
    }
}
