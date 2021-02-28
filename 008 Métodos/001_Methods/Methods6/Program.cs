using System;

// Devolución de valores del método Main ()

// Sobrecarga del metodo Main () -

// Punto de inicio del programa es el metodo Main (), el cual devuelve un valor de tipo  void o int.

namespace Methods
{
    class Program
    {
        
        // la sobre carga . (No es el punto  de inicio)
        static string Main(string argument)
        {
            return "hola " + argument + "!";
        }

        
        // Punto de inicio del programa.
        static int Main()
        {
            string @string = Main("mundo");

            Console.WriteLine(@string);

            // Demora.
            Console.ReadKey();

            return 0;
        }
    }
}
