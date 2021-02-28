using System;

namespace Char
{
    class Program
    {
        static void Main()
        {
            char a = 'A';      // Simbolo o un caracter
            char b = '\x0042'; // Valor en formato hexadecimal
            char c = '\u0041'; // valor en formato unicode

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
