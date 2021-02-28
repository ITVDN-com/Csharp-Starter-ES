using System;

// La posición del máximo común divisor (MCD) De dos números enteros

namespace Recursion
{
    class Program
    {
        static int Calculate(int a, int b)
        {
            if (a % b == 0)
                return b;
            else
                return Calculate(b, a % b);
        }

        static void Main()
        {
            Console.WriteLine("La posición del máximo común divisor de dos números enteros");

            int a = 15, b = 33;

            Console.WriteLine("a = {0}, b = {1}, MCD = {2};", a, b, Calculate(a, b));

            Console.ReadKey();
        }

        #region La segunda variante de la decisión

        static int Calculate2(int a, int b)
        {
            while (b != 0)
                b = a % (a = b);
            return a;
        }
        
        #endregion
    }
}
