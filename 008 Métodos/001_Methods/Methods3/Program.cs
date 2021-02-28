using System;

// Nombramiento del argumento del Método

namespace Methods
{
    class Program
    {
        static int Difference(int altura, int ancho)
        {
            return altura - ancho;
        }

        static void Main()
        {
            // Se puede llamar a un método asi :
            int difference = Difference(6, 5);

            //difference = Difference(5, 6);

            Console.WriteLine("La diferencia es igual a: {0}", difference);

            // y ahora , ahora asi :
            difference = Difference(ancho: 5, altura: 6);

            Console.WriteLine("La diferencia es igual a: {0}", difference);

            Console.ReadKey();
        }
    }
}
