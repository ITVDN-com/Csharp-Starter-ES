using System;

// Operador de elección múltiple  - switch-case (interruptor).
namespace Condition
{
    class Program
    {
        static void Main()
        {
            // Invitamos al usuario elegir una bebida.
            Console.WriteLine("tamaño del vaso con cafe: 1 = pequeño, 2 = mediano, 3 = grande");
            Console.Write("Por favor,  elija: ");

            // REcivimos lo introducido por el usuario.
            string coffeeSize = Console.ReadLine();

            int cost = 0;

            // SI el operador  case tiene en su construcción el código, ENTONCES no se admite "paso de una etiqueta case a otra".
            // Para la organización "проваливания" Se puede usar al operador del tránsito incondicional( instrucción de salto) - goto
            switch (coffeeSize)
            {
                case "1":
                    cost += 25;
                    break;
                case "2":
                    cost += 25;
                    goto case "1";
                case "3":
                    cost += 50;
                    goto case "1";
                default:
                    Console.WriteLine("elección incoreccta. Por favor  elija 1, 2, ó 3.");
                    break;
            }

            if (cost != 0)
            {
                Console.WriteLine("Introdusca {0} centavos.", cost);
                Console.WriteLine("Gracias!");
            }
            else
            {
                Console.Write("Por favor, repita su elección.");
            }
            
            // Demora.
            Console.ReadKey();
        }
    }
}
