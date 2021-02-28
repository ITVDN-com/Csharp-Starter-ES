using System;

// condición del operador ternario.

namespace Condition
{
    class Program
    {
        static void Main()
        {
            double quantity = 1;    // La cantidad de las unidades de mercancía.            
            double price = 1000;      // Precio por unidad.           
            double discount = 0.75;  // Descuento en el costo total - 25%.
            double cost;             // valor total.  

            // SI: Compraron 10 unidades O mas . ENTONCES: Conceder la rebaja en 25%. DE ORO MODO: Los descuentos no están disponibles..

            cost = quantity >= 10 ? quantity * price * discount : quantity * price;

            Console.WriteLine("El valor total de la mercancía es: {0} у.е.", cost);

            // Demora.
            Console.ReadKey();
        }
    }
}
