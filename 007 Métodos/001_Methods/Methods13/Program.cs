using System;

namespace Methods
{
    class Program
    {
        //  Pasó una referencia a los argumentos originales en el argumento de salida  no se crea una copia.
        static void AddTwo(ref int a)
        {
            a = a + 2;
            Console.WriteLine("VALOR int a = {0}", a);
        }

        static void Main()
        {
            Console.WriteLine("Introdusca un numero:");

            // Recivimos lo introducio por el usiario  y lo convertimos en un valor numerico.
            
            string number = Console.ReadLine();
            int result = Int32.Parse(number);

            Console.WriteLine("Valor del resulado = {0}", result);

            // En la calidad del argumento se transfiere la propia variables - result, y no su copia.
            AddTwo(ref result);
            Console.WriteLine("valor del resultado = {0}", result);

            // Demora.
            Console.ReadKey();
        }
    }
}
