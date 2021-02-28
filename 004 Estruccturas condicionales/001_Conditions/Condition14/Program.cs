using System;

// Operador de elección múltiple  - switch-case (interruptor).  paso de una etiqueta case a otra.

namespace Condition
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Introduzca el número de días de la semana: 1-2-3-4-5-6-7: ");
            
            string day = Console.ReadLine();

            switch (day)
            {
                // Para los operadores vacíos case permite "el paso de una etiqueta case a otra". 
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                    Console.WriteLine("Este día de la semana - de Trabajo.");
                    break;
                case "6":
                case "7":
                    Console.WriteLine("Este día de la semana - libre.");
                    break;

                default:
                    Console.WriteLine("Ha introducido un día de semana inexistente.");
                    break;
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
