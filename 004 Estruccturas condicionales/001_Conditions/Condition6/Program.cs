
using System;

// Operador Ternario .

// Operador Ternario (terciario) [?:] .
// Operador Ternario  [?:], es la abreviatura de la instrucción if ... else.
// [?:] - incluye tres operandos - ( condición ? bloque verdad : bloque falsedad )

//  algoritmo de trabajo del operador ternario: (La expresión lógica) ? expresión 1 : expresión 2
//    1. Determinando   La expresión lógica  (condición).
//    2. Si la operación lógica satisface la veracidad , entonces devolver el valor de la expresión  1,
//          DE OTRO MODO  — El valor de la expresión 2.
//    3. El valor calculado vuelve a ser el valor de la nueva variable.

namespace Condition
{
    class Program
    {
        static void Main()
        {
            int a = 1, b = 2, max = 0;

            // Variable max, le asignamos el valor que nos estaria devolviendo el resultado del operador ternario

            max = (a > b) ? a : b;   // SI:  (a > b)  ENTONCES:  El resultado que devuelve es de  a  DE OTRO MODO : el valor de  b;

            Console.WriteLine(max);

            // retraso.
            Console.ReadKey();
        }

    }
}
