using System;

// Operaciones lógicas.

namespace Logic
{
    class Program
    {
        static void Main()
        {
            bool operand1 = false, operand2 = false, result = false;

            #region Conjunción

            // La tabla de verdad para la conjunción (Y) - && - [AND]

            // Si al menos uno de la operación, operación de la conjunción tiene valor false -
            // toda expresión tiene valor false, o de otro modo - true

            // false && false = false                  true && false = false
            // false && true = false                   true && true = true

            operand1 = true;                           // true          
            operand2 = false;                          // false
            result = operand1 && operand2;             // false

            Console.WriteLine("{0} AND {1} = {2}", operand1, operand2, result);
            
            #endregion

            #region Disyunción

            // Tabla de verdad para la disyunción (O) - || - [OR]

            // Si al menos uno de la operación, operación de la disyunción tiene valor true -
            // toda expresión tiene valor true, o de otro modo - false

            // false || false = false                  true || false = true         
            // false || true = true                    true || true = true

            operand1 = true;                           // true          
            operand2 = false;                          // false
            result = operand1 || operand2;             // true

            Console.WriteLine("{0} OR {1} = {2}", operand1, operand2, result);
            
            #endregion

            #region Exclusión O

            // La tabla de verdad para la Exclusión O - ^ - [XOR]

            // Si ambas expresiones de la operación O tienеn el mismo valor -
            // toda expresión tiene valor false, si es diferente - true 


            // false ^ false = false                   true ^ false = true
            // false ^ true = true                     true ^ true = false

            operand1 = true;                           // true          
            operand2 = false;                          // false
            result = operand1 ^ operand2;              // true

            Console.WriteLine("{0} XOR {1} = {2}", operand1, operand2, result);
            
            #endregion

            #region Отрицание

            // Tabla de verdad para la negación (NO) - ! - [NOT]

            // !false  = true
            // !true  = false       

            operand1 = true;
            result = !operand1;

            Console.WriteLine("NOT {0} = {1}", operand1, result);
            
            #endregion
                        
            // Delay.
            Console.ReadKey();
        }
    }
}
