using System;

// Ejemplo  Varias devoluciones método correcto.

namespace Methods
{
    class Program
    {
        static string Compare(int value1, int value2)
        {
            if (value1 < value2)
            {
                return "Comparación Menor que";
            }
            else if (value1 > value2)
            {
                return "Comparación MAYOR que";
            }

            return "IGUALDAD";
        }

        static void Main()
        {
            int operand1 = 1, operand2 = 2;

            string result = Compare(operand1, operand2);

            Console.WriteLine(result);

            // Demora.
            Console.ReadKey();
        }
    }
}
