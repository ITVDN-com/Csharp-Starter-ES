using System;

// La condición del operador ternario.

namespace Condition
{
    class Program
    {
        static void Main()
        {
            string @string = "HOLA ";

            Console.WriteLine("Digite su login:");

            // En la línea 17 declaramos la variable con el nombre login  de tipo string y recibe en ella lo que el usuario digito
            
            string login = Console.ReadLine();

            // En la línea 21  la variable  @string le asiganamos  el valor del resultado del operador ternario.
           
            @string += login == "Admin" ? "Administrator" : "User"; 

            Console.WriteLine(@string);

            // Retraso.
            Console.ReadKey();
        }
    }
}
