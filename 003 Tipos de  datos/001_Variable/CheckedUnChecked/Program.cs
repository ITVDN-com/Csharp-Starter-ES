using System;

// Combinación de checked y uncheckd.

namespace CheckedUnChecked
{
    class Program
    {
        static void Main()
        {
            sbyte a = 126;
            sbyte b = 127;

            // Comprobar la sobrecarga.
            checked
            {
                a++;

                // No comprobar la sobrecarga.
                unchecked
                {
                    b++; 
                }

                a++;
            }

            // retraso.
            Console.ReadKey();
        }
    }
}
