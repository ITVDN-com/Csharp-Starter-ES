using System;

namespace StringFormat
{
    class Program
    {
        static void Main()
        {
            int a = 1;
            Console.WriteLine("este es el numero  {0}", a);

            int b = 2, c = 3;
            Console.WriteLine("numero  {0} y {1}", b, c);
            Console.WriteLine("numero al revez  {1} y {0}", b, c);

            // Demora.
            Console.ReadKey();
        }
    }
}
