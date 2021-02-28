using System;

// Devolución de valores del método Main ()

// Al finalizar el programa, es posible devolver un valor del métodoMain () el proceso de llamada o el sistema operativo.

// Devolución de valores del método Main() pueden ser solo del tipo int.

// Típicamente, el valor devuelto del metodo  Main (), indica la finalización normal del programa,
// Emergencia o su terminación debido a las condiciones prevalecientes de ejecución anormal. 
// si el valor de retorno cero por lo general indica una terminación normal del programa, 
// y todos los demás valores indican el tipo de error que se produjo.

namespace Methods
{
    class Program
    {       
        static int Main()
        {
            Console.WriteLine("Hola mundo !");

            // Demora.
            Console.ReadKey();

            return 0;
        }
    }
}
