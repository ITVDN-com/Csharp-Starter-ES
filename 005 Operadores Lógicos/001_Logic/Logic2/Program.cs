using System;

// Operaciones lógicas bit a bit. (&, |)

// Ejemplo: 
// Nosotros tenemos el puerto de entrada/conclusión o el registro con un cierto significado en ello.
// tenemos que encender el dispositivo en el primer bit controlado estableciendo el primer bit en 1.
// Después tenemos que apagar el dispositivo, dejando caer el primer bit a 0.
//  1 1 1 1   0 0 0 0  -  valor inicial del puerto de entrada/conclusión.
//  7 6 5 4   3 2 1 0  -  numeración de bits de dispositivos direccionales.

namespace Logic
{
    class Program
    {
        static void Main()
        {
            byte port = 0xF0;     // 1 1 1 1   0 0 0 0  -  valor inicial del puerto de entrada/conclusión.
            byte mask = 0x02;     // 0 0 0 0   0 0 1 0  -  máscara de encendido de dispositivo en el primer bit controlado.
            Console.WriteLine("port = {0:X}", port); // situación con la bombilla en la habitación

            port = (byte)(port | mask);  // Encender el dispositivo que esta dirigido al primer bit.
            Console.WriteLine("port = {0:X}", port);

            mask = 0xFD;          // 1 1 1 1   1 1 0 1  - Creamos la máscara en desconectación del dispositivo que esta dirigido al primer bit. 
            
            port = (byte)(port & mask);  // Encender el dispositivo que esta dirigido al primer bit.
            Console.WriteLine("port = {0:X}", port);

            // Delay.
            Console.ReadKey();
        }
    }
}
