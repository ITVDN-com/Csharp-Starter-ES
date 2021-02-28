using System;

/*   
 *  EL CÁLCULO DE CORTO CIRCUITO - técnica que trabaja según el siguiente principio:
 *  Si el primer operando en la operación AND (&&) es falso, el segundo operando no se evalúa,
 *  porque la expresión completa en cualquier caso será falso.
 */

namespace ShortLogicComputing
{
    class Program
    {
        static void Main()
        {
            int MIN_VALUE = 1;
            int denominator = 0;
            int item = 2;

            // La condición, que funciona con la utilización tecnica de CÁLCULO DE CORTO CIRCUITO.
            // Si la expresión se evalúa por completo, entonces la operación de la división en el segundo operando, 
            // Generaría un error de división por 0.

            if ((denominator != 0) && (item / denominator) > MIN_VALUE) // Deje un operador &
            {
                Console.WriteLine("Nosotros en el bloque IF");
            }
            else
            {
                Console.WriteLine("Nosotros en el bloque ELSE");
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
