using System;

// Métodos (funciones).

namespace Methods
{
    class Program
    {
        // En la línea 13, declaramos el método con el nombre Funtion, que toma un argumento de línea y devuelve el valor de la línea.
        // En el cuerpo delmétodo  ,     sentence, le asignamos la  concatenación y argumentos, 
        // utilizando la palabra clave return, devolvemos el valor de la variable sentence.
        
        static string Function(string name)
        {
            string sentence = "Hello " + name + "!";

            return sentence;
        }

        static void Main()
        {
            // En el cuerpo del método Main en la línea 25, la variablelocal del tipo cadena lo declaramos con el nombre sentence, 
            // le apropiamos el valorque devuelve el  método  Function, que la calidad argumental para a la línea - edward.

            string sentence = Function("edward");

            Console.WriteLine(sentence);

            // Delay.
            Console.ReadKey();
        }
    }
}
