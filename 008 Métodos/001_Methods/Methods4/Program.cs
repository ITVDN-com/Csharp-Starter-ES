using System;

// Мétodo con parametro opciónal. 

namespace Methods
{
    class Program
    {
        // Este método se invoca de la misma manera si se tratara de una sobrecarga.
        static void Operation(string value1 = "val", int value2 = 10, double value3 = 12.2)
        {
            Console.WriteLine("{0}, {1}, {2}", value1, value2, value3);
        }

        static void Main()
        {
            Operation();                  // 1-a sobrecarga.
            Operation("val");             // 2-a sobrecarga.
            Operation("val", 10);         // 3-a sobrecarga. 
            Operation("val", 10, 12.2);   // 4-a sobrecarga.


            // No se puede poner un tercer parámetro value3 = 12.2, en el lugar del 2do pаrametro  value2 = 10!
            //12.2 no se puede reducir a int — aqui  C# tratara  de colocar  defecto al tercer parámetro, y no al segundo.
            //Operation("val", 12.2); // ERROR!

            // En este caso, puede utilizar parámetros con nombre.
            // Se componen de  un especificador  del nombre del parámetro, Los dos puntos y el significado, en cual nosotros le asignamos.
           
            Operation("val", value3: 12.2);
            Operation(value2: 33, value3: 12.2);


            // Demora.
            Console.ReadKey();
        }
    }
}
