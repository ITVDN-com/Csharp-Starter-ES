
using System;

// Constante (Constant) - es un espacio   de la memoria, en el cuál se guarda algún valor, que no se debe cambiar.

namespace Constant
{
    class Program
    {
        static void Main()
        {
            // En la linea 14, declaramos una constante con noombre  pi, tipo double y le asignamos el valor 3.141

            const double pi = 3.141;

            // En la linea 18, mostramos el valor de la constante - pi, en la pantalla.

            Console.WriteLine(pi);

            // Intentar  asignar a la constante un nuevo valor, 
            //Conduce al error a nivel de la compilación!!.


            //pi = 2.71828183; 

            // Demora.
            Console.ReadKey();
        }
    }
}
