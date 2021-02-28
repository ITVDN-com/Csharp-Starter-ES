using System;

// Variables locales con asignación implícita de tipos.

namespace Var
{
    class Program
    {
        static void Main()
        {
            // Variables locales con asignación implícita de tipo.
            var myVar = 7;

            Console.WriteLine(myVar);

            // Variables locales con asignación implícita de tipo no permita varios anuncios.
            // var a = 1, b = 2, c = 3;

            // Variables locales con asignación implícita de tipo debe ser inicializado.
            // var a; 

            // La constante no puede ser  tipo implícito.
            // const var myVar = 3.14; 

            // Retraso.
            Console.ReadKey();
        }
    }
}
