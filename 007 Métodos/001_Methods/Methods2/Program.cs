using System;

// Métodos (Funciones).

namespace Methods
{
    class Program
    {
        // En la línea 12, declaramos el método con el nombre Function,que no acepta nada y devuelve un valor líneal.
        // En el método del cuerpo, utilizando la palabra clave return, devolvemos la línea - Hello!

        static string Function()
        {
            return "Hello!";
        }

        static void Main()
        {
            // En el cuerpo del método   Main en la línea 22, declaramos una  variable localde tipo cadena  con el nombre @string 
            // y le asignamos el valor devuelto del método Function.

            string @string = Function();
                       
            Console.WriteLine(@string);

            // Delay.
            Console.ReadKey();
        }
    }
}
