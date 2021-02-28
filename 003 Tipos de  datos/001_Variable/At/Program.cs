using System;

// Uso de Palabras clave en  C# en la calidad de indentificador.

namespace At
{
    class Program
    {
        static void Main()
        {
           // int bool = 5;      // Ilegal
            int @bool = 7;       // Legal
            Console.WriteLine(@bool);


            // El simbolo @ no forma parte del identificador, por eso, @myVariable - esto es lo mismo , que myVariable.
            string @myVariable = "Hola";
            Console.WriteLine(myVariable);


            // Demora.
            Console.ReadKey();
        }
    }
}
