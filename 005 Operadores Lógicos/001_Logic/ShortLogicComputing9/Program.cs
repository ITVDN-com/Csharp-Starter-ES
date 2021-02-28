using System;

/*   
 *  EL CÁLCULO DE CORTO CIRCUITO - técnica que trabaja según el siguiente principio:
 *  Si el valor del primer operando en la operación AND (&&) es falsa, el segundo operando no se evalúa,
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

            // La condición, que no funciona con la utilización tecnica de CÁLCULO DE CORTO CIRCUITO.
            // debido a que la operación && (And) se evalúa de izquierda a derecha,
            // La expresión dada lógicamente equivalente no va a trabajar!

            if (((item / denominator) > MIN_VALUE) && (denominator != 0))
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
