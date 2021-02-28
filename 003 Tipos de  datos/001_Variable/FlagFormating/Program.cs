using System;

// Formatos de salida  en cadenas.

namespace FlagFormating
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("C format: {0:C}", 99.9);      // Salida en formato monetario.
            Console.WriteLine("F format: {0:##}", 99.935);   // Los valores de salida con precisión fija.
            Console.WriteLine("N format: {0:N}", 99999);     // Formato numérico estándar.
            Console.WriteLine("X format: {0:X}", 255);       // ВFormato de salida en hexadecimal.
            Console.WriteLine("D format: {0:D}", 0xFF);      // Salida en formato decimal.
            Console.WriteLine("E format: {0:E}", 9999);      // Salida  en formato exponencialе.
            Console.WriteLine("G format: {0:G}", 99.9);      // Salida en un formato común.
            Console.WriteLine("P format: {0:P}", 99.9);      // Salida en formato de porcentaje.
            
            // Delay.
            Console.ReadKey();
        }
    }
}
