using System;

// Ejemplo: , El uso del operador de guardia.

namespace Methods
{
    class Program
    {
        static string Function(string name)
        {
            // Cumplimos la comprobación. Al descubrimiento de las faltas acabamos el trabajo.

            if (name == "tonto")   // operador de guardia.
            {
                return "Utilizó una palabra no válida.";
            }

            // Opción de código Nominal.

            string sentence = "Hola " + name + "!";

            return sentence;
        }

        static void Main()
        {
            string sentence = Function("edward");

            Console.WriteLine(sentence);

            // Demora.
            Console.ReadKey();
        }
    }
}
