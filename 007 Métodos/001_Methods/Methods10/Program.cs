using System;

//  Metodos con datos de salida (out) (out).

namespace Methods
{
    class Program
    {
        static int Method(out int a)
        {
           // Los datos de salida  tienen que ser cambiados  en el cuerpo del método, De otro modo .
            a = 2;
            return a * 2;
        }

        static void Main()
        {
            int operand;

            // out - Permite enviar en el metodoь variables no inicializadas.
            
            int result = Method(out operand);

            Console.WriteLine("{0}; {1};", operand, result);

            // Demora.
            Console.ReadKey();
        }
    }
}
