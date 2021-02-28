using System;

// Operaciones lógicas bit a bit. (^)

// Ejemplo: 
// Usando la operación XOR, podemos cifrar el mensaje.
// En tal tipo de la cifración se utiliza una llave, como para el cifrado, asi como para el cifrado y el descifrado.
// Esta clave criptográfica se puede aumentar mediante el aumento de su longitud.

namespace Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort secretKey = 0x0088; // Llave Secreta (longitud - 16 bit).
            char character = 'A';      // Símbolo inicial para la cifración.

            Console.WriteLine("Símbolo inicial: {0}, su código en el código de abajo: {1:X}", character, (byte)character);
            Console.WriteLine("Tamaño del símbolo: {0} = {1} bit", character, sizeof(char) * 8);

            // Зашифровываем символ.
            character = (char)(character ^ secretKey);
            Console.WriteLine("Símbolo cifrado: {0}, su código en la tabla de códigos: {1:X}", character, (byte)character);

            // Расшифровываем символ.
            character = (char)(character ^ secretKey);
            Console.WriteLine("Símbolo descifrado: {0}, su código en la tabla de códigos: {1:X}", character, (byte)character);

            // Delay.
            Console.ReadKey();
        }
    }
}
