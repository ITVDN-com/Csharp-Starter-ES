using System;

// Operaciones lógicas.

// Ejemplo: 
// Para comprobar la condición A < x < B, no se puede escribir directamente en una sentencia condicional, 
// ya que cada operación debe tener en cuenta los dos operandos. 
// Modo correcto de anotación: i f ( A < x && x < B).

namespace Logic
{
    class Program
    {
        static void Main()
        {
            int A = 0, B = 5, x = 13;


            if (A < x && x < B) // A < x < B
            {
                Console.WriteLine("El número {0} se encuentra en el rango de los números desde {1} hasta {2}.", x, A, B);
            }
            else
            {
                Console.WriteLine("El número {0} no cabe en el rango de los números desde {1} hasta {2}.", x, A, B);
            }


            // Delay.
            Console.ReadKey();
        }
    }
}
