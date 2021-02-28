using System;

// Desplazamiento Lógico  (shift).

namespace Logic
{
    class Program
    {
        static void Main()
        {           
            byte operand = 0x81;              // 1000 0001    
            Console.WriteLine("El número antes del desplazamiento: {0:X}", operand);

            // Desplazamiento Lógico hacia la izquierda.

            operand = (byte)(operand << 2);   // 0000 0100
            Console.WriteLine("El número después del desplazamiento a la izquierda: {0:X}", operand);

            // Desplazamiento Lógico hacia la derecha.

            operand = (byte)(operand >> 1);   // 0000 0010

            Console.WriteLine("El número después del desplazamiento a la derecha: {0:X}", operand);

            // Delay.
            Console.ReadKey();
        }
    }
}
