using System;

// Bucle Araña (Spider).  Bucle Dijkstra modificado con las condiciones de entrada explicita.

// bucle Dijjkstra no contiene explicita condición de continuación o de salida. 
// por eso fue propuesto una complicada construcción de bucle Dijkstra, llamado "bucle-araña". 

// En la notación Dijkstra se expresa de la siguiente manera:

// do
//    P1→S1,
//      …
//    Pn→Sn
//  out
//    Q1→T1,
//      …
//    Qn→Tn
//  else
//    E
// od

// donde:
// do — marca el comienzo de la construcción del bucle, 
// od — marca la terminación de la construcción del bucle 
// Pi — i-тое condición guardada (expresión booleana, que puede ser «verdadero» o «falso»),
// Si — i-yo comando guardado. 
// Después del marcador out son introducidas las ramas de la terminación que consisten de las condiciones de la salida Qi y comando terminado Ti. 
// Además, es introducida la rama de la terminación alternativa else con el comando E.

//   Bucle-'araña' se ejecuta de esta manera:
//   Se calcularán las condiciones guardadas. 
//   Si existe una verdadera condición guardada, se ejecuta el orden correspondiente guardado.
//   Se calculan las condiciones de salida. 
//   Si existe una verdadera condición de salida, se ejecuta la terminación del comando,
//   después de que termine el bucle. 
//   Si todas las condiciones de salida son falsas,se empezará la siguiente interación pero solo si es que la iteración actual
//   fuera verdadera en uno de las condiciones guardadas.
//   Si en esta iteración resultaria falo y todas las condiciones guardadas, y todas las condiciones de salida, cumple 
//   el comando de terminación alternativa E, después de la ejecución el bucle será interrumpida.

namespace Loop
{
    class Program
    {
        static void Main()
        {
            char character = '\0';
            
            bool flag = default(bool);

            for (; ; )
            {
            Start:
                flag = false;
                character = Console.ReadKey().KeyChar;

                switch (character)
                {
                    case 'l': // 'l' - condición guardada 1.
                        {
                            Console.WriteLine("Go left"); flag = true; break; // comando guardado.
                        }
                    case 'r': // 'r' - condición guardada 2.
                        {
                            Console.WriteLine("Go right"); flag = true; break; // comando guardado.
                        }
                }

                switch (character)
                {
                    case 'x': // 'x' - condición de salida 1.
                        {
                            Console.WriteLine("Exit"); goto End; // comando terminado.
                        }
                    case 'q': // 'q' - condición de salida 2.
                        {
                            Console.WriteLine("Quit"); goto End; // comando terminado.
                        }
                }

                // Finalización de la rama alternativa.
                if (flag)
                {
                    goto Start;
                }

                Console.WriteLine("Alternative exit");

            End:
                break;  // Interrupción del bucle.
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
