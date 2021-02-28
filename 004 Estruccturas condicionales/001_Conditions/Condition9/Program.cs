using System;

// La condición del operador ternario. La imposición del operador ternario.

namespace Condition
{
    class Program
    {
        static void Main()
        {
            // Calcular en cuadrante en el cual se encuentra un determinado punto.
            // Para simplificar el ejemplo ACORDAMOS, que es punto no va a estar en el centro del cuadrante ni en las ejes de las cordinadas,
            // Quiere decir , que x o y - no van a ser igual acero.

            int x = 10, y = 5;


            // No se recomienda imponer el operador ternario, Puesto que esto perjudica la lectura del código.


            string quadrant = (x > 0) ? ((y > 0) ? "I cuadrante" : "IV cuadrante") : ((y > 0) ? "II cuadrante" : "III cuadrante");

            // ... así

            quadrant = x > 0 ? (y > 0 ? "I cuadrante" : "IV cuadrante") : (y > 0 ? "II cuadrante" : "III cuadrante");

            // ... o incluso, así

            quadrant = x > 0 ? y > 0 ? "I cuadrante" : "IV cuadrante" : y > 0 ? "II cuadrante" : "III cuadrante";


            Console.WriteLine(quadrant);

            // Retraso.
            Console.ReadKey();
        }
    }
}
