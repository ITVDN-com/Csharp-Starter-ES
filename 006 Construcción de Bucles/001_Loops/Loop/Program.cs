using System;

// Instrucción de transción inmediata o bucle - goto.

namespace Loop
{
    class Program
    {
        static void Main()
        {

        // Label - La etiqueta, que será introducido para la transición inmediata de la instrucción goto.

        Label:
            Console.WriteLine("Hola!");
            goto Label;

        }
    }
}
