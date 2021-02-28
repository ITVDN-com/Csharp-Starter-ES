using System;

// Sobre cargar el método. 

namespace Methods
{
    class Program
    {
        static void Operation()                                         // 1-a sobrecarga.
        {
            Operation("val", 10, 12.2);
        }

        static void Operation(string value1)                            // 2-a sobrecarga.
        {
            Operation(value1, 10, 12.2);
        }

        static void Operation(string value1, int value2)                // 3-a sobrecarga.
        {
            Operation(value1, value2, 12.2);
        }

        static void Operation(string value1, int value2, double value3) // 4-a sobrecarga.
        {
            Console.WriteLine("{0},{1},{2}", value1, value2, value3);
        }

        static void Main()
        {
            Operation();                  // 1-a sobrecarga.
            Operation("val");             // 2-a sobrecarga.
            Operation("val", 10);         // 3-a sobrecarga. 
            Operation("val", 10, 12.2);   // 4-a sobrecarga.
            
            // Demora.
            Console.ReadKey();
        }
    }
}
