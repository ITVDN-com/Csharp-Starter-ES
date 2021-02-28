using System;

namespace Assignment
{
    class Program
    {
        static void Main()
        {
            // REGLA:
            // Todas las operaciones aritméticas se realizan en dos tipo de valores (byte, sbyte, short, ushort)
            // en la calidad del resultado, devuelve un valor de tipo int.
              
            // Asignación con dificultad para el tipo byte.
            byte variable1 = 0;
            
            //variable1 = variable1 + 5;       // ERROR: Valor implícito del resultado de la conversación, тип int в тип byte.
            //variable1 = (byte)variable1 + 5; // ERROR: hay una transformación de tipo byte en tipo byte,  antes de la operación de adición.
            
            variable1 = (byte)(variable1 + 5); // Desición voluminosa.
            
            variable1 += 5;                    // Solución elegante.           

            //variable1 += 5000;               // .  Entonces. el significado de la parte derecha de la expresión no debe seder el rango de valores del tipo de variable
            
            // REGLA:
            // Para tipos int, uint, long y ulong, no hay transformación como el resultado de las operaciones aritméticas.

            #region Operación de asignación con...
            
            // Asignación con la adición
            
            int variable2 = 0;
            variable2 = variable2 + 5;
            variable2 += 5;

            // Asignación con la resta.
            uint variable3 = 0;
            variable3 = variable3 - 5;
            variable3 -= 5;

            // Asignación  con la multiplicación.
            long variable4 = 0;
            variable4 = variable4 * 5;
            variable4 *= 5;

            // Asignación  con la división.
            ulong variable5 = 0;
            variable5 = variable5 / 5;
            variable5 /= 5;

            // Asignación resto  de la división.
            long variable6 = 0;
            variable6 = variable6 % 5;
            variable6 %= 5;
            
            #endregion

            // REGLA:
            // Para lso tipos  float y double, no se produce la conversion, como el resultado de las operaciones aritméticas.

            // Asignación con la adición.
            float variable7 = 0;
            variable7 = variable7 + 5;
            variable7 += 5;

            // Asignación  con la multiplicación.
            double variable8 = 0;
            variable8 = variable8 * 5;
            variable8 *= 5;

            // Demora.
            Console.ReadKey();
        }
    }
}
