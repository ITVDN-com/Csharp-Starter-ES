using System;

// Bucle Dijkstra.

// En la ejecución bucle en cada iteraciones pasa a la numeración de las condiciones guardadas. 
// Si por lo menos uno de ellos es verdadero, el comando guardado se ejecuta, luego comienza una nueva iteración 
// (Si en la verdad en varias condiciones guardadas, se ejecuta solo un comando guardado).
// Si la condiciones guardadas son falsas, el bucle se terminará
// Bucle Dijkstra con una sola condición guardada y un comando guardado es de hecho, un ciclo normal con la precondición (bucle «while»).

// Descripción clásica del Bucle Dijkstra.
// do 
//   P1 → S1,
//     …
//   Pn → Sn
// od

// donde:
// do — marca el comienzo de la construcción del bucle, 
// od — marca la terminación de la construcción del bucle, 
// Pi — i-тое condición guardada (expresión booleana, que puede ser «verdadero» o «falso»), 
// Si — i-yo comando guardado. 

// El bucle se compone de una o varias ramas (expresiones guardadas),
// Cada uno de ellos representa un par de la condición guardada y el comando guardado. 

namespace Loop
{
    class Program
    {
        static void Main()
        {
            char character = '\0';

            for (; ; )
            {
            
                character = Console.ReadKey().KeyChar;
                 
                switch (character)
                {
                    case 'l': // 'l' - condición guardada 1.
                        {
                            Console.WriteLine("Go left");    // comando guardado.
                           continue; 
                        }
                    case 'r': // 'r' - condición guardada 2.
                        {
                            Console.WriteLine("Go right");   // comando guardado.
                            continue;
                        }
                }
                break;  // Interrupción del bucle.
            }

            // DEemora
            
        
            // Console.ReadKey();
        }
    }
}
