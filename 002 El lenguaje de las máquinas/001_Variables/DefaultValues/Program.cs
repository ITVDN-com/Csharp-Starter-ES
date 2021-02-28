using System;

namespace DefaultValues
{
    class Program
    {
        static void Main()
        {
            // En la linea 11, declaramos una variable de nombre a, tipo byte y no le asignamos ningun valor .
            
            byte a;         
            bool b;
            char c;
            string s;

            // En la linea 18 - ERROR: Prohibe el  uso de una variable local no inicializada!

            //Console.WriteLine(a);

            // Demora.
            Console.ReadKey();
        }
    }
}
