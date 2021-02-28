using System;

// Оperador sizeof - le permite obtener la capacidad  en bytes del valor del tipo especificado.
// Оperador sizeof sólo puede aplicarse a los tipos de datos: 
// byte, sbyte, short, ushort, int, uint, long, ulong, float, double, decimal, char, bool.
// El operador resultante  sizeof solo tiene capacidad  del tipo  int.

namespace Sizeof
{   
    class Program
    {
        static void Main()
        {
            int doubleSize = sizeof(double);
            Console.WriteLine("la capacidad  de tipo double: {0} Bytes.", doubleSize);

            Console.WriteLine("la capacidad  de tipo   int: {0} Bytes.", sizeof(int));
            Console.WriteLine("la capacidad  de tipo   bool: {0} Byte.", sizeof(bool));
            Console.WriteLine("la capacidad  de tipo   long: {0} Bytes.", sizeof(long));
            Console.WriteLine("la capacidad  de tipo   short: {0} Bytes.", sizeof(short));
            
            // Demora.
            Console.ReadKey();
        }
    }
}
