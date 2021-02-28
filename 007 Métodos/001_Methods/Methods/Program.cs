using System;

// Métodos (Procedimientos).

namespace Methods
{
    class Program
    {
        // En la línea 12, declaramos un método con el nombre Procedure, que no acepta nada y nada devuelve.
        // En el cuerpo del método  , en la línea 14 mostramos la línea en la pantalla - Hello!        

        static void Procedure()
        {
            Console.WriteLine("Hola!");
        }

        static void Main()
        {
            // En el método del cuerpo Main en la línea 21, llamamos al método Procedure.

            Procedure();

            // Delay.
            Console.ReadKey();
        }
    }
}
