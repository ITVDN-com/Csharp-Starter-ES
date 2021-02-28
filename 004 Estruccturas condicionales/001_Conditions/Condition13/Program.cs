using System;

// Operador de elección múltiple  - switch-case (interruptor). 
namespace Condition
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Introdusca los dias de la semana: 1-2-3-4-5-6-7: ");
            
            string myDay = Console.ReadLine();

            // Convertimos los valores de la  variable de cadena myDay  en un valor entero.
            // y la escribimos en una variable con el nombre day tipo int

            int day = Convert.ToInt32(myDay);

            switch (day)
            {
                case 1:
                    Console.WriteLine("Lunes.");
                    break;
                case 2:
                    Console.WriteLine("Martes.");
                    break;
                case 3:
                    Console.WriteLine("Miercoles.");
                    break;
                case 4:
                    Console.WriteLine("Jueves.");
                    break;
                case 5:
                    Console.WriteLine("Viernes.");
                    break;
                case 6:
                    Console.WriteLine("Sabado.");
                    break;
                case 7:
                    Console.WriteLine("Domingo.");
                    break;
                default:
                    Console.WriteLine("Habéis introducido el día no existente de la semana.");
                    break;
            }

            // Retraso.
            Console.ReadKey();
        }
    }
}
