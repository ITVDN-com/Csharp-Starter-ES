using System;

// Metodo con salida de parametros(out).

namespace Methods
{
    class Program
    {
        // la salida de parametro  tiene que ser cambiado en  el cuerpo del metodo, de otro modo sera ERROR.
        
        static int Method(out int a)
        {
            // Comentar!
            a = 1;

            return 2;
        }

        static void Main()
        {
            int operand;

            // out - le permite transferir AL método una  variables sin inicializar.
            
            int result = Method(out operand);

            Console.WriteLine("{0}; {1};", operand, result);

            // Demora.
            Console.ReadKey();
        }
    }
}
