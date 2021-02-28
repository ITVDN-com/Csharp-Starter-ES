using System;

// Меtodos  con parámetros variables (ref = in/out).

namespace Methods
{
    class Program
    {
        // Si esque en el cuerpo del metodo  Realice cambios en el valor de la variable pasada por el enlace,
        // su valor será cambiado en todas partes

        static int Method(ref int a)

        {
            int b = a * 2;
            a = 5;
            return b;
        }

        static void Main()
        {
            int operand = 2;

            int result = Method(ref operand);

            Console.WriteLine("{0}; {1};", operand, result);

            // Demora.
            Console.ReadKey();
        }
    }
}
