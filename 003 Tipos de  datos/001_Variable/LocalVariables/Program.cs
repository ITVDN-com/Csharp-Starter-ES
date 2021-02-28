using System;

// El uso de  áreas locales y variables locales.

namespace LocalVariables
{
    class Program
    {
        static void Main()
        {
            // REGLA:
            // En el código es posible crear las áreas locales y En dos áreas diferentes locales guardar las variables homónimas.
                        
            // Area local 1
            {
                int a = 1; 
                Console.WriteLine(a);
                
            }

            // Area local 2
            {
                int a = 2; 
                Console.WriteLine(a);
                
            }

            
            // REGLA:
            // Si en el código se tiene un área local , es imposible guardar 2 variables del minmo nombre  .

           // int a = 3; // ОШИБКА: 

            // Demora.
            Console.ReadKey();
        }
    }
}
