using System;

// Operador de elección múltiple  - switch-case (interruptor). 

namespace Condition
{
    class Program
    {
        static void Main()
        {
         // Invitamos al usuario digitar un número.
            Console.WriteLine("introdusca el número  1 ó 2: ");

            // Recibimos lo digitado por el usuario .
            string number = Console.ReadLine();


            // En la linea 22  declaramos la construcción del operador de elección múltiple, interruptor - switch, 
     
            // que en calidad de la expresión-selector-number, Entregamos la variable number.
            
            switch (number)  // (number) — expresión -selector
            {
                // En el cuerpo de la instrucción  switch-case, En la línea 30 hasta el 41.
                // declaramos dos operadores case, con expresiones constantes iguales "1" y "2" respectivamente.

                // SI el valor de la expresión -Del selector coincida con uno de los valores de las expresiones constantes,
                // ENTONCES desarrollamos en cuerpo del operador case, expresión constante que, coincidido con la expresión del selector. 

                case "1":    // "1" — expesión constante.
                    {
                        Console.WriteLine("uno");                                       // Sentencia  1
                        // salida de la instrucción.
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("dos");                                        // Sentencia  2
                        break;
                    }

                // En la línea 45 declaramos (opcional) operador default, cuerpo en eñ cual Se cumple en el caso,
                // si el valor de la expresión-Del selector no coincide con ninguno de los valores de las expresiones constantes. 

                default:
                    {
                        Console.WriteLine("Habéis introducido un valor diferente  de 1 y 2.");       // Sentencia 3
                        break;
                    }

                // Si en la instrucción no esta presente el operador default, el control se transfiere fuera del interruptor switch.    
            }

            // Demora.
            Console.ReadKey();
        }
    }
}
