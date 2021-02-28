using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Converter(int n)
        {
            int temp;
            string letra = "";

            temp = n % 16;

            if (temp > 9) 

            //if (n >= 16)
            //    Converter(n / 16);
            //else
                switch (temp)
                {
                    case 15:
                        letra = "F";
                        break;
                    case 14:
                        letra = "E";
                        break;
                    case 13:
                        letra = "D";
                        break;
                    case 12:
                        letra = "C";
                        break;
                    case 11:
                        letra = "B";
                        break;
                    case 10:
                        letra = "A";
                        break;
                }

            if (n/16 != 0)
                Console.Write((n / 16) + letra);
            else
                Console.Write(letra);
        }
        static void Main(string[] args)
        {
            Console.Write("El número en el sistema decimal: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("El número en el sistema  hexadecimal:: ");

            Converter(n);

            Console.ReadKey();
        }
    }
}
