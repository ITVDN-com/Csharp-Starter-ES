using System;

// Sobrecar de métodos. 

namespace Methods
{
    class Program
    {
        // La sobre carga de métodos  se pueden diferenciar  por el tipo y la cantidad de argumentos , 
        // También por los parametros ref и out.

        static void Function()                 // 1-ra Sobrecarga.   
        {
            Console.WriteLine("Hello!");
        }

        static void Function(string s)         // 2-da sobrecarga.
        {
            Console.WriteLine(s);
        }

        static void Function(int i)            // 3-ra Sobrecarga.
        {
            Console.WriteLine(i);
        }

        static void Function(double d)         // 4-a Sobrecarga.
        {
            Console.WriteLine(d);
        }

        static void Function(string s, int i)  // 5-a Sobrecarga.
        {
            Console.WriteLine(s + i);
        }

        static void Function(int i, string s)  // 6-a Sobrecarga.
        {
            Console.WriteLine(i + s);
        }

        static void Function(ref int i, string s) // 7-a Sobrecargа.
        {
            Console.WriteLine(i + s);
        }

        // Un método sobrecargado no puede diferenciar  un valor devuelto!
        //static string Function(string s);    // 8-a Sobrecargaа.              
        //{
        //    return s;
        //}

        // La sobre carga de los metodos no pueden diferenciarse el uno al otro , solo el prametro  ref y out!
        //static void Function(out int i, string s) 
        //{
        //    i = 5;
        //    Console.WriteLine(i + s);       // 9-a Sobrecargа.
        //}
         
        static void Main()
        {
            Function();                  // 1-a Sobrecargа.
            Function("A");               // 2-a Sobrecargа.
            Function(1);                 // 3-a Sobrecargа.
            Function(3.14);              // 4-a Sobrecargа.
            Function("B ", 2);           // 5-a Sobrecargа.
            Function(3, " C");           // 6-a Sobrecargа.

            int variable = 5;
            Function(ref variable, "D"); // 7-a Sobrecargа.

            // Demora.
            Console.ReadKey();
        }
    }
}
